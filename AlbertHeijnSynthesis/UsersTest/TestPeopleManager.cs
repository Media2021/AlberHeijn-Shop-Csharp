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
        //    //private static MockPersonDB mockPersonDB = new MockPersonDB();
        //    private static Mock<IPersonDB> personDB = new Mock<IPersonDB>();

        //    private readonly PeopleManager peopleManager = new PeopleManager();
        //    private readonly List<User> users;

        //var peopleManager = new PeopleManager(users, personDB.Object);


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
            // Set up the mock repository and the test data
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
            //mockPersonDB.Setup(x => x.CreateUser(It.IsAny<User>())).Returns(true);

            // Set up the PeopleManager
            var peopleManager = new PeopleManager(mockPersonDB.Object);

            // Invoke the method under test
              peopleManager.AddUser(user2);
            var result  = peopleManager.ReadUser();

            // Assert that the user was added to the list
            Assert.AreEqual(result[1],user2);
            
        }

        [TestMethod]
        public void AddUser_InputIsValid_AddsUserToList_returnFalse()
        {
            // Set up the mock repository and the test data
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
            //mockPersonDB.Setup(x => x.CreateUser(It.IsAny<User>())).Returns(true);

            // Set up the PeopleManager
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

            // Invoke the method under test
            //peopleManager.AddUser(user1);
            

            // Assert that the user was added to the list
            //Assert.AreEqual(result[1], user1);

        }

        //[TestMethod]


        //public void GetLoggedInUser()
        //{



        //    var users = new List<User>();

        //    User user = new User { Name = "mido", Surname = "jani", Username = "mido66", Password = "mypassword23", UserRole = EntitiesLayer.UserRole.Customer, Salt = "" };
        //    User user1 = new User { Name = "jano", Surname = "fadi", Username = "user3", Password = "mypassword154", UserRole = EntitiesLayer.UserRole.Customer, Salt = "" };
        //    users.Add(user);
        //    users.Add(user1);
        //    var personDB = new Mock<IPersonDB>();

        //    var peopleManager = new PeopleManager(personDB.Object);
        //    personDB.Setup(x => x.ReadUser()).Returns(users);

        //    //var peopleManager = new PeopleManager(personDB.Object);

        //    var result = peopleManager.ReadUser();





        //    Assert.AreEqual(result.Count, 2);
        //}
        //    [TestMethod]
        //    public void GetLoggedInUser_InputIsFound_ReturnsMatchingUser1()
        //    {
        //        // Set up the mock repository and the test data
        //        var personDB = new Mock<IPersonDB>();
        //        var users = new List<User>
        //{
        //    new User { Name = "mido", Surname = "jani", Username = "mido66", Password = "mypassword23", UserRole = EntitiesLayer.UserRole.Customer, Salt = "" },
        //    new User { Name = "jano", Surname = "fadi", Username = "user3", Password = "mypassword154", UserRole = EntitiesLayer.UserRole.Customer, Salt = "" }
        //};
        //        personDB.Setup(x => x.ReadUser()).Returns(users);

        //        // Set up the PeopleManager and invoke the method under test
        //        var peopleManager = new PeopleManager(personDB.Object);
        //        var result = peopleManager.GetLoggedInUser("user3");

        //        // Assert that the result is not null
        //        Assert.IsNotNull(result);

        //        // Assert that the result is as expected
        //        Assert.AreEqual(result.Name, "jano");
        //        Assert.AreEqual(result.Surname, "fadi");
        //        Assert.AreEqual(result.Username, "user3");
        //        Assert.AreEqual(result.Password, "mypassword154");
        //        Assert.AreEqual(result.UserRole, EntitiesLayer.UserRole.Customer);
        //    }

        //[TestMethod]

        //public void CreateUser_ValidInput_CreatesUser()
        //{

        //    var user = new User
        //    {
        //        Name = "mido",
        //        Surname = "jani",
        //        Username = "m0099",
        //        Password = "mypassword",
        //        UserRole = EntitiesLayer.UserRole.Customer,
        //        Salt = ""
        //    };


        //    peopleManager.AddUser(user);
        //    bool result =peopleManager.ReadUser().Exists(x=>x==user);

        //    Assert.IsTrue(result);
        //}


        //[TestMethod]

        //public void GetUserTest()
        //{



        //    User user = new User { Name = "mido", Surname = "jani", Username = "mido66", Password = "mypassword23", UserRole = EntitiesLayer.UserRole.Customer, Salt = "" };
        //    User user1 = new User { Name = "jano", Surname = "fadi", Username = "duro", Password = "mypassword154", UserRole = EntitiesLayer.UserRole.Customer, Salt = "" };


        //    peopleManager.AddUser(user);
        //    peopleManager.AddUser(user1);


        //    List<User> retrievedUsers = peopleManager.ReadUser();

        //    Assert.AreEqual(retrievedUsers.Count, 2);

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

           

            //try
            //{
                var result = peopleManager.IsUsernameTaken(username);
            //}
            //catch (UserNameIsExistException e)
            //{
                Assert.IsFalse(result);
            //}


        }
        [TestMethod]
        public void IsUsernameTaken_InputIsNotTaken_ReturnsFalse()
        {
            // Set up the mock repository and the test data
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
            // Set up the mock repository and the test data
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
            // Set up the mock repository and the test data
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
            // Set up the mock repository and the test data
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
            //[TestMethod]
            //    public void LoginUser_ValidInput_ReturnsTrue()
            //    {

            //        var user = new User
            //        {
            //            Name = "mido",
            //            Surname = "jani",
            //            Username = "m00565",
            //            Password = "mypassword3454",
            //            UserRole = EntitiesLayer.UserRole.Customer,
            //            Salt = ""
            //        };
            //        peopleManager.AddUser(user);


            //        bool result = peopleManager.LoginUser("m00565", "mypassword3454");


            //        Assert.IsTrue(result);
            //    }
            //    [TestMethod]
            //    public void LoginUser_InvalidPassword_ReturnsFalse()
            //    {

            //        var user = new User
            //        {
            //            Name = "mido",
            //            Surname = "jani",
            //            Username = "9999f",
            //            Password = "mypassword99",
            //            UserRole = EntitiesLayer.UserRole.Customer,
            //            Salt = ""
            //        };
            //        peopleManager.AddUser(user);


            //        bool result = peopleManager.LoginUser("9999f", "invalid_password");


            //        Assert.IsFalse(result);
            //    }

            //happy//
            /// <summary>
            /// ////////////
            ///// </summary>
            ///


























            //    public void GetLoggedInUser_InputIsValid_ReturnsCorrectUser()
            //    {

            //        var users = new List<User>
            //{
            //    new User { Id = 1, Name = "User 1", Username = "user1" },
            //    new User { Id = 2, Name = "User 2", Username = "user2" },
            //    new User { Id = 3, Name = "User 3", Username = "user3" }
            //};
            //        var personDB = new Mock<IPersonDB>();
            //        var peopleManager = new PeopleManager(users, personDB.Object);
            //        string username = "user2";


            //        var result = peopleManager.GetLoggedInUser(username);


            //        Assert.AreEqual(users[1], result, "Expected correct user to be returned");
            //    }

            //[TestMethod]
            //public void DeleteUser_InputIsNull_ThrowsArgumentNullException()
            //{
            //    // Arrange
            //    var users = new List<User>();
            //    var personDB = new Mock<IPersonDB>();
            //    var peopleManager = new PeopleManager(users, personDB.Object);
            //    User user = null;

            //    // Act and Assert
            //    Assert.ThrowsException<ArgumentNullException>(() => peopleManager.DeleteUser(user), "Expected ArgumentNullException when user is null");
            //}

            //[TestMethod]
            //public void DeleteUser_InputIsValid_RemovesUserFromListAndDB()
            //{

            //    var users = new List<User>
            //    {
            //        new User { Id = 1, Name = "User 1" },
            //        new User { Id = 2, Name = "User 2" },
            //        new User { Id = 3, Name = "User 3" }
            //    };
            //    var personDB = new Mock<IPersonDB>();
            //    personDB.Setup(db => db.DeleteUser(It.IsAny<User>())).Verifiable();
            //    var peopleManager = new PeopleManager(users, personDB.Object);
            //    var user = users[1];


            //    peopleManager.DeleteUser(user);


            //    Assert.AreEqual(2, users.Count, " user should be removed from my list");
            //    Assert.IsFalse(users.Contains(user), "user should be removed from my list");
            //    personDB.Verify(db => db.DeleteUser(user), Times.Once());
            //}


            //[TestMethod]
            //public async Task LoginUser_InputIsNull_ThrowsArgumentNullException()
            //{
            //    PeopleManager peopleManager = new PeopleManager();  

            //    string username = null;
            //    string password = "password123";


            //    Func<Task> testDelegate = async () => await LoginUser(username, password);


            //    await Assert.ThrowsExceptionAsync<ArgumentNullException>(testDelegate, "Username cannot be null.");
            //}



            //[TestMethod]

            //public void TestNoUsers()
            //{

            //    PeopleManager peopleManager = new PeopleManager();


            //    List<User> retrievedUsers = peopleManager.ReadUser();


            //    Assert.AreEqual(retrievedUsers.Count, 0);
            //}
            //[TestMethod]

            //public void TestOneUser()
            //{

            //    PeopleManager peopleManager = new PeopleManager();
            //    User user = new User { Name = "mido", Surname = "lawand", Username = "mido87", Password = "mypassword", UserRole = EntitiesLayer.UserRole.Customer, Salt = "" };
            //    peopleManager.AddUser(user);


            //    List<User> retrievedUsers = peopleManager.ReadUser();


            //    Assert.AreEqual(retrievedUsers.Count, 1);
            //}
            //[TestMethod]

            //public void TestMultipleUsers()
            //{

            //    PeopleManager peopleManager = new PeopleManager();
            //    User user1 = new User { Name = "david", Surname = "rami", Username = "johndoe", Password = "mypassword", UserRole = EntitiesLayer.UserRole.Customer, Salt = "" };
            //    User user2 = new User { Name = "sami", Surname = "Dove", Username = "doe", Password = "mypassword1", UserRole = EntitiesLayer.UserRole.Customer, Salt = "" };
            //    User user3 = new User { Name = "mido", Surname = "lawand", Username = "mido87", Password = "mypassword2", UserRole = EntitiesLayer.UserRole.Customer, Salt = "" };
            //    peopleManager.AddUser(user1);
            //    peopleManager.AddUser(user2);
            //    peopleManager.AddUser(user3);


            //    List<User> retrievedUsers = peopleManager.ReadUser();


            //    Assert.AreEqual(retrievedUsers.Count, 3);
            //    Assert.AreEqual(retrievedUsers[0], user1);
            //    Assert.AreEqual(retrievedUsers[1], user2);
            //    Assert.AreEqual(retrievedUsers[2], user3);
            //}

        }
}





