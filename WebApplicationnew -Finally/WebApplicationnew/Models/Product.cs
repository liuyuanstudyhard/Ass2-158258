using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;

namespace WebApplicationnew.Models
{
    public class Product
    {
        [Key]
        public int ID { get; set; }

        
        public string Name { get; set; }

        
        
        public decimal Price { get; set; }

       

        public string Description { get; set; }
        public string ImageUrl { get; set; }

        public int? CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }


}