using DesignPatterns.State.DesafioContaBancaria;

namespace DesignPatterns.ChainOfResponsability.RequisicaoWeb
{
    public class Conta
    {
        public double Saldo { get; set; }
        public string NomeTitular { get; set; }
        public DateTime DataAbertura { get; set; }
        public IEstadoDeUmaConta Estado { get; set; }

        public Conta(double saldo, string nomeTitular)
        {
            Saldo = saldo;
            NomeTitular = nomeTitular;
        }

        public void Deposito(double valor)
        {
            Estado.Deposito(this, valor);
        }
        public void Saque(double valor)
        {
            Estado.Saque(this, valor);
        }
    }
}
