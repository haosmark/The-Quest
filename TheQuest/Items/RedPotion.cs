using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheQuest.Items
{
    class RedPotion : Weapon, IPotion
    {
        private bool used;
        public bool Used { get { return this.used; } }
        public override string Name { get { return "Red Potion"; } }
        private const int maxHealthRestore = 10;
    }
}
