using System;
using System.ComponentModel.Design;
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

        [TestMethod]
        public void Did_TransactionDatabase_Loaded_From_Comma_Seperated_File()
        {
            var transactions = new TransactionDatabase(@"sample.txt");

            Assert.IsNotNull(transactions.Transactions, "transactions.Transactions != null");

        }

        [TestMethod]
        public void Did_TransactionDatabase_GetMaxTransactionLength_Returns_Correct()
        {
            var transactions = new TransactionDatabase();
            transactions.AddTransaction(new Transaction("A,B,C,D"));
            transactions.AddTransaction(new Transaction("A,B,C,D,A"));
            transactions.AddTransaction(new Transaction("A,B"));
            transactions.AddTransaction(new Transaction("A,B,C"));

            Assert.AreEqual(5,transactions.GetMaxTransactionLength(), "GetMaxTransactionLength is not equals to 5");
        }

        [TestMethod]
        public void Did_TransactionDatabase_Support_Returns_Correct()
        {
            var transactions = new TransactionDatabase();
            transactions.AddTransaction(new Transaction("A,B,C,D"));
            transactions.AddTransaction(new Transaction("A,B,C,D,A"));
            transactions.AddTransaction(new Transaction("A,B"));
            transactions.AddTransaction(new Transaction("A,B,C"));
            var support = transactions.GetSupportOfTransaction(new Transaction("A,B,C"));
            Assert.AreEqual(0.75, support, "GetSupportOfTransaction is not equals to 0.75");
        }

    }
}
