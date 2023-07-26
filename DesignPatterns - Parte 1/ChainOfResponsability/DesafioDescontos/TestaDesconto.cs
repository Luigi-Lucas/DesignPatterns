namespace DesignPatterns.ChainOfResponsability.DesafioDescontos
{
    public class TestaDesconto
    {
        public class TestaDescontos
        {
            static void Main(string[] args)
            {
                CalculadorDeDescontos calculador = new CalculadorDeDescontos();

                Orcamento orcamento = new Orcamento(501.0);
                orcamento.AdicionaItem(new Item("CANETA", 250.0));
                orcamento.AdicionaItem(new Item("LAPIS", 500.0));

                double desconto = calculador.Calcula(orcamento);

                Console.WriteLine(desconto);
            }
        }
    }
}
