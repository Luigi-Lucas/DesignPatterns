namespace DesignPatterns.TemplateMethod.DesafioRelatorio
{
    public class Conta
    {
        public string NomeTitular { get; set; }
        public int Numero { get; set; }
        public int Agencia { get; set; }
        public double Saldo { get; set; }

        public Conta(string nomeTitular, int numero, int agencia, double saldo)
        {
            NomeTitular = nomeTitular;
            Numero = numero;
            Agencia = agencia;
            Saldo = saldo;
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
