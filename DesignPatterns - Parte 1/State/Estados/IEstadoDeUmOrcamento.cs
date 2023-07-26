﻿namespace DesignPatterns.State.Estados
{
    public interface IEstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento);
        public void Aprova(Orcamento orcamento);
        public void Reprova(Orcamento orcamento);
        public void Finaliza(Orcamento orcamento);
    }
}
