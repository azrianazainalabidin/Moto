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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class motodbEntities : DbContext
    {
        public motodbEntities()
            : base("name=motodbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Class_Record> Class_Records { get; set; }
        public virtual DbSet<Salary_Record> Salary_Records { get; set; }
        public virtual DbSet<Student_Performance_Record> Student_Performance_Records { get; set; }
        public virtual DbSet<Student_Record> Student_Records { get; set; }
        public virtual DbSet<User_Record> User_Records { get; set; }
        public virtual DbSet<User_Type> User_Types { get; set; }
    }
}
