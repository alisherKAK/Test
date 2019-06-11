using System;
using TaskManager.AbstractModels;

namespace TaskManager.Models
{
    public class Task : Entity
    {
        public virtual TaskType TaskType { get; set; }
        public virtual Period Period { get; set; }
        public DateTime Start { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public bool IsDone { get; set; }
    }
}
