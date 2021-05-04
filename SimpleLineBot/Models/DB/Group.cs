using System;
using System.Collections.Generic;

#nullable disable

namespace SimpleLineBot.Models.DB
{
    public partial class Group : ITimeLogger
    {
        public Group()
        {
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Remarks { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
