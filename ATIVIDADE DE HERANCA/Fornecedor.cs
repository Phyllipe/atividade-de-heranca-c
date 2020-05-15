using System;
using System.Collections.Generic;
using System.Text;

namespace ATIVIDADE_DE_HERANCA
{
    class Fornecedor : Pessoa
    {
        private double valorCredito;
        private double valorDivida;

        public Fornecedor(string Nome, string End, string Tel) : base(Nome, End, Tel)
        {

        }

        public double ValorCredito
        {
            get { return valorCredito; }
            set { valorCredito = value; }

        }
        public double ValorDivida
        {
            get { return valorDivida; }
            set { valorDivida = value; }

        }
        public double obterSaldo()
        {
            if ((ValorCredito - ValorDivida) >= 0)
            {
                return ValorCredito - ValorDivida;
            }
            return 0;
        }
    }
}
