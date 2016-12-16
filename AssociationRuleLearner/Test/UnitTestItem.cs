using System;
using System.Collections.Generic;
using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Test
{
    [TestClass]
    public class UnitTestItem
    {
        [TestMethod]
        public void Item_Creation_Default_Constructor_Name()
        {
            var item = new Item();
            const string expected = "Test Item";
            var actual = item.Name;

            // Assert
            Assert.AreEqual(expected,actual,"Default constructor not set Item Name correctly");
        }

        [TestMethod]
        public void Item_Creation_Default_Constructor_Guid()
        {
            var item = new Item();

            var isValid = (item.Guid != Guid.Empty);

            // Assert
            Assert.AreEqual(true, isValid, "Default constructor not set Item Guid correctly");
        }

        [TestMethod]
        public void Items_With_Same_Name_Equality_Check()
        {
            var item = new Item();
            var item2 = new Item();

            // Assert
            Assert.AreEqual(item, item2, "Items with same name are not assumed equal");
        }


        [TestMethod]
        public void Did_Items_With_Same_Name_Added_To_HashSet()
        {
            var item = new Item();
            var item2 = new Item();

            HashSet<Item> hashSet = new HashSet<Item>();
            hashSet.Add(item);
            hashSet.Add(item2);
            
            // Assert
            Assert.AreEqual(1, hashSet.Count, "Hashset added two Items with same name!");
        }


        [TestMethod]
        public void Did_Item_ToString_Works_Correct()
        {
            var item = new Item("A");

            // Assert
            Assert.AreEqual("A", item.ToString(), "Item.ToString() did not work correct!");
        }


        [TestMethod]
        public void Did_Item_NotEqual_Operator_Works_Correct()
        {
            var itemA = new Item("A");
            var itemB = new Item("B");

            // Assert
            Assert.IsTrue((itemA != itemB), "Item_NotEqual_Operator did not work correct!");
        }

        [TestMethod]
        public void Did_Item_Equals_Operator_Works_Correct()
        {
            var itemA = new Item("A");
            var itemB = new Item("B");

            // Assert
            Assert.IsFalse(itemA.Equals(itemB), "Item_Equals_Operator did not work correct!");
        }

        [TestMethod]
        public void Did_Item_CompareTo_Operator_Works_Correct()
        {
            var itemA = new Item("A");
            var itemB = new Item("A");
            var itemC = new Item("C");

            // Assert
            Assert.AreEqual(0,itemA.CompareTo(itemB), "Item_CompareTo_Operator did not work correct!");
            Assert.AreNotEqual(0, itemA.CompareTo(itemC), "Item_CompareTo_Operator did not work correct!");
        }
    }
}
