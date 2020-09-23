using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_N01445168.Controllers
{
    public class HostingCostController : ApiController
    {

        public IEnumerable<string> Get(int id)
           
        {
            double FORTNIGHT = id * 5.50;
            double HST = (13*FORTNIGHT)/100;
            return new string[] { $"{id} fortnights at $5.50/FN = ${FORTNIGHT} CAD", $"HST 13% = ${HST} CAD", $"Total = ${FORTNIGHT + HST} CAD" };
        }
    }
}
