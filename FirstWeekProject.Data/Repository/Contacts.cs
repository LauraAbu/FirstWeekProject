using System;
using System.Collections.Generic;
using System.Linq;
using FirstWeekProject.Data.Models;



namespace FirstWeekProject.Data.Repository
{
    public class Contacts
    {
        private static List<Contact> contactList = new List<Contact>();
        static Contacts()
        {
            var contact1 = new Contact();
            contact1.Name = "Petras";
            contact1.LastName = "Petraitis";
            contact1.EmailAddress = "P.Petraitis@gmail.com";
            contact1.Phone = "8689112455";
            contactList.Add(contact1);


            var contact2 = new Contact();
            contact2.Name = "Jonas";
            contact2.LastName = "Jonaitis";
            contact2.EmailAddress = "J.Jonaitis@gmail.com";
            contact2.Phone = "+3706002455";
            contactList.Add(contact2);

            var contact3 = new Contact();
            contact3.Name = "Benas";
            contact3.LastName = "Benaitis";
            contact3.EmailAddress = "BenasB@gmail.com";
            contact3.Phone = "868152466";
            contactList.Add(contact3);


            var contact4 = new Contact();
            contact4.Name = "Robertas";
            contact4.LastName = "Jonaitis";
            contact4.EmailAddress = "RobertasJonaitis@gmail.com";
            contact4.Phone = "86824579";
            contactList.Add(contact4);
        }

        public static List<Contact> GetAll()
        {

            return contactList;
        }

        public static void Add(Contact model)
        {
            contactList.Add(model);
        }
        public static Contact GetById(int id)
        {
            int _id = id;

            if (_id >= contactList.Count)
            {
                _id = contactList.Count - 1;
            }
            else if (_id < 0)
            {
                _id = 0;
            }

            return contactList[id];
        }
    }
}