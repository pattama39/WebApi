using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    // [Authorize(Roles = UserRoles.Admin)]
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController: ControllerBase
    {
        private readonly izdbDataModelSyncContext _context;

        public CustomerController(izdbDataModelSyncContext context)
        {
            _context = context;
        }

        // [AllowAnonymous]
        [HttpGet]
        public ActionResult GetAll()
        {
            var all = (
                from cus in _context.Mcustomers
                select new {
                    cus.CustomerCode,
                    cus.TitleName,
                    cus.FirstName,
                    cus.LastName,
                    cus.Sex,
                    cus.Email,
                    cus.Mobile,
                    cus.IdcardNo,
                    cus.BirthDate
                }
            ).ToList();

            return Ok(all);
        }

        [HttpPost]
        public ActionResult Create(Mcustomer cus)
        {
            _context.Mcustomers.Add(cus);
            _context.SaveChanges();
            return Ok(cus.CustomerCode);
        }
    }
}