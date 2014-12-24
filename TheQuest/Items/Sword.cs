﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace TheQuest.Items
{
    class Sword : Weapon
    {
        public override string Name { get { return "Sword"; } }
        public const int Radius = 3;
        public const int Damage = 10;

        public Sword(Game game, Point location)
            : base(game, location)
        {

        }

        public override void Attack(Direction direction, Random random)
        {
            // TODO: implement Attack
        }
    }
}
