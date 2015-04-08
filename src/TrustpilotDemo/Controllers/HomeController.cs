using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace TrustpilotDemo.Controllers
{
    public class HomeController : Controller
    {
        private Repositories.IBlogRepo _repo;

        public HomeController(Repositories.IBlogRepo repo)
        {
            _repo = repo;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var post = _repo.GetBlogPost();

            return View(post);
        }
    }
}
