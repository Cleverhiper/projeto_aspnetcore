namespace projeto_aspnetcore.Models
{
    public class Produto
    {
        public int Id {get; set;}

        public string Nome {get; set;}

        public Categoria Categoria {set; get;}

        public override string ToString()
        {
            return "Id: " + this.Id + " Nome: " + this.Nome + " Categoria: [" + this.Categoria.ToString() + "]";
        }

    }
}