using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using WebUIAutomationLibrary.Base;
using WebUIAutomationLibrary.Flows.Google;
using WebUIAutomationLibrary.Flows.Google.PageActions;

namespace WebUIAutomationLibrary.Tests
{
    [TestFixture]
    public class Googler:BaseGoogle
    {
        [Test,Category("GoogleTests"), Category("ParallelTests")]
        public void TestLaunchUrl()
        {
            LaunchSite();
        }

        [Test, Category("GoogleTests2"), Category("ParallelTests")]
        public void TestLaunchUrl2()
        {
            LaunchSite();
        }


    }
}
