using Contacts.Data;
using Contacts.Data.Interfaces;
using Contacts.Data.Repository;
using System.Web.Http;
using System.Linq;
using System.Web.Http.Cors;
using Contacts.Api.App_Start;
using Contacts.Api.Areas.Services;
using System.Threading.Tasks;

namespace Contacts.Api.Controller
{

    [Authorize]
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
        [HttpPost]
        [Route ("api/messages")]
        public IHttpActionResult Post([FromBody] Message value)
        {
            if (null == value || !ModelState.IsValid)
            {
                return BadRequest();
            }
            messagesservice service = new messagesservice();
            Task.Run(() => service.SendMessage("", ""));
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

