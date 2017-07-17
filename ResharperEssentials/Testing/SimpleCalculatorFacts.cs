using Xunit;

namespace ResharperEssentials.Testing
{
    public class SimpleCalculatorFacts
    {
        [Fact]
        public void AddWorksAsExpected()
        {
            var initialValue = 1;
            var calculator = new SimpleCalculator(initialValue);

            calculator.Add(2);

            Assert.Equal(3, calculator.Value);
        }

        [Fact]
        public void AddDoesNotSubtract()
        {
            var initialValue = 1;
            var calculator = new SimpleCalculator(initialValue);

            calculator.Add(-2);

            Assert.Equal(1, calculator.Value);
        }

        [Fact(Skip = "Not implemented yet.")]
        public void SubtractWorksAsExpected()
        {
            var initialValue = 3;
            var calculator = new SimpleCalculator(initialValue);

            calculator.Subtract(2);

            Assert.Equal(1, calculator.Value);
        }
    }
}