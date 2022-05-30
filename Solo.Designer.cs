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
            this.bullet1 = new System.Windows.Forms.PictureBox();
            this.bullet2 = new System.Windows.Forms.PictureBox();
            this.bullet3 = new System.Windows.Forms.PictureBox();
            this.bullet4 = new System.Windows.Forms.PictureBox();
            this.bullet5 = new System.Windows.Forms.PictureBox();
            this.AddMoney = new System.Windows.Forms.Button();
            this.Map = new System.Windows.Forms.PictureBox();
            this.moveTimer = new System.Windows.Forms.Timer(this.components);
            this.moneyLabel = new System.Windows.Forms.Label();
            this.groupBoxBullet = new System.Windows.Forms.GroupBox();
            this.groupBoxShop = new System.Windows.Forms.GroupBox();
            this.labelFocusRemover = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bullet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Map)).BeginInit();
            this.groupBoxBullet.SuspendLayout();
            this.groupBoxShop.SuspendLayout();
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
            this.shopButton.Location = new System.Drawing.Point(8, 24);
            this.shopButton.Margin = new System.Windows.Forms.Padding(4);
            this.shopButton.Name = "shopButton";
            this.shopButton.Size = new System.Drawing.Size(233, 69);
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
            this.reload.Location = new System.Drawing.Point(7, 128);
            this.reload.Margin = new System.Windows.Forms.Padding(4);
            this.reload.Name = "reload";
            this.reload.Size = new System.Drawing.Size(188, 80);
            this.reload.TabIndex = 5;
            this.reload.TabStop = false;
            this.reload.Text = "Перезарядка";
            this.reload.UseVisualStyleBackColor = true;
            this.reload.Click += new System.EventHandler(this.reload_Click);
            // 
            // bullet1
            // 
            this.bullet1.Image = global::Snakes.Properties.Resources.пуля1;
            this.bullet1.InitialImage = null;
            this.bullet1.Location = new System.Drawing.Point(165, 22);
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
            this.bullet2.Location = new System.Drawing.Point(126, 22);
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
            this.bullet3.Location = new System.Drawing.Point(87, 22);
            this.bullet3.Margin = new System.Windows.Forms.Padding(4);
            this.bullet3.Name = "bullet3";
            this.bullet3.Size = new System.Drawing.Size(31, 98);
            this.bullet3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bullet3.TabIndex = 8;
            this.bullet3.TabStop = false;
            // 
            // bullet4
            // 
            this.bullet4.Image = global::Snakes.Properties.Resources.пуля1;
            this.bullet4.InitialImage = null;
            this.bullet4.Location = new System.Drawing.Point(49, 22);
            this.bullet4.Margin = new System.Windows.Forms.Padding(4);
            this.bullet4.Name = "bullet4";
            this.bullet4.Size = new System.Drawing.Size(31, 98);
            this.bullet4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bullet4.TabIndex = 9;
            this.bullet4.TabStop = false;
            // 
            // bullet5
            // 
            this.bullet5.Image = global::Snakes.Properties.Resources.пуля1;
            this.bullet5.InitialImage = null;
            this.bullet5.Location = new System.Drawing.Point(7, 22);
            this.bullet5.Margin = new System.Windows.Forms.Padding(4);
            this.bullet5.Name = "bullet5";
            this.bullet5.Size = new System.Drawing.Size(31, 98);
            this.bullet5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bullet5.TabIndex = 10;
            this.bullet5.TabStop = false;
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
            this.groupBoxBullet.Controls.Add(this.bullet5);
            this.groupBoxBullet.Controls.Add(this.reload);
            this.groupBoxBullet.Controls.Add(this.bullet1);
            this.groupBoxBullet.Controls.Add(this.bullet4);
            this.groupBoxBullet.Controls.Add(this.bullet2);
            this.groupBoxBullet.Controls.Add(this.bullet3);
            this.groupBoxBullet.Location = new System.Drawing.Point(406, 39);
            this.groupBoxBullet.Name = "groupBoxBullet";
            this.groupBoxBullet.Size = new System.Drawing.Size(209, 216);
            this.groupBoxBullet.TabIndex = 12;
            this.groupBoxBullet.TabStop = false;
            // 
            // groupBoxShop
            // 
            this.groupBoxShop.Controls.Add(this.shopButton);
            this.groupBoxShop.Controls.Add(this.AddMoney);
            this.groupBoxShop.Location = new System.Drawing.Point(12, 51);
            this.groupBoxShop.Name = "groupBoxShop";
            this.groupBoxShop.Size = new System.Drawing.Size(255, 162);
            this.groupBoxShop.TabIndex = 13;
            this.groupBoxShop.TabStop = false;
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
            // Solo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1481, 908);
            this.Controls.Add(this.labelFocusRemover);
            this.Controls.Add(this.groupBoxShop);
            this.Controls.Add(this.groupBoxBullet);
            this.Controls.Add(this.life);
            this.Controls.Add(this.moneyLabel);
            this.Controls.Add(this.healthLabel);
            this.Controls.Add(this.money);
            this.Controls.Add(this.Map);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Solo";
            this.Text = "Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Solo_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.bullet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Map)).EndInit();
            this.groupBoxBullet.ResumeLayout(false);
            this.groupBoxShop.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button shopButton;
        private System.Windows.Forms.Label healthLabel;
        private System.Windows.Forms.Label life;
        private System.Windows.Forms.Button reload;
        private System.Windows.Forms.PictureBox bullet1;
        private System.Windows.Forms.PictureBox bullet2;
        private System.Windows.Forms.PictureBox bullet3;
        private System.Windows.Forms.PictureBox bullet4;
        private System.Windows.Forms.PictureBox bullet5;
        private System.Windows.Forms.Button AddMoney;
        public System.Windows.Forms.Label money;

        private System.Windows.Forms.PictureBox Map;
        private System.Windows.Forms.Timer moveTimer;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.GroupBox groupBoxBullet;
        private System.Windows.Forms.GroupBox groupBoxShop;
        private System.Windows.Forms.Label labelFocusRemover;
    }
}