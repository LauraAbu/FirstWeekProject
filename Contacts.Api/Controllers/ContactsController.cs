using Contacts.Data;
using Contacts.Data.Interfaces;
using Contacts.Data.Repository;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Contacts.Api.Controller
{
  
    [Authorize]
    public class ContactsController : ApiController
    {

        private readonly IContactRepository _contactRepository;

        public ContactsController()
        {
            _contactRepository = new ContactRepository();
        }

        // GET api/<controller>
        [HttpGet]
       [Route("api/contacts")]
        public IHttpActionResult Get()
        {
            try
            {
                var req = Request;
                return Ok(_contactRepository.GetAll().ToList());
            }
            catch (System.Exception ex)
            {
                var a = ex.Message;
            }
            return BadRequest();
        }

        // GET api/<controller>/5
        
        [HttpGet]
        [Route("api/contacts/{id:int}")]
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

