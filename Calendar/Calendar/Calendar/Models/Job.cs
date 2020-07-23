using System;
using SQLite;

namespace Calendar.Models
{
    public class Job
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime DateDeadline { get; set; }
        public TimeSpan TaskDuration { get; set; }
        public string Priority { get; set; }

    }
}
