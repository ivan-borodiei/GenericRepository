using Model.Entities;
using Model.Factories.Interfaces;
using Model.Factories;
using Model.Repositories.Interfaces;
using Model.Repositories;
using System.Configuration;

namespace Console.Wrappers
{
    public static class RepositoryConsumer
    {        
        public static void RunTest()
        {
            Book newBook = new Book()
            {
                Name = "Refactoring2",
                Author = "Martin Fauler2"
            };
            
            IEducationDbContextFactory dbContextFactory = new EducationDbContextFactory(ConfigurationManager.ConnectionStrings["Database"].ConnectionString);
            IBooksRepository repository = new BooksRepository(dbContextFactory);

            var book = repository.GetByName("Refactoring");
            //repository.Dispose();         
        }
    }
}
