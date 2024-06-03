using Core2.Models;
using Core2.StoredProcedures;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Core2.Controllers
{
    public class UserController : Controller
    {
        private readonly ExamContext _db;
        private readonly UserStoredProcedures _userProcedures;
        public UserController(ExamContext context)
        {
            _db = context;
            _userProcedures = new UserStoredProcedures(context);
        }
        public async Task<ActionResult> Index()
        {
            List<User> users = await _userProcedures.GetAllUsers();
            return View(users);
        }

        public ActionResult Details(int id)
        {
            User user = _userProcedures.GetUserById(id);


            if (user == null)
            {
                return NotFound(new { message = "User not found!" });
            }
            return PartialView("_UserDetails", user);
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Edit(int id)
        {
            User user = _userProcedures.GetUserById(id);

            if (user == null)
            {
                return NotFound(new { message = "User not found!" });
            }

            return View(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(User user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    user.Type = "Customer";
                    user.CreatedOn = DateTime.Now;
                    user.UpdatedOn = DateTime.Now;
                    user.CratedBy = null;
                    user.Isdeleted = 0;

                    _db.Add(user);
                    _db.SaveChanges();
                }
                else
                {
                    return View(user);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(user);
            }
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, User user)
        {
            User existingUser = _userProcedures.GetUserById(id);
            try
            {

                if (existingUser == null)
                {
                    return NotFound(new { message = "User not found!" });
                }

                if (ModelState.IsValid)
                {
                    existingUser.Fullname = user.Fullname;
                    existingUser.Email = user.Email;
                    existingUser.BirthDate = user.BirthDate;
                    existingUser.ContactNo = user.ContactNo;
                    existingUser.UpdatedOn = DateTime.Now;

                    _db.SaveChanges();
                }
                else
                {
                    return View(existingUser);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(existingUser);
            }
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                User user = _userProcedures.GetUserById(id);

                if (user == null)
                {
                    return NotFound(new { message = "User not found!" });
                }

                user.Isdeleted = 1;
                _db.SaveChanges();

                return Json(new
                {
                    success = true
                });

            }
            catch (Exception ex)
            {
                return Json(new
                {
                    success = false,
                    message = ex.Message
                });
            }
        }
    }
}
