using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgGameska
{
   public class NpcDeathEventArgs : EventArgs
    {
        public int Exp { get; set; }
        public Item BodyParts { get; set; }
        public List<Item> Inventory { get; set; }
    }
}
