using System;
using System.Collections.Generic;

#nullable disable

namespace SimpleLineBot.Models.DB
{
    public partial class Bot : ITimeLogger
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

        public virtual User UIdNavigation { get; set; }
    }
}
