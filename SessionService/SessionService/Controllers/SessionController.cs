using Microsoft.AspNetCore.Mvc;

namespace SessionService.Controllers;

[ApiController]
[Route("")]
public class SessionController : ControllerBase
{
    [HttpPost("data")]
    public ActionResult AddSessionData(string key, string data)
    {
        HttpContext.Session.SetString(key, data);

        return Ok($"Write data to session with key:{key} and value: {data}");
    }

    [HttpGet("data")]
    public ActionResult GetSessionData([FromQuery] string key)
    {
        var result = HttpContext.Session.GetString(key);

        return Ok(result);
    }
}