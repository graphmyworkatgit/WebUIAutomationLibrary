using System;
using System.Collections.Generic;
using System.Text;
using WebUIAutomationLibrary.Flows.Interfaces;
using NUnit.Framework;
using WebUIAutomationLibrary.Constants;
using WebUIAutomationLibrary.Base;
using System.Threading;

namespace WebUIAutomationLibrary.Flows.Google
{
    public class BaseGoogle:IFlows
    {
        public BaseGoogle()
        {
            
        }
        
        public void staticLaunchSite()
        {
            StaticdriverFactory.driver.Navigate().GoToUrl(GoogleConstants.Url);
            Thread.Sleep(10000);
        }

        [OneTimeTearDown]
        public void CloseBrowser()
        {
            StaticdriverFactory.driver.Quit();
        }

        public void LaunchSite()
        {
            new driverFactory().driver.Navigate().GoToUrl(GoogleConstants.Url);
        }
    }
}
