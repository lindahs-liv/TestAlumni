namespace DataLayer
{
    using BusinessEntities;
    using System;
    using System.Data.Entity;
    using System.Linq;


    public class AppDbContext : DbContext
    {
        // Your context has been configured to use a 'AppDbContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'DataLayer.AppDbContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'AppDbContext' 
        // connection string in the application configuration file.


        #region Adds Tables in Database
        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.
        public DbSet<User> Users { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Administrator> Administrators { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<BusinessInformatics> BusinessInformatics { get; set; }
        public DbSet<ComputerScience> ComputerSciences { get; set; }
        public DbSet<SystemsScience> SystemsSciences { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<GuestLecture> GuestLectures { get; set; }
        public DbSet<Section> Section { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public AppDbContext() : base("AppDbContext")
        {
        }
        // Kanske ska det vara såhär?
        // public virtual DbSet<User> MyEntities { get; set; }
        // eller kanske såhär
        // public DbSet<User> Users {get; set; }

        //DETTA ÄR AUTOMATISKT INLAGT OCH SKA ANTAGLIGEN ANVÄNDAS PÅ NGT SÄTT
        //public class MyEntity
        //{
        //    public int UserId { get; set; }
        //    public string Name { get; set; }
        //}
        #endregion


    }
}