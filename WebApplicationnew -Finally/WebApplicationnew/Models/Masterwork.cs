using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationnew.Models
{
    public class Masterwork
    {
        public int Id { get; set; }
        public int time { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public string Category { get; set; }

        
        public string DescriptionZ { get; set; }

        public string ImageUrl { get; set; }
    }
}