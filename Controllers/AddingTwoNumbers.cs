
using Microsoft.AspNetCore.Mvc;

namespace Adding_2_numbers___Endpoint.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddingTwoNumbers : ControllerBase
    {
        [HttpGet]
        [Route("Adding/{num1}/{num2}")]
        public IActionResult AddingNumbers(int num1, int num2)
        {
            int sum = num1 + num2;
            string result = $"The sum of {num1} plus {num2} is {sum}";
            return Ok(result);
        }
    }
}