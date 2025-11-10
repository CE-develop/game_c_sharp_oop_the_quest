using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace The_Quest
{
    public abstract class Weapon: Mover
    {
        protected Game game;
        private bool pickedUp;
        public bool PickedUp { get { return pickedUp; } }

        public Weapon(Game game, Point location)
            :base(game, location)
        {
            this.game = game;
            this.location = location;
            pickedUp = false;
        }

        public void PickUpWeapon() { pickedUp = true; }

        public abstract string Name { get; }

        public abstract void Attack(Direction direction, Random random);

        protected void DamageEnemy(Direction direction, int radius, int damage, Random random)
        {
            location = game.PlayerLocation;
            
            foreach (Enemy enemy in game.Enemies)
            {
                if (Nearby(enemy.Location, radius))
                {
                    enemy.Hit(damage, random);
                }
            }
        }



    }
}
