using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProtectYourDataApi.Tests.ProtectYourDataApi.RunParameters
{
    public class RunParameters
    {
        public static string GetSetting(string settingName)
        {
            return TestContext.Parameters.Get(settingName);
        }

        public static string SelectUrl => GetSetting("BpLoginUrl");
    }
}
