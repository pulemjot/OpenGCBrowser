using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using NUnit.Framework;

namespace OpenGCBrowser
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void OpenGC()
        {
            var myDriver = new ChromeDriver(@"C:\ChromeDriver");
            myDriver.Navigate().GoToUrl("http://stackoverflow.com/");
        }
    }
}
