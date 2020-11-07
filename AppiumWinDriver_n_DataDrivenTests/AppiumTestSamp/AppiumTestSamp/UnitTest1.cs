using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Remote;
using System.Threading;


namespace AppiumTestSamp
{
    [TestClass]
    public class UnitTest1
    {
        //---Это нужно для DataDriven тестов---
        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }
        //-------------[/]---------------------

        //Объявление интерфейсной переменной библиотеки Appium
        public static WindowsDriver<WindowsElement> winDriver;
        //Объявление переменных, которые будут связаны с элементами
        //управления тестируемого приложения.
        public static WindowsElement tb_a, tb_b, btn_Go, lb_Result;

        [TestInitialize]
        public void TestInit()
        {
            //Определение настроек библиотеки Appium WinAppDriver
            var desiredCapabilities = new AppiumOptions();

            //Прописывание пути к тестируемому приложению
            desiredCapabilities.AddAdditionalCapability("app", @"D:\Lect\20201106_PI\MyCalculator\MyCalculator\bin\Debug\MyCalculator.exe");

            //Инициализация интерфейсной переменной (собственно запуск библиотеки)
            winDriver = new WindowsDriver<WindowsElement>(
                    new Uri("http://127.0.0.1:4723"),
                    desiredCapabilities
                );

            //Ожидание в течение 1-й секунды
            //для уверенности в том, что форма тестируемого приложения точно уже открылась
            Thread.Sleep(1000);

            //Связывание элементов управления в окне запущенного тестируемого приложения
            //с переменными в коде теста.
            tb_a = winDriver.FindElementByAccessibilityId("tb_a");
            tb_b = winDriver.FindElementByAccessibilityId("tb_b");
            btn_Go = winDriver.FindElementByAccessibilityId("btn_Go");
            lb_Result = winDriver.FindElementByAccessibilityId("lb_Result");
        }

        [TestMethod]
        public void test_10_div_2_eq_5()
        {
            //Имитация клавиатурного ввода
            tb_a.SendKeys("10");
            tb_b.SendKeys("2");
            //Имитация нажатия мышью на кнопку =
            btn_Go.Click();
            //Получения результата вычислений из текстовой метки
            int result = Convert.ToInt32(lb_Result.Text);
            //Сравнение ожидаемого значения с фактическим
            Assert.AreEqual(5,result);
        }

        [TestMethod]
        public void test_10_div_0_eq_ex()
        {
            //Имитация клавиатурного ввода
            tb_a.SendKeys("10");
            tb_b.SendKeys("0");
            //Имитация нажатия мышью на кнопку =
            btn_Go.Click();
            
            //Сравнение ожидаемого значения с фактическим
            Assert.AreEqual("ОШИБКА! Деление на ноль!", lb_Result.Text);
        }

        //Строка соединения с базой данных. 
        //ВНИМАНИЕ! Укажите АБСОЛЮТНЫЙ путь к ФАКТИЧЕСКОМУ расположению базы данных на ВАШЕМ диске
        [DataSource(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Lect\20201106_PI\AppiumTestSamp\tests.mdb", "mytests")]
        [TestMethod]
        public void DataDriven()
        {
            //Получение тестовых значений (тестового множества) из базы данных
            string a = TestContext.DataRow["A"].ToString();
            string b = TestContext.DataRow["B"].ToString();
            string result = TestContext.DataRow["Result"].ToString();
            
            //Имитация клавиатурного ввода
            tb_a.SendKeys(a);
            tb_b.SendKeys(b);
            //Имитация нажатия мышью на кнопку =
            btn_Go.Click();

            //Сравнение ожидаемого значения с фактическим
            Assert.AreEqual(result, lb_Result.Text,"A=["+a+"] B=["+b+"] RESULT=["+result+"]");
        }

        //Действия после теста
        [TestCleanup]
        public void test_cleanup()
        {
            //закроем окно приложения
            winDriver.Quit();
        }
    }
}
