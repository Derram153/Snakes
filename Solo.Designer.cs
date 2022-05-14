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
            this.moneyLabel = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.bullet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet5)).BeginInit();
            this.SuspendLayout();
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.moneyLabel.Location = new System.Drawing.Point(12, 9);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(86, 25);
            this.moneyLabel.TabIndex = 1;
            this.moneyLabel.Text = "Деньги:";
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
            this.shopButton.Location = new System.Drawing.Point(3, 68);
            this.shopButton.Margin = new System.Windows.Forms.Padding(4);
            this.shopButton.Name = "shopButton";
            this.shopButton.Size = new System.Drawing.Size(233, 69);
            this.shopButton.TabIndex = 2;
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
            this.reload.Location = new System.Drawing.Point(525, 187);
            this.reload.Margin = new System.Windows.Forms.Padding(4);
            this.reload.Name = "reload";
            this.reload.Size = new System.Drawing.Size(188, 80);
            this.reload.TabIndex = 5;
            this.reload.Text = "Перезарядка";
            this.reload.UseVisualStyleBackColor = true;
            this.reload.Click += new System.EventHandler(this.reload_Click);
            // 
            // bullet1
            // 
            this.bullet1.Image = global::Snakes.Properties.Resources.пуля1;
            this.bullet1.InitialImage = null;
            this.bullet1.Location = new System.Drawing.Point(683, 81);
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
            this.bullet2.Location = new System.Drawing.Point(644, 81);
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
            this.bullet3.Location = new System.Drawing.Point(605, 81);
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
            this.bullet4.Location = new System.Drawing.Point(567, 81);
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
            this.bullet5.Location = new System.Drawing.Point(525, 81);
            this.bullet5.Margin = new System.Windows.Forms.Padding(4);
            this.bullet5.Name = "bullet5";
            this.bullet5.Size = new System.Drawing.Size(31, 98);
            this.bullet5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bullet5.TabIndex = 10;
            this.bullet5.TabStop = false;
            // 
            // AddMoney
            // 
            this.AddMoney.Location = new System.Drawing.Point(17, 187);
            this.AddMoney.Margin = new System.Windows.Forms.Padding(4);
            this.AddMoney.Name = "AddMoney";
            this.AddMoney.Size = new System.Drawing.Size(253, 62);
            this.AddMoney.TabIndex = 11;
            this.AddMoney.Text = "добавить 1000";
            this.AddMoney.UseVisualStyleBackColor = true;
            this.AddMoney.Click += new System.EventHandler(this.AddMoney_Click);
            // 
            // Solo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(729, 654);
            this.Controls.Add(this.AddMoney);
            this.Controls.Add(this.bullet5);
            this.Controls.Add(this.bullet4);
            this.Controls.Add(this.bullet3);
            this.Controls.Add(this.bullet2);
            this.Controls.Add(this.bullet1);
            this.Controls.Add(this.reload);
            this.Controls.Add(this.life);
            this.Controls.Add(this.healthLabel);
            this.Controls.Add(this.shopButton);
            this.Controls.Add(this.money);
            this.Controls.Add(this.moneyLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Solo";
            this.Text = "Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Solo_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.bullet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label moneyLabel;
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
    }
}