using System.Web.Mvc;
using IsaacBroylesWeb.Repositories;

namespace IsaacBroylesWeb.Controllers
{
    public class PostController : Controller
    {
        //
        // GET: /Post/
        public ActionResult Index()
        {
            return View();
        }

        [HandleError]
        public ActionResult Detail(string title)
        {
            return View(PostsRepository.GetPostWithTitle(title));
        }
    }
}
