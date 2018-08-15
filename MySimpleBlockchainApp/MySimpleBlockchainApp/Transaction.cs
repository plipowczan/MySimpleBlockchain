#region usings

using System;

#endregion

namespace MySimpleBlockchainApp
{
    [Serializable]
    public class Transaction
    {
        #region Properties

        public double Amount { get; set; }

        public string From { get; set; }

        public string To { get; set; }

        #endregion
    }
}