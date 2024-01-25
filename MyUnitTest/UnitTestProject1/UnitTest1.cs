using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(10,5,15)]
        [DataRow(10, 2, 13)]
        [DataRow(1, 5, 6)]
        public void TestSum(double a, double b,double result1)
        {
            double result2 = MyCalcLib.MyCalc.Sum(a, b);

            Assert.AreEqual(result1, result2);
        }

        [TestMethod]
        public void TestSum10And5()
        {
            double a = 10, b = 5,result;

            result = MyCalcLib.MyCalc.Sum(a, b);

            Assert.AreEqual(result, 15);
        }

        [TestMethod]
        public void TestSum10And2()
        {
            double a = 10, b = 2, result;

            result = MyCalcLib.MyCalc.Sum(a, b);

            Assert.AreEqual(result, 12);
        }

        [TestMethod]
        public void TestSum12And2()
        {
            double a = 12, b = 2, result;

            result = MyCalcLib.MyCalc.Sum(a, b);

            Assert.AreEqual(result, 14);
        }

        [TestMethod]
        public void TestDivide10And5()
        {
            double a = 10, b = 5, result;

            result = MyCalcLib.MyCalc.Divide(a, b);

            Assert.AreEqual(result, 2);
        }

        [TestMethod]
        public void TestDivide10And0()
        {
            double a = 10, b = 0, result;

            try
            {
                result = MyCalcLib.MyCalc.Divide(a, b);
            }catch(MyCalcLib.MyCalcDivideOnZeroException)
            {
                return;
            }
            catch (Exception)
            {
                Assert.Fail("Сгенерировано неизвестное исключение");
            }

            Assert.Fail("Исключение не сгенерировано");
            
        }
    }
}
