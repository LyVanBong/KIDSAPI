//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KIDS.API.Database
{
    using System;
    
    public partial class sp_Student_Assess_Student_sel_Result
    {
        public Nullable<System.Guid> ID { get; set; }
        public Nullable<System.Guid> NamHoc { get; set; }
        public Nullable<System.Guid> ClassID { get; set; }
        public Nullable<System.Guid> StudentID { get; set; }
        public Nullable<System.Guid> AssessID { get; set; }
        public string STT { get; set; }
        public string Name { get; set; }
        public Nullable<int> Sort { get; set; }
        public Nullable<System.Guid> ParentID { get; set; }
        public Nullable<bool> Result { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.Guid> UserCreate { get; set; }
    }
}
