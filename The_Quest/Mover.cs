using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace The_Quest
{
    public abstract class Mover
    {
        private int MoverInternal = 10;
        protected Point location;
        public Point Location { get { return location; } }
        protected Game game;

        public Mover(Game game, Point location)
        {
            this.game = game;
            this.location = location;
        }

        public bool Nearby(Point locationToCheck, int distance)
        {
            if( (Math.Abs(location.X - locationToCheck.X) < distance) &&
                (Math.Abs(location.Y - locationToCheck.Y) < distance) )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Point Move(Direction direction, Rectangle boundaries, int numberOfSteps)
        {
            Point newLocation = location;

            switch(direction)
            {
                case Direction.Up:
                    if (newLocation.Y - (MoverInternal * numberOfSteps) >= boundaries.Top)
                        newLocation.Y -= (MoverInternal * numberOfSteps);
                    break;
                case Direction.Down:
                    if (newLocation.Y + (MoverInternal * numberOfSteps) <= boundaries.Bottom)
                        newLocation.Y += (MoverInternal * numberOfSteps);
                    break;
                case Direction.Left:
                    if (newLocation.X - (MoverInternal * numberOfSteps) >= boundaries.Left)
                        newLocation.X -= (MoverInternal * numberOfSteps);
                    break;
                case Direction.Right:
                    if (newLocation.X + (MoverInternal * numberOfSteps) <= boundaries.Right)
                        newLocation.X += (MoverInternal * numberOfSteps);
                    break;
                default:
                    break;
            }

            return newLocation;
        }


    }
}
