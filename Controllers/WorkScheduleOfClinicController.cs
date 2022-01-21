using System;
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
    // [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class WorkScheduleOfClinicController: ControllerBase
    {
        private readonly izdbWebCenterContext _centraldb;
        private readonly RoleManager<Roles> _roleManager;
        private readonly UserManager<IdentityUser> _userManager;
        private IHttpContextAccessor _httpContextAccessor;
        private readonly IConfiguration _configuration;
        public WorkScheduleOfClinicController(izdbWebCenterContext centraldb, UserManager<IdentityUser> userManager, IHttpContextAccessor httpContextAccessor, RoleManager<Roles> roleManager,
            IConfiguration configuration)
        {
            _centraldb = centraldb;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
            _roleManager = roleManager;
        }

        // [AllowAnonymous]
        [HttpGet("{hospitalCode}")]
        // ดึงข้อมูลตารางการทำงานและวันหยุดคลินิก เฉพาะคลินิกที่ต้องการ
        public ActionResult GetHospital(string hospitalCode)
        {
            var databaseId = (
                from obj in _centraldb.Mhospitals 
                where obj.HospitalCode == hospitalCode 
                select obj.DatabaseId
            ).FirstOrDefault();

            izdbDataModelSyncContext currentdb = DbContextFactory.CreateClinic(databaseId, _centraldb);

            var hospital = (
                from calendar in currentdb.MclinicCalendars
                join holiday in currentdb.MclinicCalendarHolidays
                on new 
                {
                    P1 = calendar.OrganizationCode
                } equals new 
                {
                    P1 = holiday.OrganizationCode
                } 
                into ho
                from holiday in ho.DefaultIfEmpty() 
                where calendar.IsShowAppointment == Convert.ToByte(true)
                && calendar.ParentOrgCode == hospitalCode
                select new
                {
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
                    calendar.InActive,
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
        // ดึงข้อมูลตารางการทำงานและวันหยุดคลินิก เฉพาะคลินิกและสาขาที่ต้องการ
        public ActionResult GetOrg(string hospitalCode, string organizationCode)
        {
            var databaseId = (
                from obj in _centraldb.Mhospitals 
                where obj.HospitalCode == hospitalCode 
                select obj.DatabaseId
            ).FirstOrDefault();

            izdbDataModelSyncContext currentdb = DbContextFactory.CreateClinic(databaseId, _centraldb);

            var org = (
                from calendar in currentdb.MclinicCalendars
                join holiday in currentdb.MclinicCalendarHolidays
                on new 
                {
                    P1 = calendar.OrganizationCode
                } equals new 
                {
                    P1 = holiday.OrganizationCode
                } 
                into ho
                from holiday in ho.DefaultIfEmpty() 
                where calendar.IsShowAppointment == Convert.ToByte(true)
                && calendar.ParentOrgCode == hospitalCode
                && calendar.OrganizationCode == organizationCode
                select new
                {
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
                    calendar.InActive,
                    calendar.IsShowAppointment,
                    holiday.NoWorkDate,
                    holiday.NoWorkFromTime,
                    holiday.NoWorkToTime
                }
            ).ToList();

            return Ok(org);
        }

        // [AllowAnonymous]
        [HttpGet("{hospitalCode}/{organizationCode}/{seqId}")]
        // ดึงข้อมูลตารางการทำงานและวันหยุดคลินิก เฉพาะคลินิก สาขา และ SeqID ที่ต้องการ
        public ActionResult GetSeqId(string hospitalCode, string organizationCode, int seqId)
        {
            var databaseId = (
                from obj in _centraldb.Mhospitals 
                where obj.HospitalCode == hospitalCode 
                select obj.DatabaseId
            ).FirstOrDefault();

            izdbDataModelSyncContext currentdb = DbContextFactory.CreateClinic(databaseId, _centraldb);

            var seq = (
                from calendar in currentdb.MclinicCalendars
                join holiday in currentdb.MclinicCalendarHolidays
                on new 
                {
                    P1 = calendar.OrganizationCode
                } equals new 
                {
                    P1 = holiday.OrganizationCode
                } 
                into ho
                from holiday in ho.DefaultIfEmpty() 
                where calendar.IsShowAppointment == Convert.ToByte(true)
                && calendar.ParentOrgCode == hospitalCode
                && calendar.OrganizationCode == organizationCode
                && calendar.SeqId == seqId
                select new
                {
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
                    calendar.InActive,
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