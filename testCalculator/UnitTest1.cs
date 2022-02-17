using NUnit.Framework;

namespace testCalculator
{
    [TestFixture]
    public class Tests
    {
        [TestCase(100,60,1,0,3600)]
        [TestCase(50,200,2,30,15000)]
        [TestCase(50,100,0,30,1500)]
        public static void calculatorRun(double stepLength, int stepPerMin, int Hour, int Min, double expected)
        {
            var length = (stepLength / 100) * stepPerMin * ((Hour * 60) + Min);

            Assert.AreEqual(length, expected);

        }
    }
    
}