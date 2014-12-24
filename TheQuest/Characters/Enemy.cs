using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace TheQuest.Characters
{
    abstract class Enemy : Mover
    {
        private const int nearPlayerDistance = 25;
        public int HitPoints { get; private set; }
        public bool Dead { get { return (this.HitPoints <= 0) ? true : false; } }

        public Enemy(Game game, Point location, int hitPoints)
            : base(game, location)
        {
            this.HitPoints = hitPoints;
        }

        public abstract void Move(Random random);

        public void Hit(int maxDamage, Random random)
        {
            this.HitPoints -= random.Next(1, maxDamage);
        }

        protected bool nearPlayer()
        {
            return (Nearby(game.PlayerLocation, nearPlayerDistance));
        }

        protected Direction findPlayerDirection(Point playerLocation)
        {
            Direction directionToMove;
            if (playerLocation.X > location.X + 10)
            {
                directionToMove = Direction.Right;
            }
            else if (playerLocation.X < location.X - 10)
            {
                directionToMove = Direction.Left;
            }
            else if (playerLocation.Y < location.Y - 10)
            {
                directionToMove = Direction.Up;
            }
            else
            {
                directionToMove = Direction.Down;
            }
            return directionToMove;
        }
    }
}
