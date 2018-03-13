using System.ComponentModel.DataAnnotations;

namespace DomainModelLibrary
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProjectDocument
    {
        [Key]
        public int ProjectlDocumentsID { get; set; }
        public string Path { get; set; }
        public string FileExtention { get; set; }
        public int ProjectID { get; set; }
        public Nullable<int> FileSize { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
    
        public virtual ProjectDocument ProjectDocuments1 { get; set; }        
        public virtual Project Project { get; set; }
    }
}
