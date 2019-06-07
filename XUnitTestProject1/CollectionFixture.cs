using System;
using System.Collections.Generic;
using System.Text;
using TestDLL.DemoClasses;
using Xunit;

namespace XUnitTestProject1
{
    public class CollectionFixture : IDisposable
    {
        public Device CountDevice {private set; get;}

        public CollectionFixture()
        {
            CountDevice = new Device(" Device in the Collection Fixture");
        }

        public void Dispose()
        {
            CountDevice = null;
        }
    }

    //Collection Definition - the class does not have any code inside it

    [CollectionDefinition("IntegratedCollectionTests")]
    public class Collection : ICollectionFixture<CollectionFixture>
    {

    }

    [Collection("IntegratedCollectionTests")]
    public class CollectionTests1 
    {
        Device CountDevice;
        public CollectionTests1(CollectionFixture fixture)
        {
            this.CountDevice = fixture.CountDevice;
        }

        [Theory]
        [InlineData(987)]
        [Trait("Category", "CollectionTests")] 
        public void Test1(int count)
        {
            CountDevice.Count = count;
            Assert.True(true);
        }

        [Fact]
        [Trait("Category", "CollectionTests")]
        public void Test2()
        {
            Assert.Equal(987, CountDevice.GetCount());
        }
    }
}
