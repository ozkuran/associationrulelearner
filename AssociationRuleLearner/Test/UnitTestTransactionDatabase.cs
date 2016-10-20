using System;
using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTestTransactionDatabase
    {
        [TestMethod]
        public void Did_TransactionDatabase_Created_with_Default_Constructor()
        {
            var transactions = new TransactionDatabase();

            Assert.IsNotNull(transactions,"transactions != null");
        }

        [TestMethod]
        public void Did_TransactionDatabase_TransactionList_Created_with_Default_Constructor()
        {
            var transactions = new TransactionDatabase();

            Assert.IsNotNull(transactions.Transactions, "transactions.Transactions != null");
        }
    }
}
