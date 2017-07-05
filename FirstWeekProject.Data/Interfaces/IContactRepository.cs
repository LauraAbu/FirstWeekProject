using System.Collections.Generic;
using FirstWeekProject.Data.Models;

namespace FirstWeekProject.Data.Interfaces
{
    public interface IContactRepository
    {
        IEnumerable<Contact> GetAll();
        Contact GetById(int id);
        Contact Create(Contact model);
    }
}