using DesignPatterns.ChainOfResponsability.RequisicaoWeb;

namespace DesignPatterns.State.DesafioContaBancaria
{
    public class Positivo : IEstadoDeUmaConta
    {
        public void Deposito(Conta conta, double valor)
        {
            conta.Saldo += valor;
        }

        public void Saque(Conta conta, double valor)
        {
            conta.Saldo -= valor;

            if (conta.Saldo < 0)
            {
                conta.Estado = new Negativo();
            }
        }
    }
}
