using System;
using System.Collections.Generic;
using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTestRule
    {
        [TestMethod]
        public void Did_Rule_Created_With_Default_Constructor()
        {
            Rule rule = new Rule();

            Assert.IsNotNull(rule, "rule != null");
        }

        [TestMethod]
        public void Did_Rule_Created_With_Value_Constructor()
        {
            Item item1 = new Item("Test Item 1");
            Item item2 = new Item("Test Item 2");
            List<Item> itemList = new List<Item>();
            itemList.Add(item1);
            itemList.Add(item2);
            Rule rule = new Rule(itemList,0.5,0.5);

            Assert.IsNotNull(rule, "rule != null");
        }
    }
}
