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
            var returnInput = CheckPassword(mergedResponse);
            return Ok(returnInput);
        }
        string CheckPassword(string password)
        {
            var input = password;
            var ErrorMessage = string.Empty;

            var Number = new Regex(@"[0-9]+");
            var UpperCase = new Regex(@"[A-M]+");
            var LowerCase = new Regex(@"[a-m]+");

            if (!LowerCase.IsMatch(input))
            {
                ErrorMessage = "Great! Password with numbers take 1000 hours to crack";
                return $"{password}: {ErrorMessage}";
            }
            else if (!UpperCase.IsMatch(input))
            {
                ErrorMessage = "Its good to have a mix of Upper and Lower case letters!";
                return $"{password}: {ErrorMessage}";
            }
            else if (!Number.IsMatch(input))
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


////var result = "this password is strong enough";

////return Ok(new { mergedResponse, result });
//if (mergedResponse == mergedResponse.ToLower())
//    return Ok("Your password is not strong enough");
//else return Ok(mergedResponse);
