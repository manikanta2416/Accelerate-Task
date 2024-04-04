using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Form_DAL_Layer.Models
{
    public partial class RegisterFormDetail
    {
        [JsonIgnore]
        public int RequestorId { get; set; }
        public string RequestorEmail { get; set; }
        public string RequestorName { get; set; }
        public string Criticality { get; set; }
        public string RequestingTeam { get; set; }
        public string RequestingTeamLocation { get; set; }
        public string DataUsage { get; set; }
        public string CriticalityReason { get; set; }
        public string HowIndexWillBeUsed { get; set; }
        public string RequiredApplications { get; set; }
        public string HistoryRequired { get; set; }
        public string IndexType { get; set; }
        public string BlendComponents { get; set; }
        public string IndexProvider { get; set; }
        public string RequiredUniverse { get; set; }
        public string ReturnType { get; set; }
        public string ConstituentsRequired { get; set; }
        public string BaseCurrency { get; set; }
        public string IndexName { get; set; }
        public string VendorId { get; set; }
        public string IsWacidataRequired { get; set; }
        public string IndexCostApproval { get; set; }
        public string AllergapproverEmailies { get; set; }
        public DateTime RequiredHistoryDate { get; set; }
    }
}
