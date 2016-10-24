using System;
using System.Text;
using System.Collections.Generic;
using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    /// <summary>
    /// Summary description for UnitTestItemList
    /// </summary>
    [TestClass]
    public class UnitTestItemList
    {
        public UnitTestItemList()
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
        public void Did_ItemList_Created_With_Default_Constructor()
        {
            ItemList itemList = new ItemList();

            Assert.IsNotNull(itemList);
        }

        [TestMethod]
        public void Did_ItemListItems_Created_With_Default_Constructor()
        {
            ItemList itemList = new ItemList();

            Assert.IsNotNull(itemList.Items);
        }

        [TestMethod]
        public void Did_ItemListItems_Added_Correctly_With_AddItemsOfTransaction()
        {
            var itemList = new ItemList();
            var transaction = new Transaction();
            transaction.Items.Add(new Item("A"));
            transaction.Items.Add(new Item("B"));
            transaction.Items.Add(new Item("C"));
            transaction.Items.Add(new Item("D"));
            transaction.Items.Add(new Item("E"));
            itemList.AddItemsOfTransaction(transaction);

            Assert.IsTrue(itemList.IsItemPresent(new Item("A"))&& itemList.IsItemPresent(new Item("B")) && itemList.IsItemPresent(new Item("C")) && itemList.IsItemPresent(new Item("D")) && itemList.IsItemPresent(new Item("E")), "All added items are found in the list");
        }


        [TestMethod]
        public void Did_ItemListItems_IsItemPresent_True()
        {
            var itemList = new ItemList();
            itemList.Items.Add(new Item("A"));
            itemList.Items.Add(new Item("B"));

            Assert.IsTrue(itemList.IsItemPresent(new Item("A")), "Present item detected as non-present");
        }

        [TestMethod]
        public void Did_ItemListItems_IsItemPresent_False()
        {
            var itemList = new ItemList();
            itemList.Items.Add(new Item("A"));
            itemList.Items.Add(new Item("B"));

            Assert.IsFalse(itemList.IsItemPresent(new Item("C")),"Non-present item detected as present");
        }

        [TestMethod]
        public void Did_ItemListItems_Added_Correctly_With_AddItemsOfTransaction_Did_Only_Unique_Items_Added_To_ItemList()
        {
            var itemList = new ItemList();
            var transaction = new Transaction();
            transaction.Items.Add(new Item("A"));
            transaction.Items.Add(new Item("B"));
            transaction.Items.Add(new Item("C"));
            transaction.Items.Add(new Item("D"));
            transaction.Items.Add(new Item("E"));
            transaction.Items.Add(new Item("E"));
            itemList.AddItemsOfTransaction(transaction);

            Assert.AreEqual(itemList.Items.Count, 5, "Amount of Transaction Items Added Correctly");
        }


    }
}
