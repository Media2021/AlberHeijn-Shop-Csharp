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
            mockPersonDB.Setup(x => x.ReadUser()).Returns(new List<User>());
            peopleManager = new PeopleManager(mockPersonDB.Object);
        }
        [TestMethod]
        public void GetLoggedInUser_InputIsFound_ReturnsMatchingUser()
        {
            //arrange/
            var peopleManager = new PeopleManager(mockPersonDB.Object);
            User user2 = new User
            {
                Name = "jane",
                Surname = "doe",
                Username = "jane123",
                Password = "password456"
            };
            //act/
            peopleManager.AddUser(user2);

            var result = peopleManager.GetLoggedInUser("jane123");

            //assert/
            Assert.IsNotNull(result);

            Assert.AreEqual(result.Name, "jane");
            Assert.AreEqual(result.Username, "jane123");
        }
        [TestMethod]
        public void GetLoggedInUser_InputIsNotFound_ReturnsNull()
        {
            var result = peopleManager.GetLoggedInUser("user4");
            Assert.IsNull(result);
        }


        [TestMethod]
        public void AddUser_InputIsValid_AddsUserToList_returnFalse()
        {
            //arrange/

            var peopleManager = new PeopleManager(mockPersonDB.Object);
            
            User user1 = new User
            {
                Name = "mido",
                Surname = "ramie",
                Username = "mido333",
                Password = "password123"
            };
            //act/
            peopleManager.AddUser(user1);
         

            try
            {
                 peopleManager.AddUser(user1);
            }
            catch (UserNameIsExistException e)
            {
                //assert/
                Assert.AreEqual(e.Message, "the username is already taken");
            }

        }

        [TestMethod]
        public void IsUserTaken()
        {
           
          
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

            try
            {
              peopleManager.AddUser(user1);
            }
            catch (UserNameIsExistException e)
            {
                Assert.AreEqual(e.Message, "the username is already taken");
            }


        }

        [TestMethod]
        public void IsUserTaken_returnFalseWhenUserNotExist()
        {

            
            var users = new List<User>();
            User user1 = new User
            {
                Name = "mido",
                Surname = "ramie",
                Username = "mido333",
                Password = "password123"
            };
            users.Add(user1);
            var peopleManager = new PeopleManager(mockPersonDB.Object);
            mockPersonDB.Setup(x => x.ReadUser()).Returns(users);
            string username = "sami454";

                var result = peopleManager.IsUsernameTaken(username);
          
                Assert.IsFalse(result);
            


        }
        [TestMethod]
        public void IsUsernameTaken_InputIsNotTaken_ReturnsFalse()
        {
           
         
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


        [TestMethod]
        public void AddUser_InputIsValid_AddsUserToList1()
        {

            var peopleManager = new PeopleManager(mockPersonDB.Object);
            User user2 = new User
            {
                Name = "jane",
                Surname = "doe",
                Username = "jane123",
                Password = "password456"
            };


            peopleManager.AddUser(user2);
            var result = peopleManager.ReadUser();

            Assert.AreEqual(result.Count,1);

            Assert.AreEqual(result[0], user2);


        }



    }
}





