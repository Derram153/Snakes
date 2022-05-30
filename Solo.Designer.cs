﻿namespace Snakes
{
    partial class Solo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Solo));
            this.money = new System.Windows.Forms.Label();
            this.shopButton = new System.Windows.Forms.Button();
            this.healthLabel = new System.Windows.Forms.Label();
            this.life = new System.Windows.Forms.Label();
            this.reload = new System.Windows.Forms.Button();
            this.AddMoney = new System.Windows.Forms.Button();
            this.moveTimer = new System.Windows.Forms.Timer(this.components);
            this.moneyLabel = new System.Windows.Forms.Label();
            this.groupBoxPistol = new System.Windows.Forms.GroupBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.bullet1 = new System.Windows.Forms.PictureBox();
            this.bullet2 = new System.Windows.Forms.PictureBox();
            this.bullet3 = new System.Windows.Forms.PictureBox();
            this.groupBoxShop = new System.Windows.Forms.GroupBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.labelFocusRemover = new System.Windows.Forms.Label();
            this.gropBoxAK47 = new System.Windows.Forms.GroupBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.groupBoxSniper = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Map = new System.Windows.Forms.PictureBox();
            this.groupBoxBullet = new System.Windows.Forms.GroupBox();
            this.BulletCount = new System.Windows.Forms.Label();
            this.groupBoxReload = new System.Windows.Forms.GroupBox();
            this.groupBoxPistol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet3)).BeginInit();
            this.groupBoxShop.SuspendLayout();
            this.gropBoxAK47.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            this.groupBoxSniper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Map)).BeginInit();
            this.groupBoxBullet.SuspendLayout();
            this.groupBoxReload.SuspendLayout();
            this.SuspendLayout();
            // 
            // money
            // 
            this.money.AutoSize = true;
            this.money.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.money.Location = new System.Drawing.Point(108, 11);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(23, 25);
            this.money.TabIndex = 1;
            this.money.Text = "0";
            // 
            // shopButton
            // 
            this.shopButton.CausesValidation = false;
            this.shopButton.Location = new System.Drawing.Point(8, 25);
            this.shopButton.Margin = new System.Windows.Forms.Padding(4);
            this.shopButton.Name = "shopButton";
            this.shopButton.Size = new System.Drawing.Size(233, 69);
            this.shopButton.TabIndex = 2;
            this.shopButton.TabStop = false;
            this.shopButton.Text = "Магазин";
            this.shopButton.UseVisualStyleBackColor = true;
            this.shopButton.Click += new System.EventHandler(this.ShopButton_Click);
            // 
            // healthLabel
            // 
            this.healthLabel.AutoSize = true;
            this.healthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.healthLabel.Location = new System.Drawing.Point(475, 11);
            this.healthLabel.Name = "healthLabel";
            this.healthLabel.Size = new System.Drawing.Size(81, 25);
            this.healthLabel.TabIndex = 3;
            this.healthLabel.Text = "Жизни:";
            // 
            // life
            // 
            this.life.AutoSize = true;
            this.life.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.life.Location = new System.Drawing.Point(561, 11);
            this.life.Name = "life";
            this.life.Size = new System.Drawing.Size(45, 25);
            this.life.TabIndex = 4;
            this.life.Text = "100";
            // 
            // reload
            // 
            this.reload.CausesValidation = false;
            this.reload.Location = new System.Drawing.Point(7, 13);
            this.reload.Margin = new System.Windows.Forms.Padding(4);
            this.reload.Name = "reload";
            this.reload.Size = new System.Drawing.Size(185, 96);
            this.reload.TabIndex = 5;
            this.reload.TabStop = false;
            this.reload.Text = "Перезарядка";
            this.reload.UseVisualStyleBackColor = true;
            this.reload.Click += new System.EventHandler(this.Reload_Click);
            // 
            // AddMoney
            // 
            this.AddMoney.CausesValidation = false;
            this.AddMoney.Location = new System.Drawing.Point(8, 101);
            this.AddMoney.Margin = new System.Windows.Forms.Padding(4);
            this.AddMoney.Name = "AddMoney";
            this.AddMoney.Size = new System.Drawing.Size(172, 52);
            this.AddMoney.TabIndex = 11;
            this.AddMoney.TabStop = false;
            this.AddMoney.Text = "добавить 1000";
            this.AddMoney.UseVisualStyleBackColor = true;
            this.AddMoney.Click += new System.EventHandler(this.AddMoney_Click);
            // 
            // moveTimer
            // 
            this.moveTimer.Enabled = true;
            this.moveTimer.Tick += new System.EventHandler(this.MoveTimerEvent);
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.moneyLabel.Location = new System.Drawing.Point(9, 14);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(86, 25);
            this.moneyLabel.TabIndex = 3;
            this.moneyLabel.Text = "Деньги:";
            // 
            // groupBoxPistol
            // 
            this.groupBoxPistol.Controls.Add(this.pictureBox11);
            this.groupBoxPistol.Location = new System.Drawing.Point(296, 139);
            this.groupBoxPistol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxPistol.Name = "groupBoxPistol";
            this.groupBoxPistol.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxPistol.Size = new System.Drawing.Size(164, 116);
            this.groupBoxPistol.TabIndex = 12;
            this.groupBoxPistol.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::Snakes.Properties.Resources.пистолет;
            this.pictureBox11.Location = new System.Drawing.Point(8, 25);
            this.pictureBox11.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(149, 80);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 11;
            this.pictureBox11.TabStop = false;
            // 
            // bullet1
            // 
            this.bullet1.Image = global::Snakes.Properties.Resources.пуля1;
            this.bullet1.InitialImage = null;
            this.bullet1.Location = new System.Drawing.Point(8, 10);
            this.bullet1.Margin = new System.Windows.Forms.Padding(4);
            this.bullet1.Name = "bullet1";
            this.bullet1.Size = new System.Drawing.Size(31, 98);
            this.bullet1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bullet1.TabIndex = 6;
            this.bullet1.TabStop = false;
            // 
            // bullet2
            // 
            this.bullet2.Image = global::Snakes.Properties.Resources.пуля1;
            this.bullet2.InitialImage = null;
            this.bullet2.Location = new System.Drawing.Point(47, 10);
            this.bullet2.Margin = new System.Windows.Forms.Padding(4);
            this.bullet2.Name = "bullet2";
            this.bullet2.Size = new System.Drawing.Size(31, 98);
            this.bullet2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bullet2.TabIndex = 7;
            this.bullet2.TabStop = false;
            // 
            // bullet3
            // 
            this.bullet3.Image = global::Snakes.Properties.Resources.пуля1;
            this.bullet3.InitialImage = null;
            this.bullet3.Location = new System.Drawing.Point(85, 10);
            this.bullet3.Margin = new System.Windows.Forms.Padding(4);
            this.bullet3.Name = "bullet3";
            this.bullet3.Size = new System.Drawing.Size(31, 98);
            this.bullet3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bullet3.TabIndex = 8;
            this.bullet3.TabStop = false;
            // 
            // groupBoxShop
            // 
            this.groupBoxShop.Controls.Add(this.shopButton);
            this.groupBoxShop.Controls.Add(this.AddMoney);
            this.groupBoxShop.Controls.Add(this.ResetButton);
            this.groupBoxShop.Location = new System.Drawing.Point(16, 57);
            this.groupBoxShop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxShop.Name = "groupBoxShop";
            this.groupBoxShop.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxShop.Size = new System.Drawing.Size(255, 162);
            this.groupBoxShop.TabIndex = 13;
            this.groupBoxShop.TabStop = false;
            // 
            // ResetButton
            // 
            this.ResetButton.CausesValidation = false;
            this.ResetButton.Location = new System.Drawing.Point(181, 101);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(68, 52);
            this.ResetButton.TabIndex = 15;
            this.ResetButton.TabStop = false;
            this.ResetButton.Text = "restart";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // labelFocusRemover
            // 
            this.labelFocusRemover.AutoSize = true;
            this.labelFocusRemover.Location = new System.Drawing.Point(652, 18);
            this.labelFocusRemover.Name = "labelFocusRemover";
            this.labelFocusRemover.Size = new System.Drawing.Size(46, 17);
            this.labelFocusRemover.TabIndex = 14;
            this.labelFocusRemover.Text = "label1";
            // 
            // gropBoxAK47
            // 
            this.gropBoxAK47.Controls.Add(this.pictureBox14);
            this.gropBoxAK47.Location = new System.Drawing.Point(296, 139);
            this.gropBoxAK47.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gropBoxAK47.Name = "gropBoxAK47";
            this.gropBoxAK47.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gropBoxAK47.Size = new System.Drawing.Size(209, 116);
            this.gropBoxAK47.TabIndex = 15;
            this.gropBoxAK47.TabStop = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.Image = global::Snakes.Properties.Resources.автомат2;
            this.pictureBox14.Location = new System.Drawing.Point(11, 25);
            this.pictureBox14.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(185, 78);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox14.TabIndex = 19;
            this.pictureBox14.TabStop = false;
            // 
            // groupBoxSniper
            // 
            this.groupBoxSniper.Controls.Add(this.pictureBox1);
            this.groupBoxSniper.Location = new System.Drawing.Point(296, 139);
            this.groupBoxSniper.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxSniper.Name = "groupBoxSniper";
            this.groupBoxSniper.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxSniper.Size = new System.Drawing.Size(209, 116);
            this.groupBoxSniper.TabIndex = 17;
            this.groupBoxSniper.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Snakes.Properties.Resources.снайперка;
            this.pictureBox1.Location = new System.Drawing.Point(7, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // Map
            // 
            this.Map.BackColor = System.Drawing.SystemColors.Control;
            this.Map.Image = ((System.Drawing.Image)(resources.GetObject("Map.Image")));
            this.Map.Location = new System.Drawing.Point(16, 259);
            this.Map.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Map.Name = "Map";
            this.Map.Size = new System.Drawing.Size(1458, 640);
            this.Map.TabIndex = 0;
            this.Map.TabStop = false;
            this.Map.Paint += new System.Windows.Forms.PaintEventHandler(this.Map_Paint);
            // 
            // groupBoxBullet
            // 
            this.groupBoxBullet.Controls.Add(this.bullet3);
            this.groupBoxBullet.Controls.Add(this.bullet2);
            this.groupBoxBullet.Controls.Add(this.bullet1);
            this.groupBoxBullet.Location = new System.Drawing.Point(296, 31);
            this.groupBoxBullet.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxBullet.Name = "groupBoxBullet";
            this.groupBoxBullet.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxBullet.Size = new System.Drawing.Size(129, 108);
            this.groupBoxBullet.TabIndex = 16;
            this.groupBoxBullet.TabStop = false;
            // 
            // BulletCount
            // 
            this.BulletCount.AutoSize = true;
            this.BulletCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BulletCount.Location = new System.Drawing.Point(432, 47);
            this.BulletCount.Name = "BulletCount";
            this.BulletCount.Size = new System.Drawing.Size(83, 91);
            this.BulletCount.TabIndex = 9;
            this.BulletCount.Text = "0";
            // 
            // groupBoxReload
            // 
            this.groupBoxReload.Controls.Add(this.reload);
            this.groupBoxReload.Location = new System.Drawing.Point(566, 139);
            this.groupBoxReload.Name = "groupBoxReload";
            this.groupBoxReload.Size = new System.Drawing.Size(199, 116);
            this.groupBoxReload.TabIndex = 18;
            this.groupBoxReload.TabStop = false;
            // 
            // Solo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1481, 908);
            this.Controls.Add(this.groupBoxReload);
            this.Controls.Add(this.BulletCount);
            this.Controls.Add(this.groupBoxSniper);
            this.Controls.Add(this.groupBoxBullet);
            this.Controls.Add(this.gropBoxAK47);
            this.Controls.Add(this.groupBoxPistol);
            this.Controls.Add(this.labelFocusRemover);
            this.Controls.Add(this.groupBoxShop);
            this.Controls.Add(this.life);
            this.Controls.Add(this.moneyLabel);
            this.Controls.Add(this.healthLabel);
            this.Controls.Add(this.money);
            this.Controls.Add(this.Map);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MaximumSize = new System.Drawing.Size(1499, 955);
            this.MinimumSize = new System.Drawing.Size(1499, 955);
            this.Name = "Solo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Solo_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            this.groupBoxPistol.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet3)).EndInit();
            this.groupBoxShop.ResumeLayout(false);
            this.gropBoxAK47.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            this.groupBoxSniper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Map)).EndInit();
            this.groupBoxBullet.ResumeLayout(false);
            this.groupBoxReload.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button shopButton;
        private System.Windows.Forms.Label healthLabel;
        private System.Windows.Forms.Label life;
        private System.Windows.Forms.Button reload;
        public System.Windows.Forms.PictureBox bullet1;
        public System.Windows.Forms.PictureBox bullet2;
        public System.Windows.Forms.PictureBox bullet3;
        private System.Windows.Forms.Button AddMoney;
        public System.Windows.Forms.Label money;
        private System.Windows.Forms.Timer moveTimer;
        private System.Windows.Forms.Label moneyLabel;
        public System.Windows.Forms.GroupBox groupBoxPistol;
        private System.Windows.Forms.GroupBox groupBoxShop;
        private System.Windows.Forms.Label labelFocusRemover;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox11;
        public System.Windows.Forms.GroupBox gropBoxAK47;
        public System.Windows.Forms.GroupBox groupBoxSniper;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label BulletCount;
        public System.Windows.Forms.GroupBox groupBoxBullet;
        private System.Windows.Forms.PictureBox Map;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.GroupBox groupBoxReload;
    }
}