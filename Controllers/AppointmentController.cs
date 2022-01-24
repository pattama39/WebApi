using System.Linq;
using WebApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApi.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using WebApi.Modules;

namespace WebApi.Controllers
{
    // [Authorize(Roles = UserRoles.Admin)]
    [ApiController]
    [Route("api/[controller]")]
    public class AppointmentController: ControllerBase
    {
        private readonly izdbWebCenterContext _centraldb;
        private readonly RoleManager<Roles> _roleManager;
        private readonly UserManager<IdentityUser> _userManager;
        private IHttpContextAccessor _httpContextAccessor;
        private readonly IConfiguration _configuration;
        public AppointmentController(izdbWebCenterContext centraldb, UserManager<IdentityUser> userManager, IHttpContextAccessor httpContextAccessor, RoleManager<Roles> roleManager,
            IConfiguration configuration)
        {
            _centraldb = centraldb;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
            _roleManager = roleManager;
        }

        // [AllowAnonymous]
        [HttpGet]
        public ActionResult GetAll(string hospitalCode)
        {
            var databaseId = (
                from obj in _centraldb.Mhospitals 
                where obj.HospitalCode == hospitalCode 
                select obj.DatabaseId
            ).FirstOrDefault();

            izdbDataModelSyncContext currentdb = DbContextFactory.CreateClinic(databaseId, _centraldb);

            var all = (
                from app in currentdb.Appointments
                select new {
                    app.CreateByOrgCode,
                    app.AppId,
                    app.CustomerGid,
                    app.DisplayName,
                    app.AppFromDate,
                    app.AppFromTime,
                    app.AppToDate,
                    app.AppToTime,
                    app.Remark,
                    app.DoctorCode,
                    app.AppointTypeId,
                    app.IsAllDay
                }
            ).ToList();

            return Ok(all);
        }

        [HttpPost("{hospitalCode}")]
        public ActionResult Create(string hospitalCode, Appointment appointment)
        {
            var objhospital = (
                from obj in _centraldb.Mhospitals 
                where obj.HospitalCode == hospitalCode
                select new { 
                    obj.HospitalCode, 
                    obj.DatabaseId 
                }
            ).FirstOrDefault();
            
            izdbDataModelSyncContext currentdb = DbContextFactory.CreateClinic(objhospital.DatabaseId, _centraldb);
            SaveAllData.SaveData(appointment, (short)ProgramMode.NewMode, currentdb, objhospital.HospitalCode);

            return Ok(appointment.AppId);
        }
    }
}