using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Numbers.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NumbersController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            char[] chars = "$%#@!*?()^&; :123456789".ToCharArray();
            string password = string.Empty;
            Random rnd = new Random();
            int length = 5;

            //var rand = new Random();
            //            //Console.WriteLine("Five random integers between 0 and 100:");
            //            //for (int ctr = 0; ctr <= 4; ctr++)
            //            //    Console.Write("{0,8:N0}", rand.Next(101));
            //            //return ToString(); Console.WriteLine();

            // counter ctr = i 
            for (int ctr = 0; ctr < length; ctr++)
            {
                int x = rnd.Next(1, chars.Length);
                if (!password.Contains(chars.GetValue(x).ToString()))
                    password += chars.GetValue(x);
                else
                    ctr--;
            }

            return password;
        }
    }
}





