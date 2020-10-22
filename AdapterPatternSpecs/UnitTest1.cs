using AdapterPattern.Adaptee;
using AdapterPattern.Adaptor;
using AdapterPattern.Target;
using NUnit.Framework;

namespace AdapterPatternSpecs
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }




        [Test]
        public void AdapteeWithAdaptorShouldSucceed()

        {
            ////arrange
            ICalculator calculator = new CalculatorAdaptor();

            ////act
            var numbersArray = new int[] { 5, 5 };
            var result = calculator.Add(numbersArray);

            ////asert
            Assert.AreEqual(result, 10);
        }



    }
}