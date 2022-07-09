using Core_Blog.Areas.Admin.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Blog.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class WriterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult WriterList()
        {
            var jsonWriters = JsonConvert.SerializeObject(writerClasses);
            return Json(jsonWriters);
        }

        public IActionResult GetWriterByID(int writerid)
        {
            var findwriter = writerClasses.FirstOrDefault(x => x.Id == writerid);
            var jsonWriters = JsonConvert.SerializeObject(findwriter);
            return Json(jsonWriters);
        }

        public IActionResult AddWriter(WriterClass w)
        {
            writerClasses.Add(w);
            var jsonAdd = JsonConvert.SerializeObject(w);
            return Json(jsonAdd);
        }

        public IActionResult UpdateWriter(WriterClass w)
        {
            var writer = writerClasses.FirstOrDefault(x => x.Id == w.Id);
            writer.name = w.name;
            var jsonUpdate = JsonConvert.SerializeObject(w);
            return Json(jsonUpdate);
        }

        public IActionResult DeleteWriter(int id)
        {
            var writer = writerClasses.FirstOrDefault(x => x.Id == id);
            writerClasses.Remove(writer);
            return Json(writer);
        }

        public static List<WriterClass> writerClasses = new List<WriterClass>()
        {
            new WriterClass
            {
                Id=1,
                name="Samet"
            },

            new WriterClass
            {
                Id=2,
                name="Ahmet"
            }
        };
    }
}
