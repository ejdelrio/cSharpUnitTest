using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exceptions;

namespace ExepctionsTest
{
    /// <summary>
    /// Summary description for PersonTest
    /// </summary>
    [TestClass]
    public class PersonTest
    {
        Person me = new Person("Eddie", 29);

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion
        [TestMethod]
        public void TestClassConstructor()
        {
            Assert.AreEqual("Eddie", me.name);
        }

        [TestMethod]
        public void TestGetAge()
        {
            int myAge = me.getAge();
            Assert.AreEqual(29, myAge);
        }

        [TestMethod]
        public void TestAgeOneYear()
        {
            int myAge = me.getAge();
            me.AgeOneYear();
            int myNewAge = me.getAge();

            Assert.AreNotEqual(myAge, myNewAge);
            Assert.AreEqual(myNewAge, myAge + 1);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void TestException()
        {
            int[] emptyArr = new int[0];
            int x = emptyArr[3];
        }
    }
}
