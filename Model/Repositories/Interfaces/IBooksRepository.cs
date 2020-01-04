using System.Collections.Generic;
using Model.Entities;

namespace Model.Repositories.Interfaces
{
    public interface IBooksRepository: IRepository<Book>
    {
        Book GetByName(string name);
    }
}
