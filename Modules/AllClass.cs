using System.Collections.Generic;
using WebApi.Models;

namespace WebApi.Modules
{
    public class SMSCredit
    {
        public string Balance { get; set; }
        public string Currency { get; set; }
    }
    
    public class HospitalEx
    {
        public Mhospital ObjMhospital { get; set; }
        public short? HospitalTempVersionTypeId { get; set; }
        public List<MorganizationEx> LstMOrganization { get; set; }
        public string OwncloudUsed { get; set; }
        public string OwncloudTotal { get; set; }
        public string OwncloudTempTotal { get; set; }
        public string OwncloudRelative { get; set; }
        public string SMSCreditBalance { get; set; }
    }

    public class MorganizationEx
    {
        public string OrganizationCode { get; set; }
        public string OrganizationName { get; set; }
        public double SMSCreditBalance { get; set; }
    }
}