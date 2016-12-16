using System;
using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTestItemTransactionList
    {
        [TestMethod]
        public void Did_ItemTransactionList_Default_Constructor_Works()
        {
            var itemsTransactionList = new ItemsTransactionList();

            Assert.IsNotNull(itemsTransactionList, "itemsTransactionList != null");
        }

        [TestMethod]
        public void Did_ItemsTransactionList_Constructor_with_ItemList_Works()
        {
            var item1 = new Item("A");
            var item2 = new Item("B");
            var itemList = new ItemList();
            itemList.Items.Add(item1);
            itemList.Items.Add(item2);
            var itemsTransactionList = new ItemsTransactionList(itemList);

            Assert.AreEqual(2,itemsTransactionList.ItemList.Items.Count, "itemsTransactionList.ItemList.Items.Count != 2");
        }


        [TestMethod]
        public void Did_ItemsTransactionList_Load_Transactions_From_Transaction_Database()
        {
            var transactions = new TransactionDatabase();
            transactions.AddTransaction(new Transaction("A,B,C,D"));
            transactions.AddTransaction(new Transaction("A,B,C,D,A"));
            transactions.AddTransaction(new Transaction("A,B"));
            transactions.AddTransaction(new Transaction("A,B,C"));
            var item1 = new Item("A");
            var item2 = new Item("B");
            var itemList = new ItemList();
            itemList.Items.Add(item1);
            itemList.Items.Add(item2);
            var itemsTransactionList = new ItemsTransactionList(itemList);
            itemsTransactionList.AddTransactionsInTransactionDatabaseToList(transactions);

            Assert.AreEqual(4, itemsTransactionList.Transactions.Count, "itemsTransactionList.Transactions.Count is not equals to 1");
        }
    }
}
