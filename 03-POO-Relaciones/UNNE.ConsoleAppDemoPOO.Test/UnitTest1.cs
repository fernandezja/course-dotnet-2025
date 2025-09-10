namespace UNNE.ConsoleAppDemoPOO.Test
{
    public class UnitTest1
    {
        [Fact]
        public void DebeSumar1Mas1YResultadoDebeSer2()
        {
            int sumaResultado = 1 + 1;
            Assert.Equal(2, sumaResultado);
        }
    }
}
