namespace Model.Database
{    
    using System.Data.Entity;
    using Entities;

    public class EducationDbContext : DbContext
    {
        // Your context has been configured to use a 'Database' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Model.Database' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Database' 
        // connection string in the application configuration file.
        public EducationDbContext()
            : base("name=Database")
        {
        }

        public EducationDbContext(string connectionString)
            : base(connectionString)
        {
        }

        public virtual DbSet<Book> Books { get; set; }
    }

}