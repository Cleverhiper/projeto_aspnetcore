namespace projeto_aspnetcore.Models
{
    public class Produto
    {
        public int Id {get; set;}

        public string Nome {get; set;}

        public Categoria Categoria {set; get;}
        
    }
}