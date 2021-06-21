using System;
using Microsoft.AspNetCore.Mvc;


namespace Letters.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LettersController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {

            char[] chars = "abcdefghijklmnopqrstuvwxyz; :ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            string password = string.Empty;
            Random random = new Random();
            int length = 5;

            for (int ctr = 0; ctr < length; ctr++)
            {
                int x = random.Next(1, chars.Length);
                if (!password.Contains(chars.GetValue(x).ToString()))
                    password += chars.GetValue(x);
                else
                    ctr--;
            }
            return password;
        }
    }
}