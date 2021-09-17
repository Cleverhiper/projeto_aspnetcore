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

        public IActionResult Editar(int id)
        {
            Funcionario funcionario = database.Funcionarios.First(registro => registro.Id == id);
            return View("Cadastrar",funcionario);
        }

        public IActionResult Deletar(int id)
        {
            Funcionario funcionario = database.Funcionarios.First(registro => registro.Id == id);
            database.Funcionarios.Remove(funcionario);
            database.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Salvar(Funcionario funcionario) {
            if (funcionario.Id == 0)
            {
                //Salvar um novo funcionario
                database.Funcionarios.Add(funcionario);
            } else {
                Funcionario funcionariodoBanco = database.Funcionarios.First(registro => registro.Id == funcionario.Id);
                funcionariodoBanco.Nome = funcionario.Nome;
                funcionariodoBanco.Salario = funcionario.Salario;
                funcionariodoBanco.Cpf = funcionario.Cpf;
            }

            database.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}