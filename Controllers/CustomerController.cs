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
    // [Authorize(Roles = UserRoles.Admin)]
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController: ControllerBase
    {
        private readonly izdbWebCenterContext _centraldb;
        private readonly RoleManager<Roles> _roleManager;
        private readonly UserManager<IdentityUser> _userManager;
        private IHttpContextAccessor _httpContextAccessor;
        private readonly IConfiguration _configuration;
        public CustomerController(izdbWebCenterContext centraldb, UserManager<IdentityUser> userManager, IHttpContextAccessor httpContextAccessor, RoleManager<Roles> roleManager,
            IConfiguration configuration)
        {
            _centraldb = centraldb;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
            _roleManager = roleManager;
        }

        // [AllowAnonymous]
        [HttpGet]
        public ActionResult GetAll(string hospitalCode)
        {
            var databaseId = (
                from obj in _centraldb.Mhospitals 
                where obj.HospitalCode == hospitalCode 
                select obj.DatabaseId
            ).FirstOrDefault();

            izdbDataModelSyncContext currentdb = DbContextFactory.CreateClinic(databaseId, _centraldb);

            var all = (
                from cus in currentdb.Mcustomers
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

        [HttpPost("{hospitalCode}")]
        public ActionResult Create(string hospitalCode, Mcustomer cus)
        {
            var databaseId = (
                from obj in _centraldb.Mhospitals 
                where obj.HospitalCode == hospitalCode 
                select obj.DatabaseId
            ).FirstOrDefault();

            izdbDataModelSyncContext currentdb = DbContextFactory.CreateClinic(databaseId, _centraldb);

            currentdb.Mcustomers.Add(cus);
            currentdb.SaveChanges();
            return Ok(cus.CustomerCode);
        }
    }
}