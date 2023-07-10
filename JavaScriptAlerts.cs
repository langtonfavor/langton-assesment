using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace langton
{
    [TestFixture]
    public class JavaScriptAlertsTests
    {
        private IWebDriver? driver;

        [SetUp]
        public void Setup()
        {
            // Initialize the ChromeDriver
            driver = new ChromeDriver();
        }

        [Test]
        public void AcceptAlert()
        {
           driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/javascript_alerts");

          // Find and click the "Click for JS Alert" button
          IWebElement alertButton = driver.FindElement(By.XPath("//button[text()='Click for JS Alert']"));
          alertButton.Click();

          // Switch to the alert and accept it
          IAlert alert = driver.SwitchTo().Alert();
          string alertText = alert.Text; // For debugging/logging
          alert.Accept();

          // Verify the result text
          IWebElement result = driver.FindElement(By.Id("result"));

          Assert.AreEqual("You successfully clicked an alert", result.Text);

        }

        [Test]
        public void DismissAlert()
        {
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/javascript_alerts");

            // Find and click the "Click for JS Confirm" button
            IWebElement confirmButton = driver.FindElement(By.XPath("//button[text()='Click for JS Confirm']"));
            confirmButton.Click();

            // Switch to the confirm dialog and dismiss it
            IAlert confirm = driver.SwitchTo().Alert();
            confirm.Dismiss();

            // Verify the result text
            IWebElement result = driver.FindElement(By.Id("result"));
            Assert.AreEqual("You clicked: Cancel", result.Text);
        }

        [Test]
        public void EnterTextInPrompt()
        {
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/javascript_alerts");

            // Find and click the "Click for JS Prompt" button
            IWebElement promptButton = driver.FindElement(By.XPath("//button[text()='Click for JS Prompt']"));
            promptButton.Click();

            // Switch to the prompt dialog, enter text, and accept it
            IAlert prompt = driver.SwitchTo().Alert();
            prompt.SendKeys("Entering Text in Prompt");
            prompt.Accept();

            // Verify the result text
            IWebElement result = driver.FindElement(By.Id("result"));
            Assert.AreEqual("You entered: Entering Text in Prompt", result.Text);
        }

        [TearDown]
        public void Cleanup()
        {
            // Quit the driver and clean up resources
            driver.Quit();
        }
    }
}
