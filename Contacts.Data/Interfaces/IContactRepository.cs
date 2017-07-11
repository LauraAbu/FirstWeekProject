using System.Collections.Generic;
using Contacts.Data.Models;

namespace Contacts.Data.Interfaces
{
    public interface IContactRepository
    {
        IEnumerable<Contact> GetAll();
        Contact GetById(int id);
        Contact Create(Contact model);
        void Update(int id, Contact model);
        void Delete(int id);
    }
}