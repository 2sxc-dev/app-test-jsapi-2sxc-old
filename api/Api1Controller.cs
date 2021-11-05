#if NETCOREAPP // Oqtane
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
#else // DNN
using System.Web.Http;
using DotNetNuke.Web.Api;
#endif

[AllowAnonymous]      // define that all commands can be accessed without a login
// Inherit from Custom.Hybrid.Api12 to get features like App, Data...
// see https://docs.2sxc.org/web-api/custom/index.html
public class Api1Controller : Custom.Hybrid.Api12
{
    [HttpGet]        // [HttpGet] says we're listening to GET requests
    public string Hello()
    {
        return "Hello from the controller with ValidateAntiForgeryToken in /api";
    }

    [HttpPost]        // [HttpPost] says we're listening to POST requests
    [ValidateAntiForgeryToken] // protects from the users not on your site (CSRF protection)
    public int Sum([FromBody] dynamic bodyJson) // post body { "a": 2, "b": 3 }
    {
        int a = bodyJson.a;
        int b = bodyJson.b;
        return a + b;
    }
}
