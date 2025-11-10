using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;


namespace The_Quest
{
    public class Game
    {
        public List<Enemy> Enemies;
        public Weapon WeaponInRoom;
        private string LastWeaponName;

        private Player player;
        public Point PlayerLocation { get { return player.Location; } }
        public int PlayerHitPoints { get { return player.HitPoints; } }
        public List<string> PlayerWeapons { get { return player.Weapons; } }

        private int level = 0;
        public int Level { get { return level; } }
        public int NumberOfLevels = 8;

        private Rectangle boundaries;
        public Rectangle Boundaries { get { return boundaries; } }

        private int OnlyTheSword = 1;

        public Game(Rectangle boundaries)
        {
            this.boundaries = boundaries;
            player = new Player(this, new Point(boundaries.Left + 10, boundaries.Top + 70), boundaries);
        }

        public void Move(Direction direction, Random random)
        {
            player.Move(direction);
            foreach(Enemy enemy in Enemies)
            {
                if(enemy.HitPoints > 0) /* If this enemy is dead, the virtual object should not move  */
                {
                    enemy.Move(random);
                }
            }
        }

        public void Equip(string weaponName)
        {
            player.Equip(weaponName);
        }

        public bool CheckPlayerInventory(string weaponName)
        {
            return player.Weapons.Contains(weaponName);
        }

        public string EquippedWeapon()
        {
            return player.WhichWeaponIsEquipped();
        }

        public void HitPlayer(int maxDamage, Random random)
        {
            player.Hit(maxDamage, random);
        }

        public void IncreasePlayerHealth(int health, Random random)
        {
            player.IncreaseHealth(health, random);
        }

        public void Attack(Direction direction, Random random)
        {
            player.Attack(direction, random);

            foreach(Enemy enemy in Enemies)
            {
                if (enemy.HitPoints > 0)
                {
                    enemy.Move(random);
                }
            }
        }

        private Point GetRandomLocation(Random random)
        {
            return new Point(boundaries.Left + random.Next(boundaries.Right/10 - boundaries.Left/10)*10,
                                boundaries.Top + random.Next(boundaries.Bottom / 10 - boundaries.Top / 10) * 10);
        }

        public void putWeaponOutOfInventary(string weaponName)
        {
            player.putWeaponOut(weaponName);
        }

        public void usingThePotion(string Potion, Random random)
        {
            unequipLastWeapon();

            Equip(Potion);

            player.Attack(Direction.Up, random); /* Direction.Up, and random are demanded by the function */

            putWeaponOutOfInventary(Potion);

            equipLastWeapon();
        }

        private void unequipLastWeapon()
        {
            LastWeaponName = player.WhichWeaponIsEquipped();
        }

        private void equipLastWeapon()
        {
            Equip(LastWeaponName);
        }

        public bool onlyTheSwordAsWeapon()
        {
            if (player.Weapons.Count == OnlyTheSword)
                return true;
            else
                return false;
        }

        public void NewLevel(Random random)
        {
            level++;
            switch (level)
            {
                case 1:
                    Enemies = new List<Enemy>();
                    Enemies.Add(new Bat(this, GetRandomLocation(random), boundaries) );
                    WeaponInRoom = new Sword(this, GetRandomLocation(random));
                    break;
                case 2:
                    Enemies = new List<Enemy>();
                    Enemies.Add(new Ghost(this, GetRandomLocation(random), boundaries));
                    WeaponInRoom = new BluePotion(this, GetRandomLocation(random));
                    break;
                case 3:
                    Enemies = new List<Enemy>();
                    Enemies.Add(new Ghoul(this, GetRandomLocation(random), boundaries));
                    WeaponInRoom = new Bow(this, GetRandomLocation(random));
                    break;
                case 4:
                    Enemies = new List<Enemy>();
                    Enemies.Add(new Bat(this, GetRandomLocation(random), boundaries));
                    Enemies.Add(new Ghost(this, GetRandomLocation(random), boundaries));
                    if (!CheckPlayerInventory("Bow"))
                    {
                        WeaponInRoom = new Bow(this, GetRandomLocation(random));
                    }
                    else if(!CheckPlayerInventory("Blue Potion"))
                    {
                        WeaponInRoom = new BluePotion(this, GetRandomLocation(random));
                    }
                    break;
                case 5:
                    Enemies = new List<Enemy>();
                    Enemies.Add(new Bat(this, GetRandomLocation(random), boundaries));
                    Enemies.Add(new Ghoul(this, GetRandomLocation(random), boundaries));
                    if (!CheckPlayerInventory("Blue Potion"))
                    {
                        WeaponInRoom = new RedPotion(this, GetRandomLocation(random));
                    }
                    break;
                case 6:
                    Enemies = new List<Enemy>();
                    Enemies.Add(new Ghost(this, GetRandomLocation(random), boundaries));
                    Enemies.Add(new Ghoul(this, GetRandomLocation(random), boundaries));
                    WeaponInRoom = new Mace(this, GetRandomLocation(random));
                    break;
                case 7:
                    Enemies = new List<Enemy>();
                    Enemies.Add(new Bat(this, GetRandomLocation(random), boundaries));
                    Enemies.Add(new Ghost(this, GetRandomLocation(random), boundaries));
                    Enemies.Add(new Ghoul(this, GetRandomLocation(random), boundaries));
                    if (!CheckPlayerInventory("Mace"))
                    {
                        WeaponInRoom = new Mace(this, GetRandomLocation(random));
                    }
                    else if (!CheckPlayerInventory("Red Potion") && !CheckPlayerInventory("Blue Potion"))
                    {
                        WeaponInRoom = new RedPotion(this, GetRandomLocation(random));
                    }
                    break;
                case 8:
                    Rectangle boundariesForDark = boundaries;
                    boundariesForDark.Width = 350;
                    Point initialDarkLocation = new Point(300,55);
                    Enemies = new List<Enemy>();
                    Enemies.Add(new Dark(this, initialDarkLocation, boundariesForDark));
                    break;
                default:
                    break;
            }

        }

    }
}
