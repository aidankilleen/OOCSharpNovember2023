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

        public IActionResult Detail(int id)
        {
            ViewBag.Id = id;
            MemberDao.MemberDao dao = new MemberDao.MemberDao();
            var member = dao.GetMember(id);
            dao.Close();
            ViewBag.Member = member;
            return View();
        }

        public IActionResult ConfirmDelete(int id)
        {
            ViewBag.Message = $"Are you sure you want to delete {id}?";
            ViewBag.Id = id;
            return View();
        }

        public IActionResult Delete(int id)
        {
            MemberDao.MemberDao dao = new MemberDao.MemberDao();

            dao.DeleteMember(id);
            dao.Close();

            ViewBag.Message = $"Member { id } deleted successfully";
            //return View();

            return Redirect("/Member");
        }

        public IActionResult Add()
        {
            return View("MemberForm");
        }

        public IActionResult DoAdd(Member member)
        {

            MemberDao.MemberDao dao = new MemberDao.MemberDao();

            dao.AddMember(member);
            dao.Close();

            return Redirect("/Member");
        }
    }
}
