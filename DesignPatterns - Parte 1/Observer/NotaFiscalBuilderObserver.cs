using DesignPatterns.Builder;

namespace DesignPatterns.Observer
{
    public class NotaFiscalBuilderObserver
    {
        public string RazaoSocial { get; set; }
        private string Cnpj { get; set; }
        private double ValorTotal { get; set; }
        private double Impostos { get; set; }
        private DateTime Data { get; set; }
        private string Observacoes { get; set; }

        private IList<ItemDaNota> TodosItens = new List<ItemDaNota>();

        private IList<AcaoAposGerarNota> todasAcoesASeremExecutadas;

        public NotaFiscalBuilderObserver()
        {
            Data = DateTime.Now;
            this.todasAcoesASeremExecutadas = new List<AcaoAposGerarNota>();
        }

        public void AdicionaAcao(AcaoAposGerarNota novaAcao)
        {
            this.todasAcoesASeremExecutadas.Add(novaAcao);
        }

        public NotaFiscal Constroi()
        {
            NotaFiscal notaFiscal =  new NotaFiscal(RazaoSocial, Cnpj, Data, ValorTotal, Impostos, TodosItens, Observacoes);

            foreach (AcaoAposGerarNota acao in todasAcoesASeremExecutadas)
            {
                acao.Executa(notaFiscal);
            }

            return notaFiscal;
        }

        public NotaFiscalBuilderObserver ParaEmpresa(String razaoSocial)
        {
            this.RazaoSocial = razaoSocial;
            return this;
        }

        public NotaFiscalBuilderObserver ComCnpj(String cnpj)
        {
            this.Cnpj = cnpj;
            return this;
        }

        public NotaFiscalBuilderObserver ComItem(ItemDaNota item)
        {
            TodosItens.Add(item);
            ValorTotal += item.Valor;
            Impostos += item.Valor * 0.05;
            return this;
        }

        public NotaFiscalBuilderObserver ComObservacoes(string observacoes)
        {
            this.Observacoes = observacoes;
            return this;
        }

        public NotaFiscalBuilderObserver NaData()
        {
            this.Data = DateTime.Now;
            return this;
        }
    }
}
