namespace DesignPatterns.Builder
{
    public class NotaFiscalBuilder
    {
        public string RazaoSocial { get; set; }
        private string Cnpj { get; set; }
        private double ValorTotal { get; set; }
        private double Impostos { get; set; }
        private DateTime Data { get; set; }
        private string Observacoes { get; set; }

        private IList<ItemDaNota> TodosItens = new List<ItemDaNota>();

        public NotaFiscalBuilder()
        {
            Data = DateTime.Now;
        }

        public NotaFiscal Constroi()
        {
            return new NotaFiscal(RazaoSocial, Cnpj, Data, ValorTotal, Impostos, TodosItens, Observacoes);
        }

        public NotaFiscalBuilder ParaEmpresa(String razaoSocial)
        {
            this.RazaoSocial = razaoSocial;
            return this;
        }

        public NotaFiscalBuilder ComCnpj(String cnpj)
        {
            this.Cnpj = cnpj;
            return this;
        }

        public NotaFiscalBuilder ComItem(ItemDaNota item)
        {
            TodosItens.Add(item);
            ValorTotal += item.Valor;
            Impostos += item.Valor * 0.05;
            return this;
        }

        public NotaFiscalBuilder ComObservacoes(string observacoes)
        {
            this.Observacoes = observacoes;
            return this;
        }

        public NotaFiscalBuilder NaData()
        {
            this.Data = DateTime.Now;
            return this;
        }
    }
}
