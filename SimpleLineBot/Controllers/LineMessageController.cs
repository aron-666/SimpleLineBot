using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace SimpleLineBot.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LineMessageController : ControllerBase
    {
        private readonly Services.LineBotLEDService _lineBotLEDService;
        

        public LineMessageController(Services.LineBotLEDService lineBotLEDService)
        {
            _lineBotLEDService = lineBotLEDService;
        }

        [HttpPost]
        public IActionResult LineBotMessage(ViewModels.ReplyMessage msg, [FromQuery] string token)
        {
            //int len = int.Parse(Request.Headers["Content-Length"].First());
            //using var stream = Request.BodyReader.AsStream();

            //byte[] data = new byte[len];
            //stream.Read(data, 0, len);

            //string s = System.Text.Encoding.UTF8.GetString(data);
            var bot = _lineBotLEDService.GetBotFromToken(token);
            if (bot is null)
                return Ok();
            //ViewModels.ReplyMessage msg = JsonConvert.DeserializeObject<ViewModels.ReplyMessage>(s);
            
            
            //只回應文字訊息
            if (msg.events[0].message.type == "text")
            {
                string resp = "";
                try
                {
                    switch (msg.events[0].message.text)
                    {
                        case "開燈":
                            _lineBotLEDService.SetStatus(bot.Id, true);
                            resp = "已經開啟你的LED燈";
                        break;
                        case "關燈":
                            _lineBotLEDService.SetStatus(bot.Id, false);
                            resp = "已經關閉你的LED燈";
                            break;
                        case "狀態":
                            resp = "你的LED燈狀態是" + (_lineBotLEDService.GetStatus(bot.Id) ? "開" : "關");
                            break;
                        default:
                            resp = "你好";
                            break;
                    }
                }
                catch(Exception ex)
                {
                    resp = ex.Message;
                }
                

                WebClient client = new WebClient();
                ViewModels.ResponseMessage message = new ViewModels.ResponseMessage();
                message.replyToken = msg.events[0].replyToken;
                message.messages = new ViewModels.MessageData[1];
                ViewModels.MessageData m = new ViewModels.MessageData();
                m.type = "text";
                m.text = resp;
                message.messages[0] = m;
                client.Headers.Add("Authorization", "Bearer " + bot.ChannelAccessToken);
                client.Headers.Add("Content-Type", "application/json");

                client.UploadString("https://api.line.me/v2/bot/message/reply", "POST", JsonConvert.SerializeObject(message));
            }
            return Ok();
        }


    }
}
