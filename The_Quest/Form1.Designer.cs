namespace The_Quest
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Player = new System.Windows.Forms.PictureBox();
            this.sword = new System.Windows.Forms.PictureBox();
            this.Bat = new System.Windows.Forms.PictureBox();
            this.Ghoul = new System.Windows.Forms.PictureBox();
            this.Ghost = new System.Windows.Forms.PictureBox();
            this.bow = new System.Windows.Forms.PictureBox();
            this.bluePotion = new System.Windows.Forms.PictureBox();
            this.redPotion = new System.Windows.Forms.PictureBox();
            this.mace = new System.Windows.Forms.PictureBox();
            this.swordControl = new System.Windows.Forms.PictureBox();
            this.bluePotionControl = new System.Windows.Forms.PictureBox();
            this.bowControl = new System.Windows.Forms.PictureBox();
            this.redPotionControl = new System.Windows.Forms.PictureBox();
            this.maceControl = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Level = new System.Windows.Forms.Label();
            this.labelPlayer = new System.Windows.Forms.Label();
            this.labelBat = new System.Windows.Forms.Label();
            this.labelGhost = new System.Windows.Forms.Label();
            this.labelGhoul = new System.Windows.Forms.Label();
            this.playerHitPoints = new System.Windows.Forms.Label();
            this.batHitPoints = new System.Windows.Forms.Label();
            this.ghostHitPoints = new System.Windows.Forms.Label();
            this.ghoulHitPoints = new System.Windows.Forms.Label();
            this.labelLevel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelMove = new System.Windows.Forms.Label();
            this.buttonMoveLeft = new System.Windows.Forms.Button();
            this.buttonMoveUp = new System.Windows.Forms.Button();
            this.buttonMoveRight = new System.Windows.Forms.Button();
            this.buttonMoveDown = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.labelAttack = new System.Windows.Forms.Label();
            this.buttonAttactLeft = new System.Windows.Forms.Button();
            this.buttonAttactUp = new System.Windows.Forms.Button();
            this.buttonAttactRight = new System.Windows.Forms.Button();
            this.buttonAttactDown = new System.Windows.Forms.Button();
            this.Princess = new System.Windows.Forms.PictureBox();
            this.Dark = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pctPresentation = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ghoul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ghost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redPotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swordControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePotionControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bowControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redPotionControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maceControl)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Princess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPresentation)).BeginInit();
            this.SuspendLayout();
            // 
            // Player
            // 
            this.Player.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Player.ErrorImage = null;
            this.Player.Image = ((System.Drawing.Image)(resources.GetObject("Player.Image")));
            this.Player.Location = new System.Drawing.Point(91, 67);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(30, 30);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            // 
            // sword
            // 
            this.sword.BackColor = System.Drawing.Color.Transparent;
            this.sword.Image = ((System.Drawing.Image)(resources.GetObject("sword.Image")));
            this.sword.Location = new System.Drawing.Point(129, 69);
            this.sword.Name = "sword";
            this.sword.Size = new System.Drawing.Size(30, 30);
            this.sword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sword.TabIndex = 0;
            this.sword.TabStop = false;
            this.sword.Visible = false;
            // 
            // Bat
            // 
            this.Bat.BackColor = System.Drawing.Color.Transparent;
            this.Bat.Image = ((System.Drawing.Image)(resources.GetObject("Bat.Image")));
            this.Bat.Location = new System.Drawing.Point(165, 69);
            this.Bat.Name = "Bat";
            this.Bat.Size = new System.Drawing.Size(30, 30);
            this.Bat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bat.TabIndex = 0;
            this.Bat.TabStop = false;
            this.Bat.Visible = false;
            // 
            // Ghoul
            // 
            this.Ghoul.BackColor = System.Drawing.Color.Transparent;
            this.Ghoul.Image = ((System.Drawing.Image)(resources.GetObject("Ghoul.Image")));
            this.Ghoul.Location = new System.Drawing.Point(213, 69);
            this.Ghoul.Name = "Ghoul";
            this.Ghoul.Size = new System.Drawing.Size(30, 30);
            this.Ghoul.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ghoul.TabIndex = 0;
            this.Ghoul.TabStop = false;
            this.Ghoul.Visible = false;
            // 
            // Ghost
            // 
            this.Ghost.BackColor = System.Drawing.Color.Transparent;
            this.Ghost.Image = ((System.Drawing.Image)(resources.GetObject("Ghost.Image")));
            this.Ghost.Location = new System.Drawing.Point(261, 69);
            this.Ghost.Name = "Ghost";
            this.Ghost.Size = new System.Drawing.Size(30, 30);
            this.Ghost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ghost.TabIndex = 0;
            this.Ghost.TabStop = false;
            this.Ghost.Visible = false;
            // 
            // bow
            // 
            this.bow.BackColor = System.Drawing.Color.Transparent;
            this.bow.Image = ((System.Drawing.Image)(resources.GetObject("bow.Image")));
            this.bow.Location = new System.Drawing.Point(297, 69);
            this.bow.Name = "bow";
            this.bow.Size = new System.Drawing.Size(30, 30);
            this.bow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bow.TabIndex = 0;
            this.bow.TabStop = false;
            this.bow.Visible = false;
            // 
            // bluePotion
            // 
            this.bluePotion.BackColor = System.Drawing.Color.Transparent;
            this.bluePotion.Image = ((System.Drawing.Image)(resources.GetObject("bluePotion.Image")));
            this.bluePotion.Location = new System.Drawing.Point(333, 69);
            this.bluePotion.Name = "bluePotion";
            this.bluePotion.Size = new System.Drawing.Size(30, 30);
            this.bluePotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bluePotion.TabIndex = 0;
            this.bluePotion.TabStop = false;
            this.bluePotion.Visible = false;
            // 
            // redPotion
            // 
            this.redPotion.BackColor = System.Drawing.Color.Transparent;
            this.redPotion.Image = ((System.Drawing.Image)(resources.GetObject("redPotion.Image")));
            this.redPotion.Location = new System.Drawing.Point(388, 69);
            this.redPotion.Name = "redPotion";
            this.redPotion.Size = new System.Drawing.Size(30, 30);
            this.redPotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.redPotion.TabIndex = 0;
            this.redPotion.TabStop = false;
            this.redPotion.Visible = false;
            // 
            // mace
            // 
            this.mace.BackColor = System.Drawing.Color.Transparent;
            this.mace.Image = ((System.Drawing.Image)(resources.GetObject("mace.Image")));
            this.mace.Location = new System.Drawing.Point(434, 69);
            this.mace.Name = "mace";
            this.mace.Size = new System.Drawing.Size(30, 30);
            this.mace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mace.TabIndex = 0;
            this.mace.TabStop = false;
            this.mace.Visible = false;
            // 
            // swordControl
            // 
            this.swordControl.BackColor = System.Drawing.Color.Transparent;
            this.swordControl.Image = ((System.Drawing.Image)(resources.GetObject("swordControl.Image")));
            this.swordControl.Location = new System.Drawing.Point(73, 317);
            this.swordControl.Name = "swordControl";
            this.swordControl.Size = new System.Drawing.Size(50, 50);
            this.swordControl.TabIndex = 1;
            this.swordControl.TabStop = false;
            this.swordControl.Click += new System.EventHandler(this.swordControl_Click);
            // 
            // bluePotionControl
            // 
            this.bluePotionControl.BackColor = System.Drawing.Color.Transparent;
            this.bluePotionControl.Image = ((System.Drawing.Image)(resources.GetObject("bluePotionControl.Image")));
            this.bluePotionControl.Location = new System.Drawing.Point(129, 317);
            this.bluePotionControl.Name = "bluePotionControl";
            this.bluePotionControl.Size = new System.Drawing.Size(50, 50);
            this.bluePotionControl.TabIndex = 1;
            this.bluePotionControl.TabStop = false;
            this.bluePotionControl.Click += new System.EventHandler(this.bluePotionControl_Click);
            // 
            // bowControl
            // 
            this.bowControl.BackColor = System.Drawing.Color.Transparent;
            this.bowControl.Image = ((System.Drawing.Image)(resources.GetObject("bowControl.Image")));
            this.bowControl.Location = new System.Drawing.Point(185, 317);
            this.bowControl.Name = "bowControl";
            this.bowControl.Size = new System.Drawing.Size(50, 50);
            this.bowControl.TabIndex = 1;
            this.bowControl.TabStop = false;
            this.bowControl.Click += new System.EventHandler(this.bowControl_Click);
            // 
            // redPotionControl
            // 
            this.redPotionControl.BackColor = System.Drawing.Color.Transparent;
            this.redPotionControl.Image = ((System.Drawing.Image)(resources.GetObject("redPotionControl.Image")));
            this.redPotionControl.Location = new System.Drawing.Point(241, 317);
            this.redPotionControl.Name = "redPotionControl";
            this.redPotionControl.Size = new System.Drawing.Size(50, 50);
            this.redPotionControl.TabIndex = 1;
            this.redPotionControl.TabStop = false;
            this.redPotionControl.Click += new System.EventHandler(this.redPotionControl_Click);
            // 
            // maceControl
            // 
            this.maceControl.BackColor = System.Drawing.Color.Transparent;
            this.maceControl.Image = ((System.Drawing.Image)(resources.GetObject("maceControl.Image")));
            this.maceControl.Location = new System.Drawing.Point(297, 317);
            this.maceControl.Name = "maceControl";
            this.maceControl.Size = new System.Drawing.Size(50, 50);
            this.maceControl.TabIndex = 1;
            this.maceControl.TabStop = false;
            this.maceControl.Click += new System.EventHandler(this.maceControl_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.99329F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.00671F));
            this.tableLayoutPanel1.Controls.Add(this.Level, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelPlayer, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelBat, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelGhost, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelGhoul, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.playerHitPoints, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.batHitPoints, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ghostHitPoints, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ghoulHitPoints, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelLevel, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(611, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(157, 149);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // Level
            // 
            this.Level.AutoSize = true;
            this.Level.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Level.ForeColor = System.Drawing.Color.White;
            this.Level.Location = new System.Drawing.Point(3, 125);
            this.Level.Name = "Level";
            this.Level.Size = new System.Drawing.Size(52, 19);
            this.Level.TabIndex = 1;
            this.Level.Text = "Level";
            // 
            // labelPlayer
            // 
            this.labelPlayer.AutoSize = true;
            this.labelPlayer.BackColor = System.Drawing.Color.Black;
            this.labelPlayer.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer.ForeColor = System.Drawing.Color.White;
            this.labelPlayer.Location = new System.Drawing.Point(3, 0);
            this.labelPlayer.Name = "labelPlayer";
            this.labelPlayer.Size = new System.Drawing.Size(66, 19);
            this.labelPlayer.TabIndex = 0;
            this.labelPlayer.Text = "Player";
            // 
            // labelBat
            // 
            this.labelBat.AutoSize = true;
            this.labelBat.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBat.ForeColor = System.Drawing.Color.White;
            this.labelBat.Location = new System.Drawing.Point(3, 25);
            this.labelBat.Name = "labelBat";
            this.labelBat.Size = new System.Drawing.Size(41, 19);
            this.labelBat.TabIndex = 0;
            this.labelBat.Text = "Bat";
            // 
            // labelGhost
            // 
            this.labelGhost.AutoSize = true;
            this.labelGhost.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGhost.ForeColor = System.Drawing.Color.White;
            this.labelGhost.Location = new System.Drawing.Point(3, 50);
            this.labelGhost.Name = "labelGhost";
            this.labelGhost.Size = new System.Drawing.Size(58, 19);
            this.labelGhost.TabIndex = 0;
            this.labelGhost.Text = "Ghost";
            // 
            // labelGhoul
            // 
            this.labelGhoul.AutoSize = true;
            this.labelGhoul.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGhoul.ForeColor = System.Drawing.Color.White;
            this.labelGhoul.Location = new System.Drawing.Point(3, 75);
            this.labelGhoul.Name = "labelGhoul";
            this.labelGhoul.Size = new System.Drawing.Size(53, 19);
            this.labelGhoul.TabIndex = 0;
            this.labelGhoul.Text = "Ghoul";
            // 
            // playerHitPoints
            // 
            this.playerHitPoints.AutoSize = true;
            this.playerHitPoints.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerHitPoints.ForeColor = System.Drawing.Color.White;
            this.playerHitPoints.Location = new System.Drawing.Point(79, 0);
            this.playerHitPoints.Name = "playerHitPoints";
            this.playerHitPoints.Size = new System.Drawing.Size(0, 19);
            this.playerHitPoints.TabIndex = 0;
            // 
            // batHitPoints
            // 
            this.batHitPoints.AutoSize = true;
            this.batHitPoints.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batHitPoints.ForeColor = System.Drawing.Color.White;
            this.batHitPoints.Location = new System.Drawing.Point(79, 25);
            this.batHitPoints.Name = "batHitPoints";
            this.batHitPoints.Size = new System.Drawing.Size(0, 19);
            this.batHitPoints.TabIndex = 0;
            // 
            // ghostHitPoints
            // 
            this.ghostHitPoints.AutoSize = true;
            this.ghostHitPoints.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ghostHitPoints.ForeColor = System.Drawing.Color.White;
            this.ghostHitPoints.Location = new System.Drawing.Point(79, 50);
            this.ghostHitPoints.Name = "ghostHitPoints";
            this.ghostHitPoints.Size = new System.Drawing.Size(0, 19);
            this.ghostHitPoints.TabIndex = 0;
            // 
            // ghoulHitPoints
            // 
            this.ghoulHitPoints.AutoSize = true;
            this.ghoulHitPoints.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ghoulHitPoints.ForeColor = System.Drawing.Color.White;
            this.ghoulHitPoints.Location = new System.Drawing.Point(79, 75);
            this.ghoulHitPoints.Name = "ghoulHitPoints";
            this.ghoulHitPoints.Size = new System.Drawing.Size(0, 19);
            this.ghoulHitPoints.TabIndex = 0;
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLevel.ForeColor = System.Drawing.Color.White;
            this.labelLevel.Location = new System.Drawing.Point(79, 125);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(0, 19);
            this.labelLevel.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.Controls.Add(this.labelMove, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonMoveLeft, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.buttonMoveUp, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonMoveRight, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.buttonMoveDown, 1, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(611, 306);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(157, 116);
            this.tableLayoutPanel2.TabIndex = 3;
            this.tableLayoutPanel2.Visible = false;
            // 
            // labelMove
            // 
            this.labelMove.AutoSize = true;
            this.labelMove.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMove.Location = new System.Drawing.Point(3, 0);
            this.labelMove.Name = "labelMove";
            this.labelMove.Size = new System.Drawing.Size(38, 16);
            this.labelMove.TabIndex = 0;
            this.labelMove.Text = "Move";
            // 
            // buttonMoveLeft
            // 
            this.buttonMoveLeft.Location = new System.Drawing.Point(3, 49);
            this.buttonMoveLeft.Name = "buttonMoveLeft";
            this.buttonMoveLeft.Size = new System.Drawing.Size(43, 20);
            this.buttonMoveLeft.TabIndex = 0;
            this.buttonMoveLeft.TabStop = false;
            this.buttonMoveLeft.Text = "Left";
            this.buttonMoveLeft.UseVisualStyleBackColor = true;
            this.buttonMoveLeft.Click += new System.EventHandler(this.buttonMoveLeft_Click);
            // 
            // buttonMoveUp
            // 
            this.buttonMoveUp.Location = new System.Drawing.Point(55, 20);
            this.buttonMoveUp.Name = "buttonMoveUp";
            this.buttonMoveUp.Size = new System.Drawing.Size(43, 20);
            this.buttonMoveUp.TabIndex = 0;
            this.buttonMoveUp.TabStop = false;
            this.buttonMoveUp.Text = "Up";
            this.buttonMoveUp.UseVisualStyleBackColor = true;
            this.buttonMoveUp.Click += new System.EventHandler(this.buttonMoveUp_Click);
            // 
            // buttonMoveRight
            // 
            this.buttonMoveRight.Location = new System.Drawing.Point(107, 49);
            this.buttonMoveRight.Name = "buttonMoveRight";
            this.buttonMoveRight.Size = new System.Drawing.Size(43, 20);
            this.buttonMoveRight.TabIndex = 0;
            this.buttonMoveRight.TabStop = false;
            this.buttonMoveRight.Text = "Right";
            this.buttonMoveRight.UseVisualStyleBackColor = true;
            this.buttonMoveRight.Click += new System.EventHandler(this.buttonMoveRight_Click);
            // 
            // buttonMoveDown
            // 
            this.buttonMoveDown.Location = new System.Drawing.Point(55, 78);
            this.buttonMoveDown.Name = "buttonMoveDown";
            this.buttonMoveDown.Size = new System.Drawing.Size(43, 23);
            this.buttonMoveDown.TabIndex = 0;
            this.buttonMoveDown.TabStop = false;
            this.buttonMoveDown.Text = "Down";
            this.buttonMoveDown.UseVisualStyleBackColor = true;
            this.buttonMoveDown.Click += new System.EventHandler(this.buttonMoveDown_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.12102F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.12102F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.12102F));
            this.tableLayoutPanel3.Controls.Add(this.labelAttack, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonAttactLeft, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.buttonAttactUp, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.buttonAttactRight, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.buttonAttactDown, 1, 3);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(611, 178);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(157, 116);
            this.tableLayoutPanel3.TabIndex = 3;
            this.tableLayoutPanel3.Visible = false;
            // 
            // labelAttack
            // 
            this.labelAttack.AutoSize = true;
            this.labelAttack.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAttack.Location = new System.Drawing.Point(3, 0);
            this.labelAttack.Name = "labelAttack";
            this.labelAttack.Size = new System.Drawing.Size(46, 16);
            this.labelAttack.TabIndex = 0;
            this.labelAttack.Text = "Attack";
            // 
            // buttonAttactLeft
            // 
            this.buttonAttactLeft.Location = new System.Drawing.Point(3, 49);
            this.buttonAttactLeft.Name = "buttonAttactLeft";
            this.buttonAttactLeft.Size = new System.Drawing.Size(43, 23);
            this.buttonAttactLeft.TabIndex = 0;
            this.buttonAttactLeft.TabStop = false;
            this.buttonAttactLeft.Text = "Left";
            this.buttonAttactLeft.UseVisualStyleBackColor = true;
            this.buttonAttactLeft.Click += new System.EventHandler(this.buttonAttactLeft_Click);
            // 
            // buttonAttactUp
            // 
            this.buttonAttactUp.Location = new System.Drawing.Point(55, 20);
            this.buttonAttactUp.Name = "buttonAttactUp";
            this.buttonAttactUp.Size = new System.Drawing.Size(43, 23);
            this.buttonAttactUp.TabIndex = 0;
            this.buttonAttactUp.TabStop = false;
            this.buttonAttactUp.Text = "Up";
            this.buttonAttactUp.UseVisualStyleBackColor = true;
            this.buttonAttactUp.Click += new System.EventHandler(this.buttonAttactUp_Click);
            // 
            // buttonAttactRight
            // 
            this.buttonAttactRight.Location = new System.Drawing.Point(107, 49);
            this.buttonAttactRight.Name = "buttonAttactRight";
            this.buttonAttactRight.Size = new System.Drawing.Size(43, 23);
            this.buttonAttactRight.TabIndex = 0;
            this.buttonAttactRight.TabStop = false;
            this.buttonAttactRight.Text = "Right";
            this.buttonAttactRight.UseVisualStyleBackColor = true;
            this.buttonAttactRight.Click += new System.EventHandler(this.buttonAttactRight_Click);
            // 
            // buttonAttactDown
            // 
            this.buttonAttactDown.Location = new System.Drawing.Point(55, 78);
            this.buttonAttactDown.Name = "buttonAttactDown";
            this.buttonAttactDown.Size = new System.Drawing.Size(43, 23);
            this.buttonAttactDown.TabIndex = 0;
            this.buttonAttactDown.TabStop = false;
            this.buttonAttactDown.Text = "Down";
            this.buttonAttactDown.UseVisualStyleBackColor = true;
            this.buttonAttactDown.Click += new System.EventHandler(this.buttonAttactDown_Click);
            // 
            // Princess
            // 
            this.Princess.BackColor = System.Drawing.Color.Transparent;
            this.Princess.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Princess.BackgroundImage")));
            this.Princess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Princess.Location = new System.Drawing.Point(473, 137);
            this.Princess.Name = "Princess";
            this.Princess.Size = new System.Drawing.Size(40, 40);
            this.Princess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Princess.TabIndex = 5;
            this.Princess.TabStop = false;
            // 
            // Dark
            // 
            this.Dark.BackColor = System.Drawing.Color.Transparent;
            this.Dark.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Dark.BackgroundImage")));
            this.Dark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Dark.Location = new System.Drawing.Point(261, 134);
            this.Dark.Name = "Dark";
            this.Dark.Size = new System.Drawing.Size(50, 50);
            this.Dark.TabIndex = 6;
            this.Dark.TabStop = false;
            this.Dark.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(599, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 405);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pctPresentation
            // 
            this.pctPresentation.BackColor = System.Drawing.Color.Gray;
            this.pctPresentation.Location = new System.Drawing.Point(1, 0);
            this.pctPresentation.Name = "pctPresentation";
            this.pctPresentation.Size = new System.Drawing.Size(749, 400);
            this.pctPresentation.TabIndex = 7;
            this.pctPresentation.TabStop = false;
            this.pctPresentation.Click += new System.EventHandler(this.pctPresentation_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(746, 400);
            this.Controls.Add(this.pctPresentation);
            this.Controls.Add(this.Princess);
            this.Controls.Add(this.swordControl);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.maceControl);
            this.Controls.Add(this.redPotionControl);
            this.Controls.Add(this.bowControl);
            this.Controls.Add(this.bluePotionControl);
            this.Controls.Add(this.redPotion);
            this.Controls.Add(this.bluePotion);
            this.Controls.Add(this.Ghost);
            this.Controls.Add(this.Ghoul);
            this.Controls.Add(this.mace);
            this.Controls.Add(this.bow);
            this.Controls.Add(this.sword);
            this.Controls.Add(this.Dark);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Bat);
            this.Controls.Add(this.Player);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "The Quest";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ghoul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ghost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redPotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swordControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePotionControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bowControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redPotionControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maceControl)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Princess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPresentation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox sword;
        private System.Windows.Forms.PictureBox Bat;
        private System.Windows.Forms.PictureBox Ghoul;
        private System.Windows.Forms.PictureBox Ghost;
        private System.Windows.Forms.PictureBox bow;
        private System.Windows.Forms.PictureBox bluePotion;
        private System.Windows.Forms.PictureBox redPotion;
        private System.Windows.Forms.PictureBox mace;
        private System.Windows.Forms.PictureBox swordControl;
        private System.Windows.Forms.PictureBox bluePotionControl;
        private System.Windows.Forms.PictureBox bowControl;
        private System.Windows.Forms.PictureBox redPotionControl;
        private System.Windows.Forms.PictureBox maceControl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelPlayer;
        private System.Windows.Forms.Label labelBat;
        private System.Windows.Forms.Label labelGhost;
        private System.Windows.Forms.Label labelGhoul;
        private System.Windows.Forms.Label playerHitPoints;
        private System.Windows.Forms.Label batHitPoints;
        private System.Windows.Forms.Label ghostHitPoints;
        private System.Windows.Forms.Label ghoulHitPoints;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelMove;
        private System.Windows.Forms.Button buttonMoveLeft;
        private System.Windows.Forms.Button buttonMoveUp;
        private System.Windows.Forms.Button buttonMoveRight;
        private System.Windows.Forms.Button buttonMoveDown;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label labelAttack;
        private System.Windows.Forms.Button buttonAttactLeft;
        private System.Windows.Forms.Button buttonAttactUp;
        private System.Windows.Forms.Button buttonAttactRight;
        private System.Windows.Forms.Button buttonAttactDown;
        private System.Windows.Forms.PictureBox Princess;
        private System.Windows.Forms.PictureBox Dark;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Level;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pctPresentation;
    }
}

