using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    // [Authorize(Roles = UserRoles.Admin)]
    [ApiController]
    [Route("api/[controller]")]
    public class AppointmentTypeController: ControllerBase
    {
        private readonly izdbDataModelSyncContext _context;

        public AppointmentTypeController(izdbDataModelSyncContext context)
        {
            _context = context;
        }

        // [AllowAnonymous]
        [HttpGet]
        public ActionResult GetAll()
        {
            var all = (
                from type in _context.DataAppointmentTypes
                select new {
                    type.OrganizationCode,
                    type.DataName,
                    type.TeleHeath,
                    type.ShowColor,
                    type.InActive
                }
            ).ToList();

            return Ok(all);
        }
    }
}