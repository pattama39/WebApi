using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    // [Authorize(Roles = UserRoles.Admin)]
    [ApiController]
    [Route("api/[controller]")]
    public class StaffController: ControllerBase
    {
        private readonly izdbDataModelSyncContext _context;

        public StaffController(izdbDataModelSyncContext context)
        {
            _context = context;
        }

        // [AllowAnonymous]
        [HttpGet]
        public ActionResult GetAll()
        {
            var all = (
                from staff in _context.Mstaffs
                join img in _context.MstaffImages
                on new 
                {
                    P1 = staff.StaffCode
                } equals new 
                {
                    P1 = img.StaffCode
                } 
                into staimg
                from img in staimg.DefaultIfEmpty() 
                select new {
                    staff.CreateByOrgCode,
                    staff.StaffCode,
                    staff.TitleName,
                    staff.FirstName,
                    staff.LastName,
                    staff.DisplayName,
                    staff.StaffTypeId,
                    staff.DoctorTypeId,
                    staff.InActive,
                    img.StaffImagePath,
                    img.StaffImageName
                }
            ).ToList();

            return Ok(all);
        }
    }
}