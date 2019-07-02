using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using LabFinalWeb.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace LabFinalWeb.DAL
{
    public class DBContext:DbContext
    {
        public DBContext():base("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TyreShop;" +
            "Integrated Security=True;" +
            "" + "Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;" +
            "ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        {

        }
        public DbSet<Tyres>tyre { get; set; }
        public DbSet<Sales> sale { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}