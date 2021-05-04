using System;

namespace SimpleLineBot.Models.DB
{
    public interface ITimeLogger
    {
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }
    }
}