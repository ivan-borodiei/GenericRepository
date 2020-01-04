using Model.Database;

namespace Model.Factories.Interfaces
{
    public interface IEducationDbContextFactory
    {
        EducationDbContext DbContext { get; }
    }
}
