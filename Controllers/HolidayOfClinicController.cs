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
    public class HolidayOfClinicController: ControllerBase
    {
        private readonly izdbWebCenterContext _centraldb;
        private readonly RoleManager<Roles> _roleManager;
        private readonly UserManager<IdentityUser> _userManager;
        private IHttpContextAccessor _httpContextAccessor;
        private readonly IConfiguration _configuration;
        public HolidayOfClinicController(izdbWebCenterContext centraldb, UserManager<IdentityUser> userManager, IHttpContextAccessor httpContextAccessor, RoleManager<Roles> roleManager,
            IConfiguration configuration)
        {
            _centraldb = centraldb;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
            _roleManager = roleManager;
        }

        // [AllowAnonymous]
        [HttpGet("{hospitalCode}")]
        // ดึงข้อมูลตารางวันหยุดคลินิก เฉพาะคลินิกที่ต้องการ
        public ActionResult GetHospital(string hospitalCode)
        {
            var databaseId = (
                from obj in _centraldb.Mhospitals 
                where obj.HospitalCode == hospitalCode 
                select obj.DatabaseId
            ).FirstOrDefault();

            izdbDataModelSyncContext currentdb = DbContextFactory.CreateClinic(databaseId, _centraldb);

            var hospital = (
                from holiday in currentdb.MclinicCalendarHolidays
                where holiday.ParentOrgCode == hospitalCode
                select new {
                    holiday.OrganizationCode,
                    holiday.SeqId,
                    holiday.NoWorkDate,
                    holiday.NoWorkFromTime,
                    holiday.NoWorkToTime
                }
            ).ToList();

            return Ok(hospital);
        }

        // [AllowAnonymous]
        [HttpGet("{hospitalCode}/{organizationCode}")]
        // ดึงข้อมูลตารางวันหยุดคลินิก เฉพาะคลินิกและสาขาที่ต้องการ
        public ActionResult GetOrg(string hospitalCode, string organizationCode)
        {
            var databaseId = (
                from obj in _centraldb.Mhospitals 
                where obj.HospitalCode == hospitalCode 
                select obj.DatabaseId
            ).FirstOrDefault();

            izdbDataModelSyncContext currentdb = DbContextFactory.CreateClinic(databaseId, _centraldb);

            var org = (
                from holiday in currentdb.MclinicCalendarHolidays
                where holiday.ParentOrgCode == hospitalCode
                && holiday.OrganizationCode == organizationCode
                select new {
                    holiday.OrganizationCode,
                    holiday.SeqId,
                    holiday.NoWorkDate,
                    holiday.NoWorkFromTime,
                    holiday.NoWorkToTime
                }
            ).ToList();

            return Ok(org);
        }

        // [AllowAnonymous]
        [HttpGet("{hospitalCode}/{organizationCode}/{seqId}")]
        // ดึงข้อมูลตารางวันหยุดคลินิก เฉพาะคลินิก สาขา และ SeqID ที่ต้องการ
        public ActionResult GetSeqId(string hospitalCode, string organizationCode, int seqId)
        {
            var databaseId = (
                from obj in _centraldb.Mhospitals 
                where obj.HospitalCode == hospitalCode 
                select obj.DatabaseId
            ).FirstOrDefault();

            izdbDataModelSyncContext currentdb = DbContextFactory.CreateClinic(databaseId, _centraldb);

            var seq = (
                from holiday in currentdb.MclinicCalendarHolidays
                where holiday.ParentOrgCode == hospitalCode
                && holiday.OrganizationCode == organizationCode
                && holiday.SeqId == seqId
                select new {
                    holiday.OrganizationCode,
                    holiday.SeqId,
                    holiday.NoWorkDate,
                    holiday.NoWorkFromTime,
                    holiday.NoWorkToTime
                }
            ).FirstOrDefault();

            return Ok(seq);
        }
    }
}