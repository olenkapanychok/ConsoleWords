﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace words.Models
{
    internal class Topic
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
       
        public Topic(Guid id, string title)
        {
            Id = id;
            Title = title;
            
        }
    }
}
