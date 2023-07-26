namespace DesignPatterns.TemplateMethod
{
    public class IHIT : TemplateDeImpostoCondicional
    {
        public override bool UsarMaximaTaxacao(Orcamento orcamento)
        {
            return ItensComMesmoNome(orcamento);
        }

        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.13 + 100;
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * (0.01 * orcamento.Itens.Count);
        }

        private bool ItensComMesmoNome(Orcamento orcamento)
        {
            IList<string> nomes = new List<string>();

            foreach(Item item in orcamento.Itens)
            {
                if (nomes.Contains(item.Nome))
                    return true;
                else 
                    nomes.Add(item.Nome);
            }
            return false;
        }
    }
}
