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
          
        [Test]
        public void TestFizz()
        {
            Assert.AreEqual("Fizz", fizzbuzz.SayFizzBuzz(3));
            Assert.AreEqual("Fizz", fizzbuzz.SayFizzBuzz(6));
        }

        [Test]
        public void TestBuzz()
        {
            Assert.AreEqual("Buzz", fizzbuzz.SayFizzBuzz(5));
            Assert.AreEqual("Buzz", fizzbuzz.SayFizzBuzz(10));
        }

        [Test]
        public void TestFizzBuzz()
        {
            Assert.AreEqual("Fizzbuzz", fizzbuzz.SayFizzBuzz(15));
        }
    }
}
