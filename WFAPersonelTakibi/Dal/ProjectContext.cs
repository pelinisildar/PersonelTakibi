namespace WFAPersonelTakibi.Dal
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using WFAPersonelTakibi.Models;

    public class ProjectContext : DbContext
    {
      
        public ProjectContext()
            : base("name=ProjectContext")
        {
            //Database.Connection.ConnectionString = "server";
        }

      public virtual DbSet<Employee> Employees { get; set; }
    }

    
}