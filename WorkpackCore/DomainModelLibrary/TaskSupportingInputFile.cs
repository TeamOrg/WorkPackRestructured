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
    
    public partial class TaskSupportingInputFile
    {
        public int TaskSupportingInputFilesID { get; set; }
        public Nullable<int> TaskID { get; set; }
        public Nullable<int> ProjectID { get; set; }
        public string InputFilesPath { get; set; }
        public string FilesExtn { get; set; }
    }
}
