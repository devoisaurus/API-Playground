using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiPlaygroundReDux.Controllers
{
    public class SashController : ApiController
    {
        public SashController()
        {

        }

        [HttpGet]
        [Route("api/bananas/{hammock}")]
        public Sash CrazyTime(int hammock)
        {
            return new Sash
            {
                Cost = 12,
                Name = "Divorce Sash",
                QuantityRemaining = 1
            };
        }

    }

    public class Sash
    {
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public int QuantityRemaining { get; set; }
    }
}
