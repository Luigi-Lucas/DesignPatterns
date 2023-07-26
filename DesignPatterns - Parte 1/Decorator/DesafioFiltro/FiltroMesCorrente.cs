using DesignPatterns.ChainOfResponsability.RequisicaoWeb;
using System.Collections;

namespace DesignPatterns.Decorator.DesafioFiltro
{
    public class FiltroMesCorrente : Filtro
    {
        public FiltroMesCorrente(Filtro outroFiltro) : base(outroFiltro)
        {

        }
        public FiltroMesCorrente() : base()
        {

        }
        public override IList<Conta> Filtra(IList contas)
        {
            IList<Conta> contaFiltrada = new List<Conta>();

            foreach (Conta conta in contas)
            {
                if (conta.DataAbertura.Month == DateTime.Now.Month && conta.DataAbertura.Year == DateTime.Now.Year)
                {
                    contaFiltrada.Add(conta);
                }
            }

            foreach (Conta conta in Proximo(contas))
            {
                contaFiltrada.Add(conta);
            }

            return contaFiltrada;
        }
    }
}

