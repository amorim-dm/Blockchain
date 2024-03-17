using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blockchain
{
    public class Blockchain
    {
        public IList<Block> Chain {get; set;}

        public Blockchain() {
            InitializeChain();
            AddGenesisBlock();
        }

        private void InitializeChain() {
            Chain = new List<Block>();
        }

        private void AddGenesisBlock()
        {
            Chain.Add(new Block(0, "0", "Genesis Block"));
        }
    }
}