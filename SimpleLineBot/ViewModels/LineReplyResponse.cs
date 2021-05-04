using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleLineBot.ViewModels
{

    public class ResponseMessage
    {
        public string replyToken { get; set; }
        public MessageData[] messages { get; set; }
    }

    public class MessageData
    {
        public string type { get; set; }
        public string text { get; set; }
    }

    
}
