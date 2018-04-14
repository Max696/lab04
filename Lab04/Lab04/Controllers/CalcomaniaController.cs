using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab04.DBContext;
using Lab04.Models;
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Net;


namespace Lab04.Controllers
{
    public class CalcomaniaController : Controller
    {
        DefaultConnection db =  DefaultConnection.getInstance;        
        // GET: Calcomania
        public ActionResult Index()
        {
            return View();
        }

        // GET: Calcomania/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Calcomania/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Calcomania/Create
        [HttpPost]
        public ActionResult Create(HttpPostedFileBase file)
        {
            try
            {
                if(file.FileName.EndsWith(".json"))
                {
                    string name = Path.GetFileName(file.FileName);
                    string path = Path.Combine(Server.MapPath("~/Content/Json" + name));
                    if(!System.IO.File.Exists(path))
                    {
                        
                        file.SaveAs(path);
                        string data = System.IO.File.ReadAllText(path);
                        char[] separators = { '{', '}' };
                        string[] json;
                        json = data.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                        for (int i = 1; i < json.Length; i++)
                        {
                            string a =  "{" + json[i] + "}";
                            json[i] = a;
                            i++;
                        }
                        for (int j = 1; j < json.Length; j++)
                        {
                            db.Album.Add(json[j - 1], JsonConvert.DeserializeObject<Album>(json[j]));
                        }
                       
                    }
                }
                else
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                
                return  RedirectToAction("Index");
            }
               
            
            
            catch
            {
                return View();
            }
        }

        // GET: Calcomania/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Calcomania/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Calcomania/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Calcomania/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
