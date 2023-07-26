using DesignPatterns.ChainOfResponsability.RequisicaoWeb;

namespace DesignPatterns.State.DesafioContaBancaria
{
    public class Negativo : IEstadoDeUmaConta
    {
        public void Deposito(Conta conta, double valor)
        {
            conta.Saldo += valor;
            if (conta.Saldo > 0)
            {
                conta.Estado = new Positivo();
            }
        }

        public void Saque(Conta conta, double valor)
        {
            throw new Exception("Conta negativada! não foi possível realizar o saque.");
        }
    }
}
