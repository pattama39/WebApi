using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using WebApi.Models;
using WebApi.Modules;
using WebApi.Services;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Controllers
{
    // [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class DBController: ControllerBase
    {
        private readonly izdbWebCenterContext _centraldb;
        private readonly RoleManager<Roles> _roleManager;
        private readonly UserManager<IdentityUser> _userManager;
        private IHttpContextAccessor _httpContextAccessor;
        private readonly IConfiguration _configuration;
        public DBController(izdbWebCenterContext centraldb, UserManager<IdentityUser> userManager, IHttpContextAccessor httpContextAccessor, RoleManager<Roles> roleManager,
            IConfiguration configuration)
        {
            _centraldb = centraldb;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
            _roleManager = roleManager;
        }

        // [AllowAnonymous]    
        [HttpGet]
        public async Task<ActionResult<List<HospitalEx>>> GetHospitals()
        {
            List<HospitalEx> lstHospital = await (from lst in _centraldb.Mhospitals
                                                  select new HospitalEx
                                                  {
                                                    ObjMhospital = lst,
                                                  }).ToListAsync();

            // foreach (HospitalEx item in lstHospital)
            // {
            //     item.HospitalTempVersionTypeId = item.ObjMhospital.VersionTypeId;
            //     XmlNodeList resultNodeList = await GlobalFunctions.GetOwnCloudStorage(item.ObjMhospital.HospitalCode);
            //     foreach (XmlNode childrenNode in resultNodeList)
            //     {
            //         var free = childrenNode.SelectSingleNode("free");
            //         var used = childrenNode.SelectSingleNode("used");
            //         var total = childrenNode.SelectSingleNode("total");
            //         var relative = childrenNode.SelectSingleNode("relative");

            //         if (free == null || used == null || total == null || relative == null) { continue; }

            //         item.OwncloudUsed = GlobalFunctions.FormatBytes(Convert.ToInt64(used.InnerText ?? "0"));
            //         item.OwncloudTotal = GlobalFunctions.FormatBytes(Convert.ToInt64(total.InnerText ?? "0"));
            //         item.OwncloudRelative = relative.InnerText ?? "0";

            //         item.OwncloudTempTotal = item.OwncloudTotal;
            //         break;
            //     }

            //     //Org
            //     izdbDataModelSyncContext currentdb = DbContextFactory.CreateClinic(item.ObjMhospital.DatabaseId, _centraldb);
            //     try
            //     {
            //         List<MorganizationEx> lstOrg = await (from lst in currentdb.Morganizations
            //                                               where lst.InActive != Convert.ToByte(true)
            //                                               select new MorganizationEx
            //                                               {
            //                                                 OrganizationCode = lst.OrganizationCode,
            //                                                 OrganizationName = lst.OrganizationName
            //                                               }).ToListAsync();

            //         foreach (MorganizationEx itemOrg in lstOrg)
            //         {
            //             var ObjMclinic = await (from obj in currentdb.MclinicOptions
            //                                     where obj.OrganizationCode == itemOrg.OrganizationCode
            //                                     select new 
            //                                     { 
            //                                         obj.UserNameSms, obj.PasswordSms 
            //                                     }).FirstOrDefaultAsync();
            //             var resultCredit = await GlobalFunctions.GetSMSBalance(ObjMclinic.UserNameSms, ObjMclinic.PasswordSms);
            //             try
            //             {
            //                 SMSCredit credit = JsonConvert.DeserializeObject<SMSCredit>(resultCredit);
            //                 itemOrg.SMSCreditBalance = Convert.ToDouble(credit.Balance);
            //             }
            //             catch
            //             {
            //                 itemOrg.SMSCreditBalance = 0;
            //             }
            //         }

            //         item.LstMOrganization = lstOrg;

            //     }
            //     catch (Exception ex)
            //     {
            //         return NotFound(new { ex.Message });
            //     }
            //     //Org
            // }

            return lstHospital;
        }
    }
}
