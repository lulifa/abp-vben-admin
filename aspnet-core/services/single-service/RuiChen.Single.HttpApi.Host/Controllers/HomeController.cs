using Microsoft.AspNetCore.Mvc;

namespace RuiChen.Single.Admin;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return Redirect("/swagger");
    }
}
