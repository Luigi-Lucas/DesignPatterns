using DesignPatterns.Builder;

namespace DesignPatterns.Observer
{
    public class TesteObserver
    {
        static void Main(String[] args)
        {
            NotaFiscalBuilderObserver builder = new NotaFiscalBuilderObserver();
            builder.AdicionaAcao(new EnviadorDeEmail());
            builder.AdicionaAcao(new NotaFiscalDao());
            builder.AdicionaAcao(new Multiplicador(2));

            NotaFiscal notaFiscal = builder.ParaEmpresa("Caelum")
                              .ComCnpj("123.456.789/0001-10")
                              .ComItem(new ItemDaNota("item 1", 100.0))
                              .ComItem(new ItemDaNota("item 2", 200.0))
                              .ComItem(new ItemDaNota("item 3", 300.0))
                              .ComObservacoes("entregar notaFiscal pessoalmente")
                              .NaData()
                              .Constroi();
        }
    }
}
