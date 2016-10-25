using System;
using System.Text;
using System.Collections.Generic;
using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    /// <summary>
    /// Summary description for UnitTestTransaction
    /// </summary>
    [TestClass]
    public class UnitTestTransaction
    {
        public UnitTestTransaction()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

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
        public void Did_Transaction_Detects_Contained_Item_Correctly()
        {
            var transaction = new Transaction("A,B,C,D,E");
            Assert.IsTrue(transaction.ContainsItem(new Item("A")), "Did not find contained Item in the Transaction");
        }


        [TestMethod]
        public void Did_Transaction_Detects_NonContained_Item_Correctly()
        {
            var transaction = new Transaction("A,B,C,D,E");
            Assert.IsFalse(transaction.ContainsItem(new Item("G")), "Did find non contained Item in the Transaction");
        }

        [TestMethod]
        public void Did_Transaction_Detects_Contained_Transaction_Correctly()
        {
            var transaction1 = new Transaction("A,B,C,D,E");
            var transaction2 = new Transaction("A,B");
            Assert.IsTrue(transaction1.Contains(transaction2), "Did not find contained Transaction in the Transaction");
        }

        [TestMethod]
        public void Did_Transaction_Detects_NonContained_Tranaction_Correctly()
        {
            var transaction1 = new Transaction("A,B,C,D,E");
            var transaction2 = new Transaction("C,G");
            Assert.IsFalse(transaction1.Contains(transaction2), "Did find non contained Transaction in the Transaction");
        }
    }
}
