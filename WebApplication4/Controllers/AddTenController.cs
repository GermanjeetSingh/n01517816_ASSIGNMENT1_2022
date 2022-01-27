using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication4.Controllers
{
    public class AddTenController : ApiController
    {
        public string Get()
        {
            string message = "Hello!"; 
            return message;
        }

        public int Get(int id)
        {
            return id + 10;
        }
    }
}
