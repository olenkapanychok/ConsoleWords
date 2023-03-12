using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace words.Models
{
    internal class Question
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
       
        public Question(Guid id, string title)
        {
            Id = id;
            Title = title;
            
        }
    }
}
