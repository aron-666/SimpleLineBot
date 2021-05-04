using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleLineBot.ViewModels
{
    public class Bot
    {
        public int Id { get; set; }
        public int UId { get; set; }
        public string Name { get; set; }
        public string ChannelSecret { get; set; }
        public string ChannelAccessToken { get; set; }
        public string UrlToken { get; set; }
        public bool? Enable { get; set; }
        public bool IsBan { get; set; }
        public string Remarks { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }


    }
}
