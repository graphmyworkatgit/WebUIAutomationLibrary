using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using WebUIAutomationLibrary.Base;
using WebUIAutomationLibrary.Flows.Google;
using WebUIAutomationLibrary.Flows.Google.PageActions;
using WebUIAutomationLibrary.Flows.Wix;

namespace WebUIAutomationLibrary.Tests
{
    [TestFixture]
    public class Wixer:BaseWixSite
    {
        [Test,Category("WixTests"), Category("ParallelTests")]
        public void TestLaunchUrl()
        {
            LaunchSite();
        }
        [Test, Category("WixTests"), Category("ParallelTests")]
        public void StaticTestLaunchUrl()
        {
            staticLaunchSite();
        }

    }
}
