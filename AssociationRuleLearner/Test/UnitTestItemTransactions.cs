using System;
using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTestItemTransactions
    {
        [TestMethod]
        public void Did_ItemTransaction_Default_Constructor_Works()
        {
            var itemTransaction = new ItemTransactions();

            Assert.IsNotNull(itemTransaction, "ItemTransactions != null");
        }

        [TestMethod]
        public void Did_ItemTransaction_Constructor_with_Item_Works()
        {
            var item = new Item("A");
            var itemTransaction = new ItemTransactions(item);

            Assert.IsNotNull(itemTransaction.Item, "ItemTransactions != null");
        }


        [TestMethod]
        public void Did_ItemTransaction_Load_Transactions_From_Transaction_Database()
        {
            var transactions = new TransactionDatabase();
            transactions.AddTransaction(new Transaction("A,B,C,D"));
            transactions.AddTransaction(new Transaction("A,B,C,D,A"));
            transactions.AddTransaction(new Transaction("A,B"));
            transactions.AddTransaction(new Transaction("A,B,C"));


            var itemTransaction = new ItemTransactions();
            itemTransaction.GetTransactionsFromDatabase(transactions);

            Assert.AreEqual(4, itemTransaction.TransactionList.Count, "GetMaxTransactionLength is not equals to 4");
        }
    }
}
