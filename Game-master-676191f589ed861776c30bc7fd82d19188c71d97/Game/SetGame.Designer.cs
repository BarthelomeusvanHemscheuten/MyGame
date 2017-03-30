namespace Game
{
    partial class SetGame
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
            this.tbHitpoints_Player = new System.Windows.Forms.TextBox();
            this.tbHitpoints_Enemy = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPlayer = new System.Windows.Forms.Button();
            this.tbPointX_Player = new System.Windows.Forms.TextBox();
            this.tbPointX_Enemy = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPointY_Player = new System.Windows.Forms.TextBox();
            this.tbPointY_Enemy = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEnemy = new System.Windows.Forms.Button();
            this.btnMap = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tbMapWidth = new System.Windows.Forms.TextBox();
            this.tbMapHeight = new System.Windows.Forms.TextBox();
            this.lbEnemies = new System.Windows.Forms.ListBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.gbMap = new System.Windows.Forms.GroupBox();
            this.tbArmor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbPlayer_Enemies = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbHealthpacks = new System.Windows.Forms.TextBox();
            this.gbMap.SuspendLayout();
            this.gbPlayer_Enemies.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbHitpoints_Player
            // 
            this.tbHitpoints_Player.Location = new System.Drawing.Point(71, 50);
            this.tbHitpoints_Player.Name = "tbHitpoints_Player";
            this.tbHitpoints_Player.Size = new System.Drawing.Size(100, 22);
            this.tbHitpoints_Player.TabIndex = 0;
            // 
            // tbHitpoints_Enemy
            // 
            this.tbHitpoints_Enemy.Location = new System.Drawing.Point(71, 75);
            this.tbHitpoints_Enemy.Name = "tbHitpoints_Enemy";
            this.tbHitpoints_Enemy.Size = new System.Drawing.Size(100, 22);
            this.tbHitpoints_Enemy.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Player:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enemy:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Hitpoints";
            // 
            // btnPlayer
            // 
            this.btnPlayer.Location = new System.Drawing.Point(6, 120);
            this.btnPlayer.Name = "btnPlayer";
            this.btnPlayer.Size = new System.Drawing.Size(119, 25);
            this.btnPlayer.TabIndex = 7;
            this.btnPlayer.Text = "Make Player";
            this.btnPlayer.UseVisualStyleBackColor = true;
            this.btnPlayer.Click += new System.EventHandler(this.btnPlayer_Click);
            // 
            // tbPointX_Player
            // 
            this.tbPointX_Player.Location = new System.Drawing.Point(196, 50);
            this.tbPointX_Player.Name = "tbPointX_Player";
            this.tbPointX_Player.Size = new System.Drawing.Size(46, 22);
            this.tbPointX_Player.TabIndex = 8;
            // 
            // tbPointX_Enemy
            // 
            this.tbPointX_Enemy.Location = new System.Drawing.Point(196, 75);
            this.tbPointX_Enemy.Name = "tbPointX_Enemy";
            this.tbPointX_Enemy.Size = new System.Drawing.Size(46, 22);
            this.tbPointX_Enemy.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(214, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "X";
            // 
            // tbPointY_Player
            // 
            this.tbPointY_Player.Location = new System.Drawing.Point(262, 50);
            this.tbPointY_Player.Name = "tbPointY_Player";
            this.tbPointY_Player.Size = new System.Drawing.Size(46, 22);
            this.tbPointY_Player.TabIndex = 12;
            // 
            // tbPointY_Enemy
            // 
            this.tbPointY_Enemy.Location = new System.Drawing.Point(262, 75);
            this.tbPointY_Enemy.Name = "tbPointY_Enemy";
            this.tbPointY_Enemy.Size = new System.Drawing.Size(46, 22);
            this.tbPointY_Enemy.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(274, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Y";
            // 
            // btnEnemy
            // 
            this.btnEnemy.Location = new System.Drawing.Point(189, 120);
            this.btnEnemy.Name = "btnEnemy";
            this.btnEnemy.Size = new System.Drawing.Size(119, 25);
            this.btnEnemy.TabIndex = 16;
            this.btnEnemy.Text = "Make Enemy";
            this.btnEnemy.UseVisualStyleBackColor = true;
            this.btnEnemy.Visible = false;
            this.btnEnemy.Click += new System.EventHandler(this.btnEnemy_Click);
            // 
            // btnMap
            // 
            this.btnMap.Location = new System.Drawing.Point(155, 85);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(119, 28);
            this.btnMap.TabIndex = 18;
            this.btnMap.Text = "Make map";
            this.btnMap.UseVisualStyleBackColor = true;
            this.btnMap.Click += new System.EventHandler(this.btnMap_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "Map:";
            // 
            // tbMapWidth
            // 
            this.tbMapWidth.Location = new System.Drawing.Point(143, 38);
            this.tbMapWidth.Name = "tbMapWidth";
            this.tbMapWidth.Size = new System.Drawing.Size(46, 22);
            this.tbMapWidth.TabIndex = 24;
            // 
            // tbMapHeight
            // 
            this.tbMapHeight.Location = new System.Drawing.Point(61, 39);
            this.tbMapHeight.Name = "tbMapHeight";
            this.tbMapHeight.Size = new System.Drawing.Size(46, 22);
            this.tbMapHeight.TabIndex = 26;
            // 
            // lbEnemies
            // 
            this.lbEnemies.FormattingEnabled = true;
            this.lbEnemies.ItemHeight = 16;
            this.lbEnemies.Location = new System.Drawing.Point(18, 185);
            this.lbEnemies.Name = "lbEnemies";
            this.lbEnemies.Size = new System.Drawing.Size(302, 116);
            this.lbEnemies.TabIndex = 27;
            this.lbEnemies.Visible = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(110, 481);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(119, 28);
            this.btnStart.TabIndex = 28;
            this.btnStart.Text = "Start game!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Visible = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // gbMap
            // 
            this.gbMap.Controls.Add(this.tbHealthpacks);
            this.gbMap.Controls.Add(this.label7);
            this.gbMap.Controls.Add(this.tbArmor);
            this.gbMap.Controls.Add(this.label3);
            this.gbMap.Controls.Add(this.tbMapHeight);
            this.gbMap.Controls.Add(this.btnMap);
            this.gbMap.Controls.Add(this.label10);
            this.gbMap.Controls.Add(this.tbMapWidth);
            this.gbMap.Location = new System.Drawing.Point(18, 322);
            this.gbMap.Name = "gbMap";
            this.gbMap.Size = new System.Drawing.Size(280, 139);
            this.gbMap.TabIndex = 29;
            this.gbMap.TabStop = false;
            this.gbMap.Text = "Map";
            // 
            // tbArmor
            // 
            this.tbArmor.Location = new System.Drawing.Point(71, 67);
            this.tbArmor.Name = "tbArmor";
            this.tbArmor.Size = new System.Drawing.Size(46, 22);
            this.tbArmor.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Armor:";
            // 
            // gbPlayer_Enemies
            // 
            this.gbPlayer_Enemies.Controls.Add(this.label4);
            this.gbPlayer_Enemies.Controls.Add(this.tbHitpoints_Player);
            this.gbPlayer_Enemies.Controls.Add(this.tbHitpoints_Enemy);
            this.gbPlayer_Enemies.Controls.Add(this.label1);
            this.gbPlayer_Enemies.Controls.Add(this.label2);
            this.gbPlayer_Enemies.Controls.Add(this.btnEnemy);
            this.gbPlayer_Enemies.Controls.Add(this.tbPointX_Player);
            this.gbPlayer_Enemies.Controls.Add(this.btnPlayer);
            this.gbPlayer_Enemies.Controls.Add(this.label6);
            this.gbPlayer_Enemies.Controls.Add(this.tbPointX_Enemy);
            this.gbPlayer_Enemies.Controls.Add(this.tbPointY_Enemy);
            this.gbPlayer_Enemies.Controls.Add(this.label5);
            this.gbPlayer_Enemies.Controls.Add(this.tbPointY_Player);
            this.gbPlayer_Enemies.Location = new System.Drawing.Point(18, 28);
            this.gbPlayer_Enemies.Name = "gbPlayer_Enemies";
            this.gbPlayer_Enemies.Size = new System.Drawing.Size(329, 151);
            this.gbPlayer_Enemies.TabIndex = 30;
            this.gbPlayer_Enemies.TabStop = false;
            this.gbPlayer_Enemies.Text = "Player/Enemies";
            this.gbPlayer_Enemies.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 17);
            this.label7.TabIndex = 29;
            this.label7.Text = "Healthpacks:";
            // 
            // tbHealthpacks
            // 
            this.tbHealthpacks.Location = new System.Drawing.Point(98, 102);
            this.tbHealthpacks.Name = "tbHealthpacks";
            this.tbHealthpacks.Size = new System.Drawing.Size(46, 22);
            this.tbHealthpacks.TabIndex = 30;
            // 
            // SetGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 513);
            this.Controls.Add(this.gbPlayer_Enemies);
            this.Controls.Add(this.gbMap);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lbEnemies);
            this.Name = "SetGame";
            this.Text = "SetGame";
            this.gbMap.ResumeLayout(false);
            this.gbMap.PerformLayout();
            this.gbPlayer_Enemies.ResumeLayout(false);
            this.gbPlayer_Enemies.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbHitpoints_Player;
        private System.Windows.Forms.TextBox tbHitpoints_Enemy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPlayer;
        private System.Windows.Forms.TextBox tbPointX_Player;
        private System.Windows.Forms.TextBox tbPointX_Enemy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPointY_Player;
        private System.Windows.Forms.TextBox tbPointY_Enemy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEnemy;
        private System.Windows.Forms.Button btnMap;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbMapWidth;
        private System.Windows.Forms.TextBox tbMapHeight;
        private System.Windows.Forms.ListBox lbEnemies;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox gbMap;
        private System.Windows.Forms.GroupBox gbPlayer_Enemies;
        private System.Windows.Forms.TextBox tbArmor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbHealthpacks;
    }
}