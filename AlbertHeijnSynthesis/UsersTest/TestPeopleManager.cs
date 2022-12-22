using BusinessLayer;
using DBlayer;
using DBlayer.Interfaces;
using LogicLayer;
using LogicLayer.Exceptions;
using Moq;

namespace UsersTest
{
    [TestClass]
    public class TestPeopleManager
    {
       


        private readonly Mock<IPersonDB> mockPersonDB;
        private readonly PeopleManager peopleManager;

        public TestPeopleManager()
        {

            mockPersonDB = new Mock<IPersonDB>();
            var users = new List<User>
        {
            new User { Id = 1, Name = "User 1", Username = "user1" },
            new User { Id = 2, Name = "User 2", Username = "user2" },
            new User { Id = 3, Name = "User 3", Username = "user3" }
        };
            mockPersonDB.Setup(x => x.ReadUser()).Returns(users);


            peopleManager = new PeopleManager(mockPersonDB.Object);
        }
        [TestMethod]
        public void GetLoggedInUser_InputIsFound_ReturnsMatchingUser()
        {

            var result = peopleManager.GetLoggedInUser("user3");


            Assert.IsNotNull(result);


            Assert.AreEqual(result.Id, 3);
            Assert.AreEqual(result.Name, "User 3");
            Assert.AreEqual(result.Username, "user3");
        }
        [TestMethod]
        public void GetLoggedInUser_InputIsNotFound_ReturnsNull()
        {

            var result = peopleManager.GetLoggedInUser("user4");


            Assert.IsNull(result);
        }
        [TestMethod]
        public void AddUser_InputIsValid_AddsUserToList()
        {
           
            var mockPersonDB = new Mock<IPersonDB>();
            var users = new List<User>();
            User user1 = new User
            {
                Name = "mido",
                Surname = "ramie",
                Username = "mido333",
                Password = "password123"
            };
            users.Add(user1);
            User user2 = new User
            {
                Name = "jane",
                Surname = "doe",
                Username = "jane123",
                Password = "password456"
            };

            mockPersonDB.Setup(x => x.ReadUser()).Returns(users);
          

            
            var peopleManager = new PeopleManager(mockPersonDB.Object);

          
              peopleManager.AddUser(user2);
            var result  = peopleManager.ReadUser();

          
            Assert.AreEqual(result[1],user2);
            
        }

        [TestMethod]
        public void AddUser_InputIsValid_AddsUserToList_returnFalse()
        {
          
            var mockPersonDB = new Mock<IPersonDB>();
            var users = new List<User>();
            User user1 = new User
            {
                Name = "mido",
                Surname = "ramie",
                Username = "mido333",
                Password = "password123"
            };
            users.Add(user1);
            User user2 = new User
            {
                Name = "jane",
                Surname = "doe",
                Username = "jane123",
                Password = "password456"
            };

            mockPersonDB.Setup(x => x.ReadUser()).Returns(users);
           

          
            var peopleManager = new PeopleManager(mockPersonDB.Object);
            bool expectedResult = true;

            try
            {
                var result = peopleManager.AddUser(user1);
            }
            catch (UserNameIsExistException e)
            {
                Assert.AreEqual(e.Message, "the username is already taken");
            }

        }

        [TestMethod]
        public void IsUserTaken()
        {
           
            var mockPersonDB = new Mock<IPersonDB>();
            var users = new List<User>();
            User user1 = new User
            {
                Name = "mido",
                Surname = "ramie",
                Username = "mido333",
                Password = "password123"
            };
            users.Add(user1);
            mockPersonDB.Setup(x => x.ReadUser()).Returns(users);

         
            var peopleManager = new PeopleManager(mockPersonDB.Object);
           

           
            string username = "mido333";
            
            bool expectedResult = true;
          
try
            {
                var result = peopleManager.AddUser(user1);
            }
            catch (UserNameIsExistException e)
            {
                Assert.AreEqual(e.Message, "the username is already taken");
            }


        }

        [TestMethod]
        public void IsUserTaken_returnFalseWhenUserNotExist()
        {

            var mockPersonDB = new Mock<IPersonDB>();
            var users = new List<User>();
            User user1 = new User
            {
                Name = "mido",
                Surname = "ramie",
                Username = "mido333",
                Password = "password123"
            };
            users.Add(user1);
            mockPersonDB.Setup(x => x.ReadUser()).Returns(users);


            var peopleManager = new PeopleManager(mockPersonDB.Object);



            string username = "sami454";

           

          
                var result = peopleManager.IsUsernameTaken(username);
          
                Assert.IsFalse(result);
            


        }
        [TestMethod]
        public void IsUsernameTaken_InputIsNotTaken_ReturnsFalse()
        {
           
            var mockPersonDB = new Mock<IPersonDB>();
            var users = new List<User>();
            User user1 = new User
            {
                Name = "mido",
                Surname = "ramie",
                Username = "mido333",
                Password = "password123"
            };
            users.Add(user1);
            mockPersonDB.Setup(x => x.ReadUser()).Returns(users);

            var peopleManager = new PeopleManager(mockPersonDB.Object);

          
            string username = "mido334";

           
            bool result = peopleManager.IsUsernameTaken(username);

            Assert.IsFalse(result);
        }
        [TestMethod]
        public void LoginUser_InputIsValid_ReturnsTrue()
        {
           
            var mockPersonDB = new Mock<IPersonDB>();
            var users = new List<User>();
            User user1 = new User
            {
                Name = "mido",
                Surname = "ramie",
                Username = "mido333",
                Password = "jqMrQLX9EZUQhP1gvGv5w5+cnZRppmP8vHqx7hTv3HOFs75/a2OWvBtedp07iOhi4hkQJcJXnfVtfUw7+RWKMQ==",
                Salt = "3wpIHa8m/8Q2y3JeBa5DUw=="
            };
            users.Add(user1);
            mockPersonDB.Setup(x => x.ReadUser()).Returns(users);

           
            var peopleManager = new PeopleManager(mockPersonDB.Object);
           

          
            string username = "mido333";
            string password = "99999";

           
            bool result = peopleManager.LoginUser(username, password);

            
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void LoginUser_InputIsValid_ReturnsFalse()
        {
           
            var mockPersonDB = new Mock<IPersonDB>();
            var users = new List<User>();
            User user1 = new User
            {
                Name = "mido",
                Surname = "ramie",
                Username = "mido333",
                Password = "jqMrQLX9EZUQhP1gGv5w5+cnZRppmP8vHqx7hTv3HOFs75/a2OWvBtedp07iOhi4hkQJcJXnfVtfUw7+RWKMQ==",
                Salt = "3wpIHa8m/8Q2y3JeBa5DUw=="
            };
            users.Add(user1);
            mockPersonDB.Setup(x => x.ReadUser()).Returns(users);


            var peopleManager = new PeopleManager(mockPersonDB.Object);



            string username = "mido333";
            string password = "99999";


            bool result = peopleManager.LoginUser(username, password);


            Assert.IsFalse(result);
        }
        [TestMethod]
        public void UpdateUserList()
        {
            
            var mockPersonDB = new Mock<IPersonDB>();
            var users = new List<User>();
            User user1 = new User
            {
                Name = "mido",
                Surname = "ramie",
                Username = "mido333",
                Password = "jqMrQLX9EZUQhP1gGv5w5+cnZRppmP8vHqx7hTv3HOFs75/a2OWvBtedp07iOhi4hkQJcJXnfVtfUw7+RWKMQ==",
                Salt = "3wpIHa8m/8Q2y3JeBa5DUw=="
            };
            users.Add(user1);
            mockPersonDB.Setup(x => x.ReadUser()).Returns(users);


            var peopleManager = new PeopleManager(mockPersonDB.Object);



        


            var result = peopleManager.ReadUser();

            Assert.AreEqual( result.Count,1);
        }




        }
}





