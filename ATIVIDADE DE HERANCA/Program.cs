using System;

namespace ATIVIDADE_DE_HERANCA
{
    class Program
    {
        static void Main(string[] args)
        {
            Fornecedor f = new Fornecedor("Filipe", "Lambari", "(35)3271-3025");
            f.ValorCredito = 1000.00;
            f.ValorDivida = 315.41;
            Console.WriteLine("Fornecedor, saldo de :" + f.obterSaldo());

            Colaborador c = new Colaborador("João", "Varginha", "(35)3234-1045");
            c.CodSetor = 30;
            c.SalarioBase = 818.13;
            c.Impostos = 2;
            Console.WriteLine("Colaborador, salário :" + c.calcularSalario());

            Admistrador a = new Admistrador("Marcos", "São Paulo", "(35)3222-1478");
            a.CodSetor = 30;
            a.SalarioBase = 818.13;
            a.Impostos = 2;
            a.AjudaDeCusto = 314.07;
            Console.WriteLine("Administrador", "salário :" + a.calcularSalario());

            Operario o = new Operario("Rafael", "RioDeJaneiro", "(35)3748-1589");
            o.CodSetor = 30;
            o.SalarioBase = 818.13;
            o.Impostos = 2;
            o.ValorProducao = 118.00;
            o.Comissao = 3;
            Console.WriteLine("Operário, salário :" + o.calcularSalario());

            Vendedor v = new Vendedor("Lucas", "Varginha", "(35)3258-4714");
            v.CodSetor = 30;
            v.SalarioBase = 818.14;
            v.Impostos = 2;
            v.ValorVendas = 518.14;
            v.Comissao = 5;
            Console.WriteLine("Vendedor, salário : " + v.calcularSalario());

            Console.ReadKey();
        }
    }
}
