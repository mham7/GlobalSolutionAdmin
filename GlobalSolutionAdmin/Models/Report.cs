//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GlobalSolutionAdmin.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Report
    {
        public int report_id { get; set; }
        public Nullable<int> site_id { get; set; }
        public System.DateTime report_date { get; set; }
        public string report_content { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
    
        public virtual Site Site { get; set; }
    }
}
