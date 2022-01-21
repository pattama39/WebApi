using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    // [Authorize(Roles = UserRoles.Admin)]
    [ApiController]
    [Route("api/[controller]")]
    public class HolidayOfClinicController: ControllerBase
    {
        private readonly izdbDataModelSyncContext _context;

        public HolidayOfClinicController(izdbDataModelSyncContext context)
        {
            _context = context;
        }

        // [AllowAnonymous]
        [HttpGet]
        public ActionResult GetAll()
        {
            var all = (
                from holiday in _context.MclinicCalendarHolidays
                select new {
                    holiday.OrganizationCode,
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