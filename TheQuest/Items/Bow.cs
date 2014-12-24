using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheQuest.Items
{
    class Bow : Weapon
    {
        public override string Name { get { return "Bow"; } }
        public const int Radius = 30;
        public const int Damage = 1;

        public Bow(Game game, Point location)
            : base(game, location)
        {

        }

        public override void Attack(Direction direction, Random random)
        {
            // TODO: implement Attack
        }
    }
}
