using System;
using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTestEclat
    {
        [TestMethod]
        public void Eclat_Creation_Default_Constructor_Name()
        {
            var transactions = new TransactionDatabase();
            transactions.AddTransaction(new Transaction("A,B,C,D"));
            transactions.AddTransaction(new Transaction("A,B,C,A"));
            transactions.AddTransaction(new Transaction("A,B"));
            transactions.AddTransaction(new Transaction("A,B,C"));
            transactions.AddTransaction(new Transaction("D"));
            transactions.AddTransaction(new Transaction("E"));
            var eclat = new Eclat(transactions, 0.2);
            eclat.Run();
            Assert.AreEqual(8, eclat.TransactionCountWithSupport(), "Apriori Algorithm results wrong amount of transaction.");

            eclat = new Eclat(transactions);
            eclat.Run();
            Assert.AreEqual(16, eclat.TransactionCountWithSupport(), "Apriori Algorithm results wrong amount of transaction.");
            Assert.IsTrue(eclat.IsTransactionSupported(new Transaction("A,B")), "Apriori algorithm did not works right as new Transaction(\"A,B\") is not included in Supported Transactions List");
        }

        [TestMethod]
        public void Eclat_Calcuates_Transactions_Support_Right()
        {
            var transactions = new TransactionDatabase();
            transactions.AddTransaction(new Transaction("A,B,C,D"));
            transactions.AddTransaction(new Transaction("A,B,C,A"));
            transactions.AddTransaction(new Transaction("A,B"));
            transactions.AddTransaction(new Transaction("A,B,C"));
            transactions.AddTransaction(new Transaction("D"));
            transactions.AddTransaction(new Transaction("E"));
            var eclat = new Eclat(transactions);
            eclat.Run();
            Assert.IsTrue(eclat.IsTransactionSupported(new Transaction("A,B")), "Apriori algorithm did not works right as new Transaction(\"A,B\") is not included in Supported Transactions List");
            Assert.IsFalse(eclat.IsTransactionSupported(new Transaction("D,E")), "Apriori algorithm did not works right as new Transaction(\"D,E\") is included in Supported Transactions List");
        }
    }
}
