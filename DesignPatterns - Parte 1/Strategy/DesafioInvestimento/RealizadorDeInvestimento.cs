using DesignPatterns.ChainOfResponsability.RequisicaoWeb;

namespace DesignPatterns.Strategy.DesafioInvestimento
{
    public class RealizadorDeInvestimentos
    {
        public void Realiza(Conta conta, Investimento investimento)
        {
            double resultado = investimento.Calcula(conta);
            conta.Deposito(resultado * 0.75);
            Console.WriteLine("Novo saldo: " + conta.Saldo);
        }
    }
}
