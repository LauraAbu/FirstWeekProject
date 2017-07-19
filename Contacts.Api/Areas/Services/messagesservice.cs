using Contacts.Api.Areas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.Results;

namespace Contacts.Api.Areas.Services
{
    public class messagesservice
    {
        private static HttpClient client = new HttpClient();

        public async Task SendMessage(string phone, string messageText)
        {
            EsendexModel model = new EsendexModel
            {
                accountreference = "EX0235290",
                messages = new Message[]
                {
                    new Message
                        {
                            to = "37068912166",
                            body = "Labas Laura"
                        }
                }
            };

            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", "bC5hYnVrYXVza2FpdGVAZ21haWwuY29tOmFzdHVydGluZ2ExMg==");
            await client.PostAsJsonAsync(new Uri("https://api.esendex.com/v1.0/messagedispatcher"), model).ConfigureAwait(false);
           
        }

    }

