using Autofac.Extras.Moq;
using Moq;
using Moq.Protected;
using OpenWeatherAPI;
using System;
using System.Threading.Tasks;
using Xunit;

namespace OpenWeatherAPITests
{
    public class OpenWeatherProcessorTests
    {
        [Fact]
        public void GetOneCallAsync_IfApiKeyEmptyOrNull_ThrowArgumentException()
        {


            var mock = new Mock<OpenWeatherProcessor>();

            mock.Setup(x => x.GetOneCallAsync());
 
            //Arrange
            OpenWeatherProcessor.Instance.ApiKey = "";
  

            Assert.ThrowsAsync<ArgumentException>(() => Task.Run(() => mock.Object.GetOneCallAsync()));
            
        }
    }
}
