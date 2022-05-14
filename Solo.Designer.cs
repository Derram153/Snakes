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
            this.label1 = new System.Windows.Forms.Label();
            this.money = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.life = new System.Windows.Forms.Label();
            this.reload = new System.Windows.Forms.Button();
            this.bullet1 = new System.Windows.Forms.PictureBox();
            this.bullet2 = new System.Windows.Forms.PictureBox();
            this.bullet3 = new System.Windows.Forms.PictureBox();
            this.bullet4 = new System.Windows.Forms.PictureBox();
            this.bullet5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bullet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Деньги:";
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 56);
            this.button1.TabIndex = 2;
            this.button1.Text = "Магазин";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(356, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Жизни:";
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
            this.reload.Location = new System.Drawing.Point(394, 152);
            this.reload.Name = "reload";
            this.reload.Size = new System.Drawing.Size(141, 65);
            this.reload.TabIndex = 5;
            this.reload.Text = "Перезарядка";
            this.reload.UseVisualStyleBackColor = true;
            this.reload.Click += new System.EventHandler(this.reload_Click);
            // 
            // bullet1
            // 
            this.bullet1.Image = global::Snakes.Properties.Resources.пуля1;
            this.bullet1.InitialImage = null;
            this.bullet1.Location = new System.Drawing.Point(512, 66);
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
            this.bullet2.Location = new System.Drawing.Point(483, 66);
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
            this.bullet3.Location = new System.Drawing.Point(454, 66);
            this.bullet3.Name = "bullet3";
            this.bullet3.Size = new System.Drawing.Size(23, 80);
            this.bullet3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bullet3.TabIndex = 8;
            this.bullet3.TabStop = false;
            // 
            // bullet4
            // 
            this.bullet4.Image = global::Snakes.Properties.Resources.пуля1;
            this.bullet4.InitialImage = null;
            this.bullet4.Location = new System.Drawing.Point(425, 66);
            this.bullet4.Name = "bullet4";
            this.bullet4.Size = new System.Drawing.Size(23, 80);
            this.bullet4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bullet4.TabIndex = 9;
            this.bullet4.TabStop = false;
            // 
            // bullet5
            // 
            this.bullet5.Image = global::Snakes.Properties.Resources.пуля1;
            this.bullet5.InitialImage = null;
            this.bullet5.Location = new System.Drawing.Point(394, 66);
            this.bullet5.Name = "bullet5";
            this.bullet5.Size = new System.Drawing.Size(23, 80);
            this.bullet5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bullet5.TabIndex = 10;
            this.bullet5.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(2, 55);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(544, 473);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 152);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 50);
            this.button2.TabIndex = 11;
            this.button2.Text = "добавить 1000";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Solo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(547, 531);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bullet5);
            this.Controls.Add(this.bullet4);
            this.Controls.Add(this.bullet3);
            this.Controls.Add(this.bullet2);
            this.Controls.Add(this.bullet1);
            this.Controls.Add(this.reload);
            this.Controls.Add(this.life);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.money);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Solo";
            this.Text = "Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Solo_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.bullet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label life;
        private System.Windows.Forms.Button reload;
        private System.Windows.Forms.PictureBox bullet1;
        private System.Windows.Forms.PictureBox bullet2;
        private System.Windows.Forms.PictureBox bullet3;
        private System.Windows.Forms.PictureBox bullet4;
        private System.Windows.Forms.PictureBox bullet5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Label money;
    }
}