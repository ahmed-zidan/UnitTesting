using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using UnitTesting.Project;

namespace UnitTesting.Test
{
    [TestFixture]
    class Calculator_Test
    {
        [Test]
        public void Add_int_tes()
        {
            //AAA
            //Arange
            Calculator calc = new Calculator();
            //Act
            var res = calc.Add(10, 20);
            //Assert
            Assert.AreEqual(20, res);
        }

        [Test]
        public void div_double_test()
        {
            //AAA
            //Arrange
            Calculator calc = new Calculator();
            //Act
            var res = calc.divide_double(1, 3);

            //assert
            Assert.That(res, Is.EqualTo(0.33).Within(0.004));
        }


        [Test]
        public void Div_by_zero()
        {
            Calculator cal = new Calculator();

            Assert.Throws<DivideByZeroException>(() =>
            {

                cal.divide_double(1, 0);
            });


        }


    }
}
