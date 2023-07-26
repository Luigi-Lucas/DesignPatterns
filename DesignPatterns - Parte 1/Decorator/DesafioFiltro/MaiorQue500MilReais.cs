using DesignPatterns.ChainOfResponsability.RequisicaoWeb;
using System.Collections;

namespace DesignPatterns.Decorator.DesafioFiltro
{
    public class MaiorQue500MilReais : Filtro
    {
        public MaiorQue500MilReais(Filtro outroFiltro) : base(outroFiltro)
        {
            
        }
        public MaiorQue500MilReais() : base()
        {
            
        }
        public override IList<Conta> Filtra(IList contas)
        {
            IList<Conta> contaFiltrada = new List<Conta>();

            foreach (Conta conta in contas)
            {
                if (conta.Saldo > 500000)
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
