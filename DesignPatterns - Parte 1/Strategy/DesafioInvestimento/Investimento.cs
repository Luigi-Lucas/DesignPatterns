using DesignPatterns.ChainOfResponsability.RequisicaoWeb;

namespace DesignPatterns.Strategy.DesafioInvestimento
{
    public interface Investimento
    {
        double Calcula(Conta conta);
    }
}
