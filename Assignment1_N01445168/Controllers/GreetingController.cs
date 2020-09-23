using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_N01445168.Controllers
{
    public class GreetingController : ApiController
    {
        // GET /api/Greeting/3 -> Greetings to 3 people!
        public string Get(int id)
        {
            return "Greetings to " + id + " people!";
        }
         
        /// <summary>
        /// This method returns a string when receiving a POST request
        /// <example>/api/Greeting</example>
        /// </summary>
        /// <returns>Hello World!</returns>
        public string Post()
        {
            return "Hello World!";
        }
    }
}
