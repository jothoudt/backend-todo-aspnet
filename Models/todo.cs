using System;
using Microsoft.EntityFrameworkCore;

namespace todo.Models
{
    [Index(nameof(id), IsUnique=true)]
    public class TodoItem
    {
        public int id {get; set;}
        public string task{get; set;}

        public bool completed{get;set;}=false;
        
         public string date_added 
            {get{
                return this.dateCreated.ToString("MM/dd/yyyy");
            }
            set{
                this.dateCreated.ToString("MM/dd/yyyy");
            }
            }

        private DateTime dateCreated = DateTime.Now;
        public string date_completed{get;set;}
    }
}