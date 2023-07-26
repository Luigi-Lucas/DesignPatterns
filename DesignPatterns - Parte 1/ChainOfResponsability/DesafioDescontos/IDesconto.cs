namespace DesignPatterns.ChainOfResponsability.DesafioDescontos
{
    public interface IDesconto
    {
        IDesconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento);
    }
}
