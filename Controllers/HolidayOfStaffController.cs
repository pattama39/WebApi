using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    // [Authorize(Roles = UserRoles.Admin)]
    [ApiController]
    [Route("api/[controller]")]
    public class HolidayOfStaffController: ControllerBase
    {
        private readonly izdbDataModelSyncContext _context;

        public HolidayOfStaffController(izdbDataModelSyncContext context)
        {
            _context = context;
        }

        // [AllowAnonymous]
        [HttpGet]
        public ActionResult GetAll()
        {
            var all = (
                from holiday in _context.MstaffCalendarHolidays
                select new {
                    holiday.OrganizationCode,
                    holiday.StaffCode,
                    holiday.SeqId,
                    holiday.NoWorkDate,
                    holiday.NoWorkFromTime,
                    holiday.NoWorkToTime
                }
            ).ToList();

            return Ok(all);
        }
    }
}