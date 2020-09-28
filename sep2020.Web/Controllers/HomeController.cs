using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace sep2020.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : sep2020ControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}