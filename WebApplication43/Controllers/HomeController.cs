using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace WebApplication43.Controllers
{
    public class HomeController : Controller
    {
        
        public string EmpList1()
        {
            string result = "";
            
            string filePath = AppDomain.CurrentDomain.BaseDirectory + "/MyData/EmpList.txt";
            StreamReader streamReader = new StreamReader(filePath);
            string Rec = "";

            Rec = streamReader.ReadLine();
            while (Rec != null)
            {
                result += Rec;
                Rec = streamReader.ReadLine();
            }

            return result;
        }

        public ActionResult EmpList2()
        {
            List<Models.Employee> result = new List<Models.Employee>();

            string filePath = AppDomain.CurrentDomain.BaseDirectory + "/MyData/EmpList.txt";
            StreamReader streamReader = new StreamReader(filePath);
            string Rec = "";

            Rec = streamReader.ReadLine();
            while (Rec != null)
            {
                result.Add(new Models.Employee(Rec));
                Rec = streamReader.ReadLine();
            }


            return View(result);
        }

        public ActionResult EmpList3(string orderBy)
        {
            List<Models.Employee> result = new List<Models.Employee>();

            string filePath = AppDomain.CurrentDomain.BaseDirectory + "/MyData/EmpList.txt";
            StreamReader streamReader = new StreamReader(filePath);
            string Rec = "";

            Rec = streamReader.ReadLine();
            while (Rec != null)
            {
                result.Add(new Models.Employee(Rec));
                Rec = streamReader.ReadLine();
            }

            switch (orderBy)
            {
                case "nameasc":
                    return View(result.OrderBy(x=> x.Name).ToList());
                case "namedesc":
                    return View(result.OrderByDescending(x => x.Name).ToList());
                case "emailasc":
                    return View(result.OrderBy(x => x.EMail).ToList());
                case "emaildesc":
                    return View(result.OrderByDescending(x => x.EMail).ToList());
                default:
                    return View(result);
            }



        }
    }
}