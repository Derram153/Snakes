namespace Snakes
{
    partial class Shop
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
            this.price1 = new System.Windows.Forms.Label();
            this.price2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.moneyshop = new System.Windows.Forms.Label();
            this.rifle = new System.Windows.Forms.Button();
            this.automat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // price1
            // 
            this.price1.AutoSize = true;
            this.price1.Location = new System.Drawing.Point(159, 41);
            this.price1.Name = "price1";
            this.price1.Size = new System.Drawing.Size(31, 13);
            this.price1.TabIndex = 2;
            this.price1.Text = "2400";
            // 
            // price2
            // 
            this.price2.AutoSize = true;
            this.price2.Location = new System.Drawing.Point(159, 123);
            this.price2.Name = "price2";
            this.price2.Size = new System.Drawing.Size(31, 13);
            this.price2.TabIndex = 3;
            this.price2.Text = "3600";
            this.price2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ваши деньги:";
            // 
            // moneyshop
            // 
            this.moneyshop.AutoSize = true;
            this.moneyshop.Location = new System.Drawing.Point(337, 23);
            this.moneyshop.Name = "moneyshop";
            this.moneyshop.Size = new System.Drawing.Size(13, 13);
            this.moneyshop.TabIndex = 5;
            this.moneyshop.Text = "0";
            // 
            // rifle
            // 
            this.rifle.BackColor = System.Drawing.SystemColors.Control;
            this.rifle.BackgroundImage = global::Snakes.Properties.Resources.снайперка;
            this.rifle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rifle.Location = new System.Drawing.Point(12, 105);
            this.rifle.Name = "rifle";
            this.rifle.Size = new System.Drawing.Size(141, 48);
            this.rifle.TabIndex = 1;
            this.rifle.UseVisualStyleBackColor = false;
            this.rifle.Click += new System.EventHandler(this.rifle_Click);
            // 
            // automat
            // 
            this.automat.BackgroundImage = global::Snakes.Properties.Resources.автомат2;
            this.automat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.automat.Location = new System.Drawing.Point(12, 23);
            this.automat.Name = "automat";
            this.automat.Size = new System.Drawing.Size(141, 48);
            this.automat.TabIndex = 0;
            this.automat.UseVisualStyleBackColor = true;
            this.automat.Click += new System.EventHandler(this.automat_Click);
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 221);
            this.Controls.Add(this.moneyshop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.price2);
            this.Controls.Add(this.price1);
            this.Controls.Add(this.rifle);
            this.Controls.Add(this.automat);
            this.Name = "Shop";
            this.Text = "Shop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button automat;
        private System.Windows.Forms.Button rifle;
        private System.Windows.Forms.Label price1;
        private System.Windows.Forms.Label price2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label moneyshop;
    }
}