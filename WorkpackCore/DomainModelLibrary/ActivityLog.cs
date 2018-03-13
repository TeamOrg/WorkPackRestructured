using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainModelLibrary
{


    public partial class ActivityLog
    {
        [Key]
        public int ActivityLogID { get; set; }
        public int ProjectTaskID { get; set; }
        public int FileID { get; set; }
        public string RevNumber { get; set; }
        public string RevName { get; set; }
        public string Action { get; set; }
        public string ActionBy { get; set; }
        public System.DateTime ActionDate { get; set; }
    }
}
