﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class TransactionDatabase
    {
        public TransactionDatabase()
        {
            Transactions = new List<Transaction>();
        }

        public TransactionDatabase(string fileName) : this()
        {
            LoadTransactionsFromCommaSeperatedFile(fileName);
        }

        public List<Transaction> Transactions { get; set; }
        public ItemList UniqueItems { get; set; }


        public void AddTransaction(Transaction transaction)
        {
            Transactions.Add(transaction);
        }

        public void LoadTransactionsFromCommaSeperatedFile(string fileName)
        {
            var lines = File.ReadLines(fileName);
            foreach (var line in lines)
            {
                var transaction = new Transaction(line);
                AddTransaction(transaction);
            }
        }

        public int GetMaxTransactionLength()
        {
            return Transactions.Select(transaction => transaction.Items.Count).Concat(new[] {0}).Max();
        }

        public double GetSupportOfTransaction(Transaction transaction)
        {
            int containedTransaction = 0;
            foreach (Transaction transaction1 in Transactions)
            {
                if (transaction1.Contains(transaction))
                {
                    containedTransaction++;
                }
            }
            var support = (double)(containedTransaction)/(double)(Transactions.Count);
            return support;
        }
    }
}
