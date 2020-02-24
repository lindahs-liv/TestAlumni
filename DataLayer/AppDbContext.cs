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
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Administrator> Administrators { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Section> Sections { get; set; }
        public virtual DbSet<BusinessInformatics> BusinessInformatics { get; set; }
        public virtual DbSet<ComputerScience> ComputerSciences { get; set; }
        public virtual DbSet<SystemsScience> SystemsSciences { get; set; }
        public virtual DbSet<Activity> Activities { get; set; }
        public virtual DbSet<GuestLecture> GuestLectures { get; set; }
        public virtual DbSet<Section> Section { get; set; }
        public virtual DbSet<Session> Sessions { get; set; }
        public  AppDbContext() : base("AppDbContext")
        {
        }
        #endregion
        // Kanske ska det vara s�h�r?
        // public virtual DbSet<User> MyEntities { get; set; }
        // eller s�h�r
        // public DbSet<User> Users {get; set; }
    }


    //DETTA �R AUTOMATISKT INLAGT OCH SKA ANTAGLIGEN ANV�NDAS P� NGT S�TT

    //public class MyEntity
    //{
    //    public int UserId { get; set; }
    //    public string Name { get; set; }
    //}
}