using System;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using static WebApi.Modules.ModEnum;

namespace WebApi.Controllers
{
    // [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class WorkScheduleOfStaffController: ControllerBase
    {
        private readonly izdbDataModelSyncContext _context;

        public WorkScheduleOfStaffController(izdbDataModelSyncContext context)
        {
            _context = context;
        }

        // [AllowAnonymous]
        [HttpGet]
        public ActionResult GetAll()
        {
            var all = (
                from staff in _context.Mstaffs
                join calendar in _context.MstaffCalendars
                on new 
                {
                    P1 = staff.StaffCode
                } equals new 
                {
                    P1 = calendar.StaffCode
                }
                into cal
                from calendar in cal.DefaultIfEmpty()
                join holiday in _context.MstaffCalendarHolidays
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

            return Ok(all);
        }
    }
}