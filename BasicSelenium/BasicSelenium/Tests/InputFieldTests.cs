using BasicSelenium.Pabes;
using BasicSelenium.Utils;
using NUnit.Framework;
using OpenQA.Selenium;

namespace BasicSelenium
{
    public class InputFieldTests
    {
        private IWebDriver driver;
        private InputDemoPage inputDemoPage;

        [SetUp]
        public void Setup()
        {
            driver = new Driver().Init();
            driver.Url = "https://www.seleniumeasy.com/test/basic-first-form-demo.html";
            inputDemoPage = new InputDemoPage(driver);
        }

        [Test]
        public void Test1()
        {
            var userMessage = "Test message";
            inputDemoPage
                .EnterText(userMessage)
                .ClickShowMessage();

            Assert.AreEqual(userMessage, inputDemoPage.GetUserMessage());
        }

        [TearDown]
        public void AfterTest()
        {
            driver.Quit();
        }
    }
}