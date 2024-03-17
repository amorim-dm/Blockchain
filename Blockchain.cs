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

        public void AddBlock(Block newBlock) {
            Block latestBlock = GetLatestBlock();
            newBlock.Index = latestBlock.Index + 1;
            newBlock.PreviousHash = latestBlock.Hash;
            newBlock.Hash = newBlock.CalculateHash();
            Chain.Add(newBlock);
        }

        private Block GetLatestBlock() {
            return Chain.Last();
        }

        public bool isValid() {
            for(int i = 1; i < Chain.Count; i++) {
                Block currentBlock = Chain[i];
                Block previousBlock = Chain[i - 1];

                if(currentBlock.Hash != currentBlock.CalculateHash()){
                    return false;
                }

                if(currentBlock.PreviousHash != previousBlock.Hash)
                {
                    return false;
                }
            }

            return true;
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