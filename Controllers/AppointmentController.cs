using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    // [Authorize(Roles = UserRoles.Admin)]
    [ApiController]
    [Route("api/[controller]")]
    public class AppointmentController: ControllerBase
    {
        private readonly izdbDataModelSyncContext _context;

        public AppointmentController(izdbDataModelSyncContext context)
        {
            _context = context;
        }

        // [AllowAnonymous]
        [HttpGet]
        public ActionResult GetAll()
        {
            var all = (
                from app in _context.Appointments
                select new {
                    app.CreateByOrgCode,
                    app.AppId,
                    app.CustomerGid,
                    app.DisplayName,
                    app.AppFromDate,
                    app.AppFromTime,
                    app.AppToDate,
                    app.AppToTime,
                    app.Remark,
                    app.DoctorCode,
                    app.AppointTypeId,
                    app.IsAllDay
                }
            ).ToList();

            return Ok(all);
        }

        [HttpPost]
        public ActionResult Create(Appointment appointment)
        {
            _context.Appointments.Add(appointment);
            _context.SaveChanges();
            return Ok(appointment.AppId);
        }
    }
}