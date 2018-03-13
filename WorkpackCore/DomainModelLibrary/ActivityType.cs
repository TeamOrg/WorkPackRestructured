using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainModelLibrary
{
    public partial class ActivityType
    {
        [Key]
        public int ActivityTypeID { get; set; }
        public string Activity { get; set; }
        public Nullable<int> MasterTaskTypeID { get; set; }
    }
}
