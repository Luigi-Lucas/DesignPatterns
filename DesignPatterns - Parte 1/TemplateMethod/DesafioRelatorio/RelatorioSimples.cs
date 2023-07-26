namespace DesignPatterns.TemplateMethod.DesafioRelatorio
{
    public class RelatorioSimples : TemplateRelatorio
    {
        protected override void Cabecalho()
        {
            Console.WriteLine("Banco X");
        }

        protected override void Corpo(IList<Conta> contas)
        {
            foreach (Conta conta in contas)
            {
                Console.WriteLine(conta.ToString);
            }
        }

        protected override void Rodape()
        {
            Console.WriteLine("(11) 8907-6532");
        }
    }
}
