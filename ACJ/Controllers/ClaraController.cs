using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using ACJ.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ACJ.Controllers
{
    public class ClaraController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var quote = new QuoteModel();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://api.quotable.io/random"))
                {
                    var content = await response.Content.ReadAsStringAsync();
                    quote = JsonConvert.DeserializeObject<QuoteModel>(content);
                }
            }
            return View(quote);
        }
    }
}
