using DesignPatterns.ChainOfResponsability.RequisicaoWeb;
using System.Collections;

namespace DesignPatterns.Decorator.DesafioFiltro
{
    public abstract class Filtro
    {
        public Filtro() { }
        protected Filtro OutroFiltro { get; private set; }
        public Filtro(Filtro outroFiltro)
        {
            this.OutroFiltro = outroFiltro;
        }

        public abstract IList<Conta> Filtra(IList contas);

        protected IList<Conta> Proximo(IList contas)
        {
            if (OutroFiltro != null)

                return OutroFiltro.Filtra(contas);
            else
            {
                return new List<Conta>();
            }
        }
    }
}
