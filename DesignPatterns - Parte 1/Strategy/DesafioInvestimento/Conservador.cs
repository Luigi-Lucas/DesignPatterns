using DesignPatterns.ChainOfResponsability.RequisicaoWeb;

namespace DesignPatterns.Strategy.DesafioInvestimento
{
    public class Conservador : Investimento
    {
        public double Calcula(Conta conta)
        {
            return conta.Saldo * 0.008;
        }
    }
}
