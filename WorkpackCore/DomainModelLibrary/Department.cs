using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainModelLibrary
{
   
    
    public partial class Department
    {
        //public Department()
        //{
        //    this.ProjectsDepartments = new HashSet<ProjectsDepartment>();
        //    this.ResourceRequests = new HashSet<ResourceRequest>();
        //    this.Users = new HashSet<User>();
        //}
        [Key]
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentCode { get; set; }
    
        //public virtual ICollection<ProjectsDepartment> ProjectsDepartments { get; set; }
        //public virtual ICollection<ResourceRequest> ResourceRequests { get; set; }
        //public virtual ICollection<User> Users { get; set; }
    }
}
