using DesignPatterns.Strategy;

namespace DesignPatterns.Decorator.DesafioImposto
{
    public class TestaImpostoMuitoAlto
    {
        static void Main(string[] args)
        {
            Imposto imposto = new ImpostoMuitoAlto(new ICMS());

            Orcamento orcamento = new Orcamento(500.0);

            double valor = imposto.Calcula(orcamento);

            Console.WriteLine(valor);
        }
    }
}
