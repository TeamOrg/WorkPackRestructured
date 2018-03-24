
namespace DomainModelLibrary
{

    using System;
    using System.ComponentModel.DataAnnotations;
    public partial class Android_usp_GetProjectDetails_Result
    {
        public int ProjectID { get; set; }
        public string ProjectName { get; set; }
        public string ProjectCode { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Clientname { get; set; }
        public string ClientCode { get; set; }
        public string ClientProjectNo { get; set; }
        public Nullable<int> ProjectStageID { get; set; }
        public string StageName { get; set; }
        public string ProjectLeader { get; set; }

    }
}
