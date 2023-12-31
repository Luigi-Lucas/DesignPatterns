﻿using DesignPatterns.Builder;

namespace DesignPatterns.Observer
{
    public class Multiplicador : AcaoAposGerarNota
    {
        public double Fator { get; private set; }
        public Multiplicador(double fator)
        {
            this.Fator = fator;
        }
        public void Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine(notaFiscal.ValorBruto * Fator);
        }
    }
}
