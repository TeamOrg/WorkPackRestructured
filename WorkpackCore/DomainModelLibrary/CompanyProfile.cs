using System.ComponentModel.DataAnnotations;

namespace DomainModelLibrary
{
    using System;
    using System.Collections.Generic;
    
    public partial class CompanyProfile
    {
        public CompanyProfile()
        {
            this.Companies = new HashSet<Company>();
        }
        [Key]
        public int ProfileID { get; set; }
        public string ProfileName { get; set; }
        public string ProfileCode { get; set; }
        public int UploadFileLimit { get; set; }
    
        public virtual ICollection<Company> Companies { get; set; }
    }
}
