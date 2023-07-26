namespace DesignPatterns.ChainOfResponsability.RequisicaoWeb.Formatos
{
    public class XML : IRetorno
    {
        public IRetorno ?Proximo { get; set; }

        public XML(IRetorno proximo)
        {
            Proximo = proximo;
        }
        public XML()
        {
            Proximo = null;
        }

        public void Retorna(Requisicao requisicao, Conta conta)
        {
            if (requisicao.Formato.Equals(Formato.XML))
            {
                Console.WriteLine("<conta><titular>" + conta.NomeTitular + "</titular><saldo>" + conta.Saldo + "</saldo></conta>");
            }
            else if(Proximo != null) 
            {
                Proximo.Retorna(requisicao, conta);
            }
            else
            {
                Console.WriteLine("Formato não encontrado!");
            }
        }
    }
}
