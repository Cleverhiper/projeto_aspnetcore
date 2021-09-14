using System;
using Microsoft.AspNetCore.Mvc;

namespace projeto_aspnetcore.Controllers
{
    public class AdminController: Controller
    {
        public IActionResult Index(){
            return Content("Olá Mundo - School of Net");
        }
    }
}