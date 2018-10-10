using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;

namespace SeleniumTests
{

    [TestFixture]
    [Parallelizable]
    public class FireFox : Hooks
    {
        public FireFox() : base(BrowserType.Firefox)
        {
        }

        [Test]
        public void GoogleTest()
        {
            Driver.Navigate().GoToUrl("http://www.google.com");
            Thread.Sleep(2000);
        }
        [Test]
        public void FacebookTest()
        {
            Driver.Navigate().GoToUrl("http://www.facebook.com");
            Thread.Sleep(2000);
        }
        [TearDown]
        public void CloseDriver()
        {
            Driver.Close();
            Driver.Quit();
        }

    }

    [TestFixture]
    [Parallelizable]
    public class Chrome : Hooks
    {
        public Chrome() : base(BrowserType.Chrome)
        {
        }

        [Test]
        public void GoogleTest()
        {
            Driver.Navigate().GoToUrl("http://www.google.com");
            Thread.Sleep(2000);
        }
        [Test]
        public void FacebookTest()
        {
            Driver.Navigate().GoToUrl("http://www.facebook.com");
            Thread.Sleep(2000);
        }
        [TearDown]
        public void CloseDriver()
        {
            Driver.Close();
            Driver.Quit();
        }
        
    }

    [TestFixture]
    [Parallelizable]
    public class Edge : Hooks
    {
        public Edge() : base(BrowserType.Edge)
        {
        }

        [Test]
        public void GoogleTest()
        {
            Driver.Navigate().GoToUrl("http://www.google.com");
            Thread.Sleep(2000);
        }
        [Test]
        public void FacebookTest()
        {
            Driver.Navigate().GoToUrl("http://www.facebook.com");
            Thread.Sleep(2000);
        }
        [TearDown]
        public void CloseDriver()
        {
            Driver.Close();
            Driver.Quit();
        }
    }


}
