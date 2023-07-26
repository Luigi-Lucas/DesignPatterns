using DesignPatterns.TemplateMethod;
using DesignPatterns.Strategy;

namespace DesignPatterns.Decorator.DecorandoImpostos
{
    public class IKCV : TemplateDeImpostoCondicional
    {
        public IKCV(Imposto outroImposto) : base(outroImposto) { }

        public IKCV() : base() { }

        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1 + CalculoDoOutroImposto(orcamento);
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05 + CalculoDoOutroImposto(orcamento);
        }

        public override bool UsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor > 500 && ExisteItem(orcamento);
        }

        private bool ExisteItem(Orcamento orcamento)
        {
            foreach (Item item in orcamento.Itens)
            {
                if (item.Valor > 100)
                    return true;
            }
            return false;
        }

        private double CalculoDoOutroImposto(Orcamento orcamento)
        {
            return OutroImposto.Calcula(orcamento);
        }
    }
}
