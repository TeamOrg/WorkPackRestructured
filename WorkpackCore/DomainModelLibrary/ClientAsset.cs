//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DomainModelLibrary
{
    using System;
    using System.Collections.Generic;
    
    public partial class ClientAsset
    {
        public ClientAsset()
        {
            this.AssentUniqueNumbers = new HashSet<AssentUniqueNumber>();
        }
    
        public int ClientAssetID { get; set; }
        public string ClientAssetName { get; set; }
        public string ClientAssetCode { get; set; }
        public Nullable<int> ClientID { get; set; }
    
        public virtual ICollection<AssentUniqueNumber> AssentUniqueNumbers { get; set; }
        public virtual Client Client { get; set; }
    }
}
