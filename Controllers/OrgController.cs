using System.Linq;
using WebApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrganizationController: ControllerBase
    {
        private readonly izdbDataModelSyncContext _context;

        public OrganizationController(izdbDataModelSyncContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            var all = (
                from org in _context.Morganizations
                join img in _context.MorganizationLogos
                on new 
                {
                    P1 = org.OrganizationCode
                } equals new 
                {
                    P1 = img.OrganizationCode
                } 
                into staimg
                from img in staimg.DefaultIfEmpty() 
                select new {
                    org.ParentOrgCode,
                    org.OrganizationCode,
                    org.OrganizationOfficialCode,
                    org.OrganizationName,
                    org.CurrentAddress1,
                    org.CurrentTumbonName,
                    org.CurrentAmphurName,
                    org.CurrentProvinceName,
                    org.CurrentPostCode,
                    org.CurrentTelephone,
                    org.InActive,
                    img.OrganizationLogoPath,
                    img.OrganizationLogoName
                }
            ).ToList();

            return Ok(all);
        }
    }
}