using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using UnitTesting.Project;

namespace UnitTesting.Test
{
    [TestFixture]
    class SimpleParser_Test
    {
     


        [Test]
        public void Zero()
        {
            //arrange
            SimpleParser sim = new SimpleParser();
            //act
            var res = sim.ParseAndSum("0");
            //assert
            Assert.That(res,Is.EqualTo(0));

        }
        [Test]
        public void NotNumber()
        {
            SimpleParser sim = new SimpleParser();

            Assert.Throws<FormatException>(() =>
            {

                sim.ParseAndSum("kjfkjk");
            });


        }


        [Test]
        public void stringLen()
        {
            SimpleParser sim = new SimpleParser();
            var res = sim.ParseAndSum("");
            Assert.That(res, Is.EqualTo(0));
        }



        [Test]
        public void noReapeat()
        {
            SimpleParser sim = new SimpleParser();
            var res  = sim.NoRepeat("aaa", 'a');
            Assert.That(res, Is.EqualTo("a"));
        }



        [Test]
        public void Prime()
        {

            SimpleParser sim = new SimpleParser();

            //var res = sim.isPrime(-49);

            Assert.Throws<NonInteger>(() =>
            {

                sim.isPrime(8);
            });

            //Assert.That(res, Throws.TypeOf<Negative>());

        }

    }
}
