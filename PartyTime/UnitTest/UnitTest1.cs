using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PartyTime.Core;
using PartyTime.Infastructure;
using System;
using System.Threading.Tasks;

namespace UnitTest
{

    [TestClass]
    public class MemoryDBTest
    {
        //IUserService userService;
        //public MemoryDBTest(IUserService userService)
        //{
        //    this.userService = userService;
        //}
      
        [TestMethod]
        public async Task AddUser()
        {
            var options = new DbContextOptionsBuilder<ApplicationContext>()
            .UseInMemoryDatabase(databaseName: "Add_writes_to_database")
            .Options;

            // Run the test against one instance of the context
            using (var context = new ApplicationContext(options))
            {
                //var userRepository = new Mock<IRepository<User>>();
                //var userService = new UserService(mockRepository.Object);

                var userRepository = new Repository<User>(context);
                var userService = new UserService(userRepository);
                await userService.RegisterAsync(Guid.NewGuid(),"aaa@wp.pl","dzida","dz2","imba","12345","55555555");
                //context.Add(new User(Guid.NewGuid(), "aaa@wp.pl", "dzida", "dz2", "imba", "12345", "55555555"));
                //context.SaveChanges();
            }

            // Use a separate instance of the context to verify correct data was saved to database
            using (var context = new ApplicationContext(options))
            {
                Assert.AreEqual(1,await context.Users.CountAsync());
                //Assert.AreEqual("http://sample.com", context.Blogs.Single().Url);
            }
        }
    }
}
