using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace langton
{
    public class Program
    {
        private static IWebDriver? driver;

        static void Main(string[] args)
        {
            Setup();
            RunTests();
            Cleanup();
        }

        static void Setup()
        {
            // Initialize the ChromeDriver
            driver = new ChromeDriver();
        }

        static void RunTests()
        {
            JavaScriptAlertsTests testClass = new JavaScriptAlertsTests();

            testClass.Setup();
            testClass.AcceptAlert();
            testClass.DismissAlert();
            testClass.EnterTextInPrompt();
            testClass.Cleanup();
        }

        static void Cleanup()
        {
            // Quit the driver and clean up resources
            driver.Quit();
        }
    }
}
