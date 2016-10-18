using System;
using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Test
{
    [TestClass]
    public class ItemUnitTests
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
        
    }
}
