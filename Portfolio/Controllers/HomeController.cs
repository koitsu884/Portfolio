using Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            IndexViewModel vm = new IndexViewModel()
            {
                Introduction = "I’m seeking a role within the IT industry where I can utilize the programming skills and I can gain further experience in challenging environment. I am especially looking for C# and ASP.NET developer position for my next carrier.\n"
                                + "I have work experience as a game programmer and a system analyst in Japan for 4 years, and a web developer in Auckland for 3 years.\n"
                                + "My core skills are C, C++, C# and PHP, which I took away from the work. I understand ASP.NET as well from self-study and from Industry Connect Internship project.",
                SkillSet = new List<KeyValuePair<string, int>>()
                {
                    new KeyValuePair<string, int>("C#", 70),
                    new KeyValuePair<string, int>("ASP.NET", 60),
                    new KeyValuePair<string, int>("HTML,CSS", 66),
                    new KeyValuePair<string, int>("SQL SERVER", 60),
                    new KeyValuePair<string, int>("PHP", 80),
                    new KeyValuePair<string, int>("MySQL", 80),
                    new KeyValuePair<string, int>("JavaScript, jQuery", 65),
                    new KeyValuePair<string, int>("KnockoutJS", 50),
                }
            };
            vm.Introduction.Replace("\n", "<br/>");
            return View(vm);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult CVDownload()
        {
            var cvPath = Server.MapPath("~/Content/CV_kazunori_hayashi_v1.docx");
            if (System.IO.File.Exists(cvPath))
            {
                return File(cvPath, "application/msword", "CV_Kazunori_Hayashi.docx");
            }
            return HttpNotFound("File does not exist.");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}