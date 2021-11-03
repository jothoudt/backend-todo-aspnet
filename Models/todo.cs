using System;

namespace todo.Models
{
    public class Task
    {
        public int id {get; set;}
        public string task{get; set;}

        private bool _boolVal= false;
        public bool completed
        {get
            {
                return completed; 
            } 
        set
            {
                _boolVal = value;
            }}
        
        private DateTimeOffset now = (DateTimeOffset)DateTime.UtcNow; 
        public DateTime date_added
        {
            get
                {
                    return date_added;
                }
            set
                {
                    now = value;
                }
        }

        public string date_completed{get;set;}
    }
}