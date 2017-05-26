using Google.Apis.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Google.Apis.Tests.Services
{
    public class BaseClientServiceTests
    {
        [Fact]
        public void ValidApplicationName()
        {
            new BaseClientService.Initializer
            {
                ApplicationName = "AppName"
            };
        }

        [Fact]
        public void NullApplicationName()
        {
            new BaseClientService.Initializer
            {
                ApplicationName = null
            };
        }

        [Fact]
        public void InvalidApplicationName()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                new BaseClientService.Initializer
                {
                    ApplicationName = "AppName = a name"
                };
            });
        }
    }
}
