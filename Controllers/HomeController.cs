using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using projeto_aspnetcore.Models;
using projeto_aspnetcore.Database;
using Microsoft.EntityFrameworkCore;

namespace projeto_aspnetcore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ApplicationDBContext database;

       

        
        public HomeController(ILogger<HomeController> logger, ApplicationDBContext database)
        {
            _logger = logger;
            this.database =database;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Teste()
        {
            /*Categoria c1 = new Categoria();
            c1.Nome="Nome1";

            Categoria c2 = new Categoria();
            c2.Nome="Nome2";

            Categoria c3 = new Categoria();
            c3.Nome="Nome3";

            List<Categoria> catList = new List<Categoria>();
            catList.Add(c1);
            catList.Add(c2);
            catList.Add(c3);

            database.AddRange(catList);
            database.SaveChanges();*/

            var listaDeCategorias  = database.Categorias.Where(cat => cat.Nome.Equals("Elisangela")).ToList();
            
            Console.WriteLine("*************CATEGORIAS*******************");
            listaDeCategorias.ForEach(Categoria => {
                Console.WriteLine(Categoria.ToString());
            });
            Console.WriteLine("*******************************************");

            return Content ("Dados Salvos!");
        }

        public IActionResult Relacionamento(){
            /*Produto p = new Produto();
            p.Nome = "Frango";
            p.Categoria = database.Categorias.First(c => c.Id == 1);

            Produto p2 = new Produto();
            p2.Nome = "Mussarela";
            p2.Categoria = database.Categorias.First(c => c.Id == 2);

            database.Add(p);
            database.Add(p2);
            database.SaveChanges();*/

            /*var listadeProdutos = database.Produtos.Include(p => p.Categoria).ToList();

            listadeProdutos.ForEach(produto => {
                Console.WriteLine(produto.ToString());
            });*/

             var listadeProdutos = database.Produtos.Include(p => p.Categoria).Where(p => p.Categoria.Id == 2).ToList();

            listadeProdutos.ForEach(produto => {
                Console.WriteLine(produto.ToString());
            });

            return Content ("Dados Salvos Relacionamentos!");
        }


        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
