using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_N01445168.Controllers
{
    public class AddTenController : ApiController
    {
        //  GET /api/AddTen/21 -> 31
        public int Get(int id)
        {
            return id+10;
        }
    }
}
