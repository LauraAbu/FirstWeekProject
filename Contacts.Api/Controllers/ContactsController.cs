using Contacts.Data;
using Contacts.Data.Interfaces;
using Contacts.Data.Repository;
using System.Web.Http;

namespace Contacts.Api.Controllers
{
    public class ContactsController : ApiController
    {

        private readonly IContactRepository _contactRepository;

        public ContactsController()
        {
            _contactRepository = new ContactRepository();
        }

        // GET api/<controller>
        public IHttpActionResult Get()
        {
            return Ok(_contactRepository.GetAll());
        }

        // GET api/<controller>/5
        public IHttpActionResult Get(int id)

        {
            if (id == 0)
            {
                return Ok(new Contact());
            }
            var contact = _contactRepository.GetById(id);

            if (null == contact)
            {
                return NotFound();
            }

            return Ok(contact);
        }

        // POST api/<controller>
        public IHttpActionResult Post([FromBody] Contact value)
        {
            if (null == value || !ModelState.IsValid)
            {
                return BadRequest();
            }

            _contactRepository.Create(value);

            return Ok();
        }

        // PUT api/<controller>/5
        public IHttpActionResult Put(int id, [FromBody] Contact value)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            _contactRepository.Update(id, value);

            return Ok();
        }

        // DELETE api/<controller>/5
        public IHttpActionResult Delete(int id)
        {
            _contactRepository.Delete(id);

            return Ok();
        }
    }
}

