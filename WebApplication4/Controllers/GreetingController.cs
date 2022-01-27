﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication4.Controllers
{
    public class GreetingController : ApiController
    {
        public string Get()
        {
            return "Hello World!";
        }

        public string Get(int id)
        {
            string message = "Greeting to " + id + " people";
            return message;

        }
            
    }
}
