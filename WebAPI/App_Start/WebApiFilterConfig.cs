using System.Web;
using System.Web.Mvc;
using System.Web.Http.Filters;
using WebAPI.Framework;

namespace WebAPI
{
    /// <summary>
    /// Filter config for web api.
    /// </summary>
    public class WebApiFilterConfig
    {
        #region "Public Methods"
        
        /// <summary>
        /// Global filters.
        /// </summary>
        /// <param name="filters"></param>
        public static void RegisterGlobalFilters(HttpFilterCollection filters)
        {
            // error logging
            filters.Add(new CustomErrorHttpAttribute());

            // basic authentication for all api
            filters.Add(new AppBasicAuthenticationFilter());
        }

        #endregion
    }
}