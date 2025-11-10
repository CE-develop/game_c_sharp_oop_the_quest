using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace The_Quest
{
    public class Ghoul: Enemy
    {
        Rectangle boundaries;
        int GhoulDamage = 4;
        int steps = 1;
        int distance = 25;

        public Ghoul(Game game, Point location, Rectangle boundaries)
            : base(game, location, boundaries, 10)
        {
            this.boundaries = boundaries;
        }

        public override void Move(Random random)
        {
            Direction Movement;
            int Value;

            Value = random.Next(0, 3); /*0>Gets near the player  1>Moves to a random position  2>It stands still*/

            if (Value == 0 || Value == 1)
            {
                Movement = FindPlayerDirection(game.PlayerLocation);
                base.location = Move(Movement, boundaries, steps);
            }
            else
            {
                /* The same location remains in this case for the Ghost */
            }


            if (NearPlayer(distance))
                game.HitPlayer(GhoulDamage, random);
        }
    }
}
