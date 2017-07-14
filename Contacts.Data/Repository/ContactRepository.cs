using Contacts.Data.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Contacts.Data.Repository
{
    public class ContactRepository : IContactRepository
    {
        ContactsAppDbEntities _context;

        public ContactRepository()
        {
            _context = new ContactsAppDbEntities();
        }



        public IEnumerable<Contact> GetAll()
        {
            var contacts = _context.Contacts.ToList();
            return contacts;
        }

        public Contact Create(Contact model)
        {


            _context.Contacts.Add(model);
            _context.SaveChanges();

            return model;
        }

        public Contact GetById(int id)
        {
            var contact=_context.Contacts.FirstOrDefault(x=>x.Id==id);

            return contact;

        }

        public void Update(int id, Contact model)
        {
            var dbcontact = _context.Contacts.FirstOrDefault(x => x.Id == id);

            dbcontact.EmailAddress = model.EmailAddress;
            dbcontact.LastName = model.LastName;
            dbcontact.Name = model.Name;
            dbcontact.Phone = model.Phone;


            _context.SaveChanges();

        }
        public void Delete (int id)
        {
            var contact = _context.Contacts.FirstOrDefault(x => x.Id == id);

            _context.Contacts.Remove(contact);
            _context.SaveChanges();
        }

    }
}