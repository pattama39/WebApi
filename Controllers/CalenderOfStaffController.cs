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
    public class CalendarOfStaffController: ControllerBase
    {
        private readonly izdbWebCenterContext _centraldb;
        private readonly RoleManager<Roles> _roleManager;
        private readonly UserManager<IdentityUser> _userManager;
        private IHttpContextAccessor _httpContextAccessor;
        private readonly IConfiguration _configuration;
        public CalendarOfStaffController(izdbWebCenterContext centraldb, UserManager<IdentityUser> userManager, IHttpContextAccessor httpContextAccessor, RoleManager<Roles> roleManager,
            IConfiguration configuration)
        {
            _centraldb = centraldb;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
            _roleManager = roleManager;
        }

        // [AllowAnonymous]
        [HttpGet("{hospitalCode}")]
        // ดึงข้อมูลตารางการทำงานพนักงาน เฉพาะคลินิกที่ต้องการ
        public ActionResult GetHospital(string hospitalCode)
        {
            var databaseId = (
                from obj in _centraldb.Mhospitals 
                where obj.HospitalCode == hospitalCode 
                select obj.DatabaseId
            ).FirstOrDefault();

            izdbDataModelSyncContext currentdb = DbContextFactory.CreateClinic(databaseId, _centraldb);

            var hospital = (
                from calendar in currentdb.MstaffCalendars
                where calendar.ParentOrgCode == hospitalCode
                select new {
                    calendar.OrganizationCode,
                    calendar.StaffCode,
                    calendar.SeqId,
                    calendar.IsMonday,
                    calendar.MonTimeIn,
                    calendar.MonTimeOut,
                    calendar.IsTueday,
                    calendar.TueTimeIn,
                    calendar.TueTimeOut,
                    calendar.IsWedday,
                    calendar.WedTimeIn,
                    calendar.WedTimeOut,
                    calendar.IsThuday,
                    calendar.ThuTimeIn,
                    calendar.ThuTimeOut,
                    calendar.IsFriday,
                    calendar.FriTimeIn,
                    calendar.FriTimeOut,
                    calendar.IsSatday,
                    calendar.SatTimeIn,
                    calendar.SatTimeOut,
                    calendar.IsSunday,
                    calendar.SunTimeIn,
                    calendar.SunTimeOut,
                    calendar.InActive,
                    calendar.IsShowAppointment
                }
            ).ToList();

            return Ok(hospital);
        }

        // [AllowAnonymous]
        [HttpGet("{hospitalCode}/{organizationCode}")]
        // ดึงข้อมูลตารางการทำงานพนักงาน เฉพาะคลินิกและสาขาที่ต้องการ
        public ActionResult GetOrg(string hospitalCode, string organizationCode)
        {
            var databaseId = (
                from obj in _centraldb.Mhospitals 
                where obj.HospitalCode == hospitalCode 
                select obj.DatabaseId
            ).FirstOrDefault();

            izdbDataModelSyncContext currentdb = DbContextFactory.CreateClinic(databaseId, _centraldb);

            var org = (
                from calendar in currentdb.MstaffCalendars
                where calendar.ParentOrgCode == hospitalCode
                && calendar.OrganizationCode == organizationCode
                select new {
                    calendar.OrganizationCode,
                    calendar.StaffCode,
                    calendar.SeqId,
                    calendar.IsMonday,
                    calendar.MonTimeIn,
                    calendar.MonTimeOut,
                    calendar.IsTueday,
                    calendar.TueTimeIn,
                    calendar.TueTimeOut,
                    calendar.IsWedday,
                    calendar.WedTimeIn,
                    calendar.WedTimeOut,
                    calendar.IsThuday,
                    calendar.ThuTimeIn,
                    calendar.ThuTimeOut,
                    calendar.IsFriday,
                    calendar.FriTimeIn,
                    calendar.FriTimeOut,
                    calendar.IsSatday,
                    calendar.SatTimeIn,
                    calendar.SatTimeOut,
                    calendar.IsSunday,
                    calendar.SunTimeIn,
                    calendar.SunTimeOut,
                    calendar.InActive,
                    calendar.IsShowAppointment
                }
            ).ToList();

            return Ok(org);
        }

        // [AllowAnonymous]
        [HttpGet("{hospitalCode}/{organizationCode}/{staffCode}")]
        // ดึงข้อมูลตารางการทำงานพนักงาน เฉพาะคลินิก สาขา และพนักงานที่ต้องการ
        public ActionResult GetStaff(string hospitalCode, string organizationCode, string staffCode)
        {
            var databaseId = (
                from obj in _centraldb.Mhospitals 
                where obj.HospitalCode == hospitalCode 
                select obj.DatabaseId
            ).FirstOrDefault();

            izdbDataModelSyncContext currentdb = DbContextFactory.CreateClinic(databaseId, _centraldb);

            var staff = (
                from calendar in currentdb.MstaffCalendars
                where calendar.ParentOrgCode == hospitalCode
                && calendar.OrganizationCode == organizationCode
                && calendar.StaffCode == staffCode
                select new {
                    calendar.OrganizationCode,
                    calendar.StaffCode,
                    calendar.SeqId,
                    calendar.IsMonday,
                    calendar.MonTimeIn,
                    calendar.MonTimeOut,
                    calendar.IsTueday,
                    calendar.TueTimeIn,
                    calendar.TueTimeOut,
                    calendar.IsWedday,
                    calendar.WedTimeIn,
                    calendar.WedTimeOut,
                    calendar.IsThuday,
                    calendar.ThuTimeIn,
                    calendar.ThuTimeOut,
                    calendar.IsFriday,
                    calendar.FriTimeIn,
                    calendar.FriTimeOut,
                    calendar.IsSatday,
                    calendar.SatTimeIn,
                    calendar.SatTimeOut,
                    calendar.IsSunday,
                    calendar.SunTimeIn,
                    calendar.SunTimeOut,
                    calendar.InActive,
                    calendar.IsShowAppointment
                }
            ).ToList();

            return Ok(staff);
        }

        // [AllowAnonymous]
        [HttpGet("{hospitalCode}/{organizationCode}/{staffCode}/{seqId}")]
        // ดึงข้อมูลตารางการทำงานพนักงาน เฉพาะคลินิก สาขา พนักงาน และ SeqID ที่ต้องการ
        public ActionResult GetSeqId(string hospitalCode, string organizationCode, string staffCode, int seqId)
        {
            var databaseId = (
                from obj in _centraldb.Mhospitals 
                where obj.HospitalCode == hospitalCode 
                select obj.DatabaseId
            ).FirstOrDefault();

            izdbDataModelSyncContext currentdb = DbContextFactory.CreateClinic(databaseId, _centraldb);

            var seq = (
                from calendar in currentdb.MstaffCalendars
                where calendar.ParentOrgCode == hospitalCode
                && calendar.OrganizationCode == organizationCode
                && calendar.StaffCode == staffCode
                && calendar.SeqId == seqId
                select new {
                    calendar.OrganizationCode,
                    calendar.StaffCode,
                    calendar.SeqId,
                    calendar.IsMonday,
                    calendar.MonTimeIn,
                    calendar.MonTimeOut,
                    calendar.IsTueday,
                    calendar.TueTimeIn,
                    calendar.TueTimeOut,
                    calendar.IsWedday,
                    calendar.WedTimeIn,
                    calendar.WedTimeOut,
                    calendar.IsThuday,
                    calendar.ThuTimeIn,
                    calendar.ThuTimeOut,
                    calendar.IsFriday,
                    calendar.FriTimeIn,
                    calendar.FriTimeOut,
                    calendar.IsSatday,
                    calendar.SatTimeIn,
                    calendar.SatTimeOut,
                    calendar.IsSunday,
                    calendar.SunTimeIn,
                    calendar.SunTimeOut,
                    calendar.InActive,
                    calendar.IsShowAppointment
                }
            ).FirstOrDefault();

            return Ok(seq);
        }  
    }
}