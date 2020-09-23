using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_N01445168.Controllers
{
    public class SquareController : ApiController
    {
        // GET /api/Square/2 -> 4
        public int Get(int id)
        {
            return id*id;
        }
    }
}
