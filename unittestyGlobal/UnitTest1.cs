using NUnit.Framework;
using testyGlobal;
using TestyGlobal;

namespace unitttestyGlobal

{


    //brzegowe, negatywne, pozytywne
    // ok 8

    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            //Build: 1 succeeded, 1 failed, 0 up-to-date, 0 skipped
        }

        [TestCase("5", "To jest liczba pierwsza")]

        public void checkPrimeNumber(string input, string expected)
        {
            var ts = new LiczbyPierwsze();
            string res = ts.Test(input);
            Assert.AreEqual(expected, res);
        }

        [TestCase("4", "To nie jest liczba pierwsza")]
        //xpected string length 27 but was 23. Strings differ at index 3.
        //Expected: "To nie jest liczba pierwsza"
        //But was:  "To jest liczba pierwsza"
        // --------------^

        public void checkIfNotPrimeNumber(string input, string expected)
        {
            var ts = new LiczbyPierwsze();
            string res = ts.Test(input);
            Assert.AreEqual(expected, res);
        }

        [TestCase("4", "To jest liczba pierwsza")]

        public void numberNotEqual(string input, string expected)
        {
            var ts = new LiczbyPierwsze();
            string res = ts.Test(input);
            Assert.AreNotEqual(expected, res);
        }

        [TestCase("-1000")]

        public void negativeNumber(string input)
        {
            var ts = new LiczbyPierwsze();
            Assert.Throws<InvalidOperationException>(() => ts.Test(input));
        }

        [TestCase("q")]

        public void notNumber(string input)
        {
            var ts = new LiczbyPierwsze();
            Assert.Throws<InvalidOperationException>(() => ts.Test(input));
        }

        [TestCase("14.1")]

        public void numberIsFloat(string input)
        {
            var ts = new LiczbyPierwsze();
            Assert.Throws<InvalidOperationException>(() => ts.Test(input));
        }

        [TestCase("0", "To nie jest liczba pierwsza")]
        [TestCase("1", "To nie jest liczba pierwsza")]
        public void numberIsEqual(string input, string expected)
        {
            var ts = new LiczbyPierwsze();
            string res = ts.Test(input);
            Assert.AreEqual(expected, res);
        }


    }
}