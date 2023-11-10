namespace WebApplicationnew.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Diagnostics;
    using System.Linq;
    using System.Xml.Linq;
    using WebApplicationnew.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplicationnew.Data.WebApplicationnewContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebApplicationnew.Data.WebApplicationnewContext context)
        {
            var categories = new List<Category>
 {
new Category {Name = "Su Embroidery" ,ImageUrl="/picture/SU.jpg",D="Su embroidery is famous for its fine and elegant, landscape can distinguish the interest of distance, The pavilion has a deep body, Characters can look forward to vivid feelings, Flowers and birds can show intimacy. Su embroidery is renowned worldwide for its lifelike artistic effects in its imitation painting embroidery and photo embroidery."},
new Category {Name = "Xiang Embroidery",ImageUrl="/picture/XIANG.jpg",D="Xiang embroidery is based on Chinese painting, with vivid forms and bold styles. The embroidered content is mostly landscape, figures, animals, etc., of which the liger theme is particularly exquisite. It has the reputation of embroidering peanuts, embroidering birds can hear, embroidering tigers can run, embroidering people can convey the spirit." },
new Category {Name = "Yue Embroidery" ,ImageUrl="/picture/YUE.jpg", D ="The theme of Cantonese embroidery is mostly the patterns of hundreds of birds in the sun, dragon and phoenix, etc., integrating auspicious meanings. Its biggest feature is that the composition is full and magnificent, often with few gaps, even if there is, but also with landscape grass and other supplements, it is lively and compact."},
new Category {Name = "Shu Embroidery" ,ImageUrl="/picture/SHU.jpg", D = "With soft satin and colored silk as the main raw materials, Shu embroidery has more than 100 kinds of stitches. It is rigorous and delicate, bright and smooth, with clear composition, thick and round, and bright colors. Give full play to the specialty of hand embroidery, with a strong local style."},
 };
            categories.ForEach(c => context.Categories.AddOrUpdate(p => p.Name, c));
            context.SaveChanges();

            var products = new List<Product>
 {
new Product {Name = "Bamboo and Butterfly", Description = "Circular Fan", Price =390, ImageUrl="/picture/Su1.jpg",CategoryID= categories.Single(c=>c.Name == "Su Embroidery").ID},
new Product {Name = "Rich and Prosperous Flower", Description = "Circular Fan",Price = 387, ImageUrl="/picture/Su2.jpg",CategoryID= categories.Single(c=>c.Name == "Su Embroidery").ID},
new Product {Name = "The Flowers Are in Full Bloom", Description = "Circular Fan", Price =400,ImageUrl="/picture/Su3.jpg", CategoryID= categories.Single(c=>c.Name == "Su Embroidery").ID},
new Product {Name = "Flower and Butterfly", Description = "Bookmark",Price = 100, ImageUrl="/picture/Su4.jpg",CategoryID= categories.Single(c=>c.Name == "Su Embroidery").ID},
new Product {Name = "Artware", Description = "Artware", Price =100,ImageUrl="/picture/Su6.jpg", CategoryID= categories.Single(c=>c.Name == "Su Embroidery").ID},
new Product {Name = "Happy Occasion", Description = "Casket",Price = 800, ImageUrl="/picture/Su5.jpg",CategoryID= categories.Single(c=>c.Name == "Su Embroidery").ID},

new Product {Name = "Pond Mandarin Duck", Description = "Decorative Painting", Price = 2500, ImageUrl="/picture/X1.jpg",CategoryID= categories.Single(c=>c.Name == "Xiang Embroidery").ID},
new Product {Name = "Flower and Bird", Description = "Circular Fan", Price = 400, ImageUrl="/picture/X2.jpg",CategoryID= categories.Single(c=>c.Name == "Xiang Embroidery").ID},
new Product {Name = "Double Happiness Comes to the Door", Description = "Tea Caddy", Price = 1300, ImageUrl="/picture/X3.jpg",CategoryID= categories.Single(c=>c.Name == "Xiang Embroidery").ID},
new Product {Name = "Thrush", Description = "Furniture for Display", Price = 300, ImageUrl="/picture/X4.jpg",CategoryID= categories.Single(c=>c.Name == "Xiang Embroidery").ID},
new Product {Name = "The King of Beasts", Description = "Furniture for Display", Price = 2550, ImageUrl="/picture/X5.jpg",CategoryID= categories.Single(c=>c.Name == "Xiang Embroidery").ID},
new Product {Name = "Great Fortune", Description = "Watch Winder", Price = 2000,ImageUrl="/picture/X6.jpg", CategoryID= categories.Single(c=>c.Name == "Xiang Embroidery").ID},

new Product {Name = "Peacock", Description = "Circular Fan", Price = 233,ImageUrl="/picture/Y1.jpg", CategoryID= categories.Single(c=>c.Name == "Yue Embroidery").ID},
new Product {Name = "Quiet Blue", Description = "Artware", Price = 7800,ImageUrl="/picture/Y2.jpg", CategoryID= categories.Single(c=>c.Name == "Yue Embroidery").ID},
new Product {Name = "Spirit Crane", Description = "Artware", Price = 8000, ImageUrl="/picture/Y3.jpg",CategoryID= categories.Single(c=>c.Name == "Yue Embroidery").ID},
new Product {Name = "The Deer", Description = "Bamboo-woven Bag", Price = 1573,ImageUrl="/picture/Y4.jpg", CategoryID= categories.Single(c=>c.Name == "Yue Embroidery").ID},
new Product {Name = "Rooster", Description = "Bamboo-woven Bag", Price = 1550, ImageUrl="/picture/Y5.jpg",CategoryID= categories.Single(c=>c.Name == "Yue Embroidery").ID},
new Product {Name = "Butterfly", Description = "Brooch", Price = 400,ImageUrl="/picture/Y6.jpg", CategoryID= categories.Single(c=>c.Name == "Yue Embroidery").ID},


 new Product {Name = "Panda Climbing Rock", Description = "Furniture for Display", Price = 2226,ImageUrl="/picture/S1.jpg", CategoryID= categories.Single(c=>c.Name == "Shu Embroidery").ID},
 new Product {Name = "Lotus", Description = "Silk Scarf", Price = 1000,ImageUrl="/picture/S2.jpg", CategoryID= categories.Single(c=>c.Name == "Shu Embroidery").ID},
 new Product {Name = "Summer Pond", Description = "Furniture for Display", Price = 790, ImageUrl="/picture/S3.jpg",CategoryID= categories.Single(c=>c.Name == "Shu Embroidery").ID},
 new Product {Name = "Naughty Panda", Description = "Furniture for Display", Price = 1450,ImageUrl="/picture/S4.jpg", CategoryID= categories.Single(c=>c.Name == "Shu Embroidery").ID},
 new Product {Name = "Playmate", Description = "Circular Fan", Price = 600, ImageUrl="/picture/S5.jpg",CategoryID= categories.Single(c=>c.Name == "Shu Embroidery").ID},
 new Product {Name = "Shawl", Description = "Shawl", Price = 950,ImageUrl="/picture/S6.jpg", CategoryID= categories.Single(c=>c.Name == "Shu Embroidery").ID},
            };
            products.ForEach(c => context.Products.AddOrUpdate(p => p.Name, c));
            context.SaveChanges();
        }
    }
}
