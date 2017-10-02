
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;

using Xunit;
using PartyTime;
using System.Text;
using Newtonsoft.Json;

namespace FuncionalTest
{
    public class UserControllerTest
    {

        private readonly HttpClient _client;
        private readonly HttpMessageHandler _handler;

        public UserControllerTest()
        {
            var builder = new WebHostBuilder()
                .UseStartup<Startup>();
            var server = new TestServer(builder);

            _handler = server.CreateHandler();
            _client = server.CreateClient();
        }

        //private readonly TestServer _server;
        //private readonly HttpClient _client;
        //public UserControllerTest()
        //{
        //    // Arrange
        //    _server = new TestServer(new WebHostBuilder()
        //        .UseStartup<Startup>());
        //    _client = _server.CreateClient();
        //}
        [Fact]
        public async Task TestRegisterUser()
        {
            //Assing
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject("test"), Encoding.UTF8, "application/json");
            //Act
            var response = await _client.PostAsync("api/values/register", stringContent);
            var content = await response.Content.ReadAsStringAsync();
            //Assert
            response.EnsureSuccessStatusCode();
           // Assert.NotEmpty(content);
            

        }
    }
}
