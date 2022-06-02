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
            this.groupBoxShop = new System.Windows.Forms.GroupBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.labelFocusRemover = new System.Windows.Forms.Label();
            this.gropBoxAK47 = new System.Windows.Forms.GroupBox();
            this.groupBoxSniper = new System.Windows.Forms.GroupBox();
            this.groupBoxBullet = new System.Windows.Forms.GroupBox();
            this.bullet3 = new System.Windows.Forms.PictureBox();
            this.bullet2 = new System.Windows.Forms.PictureBox();
            this.bullet1 = new System.Windows.Forms.PictureBox();
            this.BulletCount = new System.Windows.Forms.Label();
            this.groupBoxReload = new System.Windows.Forms.GroupBox();
            this.groupBoxMachinegun = new System.Windows.Forms.GroupBox();
            this.groupBoxScore = new System.Windows.Forms.GroupBox();
            this.scorelable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Map = new System.Windows.Forms.PictureBox();
            this.pictureGameOver = new System.Windows.Forms.PictureBox();
            this.shootTimer = new System.Windows.Forms.Timer(this.components);
            this.bulletShoot = new System.Windows.Forms.Timer(this.components);
            this.groupBoxShop.SuspendLayout();
            this.groupBoxBullet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bullet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet1)).BeginInit();
            this.groupBoxReload.SuspendLayout();
            this.groupBoxScore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Map)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGameOver)).BeginInit();
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
            this.shopButton.Click += new System.EventHandler(this.ShopButton_Click);
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
            this.reload.Location = new System.Drawing.Point(5, 11);
            this.reload.Name = "reload";
            this.reload.Size = new System.Drawing.Size(139, 78);
            this.reload.TabIndex = 5;
            this.reload.TabStop = false;
            this.reload.Text = "Перезарядка";
            this.reload.UseVisualStyleBackColor = true;
            this.reload.Click += new System.EventHandler(this.Reload_Click);
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
            this.moveTimer.Tick += new System.EventHandler(this.MoveTimerEvent);
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.moneyLabel.Location = new System.Drawing.Point(7, 11);
            this.moneyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(68, 20);
            this.moneyLabel.TabIndex = 3;
            this.moneyLabel.Text = "Деньги:";
            // 
            // groupBoxPistol
            // 
            this.groupBoxPistol.BackgroundImage = global::Snakes.Properties.Resources.пистолет;
            this.groupBoxPistol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBoxPistol.Location = new System.Drawing.Point(222, 113);
            this.groupBoxPistol.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxPistol.Name = "groupBoxPistol";
            this.groupBoxPistol.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxPistol.Size = new System.Drawing.Size(123, 94);
            this.groupBoxPistol.TabIndex = 12;
            this.groupBoxPistol.TabStop = false;
            // 
            // groupBoxShop
            // 
            this.groupBoxShop.Controls.Add(this.shopButton);
            this.groupBoxShop.Controls.Add(this.AddMoney);
            this.groupBoxShop.Controls.Add(this.ResetButton);
            this.groupBoxShop.Location = new System.Drawing.Point(12, 46);
            this.groupBoxShop.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxShop.Name = "groupBoxShop";
            this.groupBoxShop.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxShop.Size = new System.Drawing.Size(191, 132);
            this.groupBoxShop.TabIndex = 13;
            this.groupBoxShop.TabStop = false;
            // 
            // ResetButton
            // 
            this.ResetButton.CausesValidation = false;
            this.ResetButton.Location = new System.Drawing.Point(136, 82);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(2);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(51, 42);
            this.ResetButton.TabIndex = 15;
            this.ResetButton.TabStop = false;
            this.ResetButton.Text = "restart";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // labelFocusRemover
            // 
            this.labelFocusRemover.AutoSize = true;
            this.labelFocusRemover.Location = new System.Drawing.Point(682, 11);
            this.labelFocusRemover.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFocusRemover.Name = "labelFocusRemover";
            this.labelFocusRemover.Size = new System.Drawing.Size(35, 13);
            this.labelFocusRemover.TabIndex = 14;
            this.labelFocusRemover.Text = "label1";
            // 
            // gropBoxAK47
            // 
            this.gropBoxAK47.BackgroundImage = global::Snakes.Properties.Resources.автомат2;
            this.gropBoxAK47.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gropBoxAK47.Location = new System.Drawing.Point(222, 113);
            this.gropBoxAK47.Margin = new System.Windows.Forms.Padding(2);
            this.gropBoxAK47.Name = "gropBoxAK47";
            this.gropBoxAK47.Padding = new System.Windows.Forms.Padding(2);
            this.gropBoxAK47.Size = new System.Drawing.Size(127, 90);
            this.gropBoxAK47.TabIndex = 15;
            this.gropBoxAK47.TabStop = false;
            // 
            // groupBoxSniper
            // 
            this.groupBoxSniper.BackgroundImage = global::Snakes.Properties.Resources.снайперка;
            this.groupBoxSniper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBoxSniper.Location = new System.Drawing.Point(222, 113);
            this.groupBoxSniper.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxSniper.Name = "groupBoxSniper";
            this.groupBoxSniper.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxSniper.Size = new System.Drawing.Size(137, 90);
            this.groupBoxSniper.TabIndex = 17;
            this.groupBoxSniper.TabStop = false;
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
            // bullet3
            // 
            this.bullet3.Image = global::Snakes.Properties.Resources.пуля1;
            this.bullet3.InitialImage = null;
            this.bullet3.Location = new System.Drawing.Point(64, 10);
            this.bullet3.Margin = new System.Windows.Forms.Padding(4);
            this.bullet3.Name = "bullet3";
            this.bullet3.Size = new System.Drawing.Size(20, 72);
            this.bullet3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bullet3.TabIndex = 8;
            this.bullet3.TabStop = false;
            // 
            // bullet2
            // 
            this.bullet2.Image = global::Snakes.Properties.Resources.пуля1;
            this.bullet2.InitialImage = null;
            this.bullet2.Location = new System.Drawing.Point(36, 10);
            this.bullet2.Margin = new System.Windows.Forms.Padding(4);
            this.bullet2.Name = "bullet2";
            this.bullet2.Size = new System.Drawing.Size(20, 72);
            this.bullet2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bullet2.TabIndex = 7;
            this.bullet2.TabStop = false;
            // 
            // bullet1
            // 
            this.bullet1.Image = global::Snakes.Properties.Resources.пуля1;
            this.bullet1.InitialImage = null;
            this.bullet1.Location = new System.Drawing.Point(8, 10);
            this.bullet1.Margin = new System.Windows.Forms.Padding(4);
            this.bullet1.Name = "bullet1";
            this.bullet1.Size = new System.Drawing.Size(20, 72);
            this.bullet1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bullet1.TabIndex = 6;
            this.bullet1.TabStop = false;
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
            // groupBoxReload
            // 
            this.groupBoxReload.Controls.Add(this.reload);
            this.groupBoxReload.Location = new System.Drawing.Point(424, 113);
            this.groupBoxReload.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxReload.Name = "groupBoxReload";
            this.groupBoxReload.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxReload.Size = new System.Drawing.Size(149, 94);
            this.groupBoxReload.TabIndex = 18;
            this.groupBoxReload.TabStop = false;
            // 
            // groupBoxMachinegun
            // 
            this.groupBoxMachinegun.BackgroundImage = global::Snakes.Properties.Resources.пулемет;
            this.groupBoxMachinegun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBoxMachinegun.Location = new System.Drawing.Point(222, 113);
            this.groupBoxMachinegun.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxMachinegun.Name = "groupBoxMachinegun";
            this.groupBoxMachinegun.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxMachinegun.Size = new System.Drawing.Size(157, 93);
            this.groupBoxMachinegun.TabIndex = 19;
            this.groupBoxMachinegun.TabStop = false;
            // 
            // groupBoxScore
            // 
            this.groupBoxScore.BackgroundImage = global::Snakes.Properties.Resources.scorehead;
            this.groupBoxScore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBoxScore.Controls.Add(this.scorelable);
            this.groupBoxScore.Controls.Add(this.label1);
            this.groupBoxScore.Location = new System.Drawing.Point(424, 25);
            this.groupBoxScore.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxScore.Name = "groupBoxScore";
            this.groupBoxScore.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxScore.Size = new System.Drawing.Size(149, 94);
            this.groupBoxScore.TabIndex = 20;
            this.groupBoxScore.TabStop = false;
            // 
            // scorelable
            // 
            this.scorelable.AutoSize = true;
            this.scorelable.BackColor = System.Drawing.Color.Transparent;
            this.scorelable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scorelable.Location = new System.Drawing.Point(59, 68);
            this.scorelable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.scorelable.Name = "scorelable";
            this.scorelable.Size = new System.Drawing.Size(18, 20);
            this.scorelable.TabIndex = 21;
            this.scorelable.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(4, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Счет:";
            // 
            // Map
            // 
            this.Map.BackColor = System.Drawing.SystemColors.Control;
            this.Map.Image = ((System.Drawing.Image)(resources.GetObject("Map.Image")));
            this.Map.Location = new System.Drawing.Point(16, 212);
            this.Map.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Map.Name = "Map";
            this.Map.Size = new System.Drawing.Size(1094, 520);
            this.Map.TabIndex = 0;
            this.Map.TabStop = false;
            this.Map.Paint += new System.Windows.Forms.PaintEventHandler(this.Map_Paint);
            // 
            // pictureGameOver
            // 
            this.pictureGameOver.Image = global::Snakes.Properties.Resources.Cherep_Skull1;
            this.pictureGameOver.Location = new System.Drawing.Point(578, 9);
            this.pictureGameOver.Name = "pictureGameOver";
            this.pictureGameOver.Size = new System.Drawing.Size(129, 198);
            this.pictureGameOver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureGameOver.TabIndex = 19;
            this.pictureGameOver.TabStop = false;
            this.pictureGameOver.Visible = false;
            // 
            // shootTimer
            // 
            this.shootTimer.Enabled = true;
            this.shootTimer.Interval = 20;
            this.shootTimer.Tick += new System.EventHandler(this.ShootTimerEvent);
            // 
            // bulletShoot
            // 
            this.bulletShoot.Enabled = true;
            this.bulletShoot.Tick += new System.EventHandler(this.BulletShootEvent);
            // 
            // Solo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1112, 738);
            this.Controls.Add(this.groupBoxSniper);
            this.Controls.Add(this.pictureGameOver);
            this.Controls.Add(this.groupBoxMachinegun);
            this.Controls.Add(this.gropBoxAK47);
            this.Controls.Add(this.groupBoxScore);
            this.Controls.Add(this.groupBoxReload);
            this.Controls.Add(this.BulletCount);
            this.Controls.Add(this.groupBoxBullet);
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
            this.MaximumSize = new System.Drawing.Size(1128, 783);
            this.MinimumSize = new System.Drawing.Size(1128, 675);
            this.Name = "Solo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Solo_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            this.groupBoxShop.ResumeLayout(false);
            this.groupBoxBullet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bullet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet1)).EndInit();
            this.groupBoxReload.ResumeLayout(false);
            this.groupBoxScore.ResumeLayout(false);
            this.groupBoxScore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Map)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGameOver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button shopButton;
        private System.Windows.Forms.Label healthLabel;
        private System.Windows.Forms.Label life;
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
        public System.Windows.Forms.GroupBox gropBoxAK47;
        public System.Windows.Forms.GroupBox groupBoxSniper;
        public System.Windows.Forms.Label BulletCount;
        public System.Windows.Forms.GroupBox groupBoxBullet;
        private System.Windows.Forms.PictureBox Map;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.GroupBox groupBoxReload;
        private System.Windows.Forms.PictureBox pictureGameOver;
        public System.Windows.Forms.GroupBox groupBoxMachinegun;
        public System.Windows.Forms.Button reload;
        private System.Windows.Forms.GroupBox groupBoxScore;
        private System.Windows.Forms.Label scorelable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer shootTimer;
        private System.Windows.Forms.Timer bulletShoot;
    }
}