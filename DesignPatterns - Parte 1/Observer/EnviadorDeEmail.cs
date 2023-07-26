using DesignPatterns.Builder;

namespace DesignPatterns.Observer
{
    public class EnviadorDeEmail : AcaoAposGerarNota
    {
        public void Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine("Enviando Email");
        }
    }
}
