using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebAPI.Framework
{
    /// <summary>
    /// Custom error http attribute.
    /// </summary>
    public class CustomErrorHttpAttribute : System.Web.Http.Filters.ExceptionFilterAttribute 
    {
        #region "Events"
        
        /// <summary>
        /// OnException.
        /// </summary>
        /// <param name="filterContext"></param>
        public override void OnException(System.Web.Http.Filters.HttpActionExecutedContext context)
        {
            try
            {
                // log da exceção
                // ................

                long errorCode = 123456;
                string error = "An error occurred: " + errorCode.ToString();

                context.Response = context.Request.CreateResponse(HttpStatusCode.InternalServerError, new { error = error });
            }
            catch
            {
                base.OnException(context);
            }
        }

        #endregion

    }

}
