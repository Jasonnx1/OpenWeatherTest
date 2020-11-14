using Moq;
using OpenWeatherAPI;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Tests
{
    public class OpenWeatherProcessorTests
    {
        [Fact]
        public void GetOneCallAsync_IfApiKeyEmptyOrNull_ThrowArgumentException()
        {

            var mock = new Mock<OpenWeatherProcessor>();

            OpenWeatherProcessor.Instance.ApiKey = "";

            Assert.ThrowsAsync<ArgumentException>(() => Task.Run(() => mock.Object.GetOneCallAsync()));

        }

        [Fact]
        public void GetCurrentWeatherAsync_IfApiKeyEmptyOrNull_ThrowArgumentException()
        {
            var mock = new Mock<OpenWeatherProcessor>();

            OpenWeatherProcessor.Instance.ApiKey = "";


            Assert.ThrowsAsync<ArgumentException>(() => Task.Run(() => mock.Object.GetCurrentWeatherAsync()));
        }

        [Fact]
        public void GetOneCallAsync_IfApiHelperNotInitialized_ThrowArgumentException()
        {
            var mock = new Mock<OpenWeatherProcessor>();

            ApiHelper.ApiClient = null;

            Assert.ThrowsAsync<ArgumentException>(() => Task.Run(() => mock.Object.GetOneCallAsync()));
        }

        [Fact]
        public void GetCurrentWeatherAsync_IfApiHelperNotInitialized_ThrowArgumentException()
        {
            var mock = new Mock<OpenWeatherProcessor>();

            ApiHelper.ApiClient = null;

            Assert.ThrowsAsync<ArgumentException>(() => Task.Run(() => mock.Object.GetCurrentWeatherAsync()));
        }


    }
}
