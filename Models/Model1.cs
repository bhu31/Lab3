namespace Lab3.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Images> Images { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Images>()
                .Property(e => e.C_Path_)
                .IsUnicode(false);

            modelBuilder.Entity<Images>()
                .Property(e => e.C_Name_)
                .IsUnicode(false);
        }
    }
}
