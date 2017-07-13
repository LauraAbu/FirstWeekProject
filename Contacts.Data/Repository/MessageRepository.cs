using Contacts.Data.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Contacts.Data.Repository
{
    public class MessageRepository : IMessageRepository
    {
        ContactsAppDbEntities _context;

        public MessageRepository()
        {
            _context = new ContactsAppDbEntities();
        }



        public IEnumerable<Message> GetAll()
        {
            return _context.Messages.ToList();
        }

        public Message Create(Message model)
        {


            _context.Messages.Add(model);
            _context.SaveChanges();

            return model;
        }

        public Message GetById(int id)
        {
            var Message = _context.Messages.FirstOrDefault(x => x.Id == id);

            return Message;

        }

        public void Update(int id, Message model)
        {
            var dbmessage = _context.Messages.FirstOrDefault(x => x.Id == id);

            dbmessage.Message1 = model.Message1;
            dbmessage.IsSent = model.IsSent;
            dbmessage.ContactId = model.ContactId;
            
            _context.SaveChanges();

        }
        public void Delete(int id)
        {
            var Message = _context.Messages.FirstOrDefault(x => x.Id == id);

            _context.Messages.Remove(Message);
            _context.SaveChanges();
        }

    }
}