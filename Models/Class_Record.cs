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
    
    public partial class Class_Record
    {
        public string c_id { get; set; }
        public System.DateTime c_date { get; set; }
        public string c_studentID { get; set; }
        public int c_duration { get; set; }
        public string c_teacherID { get; set; }
    
        public virtual Student_Record Student_Record { get; set; }
        public virtual User_Record User_Record { get; set; }
    }
}
