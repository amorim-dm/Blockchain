using System.Linq;
using Blockchain;
using System.Security.Cryptography;
using System.Text;

List<Block> blocks = new List<Block>();

for (int i = 0; i < 10; i++)
{
  Block block = new Block(i, "0", "");
  Console.WriteLine(block.PreviousHash);
}

