using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SimpleLineBot.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StatusController : ControllerBase
    {
        private readonly Services.LineBotLEDService _lineBotLEDService;


        public StatusController(Services.LineBotLEDService lineBotLEDService)
        {
            _lineBotLEDService = lineBotLEDService;
        }
        public ViewModels.Status GetStatus([FromQuery] string token)
        {
            var bot = _lineBotLEDService.GetBotFromToken(token);
            bool status = _lineBotLEDService.GetStatus(bot.Id);

            return new ViewModels.Status() { status = status };
        }

        
    }
}
