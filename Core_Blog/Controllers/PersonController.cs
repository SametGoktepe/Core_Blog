using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Core_Blog.Controllers
{
    public class PersonController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var httpClient = new HttpClient();
            var responeseMessage = await httpClient.GetAsync("https://localhost:44321/api/Default");
            var jSonString = await responeseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<Class1>>(jSonString);
            return View(values);
        }

        public IActionResult AddPerson()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddPerson(Class1 c)
        {
            var httpClient = new HttpClient();
            var jsonPerson = JsonConvert.SerializeObject(c);
            StringContent content = new StringContent(jsonPerson, Encoding.UTF8, "application/json");
            var responseMessage = await httpClient.PostAsync("https://localhost:44321/api/Default", content);
            if (responseMessage.IsSuccessStatusCode) return RedirectToAction("Index");
            return View(c);
        }

        [HttpGet]
        public async Task<IActionResult> UpdatePerson(int id)
        {
            var httpClient = new HttpClient();
            var responseMessage = await httpClient.GetAsync("https://localhost:44321/api/Default/" + id);
            if(responseMessage.IsSuccessStatusCode)
            {
                var jsonPerson = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<Class1>(jsonPerson);
                return View(values);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> UpdatePerson(Class1 c)
        {
            var httpClient = new HttpClient();
            var jsonPerson = JsonConvert.SerializeObject(c);
            var content = new StringContent(jsonPerson, Encoding.UTF8, "application/json");
            var responseMessage = await httpClient.PutAsync("https://localhost:44321/api/Default", content);
            if(responseMessage.IsSuccessStatusCode)
            {
               return RedirectToAction("Index");
            }
            return View(c);
        }

        public async Task<IActionResult> DeletePerson(int id)
        {
            var httpClient = new HttpClient();
            var responseMessage = await httpClient.DeleteAsync("https://localhost:44321/api/Default/" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }

    public class Class1
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
