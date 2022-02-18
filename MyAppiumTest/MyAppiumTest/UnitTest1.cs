using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Remote;

namespace MyAppiumTest
{
    [TestClass]
    public class UnitTest1
    {
        public static WindowsDriver<WindowsElement> windowsDriver;

        public static WindowsElement tb_a, tb_b, btn_Go, lb_Result;

        [TestInitialize]
        public void TestInitialize()
        {
            var desiredCapabilities = new AppiumOptions();

            //Задание параметров тестирующей библиотеки  (в данном случае параметр единственный - путь к тестируемой программе)
            desiredCapabilities.AddAdditionalCapability("app", @"D:\Lect\20210129_PI_ZAO\MyCalculator\MyCalculator\bin\Debug\MyCalculator.exe");

            //Запуск тестируемой программы и тестирующей библиотеки
            windowsDriver = new WindowsDriver<WindowsElement>(
                    new Uri("http://127.0.0.1:4723"),
                    desiredCapabilities
                );

            //Временная задержка, для уверенности в том, что приложение успело запуститься
            System.Threading.Thread.Sleep(1000);

            //Получить доступ к элементам управления, объявленным на форме
            tb_a = windowsDriver.FindElementByAccessibilityId("tb_a");
            tb_b = windowsDriver.FindElementByAccessibilityId("tb_b");
            btn_Go = windowsDriver.FindElementByAccessibilityId("btn_Go");
            lb_Result = windowsDriver.FindElementByAccessibilityId("lb_Result");

        }

        [TestMethod]
        public void TestDivideApp_10on5()
        {
            tb_a.SendKeys("10");
            tb_b.SendKeys("5");
            btn_Go.Click();
            double res = Convert.ToDouble(lb_Result.Text);

            Assert.AreEqual(res,2);
        }

        [TestMethod]
        public void TestDivideApp_10on0()
        {
            tb_a.SendKeys("10");
            tb_b.SendKeys("0");
            btn_Go.Click();
            //double res = Convert.ToDouble(lb_Result.Text);

            Assert.AreEqual(lb_Result.Text, "ОШИБКА! Деление на ноль!");
        }

        [TestMethod]
        [DataRow("10","5","2")]
        [DataRow("10","0", "ОШИБКА! Деление на ноль!")]
        [DataRow("","1","ОШИБКА! Не все поля заполнены!")]
        [DataRow("", "", "ОШИБКА! Не все поля заполнены!")]
        [DataRow("1", "", "ОШИБКА! Не все поля заполнены!")]
        public void TestUniversal(string a, string b, string res)
        {
            tb_a.SendKeys(a);
            tb_b.SendKeys(b);
            btn_Go.Click();
            
            Assert.AreEqual(lb_Result.Text, res);
        }

        //DataDriven Unit Test
        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        //Строка соединения с базой данных. 
        //ВНИМАНИЕ! Укажите АБСОЛЮТНЫЙ путь к ФАКТИЧЕСКОМУ расположению базы данных на ВАШЕМ диске
        [DataSource(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Lect\20210130\MyAppiumTest\test_data.mdb", "tests")]
        [TestMethod]
        public void DataDriven()
        {
            //Получение тестовых значений (тестового множества) из базы данных
            string a = TestContext.DataRow["a"].ToString();
            string b = TestContext.DataRow["b"].ToString();
            string result = TestContext.DataRow["res"].ToString();

            //Имитация клавиатурного ввода
            tb_a.SendKeys(a);
            tb_b.SendKeys(b);
            //Имитация нажатия мышью на кнопку =
            btn_Go.Click();

            //Сравнение ожидаемого значения с фактическим
            Assert.AreEqual(result, lb_Result.Text, "A=[" + a + "] B=[" + b + "] RESULT=[" + result + "]");
        }

        [TestMethod]
        public void TestAlwaysSuccess()
        {
            //Пустой метод обрабатывается как успешный
            //ошибка возникает в случаях, предусмотренных методами класса Assert
            //или при возникновении каких-либо исключений в коде тестового метода
           // throw new Exception("My exception");
        }

        [TestCleanup]
        public void test_cleanup()
        {
            //Закрытие программы
            windowsDriver.Quit();
        }
    }
}
