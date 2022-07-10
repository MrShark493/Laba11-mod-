namespace Laba11_mod_
{
    partial class Form1
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
            this.Frame = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Newton_RB = new System.Windows.Forms.RadioButton();
            this.Bisection_RB = new System.Windows.Forms.RadioButton();
            this.FinalTBox = new System.Windows.Forms.TextBox();
            this.NTBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Frame)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Frame
            // 
            this.Frame.Location = new System.Drawing.Point(12, 12);
            this.Frame.Name = "Frame";
            this.Frame.Size = new System.Drawing.Size(500, 500);
            this.Frame.TabIndex = 0;
            this.Frame.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(567, 489);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Newton_RB);
            this.panel1.Controls.Add(this.Bisection_RB);
            this.panel1.Controls.Add(this.FinalTBox);
            this.panel1.Controls.Add(this.NTBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(552, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 452);
            this.panel1.TabIndex = 2;
            // 
            // Newton_RB
            // 
            this.Newton_RB.AutoSize = true;
            this.Newton_RB.Enabled = false;
            this.Newton_RB.Location = new System.Drawing.Point(21, 102);
            this.Newton_RB.Name = "Newton_RB";
            this.Newton_RB.Size = new System.Drawing.Size(62, 17);
            this.Newton_RB.TabIndex = 4;
            this.Newton_RB.Text = "Newton";
            this.Newton_RB.UseVisualStyleBackColor = true;
            // 
            // Bisection_RB
            // 
            this.Bisection_RB.AutoSize = true;
            this.Bisection_RB.Checked = true;
            this.Bisection_RB.Location = new System.Drawing.Point(21, 66);
            this.Bisection_RB.Name = "Bisection_RB";
            this.Bisection_RB.Size = new System.Drawing.Size(68, 17);
            this.Bisection_RB.TabIndex = 3;
            this.Bisection_RB.TabStop = true;
            this.Bisection_RB.Text = "Bisection";
            this.Bisection_RB.UseVisualStyleBackColor = true;
            // 
            // FinalTBox
            // 
            this.FinalTBox.Location = new System.Drawing.Point(3, 429);
            this.FinalTBox.Name = "FinalTBox";
            this.FinalTBox.Size = new System.Drawing.Size(194, 20);
            this.FinalTBox.TabIndex = 2;
            // 
            // NTBox
            // 
            this.NTBox.Location = new System.Drawing.Point(90, 27);
            this.NTBox.Name = "NTBox";
            this.NTBox.Size = new System.Drawing.Size(30, 20);
            this.NTBox.TabIndex = 1;
            this.NTBox.Text = "2";
            this.NTBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NTBox_KeyDown);
            this.NTBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NTBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Значение N";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 525);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Frame);
            this.Name = "Form1";
            this.Text = "Laba 1.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Frame)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Frame;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox NTBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FinalTBox;
        private System.Windows.Forms.RadioButton Newton_RB;
        private System.Windows.Forms.RadioButton Bisection_RB;
    }
}

