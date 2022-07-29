using Domain;

namespace CalculatorTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestSum()
        {
            var calculator = new Calculator();
            if (calculator.Sum(2, 2) != 4)
                throw new Exception();
        }

        
    }
}