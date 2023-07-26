using DesignPatterns;

namespace DesignPatterns.Strategy
{
    public abstract class Imposto
    {
        public Imposto OutroImposto { get; set; }

        public Imposto(Imposto outroImposto)
        {
            OutroImposto = outroImposto;
        }

        public Imposto()
        {
            OutroImposto = null;
        }

        protected double CalculaOutroImposto(Orcamento orcamento)
        {
            return OutroImposto == null ? 0 : OutroImposto.Calcula(orcamento);
        }

        public abstract double Calcula(Orcamento orcamento);
    }
}
