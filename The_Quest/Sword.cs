using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace The_Quest
{
    public class Sword: Weapon
    {
        public Sword(Game game, Point location )
            : base(game, location)
        {
        }

        public override string Name { get { return "Sword"; } }

        public override void Attack(Direction direction, Random random)
        {
            DamageEnemy(direction, 25, 3, random); /* Sword radius - 10 */
        }


    }
}
