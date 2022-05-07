namespace Snakes
{
    partial class MainMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.SoloBut = new System.Windows.Forms.Button();
            this.DuoBut = new System.Windows.Forms.Button();
            this.ExitBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SoloBut
            // 
            this.SoloBut.Location = new System.Drawing.Point(100, 35);
            this.SoloBut.Name = "SoloBut";
            this.SoloBut.Size = new System.Drawing.Size(200, 50);
            this.SoloBut.TabIndex = 0;
            this.SoloBut.Text = "Игра одному";
            this.SoloBut.UseVisualStyleBackColor = true;
            // 
            // DuoBut
            // 
            this.DuoBut.Location = new System.Drawing.Point(100, 95);
            this.DuoBut.Name = "DuoBut";
            this.DuoBut.Size = new System.Drawing.Size(200, 50);
            this.DuoBut.TabIndex = 0;
            this.DuoBut.Text = "Игра вдвоем";
            this.DuoBut.UseVisualStyleBackColor = true;
            // 
            // ExitBut
            // 
            this.ExitBut.Location = new System.Drawing.Point(100, 155);
            this.ExitBut.Name = "ExitBut";
            this.ExitBut.Size = new System.Drawing.Size(200, 50);
            this.ExitBut.TabIndex = 0;
            this.ExitBut.Text = "Выход";
            this.ExitBut.UseVisualStyleBackColor = true;
            this.ExitBut.Click += new System.EventHandler(this.ExitBut_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(382, 353);
            this.Controls.Add(this.ExitBut);
            this.Controls.Add(this.DuoBut);
            this.Controls.Add(this.SoloBut);
            this.Name = "MainMenu";
            this.Text = "Snakiez";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SoloBut;
        private System.Windows.Forms.Button DuoBut;
        private System.Windows.Forms.Button ExitBut;
    }
}

