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
    
    public partial class User_Record
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User_Record()
        {
            this.Class_Record = new HashSet<Class_Record>();
            this.Salary_Record = new HashSet<Salary_Record>();
            this.Student_Record = new HashSet<Student_Record>();
        }
    
        public string u_id { get; set; }
        public string u_pwd { get; set; }
        public int u_type { get; set; }
        public string u_name { get; set; }
        public string u_contactNo { get; set; }
        public string u_email { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Class_Record> Class_Record { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Salary_Record> Salary_Record { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student_Record> Student_Record { get; set; }
        public virtual User_Type User_Type { get; set; }
    }
}
