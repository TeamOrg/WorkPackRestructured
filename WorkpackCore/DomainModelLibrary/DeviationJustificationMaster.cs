using System.ComponentModel.DataAnnotations;




namespace DomainModelLibrary
{
    using System;
    using System.Collections.Generic;
    
    public partial class DeviationJustificationMaster
    {
        public DeviationJustificationMaster()
        {
            this.ProgressSheets = new HashSet<ProgressSheet>();
        }
        [Key]
        public int DeviationJustificationID { get; set; }
        public string DeviationJustificationText { get; set; }
        public string DeviationType { get; set; }
    
        public virtual ICollection<ProgressSheet> ProgressSheets { get; set; }
    }
}
