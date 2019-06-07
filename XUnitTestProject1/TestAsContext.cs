using System;
using Xunit;
using TestDLL.DemoClasses;

namespace XUnitTestProject1
{
    public class TestAsContext
    {
        private Device _device;
        private string _testName;
        public TestAsContext()
        {
            _device = new Device("UnitTest-1");
        }

        [Fact]
        [Trait("Category", "Inc")]
        public void Test1()
        {
            _device.IncCount();
            _device.IncCount();
            Assert.Equal("UnitTest-1", _device.Name);
            Assert.Equal(2, _device.GetCount() );
        }

        [Fact]
        [Trait("Category", "Inc")]
        public void Test2()
        {
            _device.IncCount();
            Assert.Equal(1, _device.GetCount() );
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [Trait("Category", "Set")]
        public void Test3(int count)
        {
            _device.Count = count;
                Assert.Equal(count, _device.GetCount());
        }
    }
}
