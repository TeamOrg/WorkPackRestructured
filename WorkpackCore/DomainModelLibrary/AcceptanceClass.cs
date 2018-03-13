using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainModelLibrary
{

    public partial class AcceptanceClass
    {
        //public AcceptanceClass()
        //{
        //    this.ProgressSheets = new HashSet<ProgressSheet>();
        //}
        [Key]
        public int AcceptanceClassID { get; set; }
        public string AcceptanceClassCode { get; set; }
        public string AcceptanceClass1 { get; set; }

        //public virtual ICollection<ProgressSheet> ProgressSheets { get; set; }
    }
}
