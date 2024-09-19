using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace codeFirst_Task1.Models
{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("DefaultConnection")
        {

        }

        public DbSet<Student> students { get; set; }
        public DbSet<Teacher> teachers { get; set; }
        public DbSet<Assignment> assignments { get; set; }



        //يقوم بشكل أساسي بإيقاف استخدام التعديلات التلقائية التي تحول أسماء الجداول إلى صيغة الجمع، مما يساعد في الحفاظ على توافق أسماء الجداول مع أسماء الكيانات في الكود الخاص بك.
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           
            modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();

            base.OnModelCreating(modelBuilder);
        }
    }  
}

