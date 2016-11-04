using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Eclat
    {
        public Eclat()
        {

        }

        public Eclat(TransactionDatabase transactionDatabase, double minimumSupport = 0.1, bool calculateSupport = true, bool calculateConfidence = false, bool calculateLift = false, bool calculateConviction = false)
        {
            TransactionDatabase = transactionDatabase;
            MinimumSupport = minimumSupport;
            CalculateSupport = calculateSupport;
            CalculateConfidence = calculateConfidence;
            CalculateLift = calculateLift;
            CalculateConviction = calculateConviction;
        }

        public TransactionDatabase TransactionDatabase { get; set; }
        public double MinimumSupport { get; set; }
        public bool CalculateSupport { get; set; }
        public bool CalculateConfidence { get; set; }
        public bool CalculateLift { get; set; }
        public bool CalculateConviction { get; set; }
        public List<Transaction> SupportedTransactionsList { get; set; }
        public List<Transaction> UnSupportedTransactionsList { get; set; }

    }
}
