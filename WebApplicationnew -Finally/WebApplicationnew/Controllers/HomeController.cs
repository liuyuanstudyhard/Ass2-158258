using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationnew.Models;
using PagedList;
using PagedList.Mvc;

namespace WebApplicationnew.Controllers
{
    public class HomeController : Controller
    {
       
        public ActionResult Index()
        {
            var embroideries = GetEmbroideries();
            return View(embroideries);
        }


        public List<Index> GetEmbroideries()
        {
            var embroideries = new List<Index>();

            embroideries.Add(new Index
            {
                Title = "Mukden shepherding map",
                Author = "Qunxiu Li",
                Category = "Su embroidery",
                Description = "Suzhou embroidery is a general term for embroidery products in Jiangsu, known as the Oriental pearl for its beautiful patterns, exquisite skills and fine embroidery work.",
                ImageUrl ="/picture/m1.jpg"
            });

            embroideries.Add(new Index
            {
                Title = "The lion whistled and the lion blew",
                Author = "Zaihong Jiang",
                Category = "Xiang embroidery",
                Description = "Xiang embroidery is a general term for embroidery products centered in Changsha, Hunan Province. It won the best award and the first prize respectively at the Turin Expo and the Panama World Expo at the beginning of the last century, and is praised as a super embroidery in foreign countries.",

                ImageUrl = "/picture/m2.jpg"
            });

            embroideries.Add(new Index
            {
                Title = "Carp with egg white",
                Author = "Peijun Zhu",
                Category = "Shu embroidery",
                Description = "Shu embroidery is the general name of Sichuan embroidery products with Chengdu as the center. Shu embroidery uses soft satin and colored silk as the main raw materials and has more than 100 kinds of stitches, which has a strong local style.",
                ImageUrl = "/picture/m3.jpg"
            });

            embroideries.Add(new Index
            {
                Title = "First rays of the morning sun",
                Author = "Yuzhen Wu",
                Category = "Yue embroidery",
                Description = "Guangdong embroidery is a general term for embroidery products whose production centers are Chaozhou and Guangzhou in Guangdong Province. Yue embroidery reached its peak in the Qing Dynasty, and its products sold well in Europe, America and Asia.",
                ImageUrl = "/picture/m4.jpg"
            });


            return embroideries;
        }

       



        

            public ActionResult History()
            {
                var history = Gethistory();
                return View(history);
            }


            public List<History> Gethistory()
            {
                var history = new List<History>();

                history.Add(new History
                {
                    Period = "Warring States",
                    Peculiarity = "The origin of Chinese embroidery is very early, according to legend, Shun made Yu needling five-color embroidery, the Xia, Shang, Zhou three generations and the Qin and Han dynasties have been developed, from the early unearthed textiles, often visible embroidery products, early embroidery relics show: the Zhou Dynasty is still simple and rough, the Warring States gradually exquisite, embroidery in this period is used in braid embroidery, also known as braid embroidery, lock embroidery. This indicates that the embroidery process has developed to a quite mature stage at this time.",

                    ImageUrl = "/picture/Warning.jpg"
                });

            history.Add(new History
            {
                Period = "Han Dynasty",
                Peculiarity = "In the Han Dynasty, embroidery began to show the beauty of art. Because of the prosperity of the economy, the silk weaving industry is especially developed. And when the rise of the rich in society, the formation of a new consumer class, embroidery supply and demand should prosper, not only has become a widely used folk clothing, manual embroidery production has also moved toward specialization. Because of the maturity of the embroidery process, the Han Dynasty has virtually begun to distinguish the grade and type of people who use embroidery, although embroidery is created by the working people in the labor, but the vast majority of the working people can not afford to enjoy high-grade silk embroidery products, can only use simple embroidery process in life to embellish clothing, shoes and hats and other practical items.",
                ImageUrl = "/picture/Han.jpg"
            });
                history.Add(new History
                {
                    Period = "Tang Dynasty",
                    Peculiarity = "Embroidery was widely used in the Tang Dynasty, and there were new developments in stitching. Embroidery is generally used as a decoration of clothing, exquisite workmanship, colorful, reflected in the literature and poetry of the Tang Dynasty. In addition to being used as clothing items, embroidery in the Tang Dynasty was also used to embroider Buddhist sutras and Buddha images for religious service. In addition to the traditional braid embroidery since the Warring States period, the needlework of the Tang Dynasty also adopted a variety of needlework methods such as flat embroidery, dot embroidery and pleat embroidery.",
                    ImageUrl = "/picture/Tang.png"
                });

                history.Add(new History
                {
                    Period = "Song Dynasty",
                    Peculiarity = "Although the ornamental production of embroidery in the Yuan Dynasty is far less than that in the Song Dynasty, it also inherited the realistic embroidery style of the Song Dynasty. The Yuan people who entered the Central Plains set up embroidery bureaus and Luo bureaus all over the country, and the aesthetic and function of embroidery became more and more artistic. The emergence of Buddhist themes began in Sui and Tang Dynasties, and the main patterns were treasure flowers. Song embroidery is unique in celebrity calligraphy and painting, occasionally embroidering Buddha. In order to deny the first position of Confucianism, Kublai Khan promoted Tibetan Buddhism, and the wind of worship was revived in the Central Plains.",
                    ImageUrl = "/picture/Song.jpg"
                });
            history.Add(new History
            {
                Period = "Yuan Dynasty",
                Peculiarity = "Although the ornamental production of embroidery in the Yuan Dynasty is far less than that in the Song Dynasty, it also inherited the realistic embroidery style of the Song Dynasty. The Yuan people who entered the Central Plains set up embroidery bureaus all over the country, and the aesthetic and function of embroidery became more and more artistic. The emergence of Buddhist themes began in Sui and Tang Dynasties, and the main patterns were treasure flowers. In order to deny the first position of Confucianism, Kublai Khan promoted Tibetan Buddhism, and the wind of worship was revived in the Central Plains.",
                ImageUrl = "/picture/yuan.png"
            });

            history.Add(new History
            {
                Period = "Ming Dynasty",
                Peculiarity = "The Ming Dynasty was a time when Chinese handicraft industry was extremely developed, inheriting the fine foundation of embroidery in the Song Dynasty and developing to a higher level. The embroidery craft of Ming Dynasty shows several characteristics: First, in the use, it is widely used in all strata of civil society. The second is in the embroidery art, generally for practical embroidery, and the Song Dynasty tends to be very complicated and gorgeous. Artistic embroidery, inheriting the excellent tradition of Song embroidery, can bring new inventions. The third is derived from other embroidery categories, embroidery originally only with silk as the material, the Ming Dynasty began to try to use other materials, greatly expanding the scope of embroidery art.",
                ImageUrl = "/picture/Ming.jpg"
            });

            history.Add(new History
            {
                Period = "Qing Dynasty",
                Peculiarity = "In the junior middle school period of Qing Dynasty, the country was prosperous, the life of people was stable, embroidery technology was further developed and improved, embroidery image changed greatly, full of high sense of reality and decorative effect. And because of its use of gold needle and cushion embroidery in harmonious colors, the embroidery pattern has a wide range of themes and vivid shapes. Embroidery in the Qing Dynasty has two outstanding achievements: First, local embroidery schools have sprung up, famous in addition to the four famous embroidery Su embroidery, Yue embroidery, Shu embroidery, Hunan embroidery, as well as Beijing embroidery, Lu embroidery, etc., each unique, forming a competitive situation. Secondly, the late Qing Dynasty absorbed the strengths of Japanese painting and even incorporated the views of Western painting into embroidery.",
                ImageUrl = "/picture/Qing.jpg"
            });

            
            return history;
            }
        

        public ActionResult Contact()
        {
          

            return View();
        }

        public ActionResult Appreciate()
        {


            return View();
        }
         
       

        public List<Masterwork> Getmaster()
        {
            var master = new List<Masterwork>();


            master.Add(new Masterwork
            {
                Title = "Yao Niang Dance Lotus Diagram",
                time = 1895,
                Author = "Ling Shu",
                Category = " Su Embroidery",
                ImageUrl = "/picture/YaoNiangDanceLotusDiagram.jpg",
                DescriptionZ = "The work is faithful to the original on the basis of a variety of techniques to embroider, give the original a new artistic sense, character streamers with horse hair embroidery, texture such as thin gauze folded, with a three-dimensional sense, beautiful opening, outside the main scene of the multi-purpose white painting, set off the theme of the characters, silk, beautiful, delicate, smooth needle, color harmony."
            });
            master.Add(new Masterwork
            {
                Title = "Autumn Scenery",
                time = 1893,
                Author = "Hua Qi",
                Category = "Su Embroidery",
                ImageUrl = "/picture/AutumnScenery.jpg",
                DescriptionZ = "Through the use of different embroidery techniques such as flat embroidery, vertical embroidery and tracing embroidery, the writer skillfully uses needles and threads to make the lines of the works smooth and delicate, showing the reality of the characters and scenes. Whether it is the facial expressions of the characters, the details of the clothes, or the buildings and flowers in the background, they can show a real and unique beauty through delicate embroidery."
            });
            master.Add(new Masterwork
            {
                Title = "The Story of the Western Chamber",
                time = 1954,
                Author = "Jin Jingfen",
                Category = "Su Embroidery",

                ImageUrl = "/picture/TheStoryoftheWesternChamberrnAuthorJinJingfen.jpg",
                DescriptionZ = "The embroider of this work is simple, the color is monotonous, only two kinds of needling and oblique needling, but the author uses the characteristics of a set of needling sets a set of a set of purple, dark gray, light gray, brown, black and other colors cleverly integrated into the silk of embroidery thread, like the Qing Dynasty painter Hua Yan and Gong Belt wrote \"small free hand\" flowers and birds. The spots and tails embroidered on the body of the double chicken, that is, the combination of dry and wet ink techniques, like the use of dry and wet brush, this embroidery method not only describes the details, but also does not lose the simplicity of the pen and ink, is Huayan to capture the natural interest in nature to create a vivid and colorful image model, outline, bone, color, ink and ink."
            });
            master.Add(new Masterwork
            {
                Title = "Wisteria Double Chicken",
                time = 1876,
                Author = "Xue Wenhua",
                Category = "Su Embroidery",
                ImageUrl = "/picture/WisteriaDoubleChicken.jpg",

                DescriptionZ = " The writer is influenced by traditional Chinese culture and has contact with Western art. Therefore, most of her works use Western gouache and oil painting as manuscripts. She boldly breaks the habit of using traditional Chinese painting manuscripts for embroidery, and dares to use the realistic style of Western painting to embroider freely, with flexible lines and multi-color threads to enrich the brightness and shade of colors and the expression of light. The thickness of the silk is also original, rough with careful, extremely free and unrestrained."
            });
            master.Add(new Masterwork
            {
                Title = "Mandarin duck in the lotus pond",
                time = 1865,
                Author = "Li Yihui",
                Category = "Xiang Embroidery",
                ImageUrl = "/picture/Mandarinduckinthelotuspond.jpg",
                DescriptionZ = "This work is a scene of mandarin ducks in the lotus pond, with lotus leaves, flowers, lotus roots and other elements as the background decoration, it symbolizes the couple's love, unity and happiness, with a strong meaning of love and marriage. The work uses silk thread and embroidered cloth, adopts the techniques of flat embroidery and vertical embroidery, and the embroidery work is exquisite. Mandarin ducks are happy \", \"Mandarin ducks play lotus\" and so on, are Hunan women yearning for eternal love complex reappearance."
            });
            master.Add(new Masterwork
            {
                Title = "Crown on crown",
                time = 2014,
                Author = "Hao Shuping",
                Category = "Shu embroidery",
                ImageUrl = "/picture/Crownoncrown.jpg",
                DescriptionZ = "This work is an excellent traditional work of Shu embroidery, Rooster and cockscomb, also known as \"the official on the official, which is a typical embodiment of traditional Chinese culture.\" The structure of the work is concise, the theme is prominent, the rooster feathers are tight and soft, flexible and lifelike, the color is thick and concise, and the cockscomb complement each other. The works are designed by Chinese first-class art master Zhang Shirong, using Chinese meticulous painting as the embroidery blueprint, the drawing is smooth and concise, and the works are more than less, bright colors, elegant and natural transition. The rooster and cockscomb in the pattern echo each other and match appropriately."
            });

            master.Add(new Masterwork
            {
                Title = "Lotus Carp",
                time = 1981,
                Author = "Meng Dezhi",
                Category = "Shu embroidery",

                ImageUrl = "/picture/LotusCarp.jpg",
                DescriptionZ = "The work is elegant and bright, with proper thickness of silk, neat stitching, meticulous, hierarchical, virtual and solid arrangement, vivid coordination. The swimming carp's eyes are wide open, mouth slightly open, body shape is flat, the back is higher and thicker than the common carp, and the body scales are tight, with the adducted abdominal muscles, giving people a kind of vitality. The embroidered face is interspersed with hibiscus, and the fresh and natural style makes people feel like being in the moonlight of a lotus pond. The color of the work is soft, the stitching is dense and uniform, and the texture is strong."
            });
            master.Add(new Masterwork
            {
                Title = "Lion",
                time = 1971,
                Author = "Liu Aiyun",
                Category = "Shu embroidery",
                ImageUrl = "/picture/Lion.jpg",
                DescriptionZ = "Liu Aiyun uses Xiang embroidery's unique fluffy pin work to make lions fluffy. The softness of the lion's fur embroidered with a wool needle. In order to show the texture of Hunan embroidery better than paper painting, when embroidering lion's eyes, a variety of very fine color lines were used, and the color lines were tightly rotated by swimming needles to show the luster of lion's eyes."
            });

            master.Add(new Masterwork
            {
                Title = "Crane Deer Tongchun",
                time = 1783,
                Author = "Wu Caixia",
                Category = "Yue embroidery",
                ImageUrl = "/picture/CraneDeerTongchun.jpg",
                DescriptionZ = "The author copied the style of the original painting, with a very delicate trocar needle, hair needle needle in accordance with the deer in the dynamic muscle, fur lines, cleverly use the unique luster of the silk to reflect its three-dimensional sense, the deer fur is very real, its dynamic and vivid. The other birds, such as crane and chicken feathers, are depicted with hair needles, trocar needles, tear needles, nail needles, and scale-carving needles. The stones, trees, flowers and plants are embroidered with a variety of needles, such as sprinkling needles, windmill needles, trocar needles, levelling needles, twisting needles, etc., and the levels of the near and far and the light and shade of the light are shown realistically."
            });
            master.Add(new Masterwork
            {
                Title = "Grape Squirrel Diagram",
                time = 1635,
                Author = "Han Ximeng",
                Category = "Yue embroidery",
                ImageUrl = "/picture/GrapeSquirrelDiagram.jpg",
                DescriptionZ = "The work is embroidered in white twill. A grapevine curled up, and a squirrel leaped over it, as if to grab the ripe fruit. This is a fleeting frame of autumn nature, the author keenly captured this moment, it is frozen in the picture. On the painting, the squirrel climbs on the grapevine, and the lively and nimble body posture and the piercing eyes depict the squirrel's alert and salivating expression vividly, and it is interesting."


            });
            master.Add(new Masterwork
            {
                Title = "Statue of Jesus",
                time = 1915,
                Author = "Shen Shou",
                Category = "Su Embroidery",
                ImageUrl = "/picture/StatueofJesus.jpg",
                DescriptionZ = "This exhibit is based on the oil painting Jesus portrait by the late Renaissance Italian painter, and creatively uses new stitches such as virtual and solid needles and rotary needles. According to the needs of the silk skin of the characters and the changes in the light and dark levels of the oil painting, it carefully chooses more than 100 different colors of silk dyed by itself to embroider and weave this \"Jesus Portrait\" vividly and lifelike. One thread of each of the more than 100 different colors used in this embroidery was embroidered into a cross on the top of the embroidery image for the audience to examine to prove that none of the parts of the embroidery image were dyed after embroidery."

            });

            return master;
        }



        public ActionResult Masterwork(string categoryFilter, string search, string sortOrder, int? page)
        {
            IEnumerable<Masterwork> masterworks = Getmaster();

            if (!string.IsNullOrEmpty(categoryFilter) && categoryFilter != "All")
            {
                masterworks = masterworks.Where(m => m.Category.Equals(categoryFilter));
            }

            if (!string.IsNullOrEmpty(search))
            {
                masterworks = masterworks.Where(m => m.Title.Contains(search));
            }

            switch (sortOrder)
            {
                case "TimeAsc":
                    masterworks = masterworks.OrderBy(m => m.time);
                    break;
                case "TimeDesc":
                    masterworks = masterworks.OrderByDescending(m => m.time);
                    break;
                default:
                    break;
            }

            int pageSize = 5;
            int pageNumber = (page ?? 1);

            return View(masterworks.ToPagedList(pageNumber, pageSize));
        }









    }

}