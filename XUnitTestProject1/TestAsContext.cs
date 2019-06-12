using System;
using Xunit;
using TestDLL.DemoClasses;

namespace XUnitTestProject1
{
    public class TestAsContext: IDisposable
    {
        private Device _device;

        /**
         * The constructor and Dispose methods are called before and after every test method
         * Does not share the instance among all unit tests
             */
        public TestAsContext()
        {
            _device = new Device("UnitTest-1");
        }
        public void Dispose()
        {
            _device = null;
        }

        // Fact is the test method without arguments
        [Fact]
        // Category is default. Trait is used for grouping by Category. The Custom categories can be also extended
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
