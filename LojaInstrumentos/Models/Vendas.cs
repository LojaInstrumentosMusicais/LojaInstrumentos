
namespace LojaInstrumentos.Models
{
    public class Venda
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Instrumento { get; set; } = "";
        public int Quantidade { get; set; }
        public decimal PrecoUnitario { get; set; }

        public decimal Total => Quantidade * PrecoUnitario;
    }
}
