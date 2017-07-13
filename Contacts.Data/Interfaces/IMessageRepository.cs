using System.Collections.Generic;

namespace Contacts.Data.Interfaces
{
    public interface IMessageRepository
    {
        IEnumerable<Message> GetAll();
        Message GetById(int id);
        Message Create(Message model);
        void Update(int id, Message model);
        void Delete(int id);
       
    }
}