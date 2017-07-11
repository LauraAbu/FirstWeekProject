using Contacts.Data.Interfaces;
using Contacts.Data.Models;
using Contacts.Data.Repository;
using System.Web.Http;

namespace Contacts.Api
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            CreateData();
        }

        private void CreateData()
        {
            IContactRepository contactRepository = new ContactRepository();

            var contact1 = new Contact();

            contact1.Name = "Petras";
            contact1.LastName = "Petraitis";
            contact1.EmailAddress = "P.Petraitis@gmail.com";
            contact1.Phone = "8689112455";

            contactRepository.Create(contact1);

            var contact2 = new Contact();

            contact2.Name = "Jonas";
            contact2.LastName = "Jonaitis";
            contact2.EmailAddress = "J.Jonaitis@gmail.com";
            contact2.Phone = "+3706002455";

            contactRepository.Create(contact2);

            var contact3 = new Contact();

            contact3.Name = "Benas";
            contact3.LastName = "Benaitis";
            contact3.EmailAddress = "BenasB@gmail.com";
            contact3.Phone = "868152466";

            contactRepository.Create(contact3);

            var contact4 = new Contact();

            contact4.Name = "Robertas";
            contact4.LastName = "Jonaitis";
            contact4.EmailAddress = "RobertasJonaitis@gmail.com";
            contact4.Phone = "86824579";

            contactRepository.Create(contact4);
        }
    }
}
