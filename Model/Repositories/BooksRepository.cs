using System.Collections.Generic;
using System.Linq;
using Model.Repositories.Interfaces;
using Model.Entities;
using Model.Factories.Interfaces;

namespace Model.Repositories
{
    public class BooksRepository : Repository<Book>, IBooksRepository
    {
        public BooksRepository(IEducationDbContextFactory dbContextFactory) : base(dbContextFactory)
        {
        }

        public Book GetByName(string name)
        {
            return dbContext.Books.FirstOrDefault(b => b.Name == name);
        }
    }
}
