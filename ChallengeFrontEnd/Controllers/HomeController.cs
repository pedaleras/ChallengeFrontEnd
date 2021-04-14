using ChallengeBackEnd;
using ChallengeBackEnd.Dados;
using ChallengeFrontEnd.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace ChallengeFrontEnd.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Add(DataModel model)
        {
            ///Aqui salvaria em um banco de Dados, como não tenho um, vou só criar a lógica
            var dados = new Data();

            var salvar = dados.Add(model);

            var ret = new
            {
                salvar.status,
                salvar.msg
            };

            return Json(ret);
        }

        [HttpPost]
        public JsonResult Delete(int Id)
        {
            ///Aqui salvaria em um banco de Dados, como não tenho um, vou só criar a lógica
            var dados = new Data();

            var delete = dados.Delete(Id);

            var ret = new
            {
                delete.status,
                delete.msg
            };

            return Json(ret);
        }

        [HttpGet]
        public JsonResult Get()
        {
            ///Aqui salvaria em um banco de Dados, como não tenho um, vou só criar a lógica
            var dados = new Data();

            var lista = dados.GetList();

            var ret = new
            {
                lista.List,
                lista.Msg,
                lista.Status
            };

            var settings = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

            return Json(ret, settings);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
