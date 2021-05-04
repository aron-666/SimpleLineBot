using System;
using System.Collections.Generic;

#nullable disable

namespace SimpleLineBot.Models.DB
{
    public partial class User : ITimeLogger
    {
        public User()
        {
            Bots = new HashSet<Bot>();
        }

        public int Id { get; set; }
        public int GId { get; set; }
        public string Email { get; set; }
        public bool? Enable { get; set; }
        public string Remarks { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }

        public virtual Group GIdNavigation { get; set; }
        public virtual ICollection<Bot> Bots { get; set; }
    }
}
