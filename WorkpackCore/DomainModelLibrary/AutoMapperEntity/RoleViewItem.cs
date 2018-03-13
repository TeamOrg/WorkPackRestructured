using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainModelLibrary.AutoMapperEntity
{
    public partial class RoleViewItem
    {
        [Key]
        public int RoleID { get; set; }
        [Required(ErrorMessage = "Required")]
        public string RoleName { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }

        public Nullable<DateTime> CreatedOn { get; set; }
        public Nullable<DateTime> ModifiedOn { get; set; }
    }


    public partial class DesignationViewItem
    {
        [Key]
        public int DesignationID { get; set; }
        [Required(ErrorMessage = "Required")]
        public string DesignationName { get; set; }

        public string DesignationCode { get; set; }

        

    }


}
