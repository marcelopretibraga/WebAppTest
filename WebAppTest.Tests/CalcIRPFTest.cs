using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using WebAppTest.Controllers;
using WebAppTest.Model;

namespace WebAppTest.Tests
{
    public class CalcIRPFTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Calc_irpf_contribuinte_is_null()
        {
            var contribuinteMock = Calculo.CalcIRPF(new Contribuinte());
            Assert.IsNull(contribuinteMock, "Objeto contribuinte Não é nullo");
        }

        [Test]
        public void Calc_irpf_salary_less_or_equal_zero()
        {
            var contribuinteSalary = new Contribuinte() { Salario = -5 };
            var contribuinteMock = Calculo.CalcIRPF(contribuinteSalary);
            Assert.IsNull(contribuinteMock, "Salário maior que zero");

            contribuinteSalary.Salario = 0;
            contribuinteMock = Calculo.CalcIRPF(contribuinteSalary);
            Assert.IsNull(contribuinteMock, "Salário maior que zero");

            contribuinteSalary.Salario = 1500;
            contribuinteMock = Calculo.CalcIRPF(contribuinteSalary);
            Assert.IsNotNull(contribuinteMock, "Salário maior que zero");
        }

        [Test]
        public void Calc_irpf_isent()
        {
            var contribuinteSalary = new Contribuinte() { Salario = 1800 };
            var contribuinteMock = Calculo.CalcIRPF(contribuinteSalary);
            Assert.AreEqual(contribuinteMock.ValorIR, 0, "Salário não é isento de IR");
        }

        [Test]
        public void Calc_irpf_1()
        {
            var contribuinteSalary = new Contribuinte() { Salario = 2500 };
            var contribuinteMock = Calculo.CalcIRPF(contribuinteSalary);
            Assert.AreEqual(contribuinteMock.ValorIR, 142.80, "Salário não está na Faixa de 7.5%");
        }
    }
}
