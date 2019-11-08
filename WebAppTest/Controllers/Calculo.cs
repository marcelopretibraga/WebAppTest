using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppTest.Model;

namespace WebAppTest.Controllers
{
    public class Calculo
    {
        public static int Soma(int v1, int v2) => v1 + v2;
        public static int Subtracao(int v1, int v2) => v1 - v2;
        public static double Multiplicacao(int v1, int v2) => v1 * v2;
        public static double Divisao(int v1, int v2) => v1 / v2;


        public static Contribuinte CalcIRPF(Contribuinte contribuinte) 
        {
            if (contribuinte == null)
                return null;

            if (contribuinte.Salario <= 0)
                return null;

            if (contribuinte.Salario <= 1903.98)//Isento 
                contribuinte.ValorIR = 0;
            else if (contribuinte.Salario > 1903.99 && contribuinte.Salario <= 2826.65)
                contribuinte.ValorIR = 142.80;

            return contribuinte;
        }

    }
}
