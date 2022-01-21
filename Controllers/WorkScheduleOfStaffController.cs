using System;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using WebApi.Models;
using WebApi.Services;
using static WebApi.Modules.ModEnum;

namespace WebApi.Controllers
{
    // [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class WorkScheduleOfStaffController: ControllerBase
    {
        private readonly izdbWebCenterContext _centraldb;
        private readonly RoleManager<Roles> _roleManager;
        private readonly UserManager<IdentityUser> _userManager;
        private IHttpContextAccessor _httpContextAccessor;
        private readonly IConfiguration _configuration;
        public WorkScheduleOfStaffController(izdbWebCenterContext centraldb, UserManager<IdentityUser> userManager, IHttpContextAccessor httpContextAccessor, RoleManager<Roles> roleManager,
            IConfiguration configuration)
        {
            _centraldb = centraldb;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
            _roleManager = roleManager;
        }

        // [AllowAnonymous]
        [HttpGet("{hospitalCode}")]
        // ดึงข้อมูลตารางการทำงานและวันหยุดพนักงาน เฉพาะคลินิกที่ต้องการ
        public ActionResult GetHospital(string hospitalCode)
        {
            var databaseId = (
                from obj in _centraldb.Mhospitals 
                where obj.HospitalCode == hospitalCode 
                select obj.DatabaseId
            ).FirstOrDefault();

            izdbDataModelSyncContext currentdb = DbContextFactory.CreateClinic(databaseId, _centraldb);

            var hospital = (
                from staff in currentdb.Mstaffs
                join calendar in currentdb.MstaffCalendars
                on new 
                {
                    P1 = staff.StaffCode
                } equals new 
                {
                    P1 = calendar.StaffCode
                }
                into cal
                from calendar in cal.DefaultIfEmpty()
                join holiday in currentdb.MstaffCalendarHolidays
                on new 
                {
                    P1 = staff.StaffCode,
                    P2 = calendar.OrganizationCode
                } equals new 
                {
                    P1 = holiday.StaffCode,
                    P2 = holiday.OrganizationCode
                } 
                into ho
                from holiday in ho.DefaultIfEmpty() 
                where staff.StaffTypeId == (byte)StaffTypeID.Doctor
                && calendar.IsShowAppointment == Convert.ToByte(true)
                && calendar.ParentOrgCode == hospitalCode
                select new 
                {
                    staff.CreateByOrgCode,
                    staff.StaffCode,
                    staff.TitleName,
                    staff.FirstName,
                    staff.LastName,
                    staff.DisplayName,
                    staff.StaffTypeId,
                    staff.DoctorTypeId,
                    staff.InActive,
                    calendar.OrganizationCode,
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
                    calendar.IsShowAppointment,
                    holiday.NoWorkDate,
                    holiday.NoWorkFromTime,
                    holiday.NoWorkToTime
                }
            ).ToList();

            return Ok(hospital);
        }

        // [AllowAnonymous]
        [HttpGet("{hospitalCode}/{organizationCode}")]
        // ดึงข้อมูลตารางการทำงานและวันหยุดพนักงาน เฉพาะคลินิกและสาขาที่ต้องการ
        public ActionResult GetOrg(string hospitalCode, string organizationCode)
        {
            var databaseId = (
                from obj in _centraldb.Mhospitals 
                where obj.HospitalCode == hospitalCode 
                select obj.DatabaseId
            ).FirstOrDefault();

            izdbDataModelSyncContext currentdb = DbContextFactory.CreateClinic(databaseId, _centraldb);

            var org = (
                from staff in currentdb.Mstaffs
                join calendar in currentdb.MstaffCalendars
                on new 
                {
                    P1 = staff.StaffCode
                } equals new 
                {
                    P1 = calendar.StaffCode
                }
                into cal
                from calendar in cal.DefaultIfEmpty()
                join holiday in currentdb.MstaffCalendarHolidays
                on new 
                {
                    P1 = staff.StaffCode,
                    P2 = calendar.OrganizationCode
                } equals new 
                {
                    P1 = holiday.StaffCode,
                    P2 = holiday.OrganizationCode
                } 
                into ho
                from holiday in ho.DefaultIfEmpty() 
                where staff.StaffTypeId == (byte)StaffTypeID.Doctor
                && calendar.IsShowAppointment == Convert.ToByte(true)
                && calendar.ParentOrgCode == hospitalCode
                && calendar.OrganizationCode == organizationCode
                select new 
                {
                    staff.CreateByOrgCode,
                    staff.StaffCode,
                    staff.TitleName,
                    staff.FirstName,
                    staff.LastName,
                    staff.DisplayName,
                    staff.StaffTypeId,
                    staff.DoctorTypeId,
                    staff.InActive,
                    calendar.OrganizationCode,
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
                    calendar.IsShowAppointment,
                    holiday.NoWorkDate,
                    holiday.NoWorkFromTime,
                    holiday.NoWorkToTime
                }
            ).ToList();

            return Ok(org);
        }

        // [AllowAnonymous]
        [HttpGet("{hospitalCode}/{organizationCode}/{staffCode}")]
        // ดึงข้อมูลตารางการทำงานและวันหยุดพนักงาน เฉพาะคลินิก สาขา และพนักงานที่ต้องการ
        public ActionResult GetStaff(string hospitalCode, string organizationCode, string staffCode)
        {
            var databaseId = (
                from obj in _centraldb.Mhospitals 
                where obj.HospitalCode == hospitalCode 
                select obj.DatabaseId
            ).FirstOrDefault();

            izdbDataModelSyncContext currentdb = DbContextFactory.CreateClinic(databaseId, _centraldb);

            var staffId = (
                from staff in currentdb.Mstaffs
                join calendar in currentdb.MstaffCalendars
                on new 
                {
                    P1 = staff.StaffCode
                } equals new 
                {
                    P1 = calendar.StaffCode
                }
                into cal
                from calendar in cal.DefaultIfEmpty()
                join holiday in currentdb.MstaffCalendarHolidays
                on new 
                {
                    P1 = staff.StaffCode,
                    P2 = calendar.OrganizationCode
                } equals new 
                {
                    P1 = holiday.StaffCode,
                    P2 = holiday.OrganizationCode
                } 
                into ho
                from holiday in ho.DefaultIfEmpty() 
                where staff.StaffTypeId == (byte)StaffTypeID.Doctor
                && calendar.IsShowAppointment == Convert.ToByte(true)
                && calendar.ParentOrgCode == hospitalCode
                && calendar.OrganizationCode == organizationCode
                && calendar.StaffCode == staffCode
                select new 
                {
                    staff.CreateByOrgCode,
                    staff.StaffCode,
                    staff.TitleName,
                    staff.FirstName,
                    staff.LastName,
                    staff.DisplayName,
                    staff.StaffTypeId,
                    staff.DoctorTypeId,
                    staff.InActive,
                    calendar.OrganizationCode,
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
                    calendar.IsShowAppointment,
                    holiday.NoWorkDate,
                    holiday.NoWorkFromTime,
                    holiday.NoWorkToTime
                }
            ).ToList();

            return Ok(staffId);
        }

        // [AllowAnonymous]
        [HttpGet("{hospitalCode}/{organizationCode}/{staffCode}/{seqId}")]
        // ดึงข้อมูลตารางการทำงานและวันหยุดพนักงาน เฉพาะคลินิก สาขา พนักงาน และ SeqID ที่ต้องการ
        public ActionResult GetSeqId(string hospitalCode, string organizationCode, string staffCode, int seqId)
        {
            var databaseId = (
                from obj in _centraldb.Mhospitals 
                where obj.HospitalCode == hospitalCode 
                select obj.DatabaseId
            ).FirstOrDefault();

            izdbDataModelSyncContext currentdb = DbContextFactory.CreateClinic(databaseId, _centraldb);

            var seq = (
                from staff in currentdb.Mstaffs
                join calendar in currentdb.MstaffCalendars
                on new 
                {
                    P1 = staff.StaffCode
                } equals new 
                {
                    P1 = calendar.StaffCode
                }
                into cal
                from calendar in cal.DefaultIfEmpty()
                join holiday in currentdb.MstaffCalendarHolidays
                on new 
                {
                    P1 = staff.StaffCode,
                    P2 = calendar.OrganizationCode
                } equals new 
                {
                    P1 = holiday.StaffCode,
                    P2 = holiday.OrganizationCode
                } 
                into ho
                from holiday in ho.DefaultIfEmpty() 
                where staff.StaffTypeId == (byte)StaffTypeID.Doctor
                && calendar.IsShowAppointment == Convert.ToByte(true)
                && calendar.ParentOrgCode == hospitalCode
                && calendar.OrganizationCode == organizationCode
                && calendar.StaffCode == staffCode
                && calendar.SeqId == seqId
                select new 
                {
                    staff.CreateByOrgCode,
                    staff.StaffCode,
                    staff.TitleName,
                    staff.FirstName,
                    staff.LastName,
                    staff.DisplayName,
                    staff.StaffTypeId,
                    staff.DoctorTypeId,
                    staff.InActive,
                    calendar.OrganizationCode,
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
                    calendar.IsShowAppointment,
                    holiday.NoWorkDate,
                    holiday.NoWorkFromTime,
                    holiday.NoWorkToTime
                }
            ).FirstOrDefault();

            return Ok(seq);
        }  
    }
}