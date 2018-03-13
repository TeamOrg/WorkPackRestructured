using System.ComponentModel.DataAnnotations;

namespace DomainModelLibrary
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProjectWB
    {
        [Key]
        public int WBSID { get; set; }
        public string WBSName { get; set; }
        public string WBSCode { get; set; }
        public int ParentWBSID { get; set; }
        public int ProjectID { get; set; }
        public string ImportWBSID { get; set; }
        public string ImportParentWBSID { get; set; }
    
        public virtual Project Project { get; set; }
    }
}
