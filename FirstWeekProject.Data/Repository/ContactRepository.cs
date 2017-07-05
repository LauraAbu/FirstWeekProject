using FirstWeekProject.Data.Interfaces;
using FirstWeekProject.Data.Models;
using System.Collections.Generic;

namespace FirstWeekProject.Data.Repository
{
    public class ContactRepository : IContactRepository
    {
        private static int _currentId = 0;
        private static Dictionary<int, Contact> _contacts = new Dictionary<int, Contact>();

        public IEnumerable<Contact> GetAll()
        {
            return _contacts.Values;
        }

        public Contact Create(Contact model)
        {
            model.Id = _currentId;

            _contacts.Add(_currentId, model);

            _currentId++;

            return model;
        }

        public Contact GetById(int id)
        {
            return _contacts[id];
        }
    }
}