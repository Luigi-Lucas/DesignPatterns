namespace DesignPatterns.TemplateMethod.DesafioRelatorio
{
    public class RelatorioCompleto : TemplateRelatorio
    {
        protected override void Cabecalho()
        {
            Console.WriteLine("Banco X");
            Console.WriteLine("Avenida Imperador, 5683");
            Console.WriteLine("(11) 4578-2053");
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
            Console.WriteLine("banco@x.com.br");
            Console.WriteLine(DateTime.Now);
        }
    }
}
