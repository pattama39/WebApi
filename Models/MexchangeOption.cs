using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MExchangeOptions")]
    public partial class MexchangeOption
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(10)]
        public string OrganizationCode { get; set; }
        [StringLength(255)]
        public string BackupPath { get; set; }
        [StringLength(50)]
        public string HostAddress { get; set; }
        [StringLength(50)]
        public string HostPort { get; set; }
        [StringLength(255)]
        public string HostRootDirectory { get; set; }
        [StringLength(50)]
        public string HostUserName { get; set; }
        [StringLength(50)]
        public string HostUserPassword { get; set; }
        [StringLength(50)]
        public string LocalAddress { get; set; }
        [StringLength(50)]
        public string LocalPort { get; set; }
        [StringLength(50)]
        public string LocalRootDirectory { get; set; }
        [StringLength(50)]
        public string LocalUserName { get; set; }
        [StringLength(50)]
        public string LocalUserPassword { get; set; }
        [Column("ProgramTypeID")]
        public int? ProgramTypeId { get; set; }
        public int? RefreshRate { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        public byte? IsExportItem { get; set; }
        public byte? IsExportPatientAndTreatment { get; set; }
        public byte? IsExportInventory { get; set; }
        public byte? IsExportInOut { get; set; }
        public byte? IsExportStaff { get; set; }
        public byte? IsExportPayroll { get; set; }
        public byte? IsExportPayrollData { get; set; }
        public byte? IsExportDocItem { get; set; }
        public byte? IsExportOrganization { get; set; }
        public byte? IsExportOrganizationData { get; set; }
        public byte? IsExportDocument { get; set; }
        public byte? IsImportItem { get; set; }
        public byte? IsImportPatientAndTreatment { get; set; }
        public byte? IsImportInventory { get; set; }
        public byte? IsImportInOut { get; set; }
        public byte? IsImportStaff { get; set; }
        public byte? IsImportPayroll { get; set; }
        public byte? IsImportPayrollData { get; set; }
        public byte? IsImportDocItem { get; set; }
        public byte? IsImportOrganization { get; set; }
        public byte? IsImportOrganizationData { get; set; }
        public byte? IsImportDocument { get; set; }
        [StringLength(50)]
        public string DatabaseName { get; set; }
        public byte? IsAutoImportDataFromServer { get; set; }
        public byte? IsSyncToServer { get; set; }
        public byte? IsAutoExportDataToServer { get; set; }
        [Column("IsAutoUpdateIPAddress")]
        public byte? IsAutoUpdateIpaddress { get; set; }
        public byte? IsAutoRun { get; set; }
        public byte? IsExportCustomer { get; set; }
        public byte? IsImportCustomer { get; set; }
        public int? UpdateRecordsAmount { get; set; }
        [Column("UpdateIPAddress2")]
        [StringLength(10)]
        public string UpdateIpaddress2 { get; set; }
        [Column("UpdateIPAddress1")]
        [StringLength(10)]
        public string UpdateIpaddress1 { get; set; }
        [StringLength(50)]
        public string HostInstanceName { get; set; }
    }
}
