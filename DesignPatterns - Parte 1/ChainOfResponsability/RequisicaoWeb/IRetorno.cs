namespace DesignPatterns.ChainOfResponsability.RequisicaoWeb
{
    public interface IRetorno
    {
        public IRetorno Proximo { get; set; }

        public void Retorna(Requisicao requisicao, Conta conta);
    }
}
