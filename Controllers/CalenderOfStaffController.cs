using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    // [Authorize(Roles = UserRoles.Admin)]
    [ApiController]
    [Route("api/[controller]")]
    public class CalendarOfStaffController: ControllerBase
    {
        private readonly izdbDataModelSyncContext _context;

        public CalendarOfStaffController(izdbDataModelSyncContext context)
        {
            _context = context;
        }

        // [AllowAnonymous]
        [HttpGet]
        public ActionResult GetAll()
        {
            var all = (
                from calendar in _context.MstaffCalendars
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

            return Ok(all);
        }
    }
}