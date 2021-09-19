using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Net;
using System.Text;

namespace WebUIAutomationLibrary.BrowserStack
{
    public class BrowserFactory
    {
        public static RemoteWebDriver driver;
        public static RemoteWebDriver CreateLocalChrome(bool maximize)
        {
            ChromeDriver chromeDriver;
            var ChromeOptionsType = "0";
            try
            {
                NameValueCollection appSetting = 
                    ConfigurationManager.GetSection("appSettings") as NameValueCollection;
                ChromeOptionsType = 
                    string.IsNullOrEmpty(appSetting["ChromeWithOptions"]) ? 
                    "0" 
                    : appSetting["ChromeWithOptions"];
            }
            catch (Exception e)
            {

                throw;
            }

            if (ChromeOptionsType.Equals("1"))
            {
                ChromeOptions options = new ChromeOptions();
                options.AddArgument("no-sandbox");
                chromeDriver = new ChromeDriver();
            }
            else
            {
                chromeDriver = new ChromeDriver();
            }

            if (maximize) chromeDriver.Manage().Window.Maximize();
            chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(180);
            chromeDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(180);

            return chromeDriver;
        }


        public static RemoteWebDriver CreateLocalIE(bool maximize)
        {
            InternetExplorerDriver iedriver = new InternetExplorerDriver();
            if (maximize) iedriver.Manage().Window.Maximize();
            IJavaScriptExecutor js = (IJavaScriptExecutor)iedriver;
            js.ExecuteScript("document.body.style.zoom='100%'");
            InternetExplorerOptions ieoption = new InternetExplorerOptions();
            ieoption.BrowserCommandLineArguments = "-private";
            ieoption.AddAdditionalCapability("silent", true);
            ieoption.AddAdditionalCapability("browserstack.ie.enablePopups", "true");
            ieoption.AddAdditionalCapability("disable-popup-blocking", "true");
            ieoption.IgnoreZoomLevel = true;
            ieoption.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
            // Set max global timeout
            iedriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(180);
            // Set Page Load timeout to 180 seconds
            iedriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(180);

            return iedriver;
        }

        /// <summary>
        /// return chrome driver
        /// </summary>
        /// <param name="maximize"></param>
        /// <returns></returns>
        public static RemoteWebDriver CreateChrome(bool maximize)
        {
            if (Uri == null) throw new WebException("Selenium server is not avilable.");

            ChromeOptions options = new ChromeOptions();
            options.AddArgument("no-sandbox");
            if (maximize) options.AddArgument("--start-maximized");
            //RemoteWebDriver tdriver = new RemoteWebDriver(new Uri("http://10.59.117.95:4444/wd/hub"), options);
            RemoteWebDriver tdriver = new RemoteWebDriver(uri, options);
            //tdriver.Manage().Cookies.DeleteAllCookies();
            // Set max global timeout
            tdriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(180);
            // Set Page Load timeout to 180 seconds
            tdriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(180);

            return tdriver;
        }

        /// <summary>
        /// return ie driver
        /// </summary>
        /// <param name="maximize"></param>
        /// <returns></returns>
        public static RemoteWebDriver CreateIE(bool maximize)
        {
            if (uri == null) throw new WebException("Selenium server is not avilable.");

            InternetExplorerOptions ieoption = new InternetExplorerOptions();
            //ieoption.ForceCreateProcessApi = true;
            ieoption.BrowserCommandLineArguments = "-private";
            ieoption.AddAdditionalCapability("silent", true);
            ieoption.AddAdditionalCapability("browserstack.ie.enablePopups", "true");
            ieoption.AddAdditionalCapability("disable-popup-blocking", "true");
            ieoption.IgnoreZoomLevel = true;
            ieoption.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
            //RemoteWebDriver iedriver = new RemoteWebDriver(uri, ieoption);
            RemoteWebDriver iedriver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), ieoption);
            if (maximize) iedriver.Manage().Window.Maximize();
            IJavaScriptExecutor js = (IJavaScriptExecutor)iedriver;
            js.ExecuteScript("document.body.style.zoom='100%'");
            // Set max global timeout
            iedriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(180);
            // Set Page Load timeout to 180 seconds
            iedriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(180);

            return iedriver;
        }

        public static RemoteWebDriver CreateFireFox(bool maximize)
        {
            //if (uri == null) throw new WebException("Selenium server is not avilable.");

            //FirefoxOptions option = new FirefoxOptions();
            //RemoteWebDriver driver = new RemoteWebDriver(uri, option);
            //if (maximize) driver.Manage().Window.Maximize();
            //// Set max global timeout
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(180);
            //// Set Page Load timeout to 180 seconds
            //driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(180);

            return driver;
        }

    }
}
