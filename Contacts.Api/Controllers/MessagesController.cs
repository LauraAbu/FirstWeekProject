using Contacts.Data;
using Contacts.Data.Interfaces;
using Contacts.Data.Repository;
using System.Web.Http;
using System.Linq;
using System.Web.Http.Cors;

namespace Contacts.Api.Controller
{
    [EnableCors("*", "*", "*", exposedHeaders: "X-Custom-Header")]
    public class MessagesController : ApiController
    {

        private readonly IMessageRepository _messageRepository;
        

        public MessagesController()
        {
            _messageRepository = new MessageRepository();
        }

        // GET api/<controller>
        [Route("api/Messages")]
        public IHttpActionResult Get()
        {
            return Ok(_messageRepository.GetAll().ToList());
        }

        // GET api/<controller>/5
        public IHttpActionResult Get(int id)

        {
            if (id == 0)
            {
                return Ok(new Message());
            }
            var Message = _messageRepository.GetById(id);

            if (null == Message)
            {
                return NotFound();
            }

            return Ok(Message);
        }

        // POST api/<controller>
        public IHttpActionResult Post([FromBody] Message value)
        {
            if (null == value || !ModelState.IsValid)
            {
                return BadRequest();
            }

            _messageRepository.Create(value);

            return Ok();
        }

        // PUT api/<controller>/5
        public IHttpActionResult Put(int id, [FromBody] Message value)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            _messageRepository.Update(id, value);

            return Ok();
        }

        // DELETE api/<controller>/5
        public IHttpActionResult Delete(int id)
        {
            _messageRepository.Delete(id);

            return Ok();
        }
    }
}

