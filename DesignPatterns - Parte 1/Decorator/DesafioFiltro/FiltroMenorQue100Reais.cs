using DesignPatterns.ChainOfResponsability.RequisicaoWeb;
using System.Collections;

namespace DesignPatterns.Decorator.DesafioFiltro
{
    public class FiltroMenorQue100Reais : Filtro
    {
        public FiltroMenorQue100Reais(Filtro outroFiltro) : base(outroFiltro)
        {

        }
        public FiltroMenorQue100Reais() : base()
        {
            
        }
        public override IList<Conta> Filtra(IList contas)
        {
            IList<Conta> contaFiltrada = new List<Conta>();

            foreach (Conta conta in contas)
            {
                if (conta.Saldo < 100)
                {
                    contaFiltrada.Add(conta);
                }
            }

            foreach(Conta conta in Proximo(contas))
            {
                contaFiltrada.Add(conta);
            }

            return contaFiltrada;
        }
    }
}
