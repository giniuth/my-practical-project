using System;
using Microsoft.AspNetCore.Mvc;

namespace Numbers.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NumbersController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string>Get()
        {
            char[] numberschars = "$%#@!*?()^&; :123456789".ToCharArray();
            string password = string.Empty;
            Random rnd = new Random();
            int length = 5;

            // counter ctr = i 
            for (int ctr = 0; ctr < length; ctr++)
            {
                int x = rnd.Next(1, numberschars.Length);
                if (!password.Contains(numberschars.GetValue(x).ToString()))
                    password += numberschars.GetValue(x);
                else
                    ctr--;
            }

            return password;
        }
    }
}





