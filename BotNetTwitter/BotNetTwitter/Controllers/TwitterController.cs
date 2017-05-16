using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Http;

namespace BotNetTwitter.Controllers
{
    [RoutePrefix("twitter")]
    public class TwitterController : ApiController
    {
        [Route("echo")]
        [System.Web.Http.HttpGet]
        public HttpResponseMessage echo()
        {
            var response = new HttpResponseMessage();
            response.Content = new StringContent("<html><body>Hello World</body></html>");
            response.Content.Headers.ContentType = new MediaTypeHeaderValue("text/html");
            return response;
        }
    }
}