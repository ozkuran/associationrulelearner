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

    }
}
