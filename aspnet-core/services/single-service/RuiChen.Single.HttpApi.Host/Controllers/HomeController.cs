using Microsoft.AspNetCore.Mvc;

namespace RuiChen.Single.HttpApi.Host;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return Redirect("/swagger");
    }
}
