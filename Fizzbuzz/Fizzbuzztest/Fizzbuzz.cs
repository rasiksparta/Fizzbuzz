using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Fizzbuzz;

namespace Fizzbuzz.Test
{
    [TestFixture]
    class FizzbuzzTest
    {
        Fizzbuzz fizzbuzz = new Fizzbuzz(1, 15);

        [Test]
        public void TestDivisibility()
        {
            Assert.AreEqual(true, fizzbuzz.Divisibility(6,3));
            Assert.AreEqual(false, fizzbuzz.Divisibility(7, 2));
            Assert.AreEqual(false, fizzbuzz.Divisibility(4, 0));
        }
    }
}
