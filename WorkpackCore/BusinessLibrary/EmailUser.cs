using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    public class EmailUser
    {
        public int UserID { get; set; }
        public string Email { get; set; }
        public Nullable<int> CompanyId { get; set; }
        public string Name { get; set; }
        public string CompanyName { get; set; }
        public string PhoneNo { get; set; }
        public string Designation { get; set; }
        public string Role { get; set; }
        public string Location { get; set; }
    }
}
