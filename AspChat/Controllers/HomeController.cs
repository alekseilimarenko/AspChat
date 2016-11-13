using System;
using System.Linq;
using System.Web.Mvc;
using AspChat.Models;

namespace AspChat.Controllers
{
    public class HomeController : Controller
    {
        private readonly ChatContext _db = new ChatContext();

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(User userFromWeb)
        {
            if (!ModelState.IsValid) return View(userFromWeb);
            
            var userFromDb = new User
            {
                Id = userFromWeb.Id,
                UserLogin = userFromWeb.UserLogin,
                UserPass = userFromWeb.UserPass
            };

            Utils.UtilsUser.UpdateUserByModelFromWeb(_db, ref userFromDb);

            return RedirectToAction("Chat", "Home", userFromWeb);
        }

        [HttpGet]
        public ActionResult Chat(User user)
        {
            SetViewBagValues(user.UserLogin);

            return View();
        }

        [HttpPost]
        public ActionResult Chat(Message messFromWeb)
        {
            if(messFromWeb.ChatMessage != null)
            {
                var msgFromDb = new Message
                {
                    Id = Guid.NewGuid(),
                    Sender = messFromWeb.Sender,
                    ChatMessage = messFromWeb.ChatMessage,
                    Date = DateTime.Now
                };

                Utils.UtilsUser.UpdateMsgFromWeb(_db, ref msgFromDb);
            }

            ModelState.Clear();

            SetViewBagValues(messFromWeb.Sender);

            return View();
        }
         
        private void SetViewBagValues(string userLogin)
        {
            ViewBag.Sender = userLogin;
            ViewBag.Messages = _db.Messages.OrderBy(i => i.Date).ToList();
        }
    }
}