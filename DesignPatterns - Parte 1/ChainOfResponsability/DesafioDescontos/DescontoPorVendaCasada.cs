namespace DesignPatterns.ChainOfResponsability.DesafioDescontos
{
    public class DescontoPorVendaCasada : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            bool existe = TestaItemVendaCasada(orcamento);
            if (existe)
            {
                return orcamento.Valor * 0.05;
            }

            return Proximo.Desconta(orcamento);
        }

        private bool TestaItemVendaCasada(Orcamento orcamento)
        {
            return Existe("Caneta", orcamento) && Existe("Lápis", orcamento);
        }

        private bool Existe(string nomeDoItem, Orcamento orcamento)
        {
            foreach (Item item in orcamento.Itens)
            {
                if (item.Nome.Equals(nomeDoItem))
                    return true;
            }
            return false;
        }
    }
}
