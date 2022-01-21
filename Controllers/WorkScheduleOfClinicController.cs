using System;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    // [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class WorkScheduleOfClinicController: ControllerBase
    {
        private readonly izdbDataModelSyncContext _context;

        public WorkScheduleOfClinicController(izdbDataModelSyncContext context)
        {
            _context = context;
        }

        // [AllowAnonymous]
        [HttpGet]
        public ActionResult GetAll()
        {
            var all = (
                from calendar in _context.MclinicCalendars
                join holiday in _context.MclinicCalendarHolidays
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

            return Ok(all);
        }
    }
}