﻿using Contacts.Api.App_Start;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OAuth;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace Contacts.Api.Controller
{
    public class AccountsController : ApiController
    {

        [HttpGet]
        [Route("api/login")]
        public HttpResponseMessage Login()
        {

            //var a = Request.Headers.GetValues("Location");
            var properties = new AuthenticationProperties
            {
            //veikia tik sekmingai prisijungus prie FB
               RedirectUri ="http://localhost:50130/#!/contacts"
            };
            Request.GetOwinContext().Authentication.Challenge(properties, "Facebook");
            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.Unauthorized);
            response.RequestMessage = Request;
            Request.GetOwinContext().Authentication.SignOut();

            return response;
        }
    }
}