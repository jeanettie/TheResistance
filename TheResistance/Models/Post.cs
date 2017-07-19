using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TheResistance.Models
{
    public class Post
    {
        public Post()
        {
            this.DateCreated = DateTime.Now;


        }

        public int ID { get; set; }
        public string Title { get; set; }
        
        public string Body { get; set; }
        
        public DateTime DateCreated { get; private set; }

       // public virtual File Files { get; set; }

    }

}