using System;
using System.Net;
using System.Net.Http;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
namespace WebAPI.Framework
{
    public class AppBasicAuthenticationFilter : BasicAuthenticationFilter
    {

        public AppBasicAuthenticationFilter()
        { }

        public AppBasicAuthenticationFilter(bool active)
            : base(active)
        { }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="actionContext"></param>
        /// <returns></returns>
        protected override bool OnAuthorizeUser(string username, string password, HttpActionContext actionContext)
        {
            if (base.OnAuthorizeUser(username, password, actionContext) == false)
                return false;

            if (username != "china" || password != "123")
                return false;

            return true;
        }
    }
}