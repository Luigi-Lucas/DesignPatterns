using DesignPatterns.Decorator.DecorandoImpostos;

namespace DesignPatterns.TemplateMethod.DesafioImpostos
{
    public class TestaImpostos
    {
        static void Main(string[] args)
        {
            Orcamento orcamento = new Orcamento(550.0);

            orcamento.AdicionaItem(new Item("CANETA", 250.0));
            orcamento.AdicionaItem(new Item("LAPIS", 500.0));

            ICPP impostoIccp = new ICPP();
            var valorIccp = impostoIccp.Calcula(orcamento);

            IKCV impostoIkcv = new IKCV();
            var valorIkcv = impostoIkcv.Calcula(orcamento);

            Console.WriteLine($"Valor do imposto ICCP: {valorIccp}\nValor do imposto IKCV: {valorIkcv}");
        }
    }
}
