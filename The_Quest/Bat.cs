using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace The_Quest
{
    public class Bat: Enemy
    {
        Rectangle boundaries;
        int BatDamage = 2;
        int steps = 1;
        int distance = 25;

        public Bat(Game game, Point location, Rectangle boundaries)
            : base(game, location, boundaries, 6)
        {
            this.boundaries = boundaries;

        }

        public override void Move(Random random)
        {
            Direction Movement;

            if (random.Next(0, 2) == 1)
            {
                Movement = FindPlayerDirection(game.PlayerLocation);
                base.location = Move(Movement, boundaries, steps);
            }
            else
            {
                base.location = Move((Direction)random.Next(0, 4), boundaries, steps);  /* 0 = Direction.Up   4 = Direction.Right + 1*/
            }

            if (NearPlayer(distance))
                game.HitPlayer(BatDamage, random);

        }

        



    }
}
