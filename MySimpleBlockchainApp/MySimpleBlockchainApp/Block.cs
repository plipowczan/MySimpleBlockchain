#region usings

using System;
using System.Collections.Generic;

#endregion

namespace MySimpleBlockchainApp
{
    [Serializable]
    public class Block
    {
        #region Constructors

        public Block(string previousHash)
        {
            this.PreviousHash = previousHash;
            this.TransactionList = new List<Transaction>();
        }

        #endregion

        #region Properties

        public string Hash { get; set; }

        public string PreviousHash { get; set; }

        public List<Transaction> TransactionList { get; set; }

        #endregion

        #region Public methods

        public void AddTransaction(double amount, string from, string to)
        {
            this.TransactionList.Add(new Transaction
            {
                Amount = amount,
                From = from,
                To = to
            });
        }

        #endregion
    }
}