using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    // all of the relevant common attributes between weapons and armor are set
    public abstract class Item
    {


        public string Name { get; set; }

        public int RequiredLevel { get; set; }

        public object Slot { get; set; }
    }
}
