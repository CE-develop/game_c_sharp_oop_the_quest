using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;


namespace The_Quest
{
    public class Ghost: Enemy
    {
        Rectangle boundaries;
        int GhostDamage = 3;
        int steps = 1;
        int distance = 25;

        public Ghost(Game game, Point location, Rectangle boundaries)
            : base(game, location, boundaries, 8)
        {
            this.boundaries = boundaries;
        }


        public override void Move(Random random)
        {
            Direction Movement;
            int Value;

            Value = random.Next(0, 3); /*0>Gets near the player  1>Moves to a random position  2>It stands still*/

            if (Value == 0)
            {
                Movement = FindPlayerDirection(game.PlayerLocation);
                base.location = Move(Movement, boundaries, steps);
            }
            else if (Value == 1)
            {
                base.location = Move((Direction)random.Next(0, 4), boundaries, steps);  /* 0 = Direction.Up   4 = Direction.Right + 1*/
            }
            else
            {
                /* The same location remains in this case for the Ghost */
            }

            if (NearPlayer(distance))
                game.HitPlayer(GhostDamage, random);
        }

    }
}
