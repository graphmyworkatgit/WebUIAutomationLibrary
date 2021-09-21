using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using WebUIAutomationLibrary.Base;
using WebUIAutomationLibrary.Constants;
using WebUIAutomationLibrary.Flows.Interfaces;

namespace WebUIAutomationLibrary.Flows.Wix
{
    public class BaseWixSite : IFlows
    {
        public void staticLaunchSite()
        {
            StaticdriverFactory.driver.Navigate().GoToUrl(WixConstants.Url);
            Thread.Sleep(4000);
        }
        [OneTimeTearDown]
        public void CloseBrowser()
        {
            StaticdriverFactory.driver.Quit();
        }

        public void LaunchSite()
        {
             new driverFactory().driver.Navigate().GoToUrl(WixConstants.Url);
            Thread.Sleep(4000);
        }
    }
}
