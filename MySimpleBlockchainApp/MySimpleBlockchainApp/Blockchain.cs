#region usings

using System.Collections.Generic;

#endregion

namespace MySimpleBlockchainApp
{
    public class Blockchain
    {
        #region Constructors

        public Blockchain()
        {
            this.BlockList = new List<Block>();
            this.CurrentBlock = new Block(null);
        }

        #endregion

        #region Properties

        public List<Block> BlockList { get; set; }

        public Block CurrentBlock { get; set; }

        #endregion

        #region Public methods

        public void AddTransaction(double amount, string from, string to)
        {
            this.CurrentBlock.AddTransaction(amount, from, to);
        }

        public void SaveBlock()
        {
            string currentHash = Helper.GetSha256Hash(this.CurrentBlock);
            this.CurrentBlock.Hash = Helper.GetSha256Hash(this.CurrentBlock);
            this.BlockList.Add(this.CurrentBlock);
            this.CurrentBlock = new Block(currentHash);
        }

        #endregion
    }
}