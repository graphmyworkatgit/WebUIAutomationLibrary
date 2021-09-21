using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebUIAutomationLibrary.Base
{
    public static class WebActions
    {
        public static bool IsELementDisplayed(IWebDriver driver, By strings)
        {
            return driver.FindElement(strings).Displayed;
        }

        public static bool Click(IWebDriver driver, By strings)
        {
            return driver.FindElement(strings).Displayed;
        }

        public static bool ClickAt(IWebDriver driver, By strings)
        {
            return driver.FindElement(strings).Displayed;
        }
        public static bool ClickUsingJs(IWebDriver driver, By strings)
        {
            return driver.FindElement(strings).Displayed;
        }

    }
}
