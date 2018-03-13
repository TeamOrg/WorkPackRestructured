using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainModelLibrary
{
    public partial class CurrencyViewItem
    {
        [Key]
        public int CurrencyID { get; set; }
        [Required(ErrorMessage = "Required")]
        public string CurrencyName { get; set; }
        public string CurrencyCode { get; set; }
        public string CreatedBy { get; set; }
    }
}
