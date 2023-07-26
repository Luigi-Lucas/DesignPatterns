using DesignPatterns.ChainOfResponsability.RequisicaoWeb;

namespace DesignPatterns.State.DesafioContaBancaria
{
    public interface IEstadoDeUmaConta
    {
        public void Deposito(Conta conta, double valor);
        public void Saque(Conta conta, double valor);
    }
}
