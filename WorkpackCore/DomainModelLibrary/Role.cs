using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainModelLibrary
{
    
    
    public partial class Role
    {
        
        [Key]
        public int RoleID { get; set; }
        public string RoleName { get; set; }

        
        public Nullable<System.DateTime> CreatedOn { get; set; }

        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
   
    }
}
