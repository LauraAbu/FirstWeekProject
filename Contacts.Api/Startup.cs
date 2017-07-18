using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Microsoft.Owin.Security.Cookies;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security.Facebook;

[assembly: OwinStartup(typeof(Contacts.Api.Startup))]

namespace Contacts.Api
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ExternalCookie,
                ExpireTimeSpan = new TimeSpan(0, 30, 0),
                LoginPath = new PathString("/api/Messages")
            });

            app.UseExternalSignInCookie(DefaultAuthenticationTypes.ExternalCookie);

            app.UseFacebookAuthentication(new FacebookAuthenticationOptions()
            {
                AppId = "1904161343184573",
                AppSecret = "2ab5c0ddc1a84bd03ab5ee2d827605da"
            });
        }
    }
}
