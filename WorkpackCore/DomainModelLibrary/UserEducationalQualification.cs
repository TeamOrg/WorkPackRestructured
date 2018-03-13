using System.ComponentModel.DataAnnotations;

namespace DomainModelLibrary
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserEducationalQualification
    {
        [Key]
        public int UserEducationalQualification1 { get; set; }
        public int UserID { get; set; }
        public string Degree { get; set; }
        public string Specialization { get; set; }
        public Nullable<int> YearofPassing { get; set; }
        public string Institute { get; set; }
        public string IsHighestQualification { get; set; }
        public string Qualification { get; set; }
    
        public virtual User User { get; set; }
    }
}
