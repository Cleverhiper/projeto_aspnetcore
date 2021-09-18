namespace projeto_aspnetcore.Models
{
    public class Categoria
    {
        public int Id {get; set;}

        public string Nome {get; set;}

        public override string ToString()
        {
            return "ID: " + this.Id + " Nome: " + this.Nome;
        }
    }
}