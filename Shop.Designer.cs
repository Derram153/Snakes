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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shop));
            this.automat = new System.Windows.Forms.Button();
            this.rifle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // automat
            // 
            this.automat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("automat.BackgroundImage")));
            this.automat.Location = new System.Drawing.Point(12, 23);
            this.automat.Name = "automat";
            this.automat.Size = new System.Drawing.Size(141, 48);
            this.automat.TabIndex = 0;
            this.automat.UseVisualStyleBackColor = true;
            // 
            // rifle
            // 
            this.rifle.BackColor = System.Drawing.SystemColors.Control;
            this.rifle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rifle.BackgroundImage")));
            this.rifle.Location = new System.Drawing.Point(12, 105);
            this.rifle.Name = "rifle";
            this.rifle.Size = new System.Drawing.Size(141, 48);
            this.rifle.TabIndex = 1;
            this.rifle.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "2400";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "3600";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 221);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}