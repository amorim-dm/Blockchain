using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text;

namespace Blockchain
{
    public class Block
    {
        public int Index { get; private set; }
        public DateTime TimeStamp { get; private set; }
        public string PreviousHash { get; private set; }
        public string Hash { get; private set; }
        public string Data { get; private set; }

        public Block(int index, string previousHash, string data){
            Index = index;
            TimeStamp = DateTime.UtcNow;
            PreviousHash = previousHash;
            Data = data;
            Hash = CalculateHash();
        }

        public string CalculateHash()
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                string rawData = $"{Index}{TimeStamp}{PreviousHash}{Data}";
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                return BitConverter.ToString(bytes).Replace("-", "").ToLower();
            }
        }
    }
}