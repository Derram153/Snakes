namespace Snakes
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
            this.labelFocusRemover = new System.Windows.Forms.Label();
            this.gropBoxAK47 = new System.Windows.Forms.GroupBox();
            this.groupBoxSniper = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.Map = new System.Windows.Forms.PictureBox();
            this.groupBoxBullet = new System.Windows.Forms.GroupBox();
            this.BulletCount = new System.Windows.Forms.Label();
            this.groupBoxPistol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            this.Map = new System.Windows.Forms.PictureBox();
            this.ResetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bullet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet3)).BeginInit();
            this.groupBoxShop.SuspendLayout();
            this.groupBoxShop.SuspendLayout();
            this.gropBoxAK47.SuspendLayout();
            this.groupBoxSniper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Map)).BeginInit();
            this.groupBoxBullet.SuspendLayout();
            this.SuspendLayout();
            // 
            // money
            // 
            this.money.AutoSize = true;
            this.money.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.money.Location = new System.Drawing.Point(81, 9);
            this.money.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(18, 20);
            this.money.TabIndex = 1;
            this.money.Text = "0";
            // 
            // shopButton
            // 
            this.shopButton.CausesValidation = false;
            this.shopButton.Location = new System.Drawing.Point(6, 20);
            this.shopButton.Name = "shopButton";
            this.shopButton.Size = new System.Drawing.Size(175, 56);
            this.shopButton.TabIndex = 2;
            this.shopButton.TabStop = false;
            this.shopButton.Text = "Магазин";
            this.shopButton.UseVisualStyleBackColor = true;
            this.shopButton.Click += new System.EventHandler(this.shopButton_Click);
            // 
            // healthLabel
            // 
            this.healthLabel.AutoSize = true;
            this.healthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.healthLabel.Location = new System.Drawing.Point(356, 9);
            this.healthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.healthLabel.Name = "healthLabel";
            this.healthLabel.Size = new System.Drawing.Size(61, 20);
            this.healthLabel.TabIndex = 3;
            this.healthLabel.Text = "Жизни:";
            // 
            // life
            // 
            this.life.AutoSize = true;
            this.life.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.life.Location = new System.Drawing.Point(421, 9);
            this.life.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.life.Name = "life";
            this.life.Size = new System.Drawing.Size(36, 20);
            this.life.TabIndex = 4;
            this.life.Text = "100";
            // 
            // reload
            // 
            this.reload.CausesValidation = false;
            this.reload.Location = new System.Drawing.Point(399, 123);
            this.reload.Name = "reload";
            this.reload.Size = new System.Drawing.Size(141, 83);
            this.reload.TabIndex = 5;
            this.reload.TabStop = false;
            this.reload.Text = "Перезарядка";
            this.reload.UseVisualStyleBackColor = true;
            this.reload.Click += new System.EventHandler(this.reload_Click);
            // 
            // AddMoney
            // 
            this.AddMoney.CausesValidation = false;
            this.AddMoney.Location = new System.Drawing.Point(6, 82);
            this.AddMoney.Name = "AddMoney";
            this.AddMoney.Size = new System.Drawing.Size(129, 42);
            this.AddMoney.TabIndex = 11;
            this.AddMoney.TabStop = false;
            this.AddMoney.Text = "добавить 1000";
            this.AddMoney.UseVisualStyleBackColor = true;
            this.AddMoney.Click += new System.EventHandler(this.AddMoney_Click);
            // 
            // moveTimer
            // 
            this.moveTimer.Enabled = true;
            this.moveTimer.Tick += new System.EventHandler(this.moveTimerEvent);
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.moneyLabel.Location = new System.Drawing.Point(5, 9);
            this.moneyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(68, 20);
            this.moneyLabel.TabIndex = 3;
            this.moneyLabel.Text = "Деньги:";
            // 
            // groupBoxPistol
            // 
            this.groupBoxPistol.Controls.Add(this.pictureBox11);
            this.groupBoxPistol.Location = new System.Drawing.Point(222, 113);
            this.groupBoxPistol.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxPistol.Name = "groupBoxPistol";
            this.groupBoxPistol.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxPistol.Size = new System.Drawing.Size(123, 94);
            this.groupBoxPistol.TabIndex = 12;
            this.groupBoxPistol.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::Snakes.Properties.Resources.пистолет;
            this.pictureBox11.Location = new System.Drawing.Point(6, 20);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(112, 65);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 11;
            this.pictureBox11.TabStop = false;
            // 
            // bullet1
            // 
            this.bullet1.Image = global::Snakes.Properties.Resources.пуля1;
            this.bullet1.InitialImage = null;
            this.bullet1.Location = new System.Drawing.Point(6, 8);
            this.bullet1.Name = "bullet1";
            this.bullet1.Size = new System.Drawing.Size(23, 80);
            this.bullet1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bullet1.TabIndex = 6;
            this.bullet1.TabStop = false;
            // 
            // bullet2
            // 
            this.bullet2.Image = global::Snakes.Properties.Resources.пуля1;
            this.bullet2.InitialImage = null;
            this.bullet2.Location = new System.Drawing.Point(35, 8);
            this.bullet2.Name = "bullet2";
            this.bullet2.Size = new System.Drawing.Size(23, 80);
            this.bullet2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bullet2.TabIndex = 7;
            this.bullet2.TabStop = false;
            // 
            // bullet3
            // 
            this.bullet3.Image = global::Snakes.Properties.Resources.пуля1;
            this.bullet3.InitialImage = null;
            this.bullet3.Location = new System.Drawing.Point(64, 8);
            this.bullet3.Name = "bullet3";
            this.bullet3.Size = new System.Drawing.Size(23, 80);
            this.bullet3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bullet3.TabIndex = 8;
            this.bullet3.TabStop = false;
            // 
            // groupBoxShop
            // 
            this.groupBoxShop.Controls.Add(this.shopButton);
            this.groupBoxShop.Controls.Add(this.AddMoney);
            this.groupBoxShop.Location = new System.Drawing.Point(9, 41);
            this.groupBoxShop.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxShop.Name = "groupBoxShop";
            this.groupBoxShop.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxShop.Size = new System.Drawing.Size(191, 132);
            this.groupBoxShop.TabIndex = 13;
            this.groupBoxShop.TabStop = false;
            // 
            // labelFocusRemover
            // 
            this.labelFocusRemover.AutoSize = true;
            this.labelFocusRemover.Location = new System.Drawing.Point(489, 15);
            this.labelFocusRemover.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFocusRemover.Name = "labelFocusRemover";
            this.labelFocusRemover.Size = new System.Drawing.Size(35, 13);
            this.labelFocusRemover.TabIndex = 14;
            this.labelFocusRemover.Text = "label1";
            // 
            // gropBoxAK47
            // 
            this.gropBoxAK47.Controls.Add(this.pictureBox14);
            this.gropBoxAK47.Location = new System.Drawing.Point(222, 113);
            this.gropBoxAK47.Margin = new System.Windows.Forms.Padding(2);
            this.gropBoxAK47.Name = "gropBoxAK47";
            this.gropBoxAK47.Padding = new System.Windows.Forms.Padding(2);
            this.gropBoxAK47.Size = new System.Drawing.Size(157, 94);
            this.gropBoxAK47.TabIndex = 15;
            this.gropBoxAK47.TabStop = false;
            // 
            // groupBoxSniper
            // 
            this.groupBoxSniper.Controls.Add(this.pictureBox1);
            this.groupBoxSniper.Location = new System.Drawing.Point(222, 113);
            this.groupBoxSniper.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxSniper.Name = "groupBoxSniper";
            this.groupBoxSniper.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxSniper.Size = new System.Drawing.Size(157, 94);
            this.groupBoxSniper.TabIndex = 17;
            this.groupBoxSniper.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Snakes.Properties.Resources.снайперка;
            this.pictureBox1.Location = new System.Drawing.Point(5, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.Image = global::Snakes.Properties.Resources.автомат2;
            this.pictureBox14.Location = new System.Drawing.Point(8, 20);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(139, 63);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox14.TabIndex = 19;
            this.pictureBox14.TabStop = false;
            // 
            // moveTimer
            // 
            this.moveTimer.Enabled = true;
            this.moveTimer.Tick += new System.EventHandler(this.moveTimerEvent);
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.moneyLabel.Location = new System.Drawing.Point(7, 11);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(86, 25);
            this.moneyLabel.TabIndex = 3;
            this.moneyLabel.Text = "Деньги:";
            // 
            // groupBoxBullet
            // 
            this.groupBoxBullet.Controls.Add(this.bullet3);
            this.groupBoxBullet.Controls.Add(this.bullet2);
            this.groupBoxBullet.Controls.Add(this.bullet1);
            this.groupBoxBullet.Location = new System.Drawing.Point(222, 25);
            this.groupBoxBullet.Name = "groupBoxBullet";
            this.groupBoxBullet.Size = new System.Drawing.Size(97, 88);
            this.groupBoxBullet.TabIndex = 16;
            this.groupBoxBullet.TabStop = false;
            // 
            // BulletCount
            // 
            this.BulletCount.AutoSize = true;
            this.BulletCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BulletCount.Location = new System.Drawing.Point(324, 38);
            this.BulletCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BulletCount.Name = "BulletCount";
            this.BulletCount.Size = new System.Drawing.Size(68, 73);
            this.BulletCount.TabIndex = 9;
            this.BulletCount.Text = "0";
            // 
            // Map
            // 
            this.Map.BackColor = System.Drawing.SystemColors.Control;
            this.Map.Image = ((System.Drawing.Image)(resources.GetObject("Map.Image")));
            this.Map.Location = new System.Drawing.Point(12, 260);
            this.Map.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Map.Name = "Map";
            this.Map.Size = new System.Drawing.Size(1458, 640);
            this.Map.TabIndex = 0;
            this.Map.TabStop = false;
            this.Map.Paint += new System.Windows.Forms.PaintEventHandler(this.Map_Paint);
            // 
            // ResetButton
            // 
            this.ResetButton.CausesValidation = false;
            this.ResetButton.Location = new System.Drawing.Point(129, 103);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(126, 50);
            this.ResetButton.TabIndex = 15;
            this.ResetButton.TabStop = false;
            this.ResetButton.Text = "restart";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // Solo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1022, 603);
            this.Controls.Add(this.BulletCount);
            this.Controls.Add(this.reload);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            ((System.ComponentModel.ISupportInitialize)(this.bullet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet3)).EndInit();
            this.groupBoxShop.ResumeLayout(false);
            this.gropBoxAK47.ResumeLayout(false);
            this.groupBoxSniper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            this.groupBoxShop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Map)).EndInit();
            this.groupBoxBullet.ResumeLayout(false);
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
    }
}