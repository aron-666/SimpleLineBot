using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLineBot.Controllers
{
    [Authorize]
    public class BotsController : Controller
    {

        private readonly Models.DB.linebotContext _linebotContext;
        private readonly Data.ApplicationDbContext _applicationDbContext;
        public BotsController(Models.DB.linebotContext linebotContext, Data.ApplicationDbContext applicationDbContext)
        {
            _linebotContext = linebotContext;
            _applicationDbContext = applicationDbContext;
        }

        

        public IActionResult Index()
        {
            
            return RedirectToAction(nameof(List));
        }

        public IActionResult List()
        {
            var user = GetOrCreateUser(User.Identity.Name);

            var data = _linebotContext.Bots.Where(x => x.UId == user.Id).OrderBy(x => x.Id).ToList();

            
            ViewBag.RootPath = $"{this.Request.Scheme}://{this.Request.Host}{this.Request.PathBase}" + "/api/LineMessage?token=";
            return View(data);
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(Models.DB.Bot bot)
        {
            var user = GetOrCreateUser(User.Identity.Name);
            bot.UrlToken = GetRandomString4(24);
            bot.UId = user.Id;
            _linebotContext.Bots.Add(bot);
            _linebotContext.SaveChanges();
            return RedirectToAction(nameof(List));
        }

        public IActionResult Edit([FromRoute] int id)
        {
            var user = GetOrCreateUser(User.Identity.Name);

            var bot = _linebotContext.Bots.Where(x => x.Id == id && x.UId == user.Id).FirstOrDefault();

            if(bot is null)
                return RedirectToAction(nameof(List));
            else
                return View(bot);
        }

        [HttpPost]
        public IActionResult Edit(Models.DB.Bot bot)
        {
            var user = GetOrCreateUser(User.Identity.Name);

            var bot2 = _linebotContext.Bots.Where(x => x.Id == bot.Id && x.UId == user.Id).FirstOrDefault();

            if(bot2 is null)
                return RedirectToAction(nameof(List));
            else
            {
                bot2.Name = bot.Name ?? "";
                bot2.ChannelAccessToken = bot.ChannelAccessToken ?? "";
                bot2.ChannelSecret = bot.ChannelSecret ?? "";
                bot2.Remarks = bot.Remarks;
                _linebotContext.SaveChanges();

                return RedirectToAction(nameof(List));
            }
        }

        public IActionResult Delete([FromRoute] int id)
        {
            var user = GetOrCreateUser(User.Identity.Name);

            var bot = _linebotContext.Bots.Where(x => x.Id == id && x.UId == user.Id).FirstOrDefault();

            if(bot is not null)
            {
                _linebotContext.Remove(bot);
                _linebotContext.SaveChanges();
            }

            return RedirectToAction(nameof(List));
            
        }

        public IActionResult ChangeStatus([FromRoute] int id)
        {
            var user = GetOrCreateUser(User.Identity.Name);

            var bot = _linebotContext.Bots.Where(x => x.Id == id && x.UId == user.Id).FirstOrDefault();

            if (bot is not null)
            {
                bot.Enable = !bot.Enable;
                _linebotContext.SaveChanges();
            }

            return RedirectToAction(nameof(List));

        }

        private Models.DB.User GetOrCreateUser(string email)
        {
            var user = _linebotContext.Users.Where(x => x.Email == User.Identity.Name).FirstOrDefault();

            if (user == null)
            {
                user = new Models.DB.User()
                {
                    GId = 1,
                    Email = User.Identity.Name,
                };
                _linebotContext.Users.Add(user);
                _linebotContext.SaveChanges();
            }

            return user;
        }

        public static string GetRandomString4(int length)
        {
            var str = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            var next = new Random();
            var builder = new StringBuilder();
            for (var i = 0; i < length; i++)
            {
                builder.Append(str[next.Next(0, str.Length)]);
            }
            return builder.ToString();
        }
    }
}
