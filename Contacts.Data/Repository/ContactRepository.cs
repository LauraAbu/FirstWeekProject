using Contacts.Data.Interfaces;
using Contacts.Data.Models;
using System.Collections.Generic;

namespace Contacts.Data.Repository
{
    public class ContactRepository : IContactRepository
    {
        private static int _currentId = 1;
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
            if (!_contacts.ContainsKey(id))
            {
                return (null);
            }

            return _contacts[id];

        }

        public void Update(int id, Contact model)
        {
            model.Id = id;
            _contacts.Remove(id);
            _contacts.Add(id, model);
        }
        public void Delete (int id)
        {
            _contacts.Remove(id);
        }
    }
}