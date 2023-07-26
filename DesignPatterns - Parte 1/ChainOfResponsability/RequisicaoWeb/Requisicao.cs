namespace DesignPatterns.ChainOfResponsability.RequisicaoWeb
{
    public class Requisicao
    {
        public Formato Formato { get; private set; }

        public Requisicao(Formato formato)
        {
            Formato = formato;
        }
    }
}
