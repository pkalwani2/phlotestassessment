using Microsoft.AspNetCore.Mvc;

namespace phloTestAssessment.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
