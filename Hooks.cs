using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;

namespace SeleniumParallelTest
{
    public enum BrowserType
    {
        Chrome,
        Firefox,
        Edge
    } 

    [TestFixture]
    public class Hooks : Base
    {
        private BrowserType _browserType;
        public Hooks(BrowserType browser)
        {
            _browserType = browser;
        }

        [SetUp]
        public void InitializeTest()
        {
            ChooseDriverInstance(_browserType);
        }

        private void ChooseDriverInstance(BrowserType browserType) 
        {
            if (browserType == BrowserType.Chrome)
            {
                Driver = new ChromeDriver(Helpers.Path + "netcoreapp2.1");
            }
            else if (browserType == BrowserType.Firefox)
            {
                Driver = new FirefoxDriver(Helpers.Path + "netcoreapp2.1");
            }
            else if (browserType == BrowserType.Edge)
            {
                Driver = new EdgeDriver(Helpers.Path + "netcoreapp2.1");
            }
        }
    }
}