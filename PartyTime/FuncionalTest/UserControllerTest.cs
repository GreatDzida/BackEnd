
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;

using Xunit;
using PartyTime;
using System.Text;
using Newtonsoft.Json;
using PartyTime.Core;
using System;
using Microsoft.EntityFrameworkCore;
using PartyTime.Infastructure;
using FluentAssertions;

namespace FuncionalTest
{
    public class UserControllerTest
    {

        private readonly TestServer _server;
        private readonly HttpClient _client;
        public UserControllerTest()
        {
            // Arrange
            _server = new TestServer(new WebHostBuilder()
                .UseStartup<Startup>());
            _client = _server.CreateClient();
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
        public async Task register_user_post()
        {
            var options = new DbContextOptionsBuilder<ApplicationContext>()
           .UseInMemoryDatabase(databaseName: "Add_writes_to_database")
           .Options;

            // Run the test against one instance of the context
            using (var context = new ApplicationContext(options))
            {

                User user = new User(Guid.NewGuid(), "Piotr", "Kowalski", "p@kowaliski.pl", "23454334", "pdziura", "ZAQ!@");
                StringContent stringContent = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");
                //Act
                var response = await _client.PostAsync("api/user", stringContent);
                var content = await response.Content.ReadAsStringAsync();
                //Assert
                content.Should().BeEmpty();
                response.EnsureSuccessStatusCode();
                //var userRepository = new Repository<User>(context);
                //var userService = new UserService(userRepository);
                //await userService.RegisterAsync(Guid.NewGuid(), "aaa@wp.pl", "dzida", "dz2", "imba", "12345", "55555555");

            }

            //Assing
            
           // Assert.NotEmpty(content);
            

        }
    }
}
