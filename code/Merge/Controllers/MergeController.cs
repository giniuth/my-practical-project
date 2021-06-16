using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Merge.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MergeController : ControllerBase

    {
        private IConfiguration Configuration;
        public MergeController(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {

            var numbersService = $"{Configuration["numbersServiceURL"]}/numbers";
            var numbersResponseCall = await new HttpClient().GetStringAsync(numbersService);

            var lettersService = $"{Configuration["lettersServiceURL"]}/letters";
            var lettersResponseCall = await new HttpClient().GetStringAsync(lettersService);

            var mergedResponse = $"{numbersResponseCall}{lettersResponseCall}";
            ////var result = "this password is strong enough";

            ////return Ok(new { mergedResponse, result });
            //if (mergedResponse == mergedResponse.ToLower())
            //    return Ok("Your password is not strong enough");
            //else return Ok(mergedResponse);

            var returnValue = ValidatePassword(mergedResponse);
            return Ok(returnValue);
        }


        string ValidatePassword(string password)
        {
            var input = password;
            var ErrorMessage = string.Empty;

            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-M]+");
            var hasLowerChar = new Regex(@"[a-m]+");

            if (!hasLowerChar.IsMatch(input))
            {
                ErrorMessage = "Great! Password with numbers take 1000 hours to crack";
                return $"{password}: {ErrorMessage}";
            }
            else if (!hasUpperChar.IsMatch(input))
            {
                ErrorMessage = "Its good to have a mix of Upper and Lower case letters!";
                return $"{password}: {ErrorMessage}";
            }
            else if (!hasNumber.IsMatch(input))
            {
                ErrorMessage = "Special characters make passwords 10 times harder to crack!";
                return $"{password}: {ErrorMessage}";
            }
            else
            {
                return password;
            }
        }
    }
}



