using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheQuest.Items
{
    class Mace : Weapon
    {
        public override string Name { get { return "Mace"; } }
        public const int Radius = 20;
        public const int Damage = 6;

        public Mace(Game game, Point location)
            : base(game, location)
        {

        }

        public override void Attack(Direction direction, Random random)
        {
            // TODO: implement Attack
        }
    }
}
