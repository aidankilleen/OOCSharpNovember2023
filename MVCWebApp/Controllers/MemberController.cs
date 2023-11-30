using MemberDao;
using Microsoft.AspNetCore.Mvc;

namespace MVCWebApp.Controllers
{
    public class MemberController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Members Page!";

            MemberDao.MemberDao dao = new MemberDao.MemberDao();
            var members = dao.GetMembers();
            dao.Close();

            ViewBag.Members = members;

            return View();
        }
    }
}
