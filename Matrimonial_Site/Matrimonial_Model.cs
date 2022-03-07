using Matrimonial_Site.User;
using System;
using System.Data.Entity;
using System.Linq;

namespace Matrimonial_Site
{
    public class Matrimonial_Model : DbContext
    {
        // Your context has been configured to use a 'Matrimonial_Model' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Matrimonial_Site.Matrimonial_Model' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Matrimonial_Model' 
        // connection string in the application configuration file.
        public Matrimonial_Model()
            : base("name=Matrimonial_Model")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

         public virtual DbSet<user> Users { get; set; }
        public virtual DbSet<forgot> Forgot  { get; set; }

    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}