using DesignPatterns.Strategy;

namespace DesignPatterns.Decorator.DesafioImposto
{
    public class ImpostoMuitoAlto : Imposto
    {
        public ImpostoMuitoAlto(Imposto outroImposto) : base(outroImposto) { }

        public ImpostoMuitoAlto() : base() { }

        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.2 + CalculoDoOutroImposto(orcamento);
        }

        private double CalculoDoOutroImposto(Orcamento orcamento)
        {
            return OutroImposto.Calcula(orcamento);
        }

    }
}




