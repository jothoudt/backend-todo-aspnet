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
        
         public DateTime date_added
            {
                get
                    {
                        return this.dateCreated.HasValue
                           ? this.dateCreated.Value
                            : DateTime.Now;
                    }

                set { this.dateCreated = value; }
            }

        private DateTime? dateCreated = null;
        public string date_completed{get;set;}
    }
}