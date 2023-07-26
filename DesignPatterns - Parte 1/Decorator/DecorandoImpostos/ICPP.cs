using DesignPatterns.Strategy;

namespace DesignPatterns.TemplateMethod.DesafioImpostos
{
    public class ICPP : TemplateDeImpostoCondicional
    {
        public ICPP(Imposto outroImposto) : base(outroImposto) { }

        public ICPP() : base() { }

        public override bool UsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor > 500;
        }

        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.07 + CalculoDoOutroImposto(orcamento);
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05 + CalculoDoOutroImposto(orcamento);
        }

        private double CalculoDoOutroImposto(Orcamento orcamento)
        {
            return OutroImposto.Calcula(orcamento);
        }
    }
}
