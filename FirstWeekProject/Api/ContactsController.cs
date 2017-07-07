using FirstWeekProject.Data.Interfaces;
using FirstWeekProject.Data.Models;
using FirstWeekProject.Data.Repository;
using System.Collections.Generic;
using System.Web.Http;

namespace FirstWeekProject.Controllers.Api
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

            _contactRepository.Update (id, value);

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