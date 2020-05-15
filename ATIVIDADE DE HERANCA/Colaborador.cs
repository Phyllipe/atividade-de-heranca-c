using System;
using System.Collections.Generic;
using System.Text;

namespace ATIVIDADE_DE_HERANCA
{
    class Colaborador : Pessoa
    {
        private int codSetor;
        private double salarioBase;
        private int impostos;

        public Colaborador(string Nome, string End, string Tel) : base(Nome, End, Tel)
        {

        }
        public int CodSetor
        {
            get { return codSetor; }
            set { codSetor = value; }
        }
        public double SalarioBase
        {
            get { return salarioBase; }
            set { salarioBase = value; }
        }
        public int Impostos
        {
            get { return impostos; }
            set { impostos = value; }
        }
        public virtual double calcularSalario()
        {

            return SalarioBase - (SalarioBase * ((double)Impostos / 100));
        }
    }
}
