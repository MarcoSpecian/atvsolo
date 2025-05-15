using Microsoft.AspNetCore.Mvc;

namespace atvsolo.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
