//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseWebAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblJob
    {
        public int JobID { get; set; }
        public Nullable<int> RemoteServiceID { get; set; }
        public string PythonCode { get; set; }
        public string Result { get; set; }
        public Nullable<int> StatusID { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
    
        public virtual tblStatu tblStatu { get; set; }
        public virtual tblClient tblClient { get; set; }
        public virtual tblClient tblClient1 { get; set; }
        public virtual tblRemoteService tblRemoteService { get; set; }
    }
}
