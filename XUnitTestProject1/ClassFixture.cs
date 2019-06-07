using System;
using System.Collections.Generic;
using System.Text;
using TestDLL.DemoClasses;
using Xunit;

namespace XUnitTestProject1
{
    // to share an instance among all tests
    public class ClassFixture : IDisposable
    {
        public Device device {set; get;}
        public ClassFixture()
        {
            device = new Device("Shared-1");
        }

        public void Dispose()
        {
            device = null;
        }
    }

    public class DeviceTests : IClassFixture<ClassFixture>
    {
        //ClassFixture Fixture;
        //public DeviceTests(ClassFixture fixture)
        //{
        //    this.Fixture = fixture;
        //}

        //[Fact]
        //public void CountTest1 ()
        //{
        //    var device = this.Fixture.device;
        //    device.IncCount();
        //    Assert.Equal(1, device.GetCount());
        //}

        //[Fact]
        //public void CountTest2 ()
        //{
        //    var device = this.Fixture.device;
        //    device.IncCount();
        //    Assert.Equal(2, device.GetCount());
        //}

        [Fact]
        public void DefaultTest()
        {
            Assert.True(true);
        }
    }
}
