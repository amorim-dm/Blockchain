using System.Linq;
using Blockchain;
using System.Security.Cryptography;
using System.Text;

Blockchain bitcoinBlockchain = new Blockchain();

for (int i = 0; i < 10; i++)
{
  Block block = new Block(i, "0", "");
  Console.WriteLine(block.PreviousHash);
}

