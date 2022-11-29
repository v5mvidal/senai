using Microsoft.VisualStudio.TestTools.UnitTesting;
using Projeto_Teste;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TesteMSTest
{
    [TestClass]
    public class TesteUnitario
    {
        [TestMethod]
        public void SomarDoisNumeros()
        {
            // Arrange 1 - Preparação
            double pNum = 1;
            double sNum = 1;
            double rNum = 2;

            // Act 1 - Ação/Executar
            double resultado = operacoes.Somar(pNum, sNum);

            // Assert 1 - Verificação
            Assert.AreEqual(rNum, resultado);
        }

        [DataTestMethod]
        // Arrange 2 - Preparação
        [DataRow(1, 1, 2)]
        [DataRow(2, 2, 4)]
        [DataRow(2, 1, 3)]
        [DataRow(3, 3, 6)]
        [DataRow(4, 1, 4)]
        public void SomarDoisNumerosLista(double pNum, double sNum, double rNum)
        {
            // Act 2 - Ação/Executar
            double resultado = operacoes.Somar(pNum, sNum);

            // Assert 2 - Verificação
            Assert.AreEqual(rNum, resultado);
        }
    }
}
