using DesignPatterns.Builder;

namespace DesignPatterns.Observer
{
    public class NotaFiscalDao : AcaoAposGerarNota
    {
        public void Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine("Salvando no banco");
        }
    }
}
