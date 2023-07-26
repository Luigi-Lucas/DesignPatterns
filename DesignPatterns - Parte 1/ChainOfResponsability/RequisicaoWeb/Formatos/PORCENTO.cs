namespace DesignPatterns.ChainOfResponsability.RequisicaoWeb.Formatos
{
    public class PORCENTO : IRetorno
    {
        public IRetorno Proximo { get; set; }

        public PORCENTO(IRetorno proximo)
        {
            Proximo = proximo;
        }

        public void Retorna(Requisicao requisicao, Conta conta)
        {
            if (requisicao.Formato.Equals(Formato.PORCENTO))
            {
                Console.WriteLine(conta.NomeTitular + "%" + conta.Saldo);
            }
            else
            {
                Proximo.Retorna(requisicao, conta);
            }
        }
    }
}
