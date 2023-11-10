using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;

namespace WebApplicationnew.Models
{
    public class Category
    {

        [Key]
        public int ID { get; set; }
        
        [Display(Name="Category Name")]
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string D { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}