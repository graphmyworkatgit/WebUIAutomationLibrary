using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebUIAutomationLibrary.Base
{
    public class StaticdriverFactory
    {
        public static IWebDriver driver = new ChromeDriver();

    }
    public class driverFactory
    {
        public IWebDriver driver;

        public driverFactory()
        {
            driver= new ChromeDriver();
        }
        

    }
}
