using DesignPatterns;

namespace DesignPatterns.Strategy
{
    public class CalculadorDeImposto
    {
        public void CalculaImposto(Orcamento orcamento, Imposto imposto)
        {
            var resultado = imposto.Calcula(orcamento);
            Console.WriteLine("Valor do Imposto: " + resultado);
        }
    }
}
