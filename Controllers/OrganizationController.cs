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
    [ApiController]
    [Route("api/[controller]")]
    public class OrganizationController: ControllerBase
    {
        private readonly izdbWebCenterContext _centraldb;
        private readonly RoleManager<Roles> _roleManager;
        private readonly UserManager<IdentityUser> _userManager;
        private IHttpContextAccessor _httpContextAccessor;
        private readonly IConfiguration _configuration;
        public OrganizationController(izdbWebCenterContext centraldb, UserManager<IdentityUser> userManager, IHttpContextAccessor httpContextAccessor, RoleManager<Roles> roleManager,
            IConfiguration configuration)
        {
            _centraldb = centraldb;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
            _roleManager = roleManager;
        }

        // [AllowAnonymous]
        [HttpGet("{hospitalCode}")]
        // ดึงข้อมูลคลินิกที่ต้องการ
        public ActionResult GetHospital(string hospitalCode)
        {
            var databaseId = (
                from obj in _centraldb.Mhospitals 
                where obj.HospitalCode == hospitalCode 
                select obj.DatabaseId
            ).FirstOrDefault();

            izdbDataModelSyncContext currentdb = DbContextFactory.CreateClinic(databaseId, _centraldb);
            
            var hospital = (
                from org in currentdb.Morganizations
                join img in currentdb.MorganizationLogos
                on new 
                {
                    P1 = org.OrganizationCode
                } equals new 
                {
                    P1 = img.OrganizationCode
                } 
                into staimg
                from img in staimg.DefaultIfEmpty()
                where org.ParentOrgCode == hospitalCode
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

            if (hospital == null)
            {
                return NotFound();
            } 
            return Ok(hospital);
        }

        // [AllowAnonymous]
        [HttpGet("{hospitalCode}/{organizationCode}")]
        // ดึงข้อมูลคลินิก และสาขาที่ต้องการ
        public ActionResult GetHospitalID(string hospitalCode, string organizationCode)
        {
            var databaseId = (
                from obj in _centraldb.Mhospitals 
                where obj.HospitalCode == hospitalCode 
                select obj.DatabaseId
            ).FirstOrDefault();

            izdbDataModelSyncContext currentdb = DbContextFactory.CreateClinic(databaseId, _centraldb);
            
            var orgCode = (
                from org in currentdb.Morganizations
                join img in currentdb.MorganizationLogos
                on new 
                {
                    P1 = org.OrganizationCode
                } equals new 
                {
                    P1 = img.OrganizationCode
                } 
                into staimg
                from img in staimg.DefaultIfEmpty()
                where org.ParentOrgCode == hospitalCode
                && org.OrganizationCode == organizationCode
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
            ).FirstOrDefault();

            if (orgCode == null)
            {
                return NotFound();
            } 
            return Ok(orgCode);
        }
    }
}