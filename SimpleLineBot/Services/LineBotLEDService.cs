using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleLineBot.Services
{
    public class LineBotLEDService
    {
        private readonly Models.DB.linebotContext _linebotContext;
        public LineBotLEDService(Models.DB.linebotContext linebotContext)
        {
            _linebotContext = linebotContext;
        }


        public void SetStatus(int bid, bool enable)
        {
            

            var bot = _linebotContext.Bots.Where(x => x.Id == bid).FirstOrDefault();

            if (bot is null)
                throw new ArgumentException("查無此bot");

            bot.Enable = enable;

            _linebotContext.SaveChanges();
        }

        public bool GetStatus(int bid)
        {
            

            var bot = _linebotContext.Bots.Where(x => x.Id == bid).FirstOrDefault();

            if (bot is null)
                throw new ArgumentException("查無此bot");

            return bot.Enable ?? false;
        }

        public Models.DB.Bot GetBotFromToken(string token)
        {
            var bot = _linebotContext.Bots.Where(x => x.UrlToken == token).FirstOrDefault();

            return bot;
        }
    }
}
