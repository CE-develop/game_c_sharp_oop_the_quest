using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace The_Quest
{
    public class BluePotion:Weapon, IPotion
    {
        bool used;

        public BluePotion(Game game, Point location )
            : base(game, location)
        {
            used = false;
        }

        public override string Name { get { return "Blue Potion"; } }

        public bool Used
        {
            get
            {
                if (used)
                    return true;
                else
                    return false;

            }
        }

        public override void Attack(Direction direction, Random random)
        {
            game.IncreasePlayerHealth(5, random);
            used = true;
        }
    }
}
