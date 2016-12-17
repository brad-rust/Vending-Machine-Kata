using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine_Kata
{
    public class Dispenser
    {
        public List<string> contents { private set; get; }
        public Dispenser()
        {
            this.contents = new List<string>();
        }

        public void addContents(string item)
        {
            this.contents.Add(item);
        }
    }
}
