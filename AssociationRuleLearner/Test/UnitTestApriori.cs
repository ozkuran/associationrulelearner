using System;
using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTestApriori
    {
        [TestMethod]
        public void Apriori_Creation_Default_Constructor_Name()
        {
            var transactions = new TransactionDatabase();
            transactions.AddTransaction(new Transaction("A,B,C,D"));
            transactions.AddTransaction(new Transaction("A,B,C,A"));
            transactions.AddTransaction(new Transaction("A,B"));
            transactions.AddTransaction(new Transaction("A,B,C"));
            transactions.AddTransaction(new Transaction("D"));
            transactions.AddTransaction(new Transaction("E"));
            var apriori = new Apriori(transactions, 0.2);
            apriori.Run();
            Assert.AreEqual(8, apriori.TransactionCountWithSupport(), "Apriori Algorithm results wrong amount of transaction.");

            apriori = new Apriori(transactions);
            apriori.Run();
            Assert.AreEqual(16, apriori.TransactionCountWithSupport(), "Apriori Algorithm results wrong amount of transaction.");

        }
    }
}
