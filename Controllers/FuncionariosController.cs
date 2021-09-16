using Microsoft.AspNetCore.Mvc;
using projeto_aspnetcore.Models;
using System;
using projeto_aspnetcore.Database;
using System.Linq;

namespace projeto_aspnetcore.Controllers
{
    public class FuncionariosController : Controller
    {
        private readonly ApplicationDBContext database;
        public FuncionariosController(ApplicationDBContext database) {
            this.database = database;
        }

        public IActionResult Index() {
            var funcionarios = database.Funcionarios.ToList();
            return View(funcionarios);
        }
        public IActionResult Cadastrar() {
            return View();
        }

        [HttpPost]
        public IActionResult Salvar(Funcionario funcionario) {
            database.Funcionarios.Add(funcionario);
            database.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}