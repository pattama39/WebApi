using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using WebApi.Models;
using WebApi.Services;

namespace WebApi.Controllers
{
    // [Authorize(Roles = UserRoles.Admin)]
    [ApiController]
    [Route("api/[controller]")]
    public class StaffController: ControllerBase
    {
        private readonly izdbWebCenterContext _centraldb;
        private readonly RoleManager<Roles> _roleManager;
        private readonly UserManager<IdentityUser> _userManager;
        private IHttpContextAccessor _httpContextAccessor;
        private readonly IConfiguration _configuration;
        public StaffController(izdbWebCenterContext centraldb, UserManager<IdentityUser> userManager, IHttpContextAccessor httpContextAccessor, RoleManager<Roles> roleManager,
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
                from staff in currentdb.Mstaffs
                join img in currentdb.MstaffImages
                on new 
                {
                    P1 = staff.StaffCode
                } equals new 
                {
                    P1 = img.StaffCode
                } 
                into staimg
                from img in staimg.DefaultIfEmpty() 
                where staff.ParentOrgCode == hospitalCode
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

            if (hospital == null)
            {
                return NotFound();
            } 
            return Ok(hospital);
        }

        // [AllowAnonymous]
        [HttpGet("{hospitalCode}/{createByOrgCode}")]
        // ดึงข้อมูลคลินิก และสาขาที่ต้องการ
        public ActionResult GetOrg(string hospitalCode, string createByOrgCode)
        {
            var databaseId = (
                from obj in _centraldb.Mhospitals 
                where obj.HospitalCode == hospitalCode 
                select obj.DatabaseId
            ).FirstOrDefault();

            izdbDataModelSyncContext currentdb = DbContextFactory.CreateClinic(databaseId, _centraldb);
            
            var orgCode = (
                from staff in currentdb.Mstaffs
                join img in currentdb.MstaffImages
                on new 
                {
                    P1 = staff.StaffCode
                } equals new 
                {
                    P1 = img.StaffCode
                } 
                into staimg
                from img in staimg.DefaultIfEmpty() 
                where staff.ParentOrgCode == hospitalCode
                && staff.CreateByOrgCode == createByOrgCode
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

            if (orgCode == null)
            {
                return NotFound();
            } 
            return Ok(orgCode);
        }

        // [AllowAnonymous]
        [HttpGet("{hospitalCode}/{createByOrgCode}/{staffCode}")]
        // ดึงข้อมูลคลินิก สาขา และพนักงานที่ต้องการ
        public ActionResult GetStaff(string hospitalCode, string createByOrgCode, string staffCode)
        {
            var databaseId = (
                from obj in _centraldb.Mhospitals 
                where obj.HospitalCode == hospitalCode 
                select obj.DatabaseId
            ).FirstOrDefault();

            izdbDataModelSyncContext currentdb = DbContextFactory.CreateClinic(databaseId, _centraldb);
            
            var orgCode = (
                from staff in currentdb.Mstaffs
                join img in currentdb.MstaffImages
                on new 
                {
                    P1 = staff.StaffCode
                } equals new 
                {
                    P1 = img.StaffCode
                } 
                into staimg
                from img in staimg.DefaultIfEmpty() 
                where staff.ParentOrgCode == hospitalCode
                && staff.CreateByOrgCode == createByOrgCode
                && staff.StaffCode == staffCode
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
            ).FirstOrDefault();

            if (orgCode == null)
            {
                return NotFound();
            } 
            return Ok(orgCode);
        }
    
    }
}