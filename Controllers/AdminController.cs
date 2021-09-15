using System;
using Microsoft.AspNetCore.Mvc;

namespace projeto_aspnetcore.Controllers
{
    [Route("son")]
    public class AdminController: Controller
    {
        [HttpGet("{numero:int}")]
        public IActionResult Index(int numero){
            return Content("Olá Mundo - School of Net: " + numero);
        }

        public IActionResult Hello() {
            var nomecompleto = Request.Query["nomecomp"];
            return Content("Desenvolvido por Cleverson!! " + nomecompleto);
        }

        [HttpGet("visualizar")]
        public IActionResult visualizar() {
            return View();
        }
    }
}