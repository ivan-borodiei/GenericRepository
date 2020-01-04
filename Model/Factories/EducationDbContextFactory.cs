using Model.Database;
using Model.Factories.Interfaces;

namespace Model.Factories
{
    public class EducationDbContextFactory : IEducationDbContextFactory
    {
        string connectionString;

        public EducationDbContextFactory(string connectionString)
        {            
            this.connectionString = connectionString;
        }

        public EducationDbContext DbContext => new EducationDbContext(connectionString);        
    }
}