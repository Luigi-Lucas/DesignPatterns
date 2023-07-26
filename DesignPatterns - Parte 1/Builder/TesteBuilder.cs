namespace DesignPatterns.Builder
{
    class TesteBuilder
    {
        public static void Main(String[] args)
        {
            NotaFiscal nf = new NotaFiscalBuilder().ParaEmpresa("EmpresaX")
                              .ComCnpj("123.456.789/0001-10")
                              .ComItem(new ItemDaNota("item 1", 100.0))
                              .ComItem(new ItemDaNota("item 2", 200.0))
                              .ComItem(new ItemDaNota("item 3", 300.0))
                              .ComObservacoes("observações")
                              .NaData()
                              .Constroi();
        }
    }
}
