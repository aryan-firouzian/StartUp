using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Web.WebPages.OAuth;
using StartUp.Models;

namespace StartUp
{
    public static class AuthConfig
    {
        public static void RegisterAuth()
        {
            OAuthWebSecurity.RegisterTwitterClient(
                consumerKey: "SadlLsy0oMGIzSizAWoapK9FH",
                consumerSecret: "sAP9vqo1WQ4IMRnuZHpFoosxAeXR90xddPpAznY3tyuqY8Zcxv");

            OAuthWebSecurity.RegisterFacebookClient(
                appId: "522456357881007",
                appSecret: "2c1a55ed9eef694f811ad6975cf48eff");
        }
    }
}
