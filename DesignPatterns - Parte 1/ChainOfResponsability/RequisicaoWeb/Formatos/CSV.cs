namespace DesignPatterns.ChainOfResponsability.RequisicaoWeb.Formatos
{
    public class CSV : IRetorno
    {
        public IRetorno Proximo { get; set; }

        public CSV(IRetorno proximo)
        {
            Proximo = proximo;
        }

        public void Retorna(Requisicao requisicao, Conta conta)
        {
            if (requisicao.Formato.Equals(Formato.CSV))
            {
                Console.WriteLine(conta.NomeTitular + ";" + conta.Saldo) ;
            }
            else
            {
                Proximo.Retorna(requisicao, conta);
            }
        }
    }
}
