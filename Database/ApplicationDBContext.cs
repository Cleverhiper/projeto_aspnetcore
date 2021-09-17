using System;
using Microsoft.EntityFrameworkCore;
using projeto_aspnetcore.Models;

namespace projeto_aspnetcore.Database
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Funcionario> Funcionarios {get; set;}

        public DbSet<Categoria> Categorias {get; set;}
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options){}
    }
}