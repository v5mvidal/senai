using Projeto_Teste;

namespace TesteXunit
{
    public class TesteUnitario
    {
        [Fact]
        public void SomarDoisNumeros()
        {
            // Arrange 1 - Prepara��o
            double pNum = 1;
            double sNum = 1;
            double rNum = 2;

            // Act 1 - A��o/Executar
            double resultado = operacoes.Somar(pNum, sNum);

            // Assert 1 - Verifica��o
            Assert.Equal(rNum, resultado);
        }

        [Theory]
        // Arrange 2 - Prepara��o
        [InlineData(1, 1, 2)]
        [InlineData(2, 2, 4)]
        [InlineData(2, 1, 3)]
        [InlineData(3, 3, 6)]
        [InlineData(4, 1, 4)]
        public void SomarDoisNumerosLista(double pNum, double sNum, double rNum)
        {
            // Act 2 - A��o/Executar
            double resultado = operacoes.Somar(pNum, sNum);

            // Assert 2 - Verifica��o
            Assert.Equal(rNum, resultado);
        }
    }
}