using System;
using System.Collections.Generic;
using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class PerformanceTestAlgorithms
    {
        [TestMethod]
        public void TestMethodAlgorithms()
        {
            List<double> supports = new List<double>(new double[] { 0.001, 0.002, 0.003, 0.004, 0.005, 0.01, 0.02, 0.03, 0.04, 0.05, 0.1, 0.2 });
            string stringResult = "";
            foreach (double support in supports)
            {
                var start = DateTime.Now;
                var transactions = new TransactionDatabase(@"simple.txt");
                var apriori = new Apriori(transactions, 0.2);
                apriori.Run();
                var end = DateTime.Now;
                var result = end - start;
                stringResult += $"APRIORI Support:{support} Total Time (ms): {result.TotalMilliseconds}" + Environment.NewLine;
            }
            foreach (double support in supports)
            {
                var start = DateTime.Now;
                var transactions = new TransactionDatabase(@"simple.txt");
                var eclat = new Eclat(transactions, 0.2);
                eclat.Run();
                var end = DateTime.Now;
                var result = end - start;
                stringResult += $"ECLAT Support:{support} Total Time (ms): {result.TotalMilliseconds}" + Environment.NewLine;
                System.IO.File.WriteAllText(@"PerformanceResults.csv", stringResult);
            }
        }
    }
}
