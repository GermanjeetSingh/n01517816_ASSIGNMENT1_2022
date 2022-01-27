using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication4.Controllers
{
    public class NumberMachineController : ApiController
    {
        public int Get(int id)
        {

            return (10 + (id / 2)) ^ 3 - 30 ; 
        }

       
    }
}
