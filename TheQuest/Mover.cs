using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheQuest
{
    abstract class Mover
    {
        private const int moveInterval = 10;
        protected Point location;
        public Point Location { get { return this.location; } }
        protected Game game;

        public Mover(Game game, Point location)
        {
            this.game = game;
            this.location = location;
        }

        public bool Nearby(Point locationToCheck, int distance)
        {
            if (Math.Abs(location.X - locationToCheck.X) < distance && Math.Abs(location.Y - locationToCheck.Y) < distance)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Point Move(Direction direction, Rectangle boundaries)
        {
            Point newLocation = this.location;
            switch (direction)
            {
                case Direction.Up:
                    if (newLocation.Y - moveInterval >= boundaries.Top)
                    {
                        newLocation.Y -= moveInterval;
                    }
                    break;
                case Direction.Down:
                    if (newLocation.Y + moveInterval <= boundaries.Bottom)
                    {
                        newLocation.Y += moveInterval;
                    }
                    break;
                case Direction.Left:
                    if (newLocation.X - moveInterval >= boundaries.Left)
                    {
                        newLocation.X -= moveInterval;
                    }
                    break;
                case Direction.Right:
                    if (newLocation.X + moveInterval <= boundaries.Right)
                    {
                        newLocation.X += moveInterval;
                    }
                    break;
                default: break;
            }
            return newLocation;
        }
    }
}
