using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace MyWebTest
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver browser;
        IWebElement tb_a, tb_b, btn_Go, lb_Result;

        [TestInitialize]
        public void TestInitialize()
        {
            browser = new OpenQA.Selenium.Chrome.ChromeDriver();
            //Открыть в браузере тестируемую страницу
            browser.Navigate().GoToUrl("http://localhost:9663/MyCalcWeb.aspx");

            //Временная задержка на 3 сек для уверенности в том, что веб-страница была загружена
            System.Threading.Thread.Sleep(3000);

            //Получение доступа к элементам управления на тестируемой странице
            tb_a = browser.FindElement(By.Id("tb_a"));
            tb_b = browser.FindElement(By.Id("tb_b"));
            btn_Go = browser.FindElement(By.Id("Button1"));
            

        }

        [TestMethod]
        public void TestMethod1()
        {
            tb_a.SendKeys("10");
            tb_b.SendKeys("5");
            btn_Go.Click();

            //Временная задержка на 3 сек для уверенности в том, что веб-страница была перезагружена
            System.Threading.Thread.Sleep(3000);

            //Те элементы, с которых предполагается считать значение после перезагрузки (постбэка)
            //- например после нажатия на кнопку на странице (если обработчик события нажатия находится на сервере - другими словами написан на C# или PHP)
            lb_Result = browser.FindElement(By.Id("lb_Result"));
            Assert.AreEqual("2",lb_Result.Text);
        }
    }
}
