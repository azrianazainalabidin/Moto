//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MengajiOne2One.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student_Performance_Record
    {
        public string per_ID { get; set; }
        public string per_desc { get; set; }
        public System.DateTime per_date { get; set; }
        public string per_studentID { get; set; }
        public Nullable<System.DateTime> per_month { get; set; }
    
        public virtual Student_Record Student_Record { get; set; }
    }
}