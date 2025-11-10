using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace The_Quest
{
    public partial class Form1 : Form
    {
        private Game game;
        private Random random = new Random();
        private PictureBox[] WeaponOrPotionIcons;

        bool startOut;
        bool end;

        public Form1()
        {
            InitializeComponent();
            stageManager();
            controlInitialization();
        }

        public void stageManager()
        {
            startOut = true;
            end = false;
        }

        private void controlInitialization()
        {
            WeaponOrPotionIcons = new PictureBox[5];

            loadingTheWeaponPictureBoxArray();

            weaponsInScrollAreInvisible();

            Princess.Visible = false;

        }

        private void loadingTheWeaponPictureBoxArray()
        {
            WeaponOrPotionIcons[0] = swordControl;
            WeaponOrPotionIcons[1] = bluePotionControl;
            WeaponOrPotionIcons[2] = bowControl;
            WeaponOrPotionIcons[3] = redPotionControl;
            WeaponOrPotionIcons[4] = maceControl;
        }

        private void weaponsInScrollAreInvisible()
        {
            for (int i = 0; i < WeaponOrPotionIcons.Count(); i++ )
            {
                WeaponOrPotionIcons[i].Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            presentation();
            game = new Game(new Rectangle(78, 57, 420, 155));
            game.NewLevel(random);
            UpdateCharacters();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (startOut)
                presentation();
            else if (end)
                ending();
        }

        private void pctPresentation_Click_1(object sender, EventArgs e)
        {
            if (startOut)
            {
                timer1.Enabled = false;
                pctPresentation.Visible = false;
                startOut = false;
                base.Text = "The Quest";
            }
            else if (end)
                Application.Exit();
        }

        private void presentation()
        {
            if (timer1.Enabled)
            {
                base.Text = "MyGames";

                Graphics PenToWrite = pctPresentation.CreateGraphics();

                PenToWrite.DrawString("The Quest", new Font("Informal Roman", 95, FontStyle.Regular), new SolidBrush(Color.Snow), new PointF((pctPresentation.Width / 2) - 250, (pctPresentation.Height / 2) - 170));
                PenToWrite.DrawString("You have to go through \nthe castle of silence \nto save the beautiful Princess. \nI would like to say that it would be easy. \nGood luck my friend! ",
                    new Font("Informal Roman", 20, FontStyle.Regular), new SolidBrush(Color.Black), new PointF((pctPresentation.Width / 2) - 120, (pctPresentation.Height / 2) - 10));
                PenToWrite.DrawString("CLICK to continue", new Font("Consolas", 10, FontStyle.Regular), new SolidBrush(Color.Black), new PointF((pctPresentation.Width / 2) - 60, (pctPresentation.Height / 2) + 180));
            }
        }

        private void ending()
        {
            if (timer1.Enabled)
            {
                base.Text = "MyGames";

                Graphics PenToWrite = pctPresentation.CreateGraphics();

                PenToWrite.DrawString("The Quest", new Font("Informal Roman", 95, FontStyle.Regular), new SolidBrush(Color.Snow), new PointF((pctPresentation.Width / 2) - 250, (pctPresentation.Height / 2) - 150));
                PenToWrite.DrawString("You have rescue her.\nShe is beutiful, Isn't it?",
                    new Font("Informal Roman", 20, FontStyle.Regular), new SolidBrush(Color.Black), new PointF((pctPresentation.Width / 2) - 120, (pctPresentation.Height / 2) - 10));
                PenToWrite.DrawString("CLICK to close", new Font("Consolas", 10, FontStyle.Regular), new SolidBrush(Color.Black), new PointF((pctPresentation.Width / 2) - 60, (pctPresentation.Height / 2) + 180));
            }
        }

        private void buttonMoveUp_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Up, random);
            UpdateCharacters();
        }

        private void buttonMoveLeft_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Left, random);
            UpdateCharacters();
        }

        private void buttonMoveRight_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Right, random);
            UpdateCharacters();
        }

        private void buttonMoveDown_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Down, random);
            UpdateCharacters();
        }

        private void buttonAttactUp_Click(object sender, EventArgs e)
        {
            tryingToAttact(Direction.Up);
        }

        private void buttonAttactLeft_Click(object sender, EventArgs e)
        {
            tryingToAttact(Direction.Left);
        }

        private void buttonAttactRight_Click(object sender, EventArgs e)
        {
            tryingToAttact(Direction.Right);
        }

        private void buttonAttactDown_Click(object sender, EventArgs e)
        {
            tryingToAttact(Direction.Down);
        }

        private void tryingToAttact(Direction direction)
        {
            if( (swordControl.BorderStyle == BorderStyle.Fixed3D)      ||  /*Blue ,and red potions are not considered in this part*/
                (bowControl.BorderStyle == BorderStyle.Fixed3D)        ||
                (maceControl.BorderStyle == BorderStyle.Fixed3D) )
            {
                //if(direction == Direction.Up)
                //    game.Attack(Direction.Up, random);
                //else if(direction == Direction.Left)
                //    game.Attack(Direction.Left, random);
                //else if(direction == Direction.Right)
                //    game.Attack(Direction.Right, random);
                //else //case for Direction.Down
                //    game.Attack(Direction.Down, random); 
                game.Attack(Direction.Up, random); /*Any direction to attack is OK, it produces the same effect*/
            }

            UpdateCharacters();

        }


        public void UpdateCharacters()
        {
            Player.Location = game.PlayerLocation;

            labelLevel.Text = game.Level.ToString() + " / " + game.NumberOfLevels.ToString();

            if (game.PlayerHitPoints > 0)
            {
                playerHitPoints.Text = game.PlayerHitPoints.ToString();
            }
            else
            {
                playerHitPoints.Text = "0";
            }
            

            int enemiesShown = 0;

            foreach (Enemy enemy in game.Enemies)
            {
                if (enemy is Bat)
                {
                    Bat.Location = enemy.Location;
                    batHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        Bat.Visible = true;
                        enemiesShown++;
                    }
                    else
                    {
                        Bat.Visible = false;
                        batHitPoints.Text = "0";
                    }
                }
                else if (enemy is Ghost)
                {
                    Ghost.Location = enemy.Location;
                    ghostHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        Ghost.Visible = true;
                        enemiesShown++;
                    }
                    else
                    {
                        Ghost.Visible = false;
                        ghostHitPoints.Text = "0";
                    }
                }
                else if (enemy is Ghoul)
                {
                    Ghoul.Location = enemy.Location;
                    ghoulHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        Ghoul.Visible = true;
                        enemiesShown++;
                    }
                    else
                    {
                        Ghoul.Visible = false;
                        ghoulHitPoints.Text = "0";
                    }
                }
                else
                {//Dark
                    labelBat.Text = "Dark";
                    labelGhost.Visible = false;
                    ghostHitPoints.Visible = false;
                    labelGhoul.Visible = false;
                    ghoulHitPoints.Visible = false;

                    Dark.Location = enemy.Location;
                    batHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        Dark.Visible = true;
                        enemiesShown++;
                    }
                    else
                    {
                        Dark.Visible = false;
                        batHitPoints.Text = "0";
                    }
                }
             }
            
            Control weaponControl = null;

            if (game.WeaponInRoom != null)
            {
                switch (game.WeaponInRoom.Name)
                {
                    case "Sword":
                        weaponControl = sword;
                        break;
                    case "Bow":
                        weaponControl = bow;
                        break;
                    case "Mace":
                        weaponControl = mace;
                        break;
                    case "Red Potion":
                        weaponControl = redPotion;
                        break;
                    case "Blue Potion":
                        weaponControl = bluePotion;
                        break;
                    default:
                        break;
                }


                weaponControl.Visible = true;

                weaponOrPoisonVisible();


                weaponControl.Location = game.WeaponInRoom.Location;

                if (game.WeaponInRoom.PickedUp)
                {
                    weaponControl.Visible = false;
                }
                else
                {
                    weaponControl.Visible = true;
                }
            }

            
            if ( game.onlyTheSwordAsWeapon() )
            {
                game.Equip("Sword");
                selectsWeaponOrPotion(swordControl);
            }


            if (game.PlayerHitPoints <= 0)
            {
                MessageBox.Show("You died!");
                Application.Exit();
            }

            /* Announcing the winner */
            if ((enemiesShown < 1) && (game.Level == 8))
            {
                end = true;
                pctPresentation.Visible = true;
                startOut = false;
                timer1.Enabled = true;
                ending();
            }
            else if ((enemiesShown < 1) && (game.Level != 8))
            {
                weaponControl.Visible = false;
                MessageBox.Show("You have defeated the enemies on level " + game.Level.ToString());
                game.NewLevel(random);
                UpdateCharacters();
            }

            if( (game.Level == 8 ) && end != true)
            {
                Princess.Visible = true;
            }

        }


        private void swordControl_Click(object sender, EventArgs e)
        {
            if(game.CheckPlayerInventory("Sword"))
            {
                game.Equip("Sword");

                selectsWeaponOrPotion(swordControl);
            }
            
            UpdateCharacters(); 
        }

        private void bluePotionControl_Click(object sender, EventArgs e)
        {
            PictureBox LastWeaponIcon;
            string LastWeaponName;

            if (game.CheckPlayerInventory("Blue Potion"))
            {
                LastWeaponName = game.EquippedWeapon();

                selectsWeaponOrPotion(bluePotionControl);
                game.usingThePotion("Blue Potion", random);

                LastWeaponIcon = fromStringToPictureBox(LastWeaponName);
                selectsWeaponOrPotion(LastWeaponIcon);
            }
            UpdateCharacters();
        }

        private void bowControl_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Bow"))
            {
                game.Equip("Bow");

                selectsWeaponOrPotion(bowControl);
            }
            
            UpdateCharacters(); 
        }

        private void redPotionControl_Click(object sender, EventArgs e)
        {
            PictureBox LastWeaponIcon;
            string LastWeaponName;

            if (game.CheckPlayerInventory("Red Potion"))
            {
                LastWeaponName = game.EquippedWeapon();

                selectsWeaponOrPotion(redPotionControl);
                game.usingThePotion("Red Potion", random);

                LastWeaponIcon = fromStringToPictureBox(LastWeaponName);
                selectsWeaponOrPotion(LastWeaponIcon);
            }

            UpdateCharacters();
        }

        private void maceControl_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Mace"))
            {
                game.Equip("Mace");

                selectsWeaponOrPotion(maceControl);
            }

            UpdateCharacters(); 
        }

        private void selectsWeaponOrPotion(PictureBox weaponOrPotionControl)
        {
            for (int i = 0; i < WeaponOrPotionIcons.Count(); i++ )
            {
                if (WeaponOrPotionIcons[i] == weaponOrPotionControl)
                    WeaponOrPotionIcons[i].BorderStyle = BorderStyle.Fixed3D;
                else
                    WeaponOrPotionIcons[i].BorderStyle = BorderStyle.None;
            }
        }

        private PictureBox fromStringToPictureBox(string weapon)
        {
            if (weapon == "Sword")
                return swordControl;
            else if (weapon == "Bow")
                return bowControl;
            else  /*(weapon == "Mace")*/
                return maceControl;
        }

        private void weaponOrPoisonVisible()
        {
            if (game.CheckPlayerInventory("Sword"))
                swordControl.Visible = true;
            else
                swordControl.Visible = false;

            if (game.CheckPlayerInventory("Bow"))
                bowControl.Visible = true;
            else
                bowControl.Visible = false;

            if (game.CheckPlayerInventory("Mace"))
                maceControl.Visible = true;
            else
                maceControl.Visible = false;

            if (game.CheckPlayerInventory("Red Potion"))
                redPotionControl.Visible = true;
            else
                redPotionControl.Visible = false;

            if (game.CheckPlayerInventory("Blue Potion"))
                bluePotionControl.Visible = true;
            else
                bluePotionControl.Visible = false;  
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                game.Move(Direction.Right, random);
                UpdateCharacters();
            }
            else if (e.KeyCode == Keys.Left)
            {
                game.Move(Direction.Left, random);
                UpdateCharacters();
            }
            else if (e.KeyCode == Keys.Up)
            {
                game.Move(Direction.Up, random);
                UpdateCharacters();
            }
            else if (e.KeyCode == Keys.Down)
            {
                game.Move(Direction.Down, random);
                UpdateCharacters();
            }
            else if (e.KeyCode == Keys.X)
            {
                tryingToAttact(Direction.Down);
            }
        }


    }
}
