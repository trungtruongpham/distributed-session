using Microsoft.AspNetCore.Mvc;

namespace CustomerService.Controllers;

[ApiController]
[Route("")]
public class CustomerController : ControllerBase
{
    [HttpGet("data")]
    public IActionResult GetCustomerData(string key)
    {
        var customerCart = HttpContext.Session.GetString(key);
        Console.WriteLine(customerCart);

        return Ok(customerCart);
    }
}