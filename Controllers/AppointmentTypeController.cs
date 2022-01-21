using System.Linq;
using WebApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApi.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace WebApi.Controllers
{
    // [Authorize(Roles = UserRoles.Admin)]
    [ApiController]
    [Route("api/[controller]")]
    public class AppointmentTypeController: ControllerBase
    {
        private readonly izdbWebCenterContext _centraldb;
        private readonly RoleManager<Roles> _roleManager;
        private readonly UserManager<IdentityUser> _userManager;
        private IHttpContextAccessor _httpContextAccessor;
        private readonly IConfiguration _configuration;
        public AppointmentTypeController(izdbWebCenterContext centraldb, UserManager<IdentityUser> userManager, IHttpContextAccessor httpContextAccessor, RoleManager<Roles> roleManager,
            IConfiguration configuration)
        {
            _centraldb = centraldb;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
            _roleManager = roleManager;
        }

        // [AllowAnonymous]
        [HttpGet("{hospitalCode}")]
        // ดึงข้อมูลคลินิกที่ต้องการ
        public ActionResult GetHospital(string hospitalCode)
        {
            var databaseId = (
                from obj in _centraldb.Mhospitals 
                where obj.HospitalCode == hospitalCode 
                select obj.DatabaseId
            ).FirstOrDefault();

            izdbDataModelSyncContext currentdb = DbContextFactory.CreateClinic(databaseId, _centraldb);
            
            var hospital = (
                from type in currentdb.DataAppointmentTypes
                where type.ParentOrgCode == hospitalCode
                select new {
                    type.OrganizationCode,
                    type.DataName,
                    type.TeleHeath,
                    type.ShowColor,
                    type.InActive
                }
            ).ToList();

            if (hospital == null)
            {
                return NotFound();
            } 
            return Ok(hospital);
        }

        // [AllowAnonymous]
        [HttpGet("{hospitalCode}/{organizationCode}")]
        // ดึงข้อมูลคลินิก และ/หรือ สาขา IZPAL999 ที่ต้องการ 
        public ActionResult GetOrg(string hospitalCode, string organizationCode)
        {
            var databaseId = (
                from obj in _centraldb.Mhospitals 
                where obj.HospitalCode == hospitalCode 
                select obj.DatabaseId
            ).FirstOrDefault();

            izdbDataModelSyncContext currentdb = DbContextFactory.CreateClinic(databaseId, _centraldb);
            
            var orgCode = (
                from type in currentdb.DataAppointmentTypes
                where type.ParentOrgCode == hospitalCode
                && (type.OrganizationCode == organizationCode
                || type.OrganizationCode == "IZPAL999")
                select new {
                    type.OrganizationCode,
                    type.DataName,
                    type.TeleHeath,
                    type.ShowColor,
                    type.InActive
                }
            ).ToList();

            if (orgCode == null)
            {
                return NotFound();
            } 
            return Ok(orgCode);
        }

        // [AllowAnonymous]
        [HttpGet("{hospitalCode}/{organizationCode}/{dataName}")]
        // ดึงข้อมูลคลินิก และ/หรือ สาขา IZPAL999 และประเภทนัดหมายที่ต้องการ
        public ActionResult GetDataName(string hospitalCode, string organizationCode, string dataName)
        {
            var databaseId = (
                from obj in _centraldb.Mhospitals 
                where obj.HospitalCode == hospitalCode 
                select obj.DatabaseId
            ).FirstOrDefault();

            izdbDataModelSyncContext currentdb = DbContextFactory.CreateClinic(databaseId, _centraldb);
            
            var name = (
                from type in currentdb.DataAppointmentTypes
                where type.ParentOrgCode == hospitalCode
                && (type.OrganizationCode == organizationCode
                || type.OrganizationCode == "IZPAL999")
                && type.DataName == dataName 
                select new {
                    type.OrganizationCode,
                    type.DataName,
                    type.TeleHeath,
                    type.ShowColor,
                    type.InActive
                }
            ).FirstOrDefault();

            if (name == null)
            {
                return NotFound();
            } 
            return Ok(name);
        }
    }
}