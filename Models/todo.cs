using System;

namespace todo.Models
{
    public class Todo
    {
        public int id {get; set;}
        public string task{get; set;}

        private bool _boolVal= false;
        public bool completed
        {get;
        set
            {
                _boolVal = value;
            }}
        
        private DateTimeOffset now = (DateTimeOffset)DateTime.UtcNow; 
        public string date_added
        {
            get;
            set
                {
                    now = value;
                }
        }

        public string date_completed{get;set;}
    }
}