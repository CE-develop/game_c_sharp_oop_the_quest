using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace The_Quest
{
    public class Player:Mover
    {
        private Weapon equippedWeapon;
        private int hitPoints;
        public int HitPoints { get { return hitPoints; } }

        private int playerDistanceToWeapon = 20;

        private int steps = 1;

        Rectangle boundaries;

        private List<Weapon> inventory = new List<Weapon>();

        public List<string> Weapons
        {
            get
            {
                List<string> names = new List<string>();
                foreach (Weapon weapon in inventory)
                    names.Add(weapon.Name);
                return names;
            }
        }

        public Player(Game game, Point location, Rectangle boundaries)
            :base(game, location)
        {
            hitPoints = 15;
            this.boundaries = boundaries;
        }

        public void Hit(int maxDamage, Random random)
        {
            hitPoints -= random.Next(1, maxDamage+1);
        }

        public void IncreaseHealth(int health, Random random)
        {
            hitPoints += random.Next(1, health+1);
        }

        public void Equip(string weaponName)
        {
            foreach (Weapon weapon in inventory)
                if (weapon.Name == weaponName)
                    equippedWeapon = weapon;
        }

        public void Move(Direction direction)
        {
            base.location = Move(direction, boundaries, steps);

            if (game.WeaponInRoom != null)
            {
                if (!game.WeaponInRoom.PickedUp)
                {
                    if (NearWeapon(game.WeaponInRoom))
                    {
                        inventory.Add(game.WeaponInRoom);
                        game.WeaponInRoom.PickUpWeapon();
                    }
                }
            }
        }

        public void Attack(Direction direction, Random random)
        {
            equippedWeapon.Attack(direction, random);
        }

        protected bool NearWeapon(Weapon weaponToPickUp)
        {
            return (Nearby(weaponToPickUp.Location, playerDistanceToWeapon));
        }

        public string WhichWeaponIsEquipped()
        {
            return equippedWeapon.Name;
        }

        public void putWeaponOut(string weaponName)
        {
            if(inventory.Count > 0)
            {
                for (int i = 0; i < inventory.Count; i++ )
                {
                    if (inventory[i].Name == weaponName)
                    {
                        inventory.RemoveAt(i);
                    }
                }
            }
        }

    }
}
