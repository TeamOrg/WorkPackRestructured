using System.ComponentModel.DataAnnotations;

namespace DomainModelLibrary
{
    using System;
    using System.Collections.Generic;
    
    public partial class ApprovalAttachmentFileTemp
    {
        [Key]
        public int AttachFileID { get; set; }
        public string FilePath { get; set; }
        public Nullable<int> FileID { get; set; }
        public string FileName { get; set; }
        public string FileExtention { get; set; }
        public Nullable<int> FileSize { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
    }
}
