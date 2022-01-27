using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication4.Controllers
{
    public class HostingCostController : ApiController
    {
        public IEnumerable<string> Get(int id)
        {
            double fortnights = id / 14;
            int fortnights2 = Convert.ToInt32(fortnights + 1);
            double chargeforfortnight = 5.50 * fortnights2;
            double HstTotal = fortnights2 * 0.72;
            double TotalBill = chargeforfortnight + HstTotal;
            return new string[] { fortnights2 + "Fortnights at t $5.50/FN =$"+chargeforfortnight+" CAD" ,"HST 13% = $" +
                HstTotal+" CAD","Total = $" + TotalBill +" CAD"};
        }
    }
}
