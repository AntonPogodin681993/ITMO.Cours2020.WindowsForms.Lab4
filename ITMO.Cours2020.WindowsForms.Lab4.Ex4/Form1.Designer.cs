namespace ITMO.Cours2020.WindowsForms.Lab4.Ex4
{
    partial class Form1
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
            this.textBoxF1 = new System.Windows.Forms.TextBox();
            this.textBoxF2 = new System.Windows.Forms.TextBox();
            this.buttonF1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxF1
            // 
            this.textBoxF1.Location = new System.Drawing.Point(40, 33);
            this.textBoxF1.Name = "textBoxF1";
            this.textBoxF1.Size = new System.Drawing.Size(140, 22);
            this.textBoxF1.TabIndex = 0;
            // 
            // textBoxF2
            // 
            this.textBoxF2.Location = new System.Drawing.Point(305, 32);
            this.textBoxF2.Name = "textBoxF2";
            this.textBoxF2.Size = new System.Drawing.Size(138, 22);
            this.textBoxF2.TabIndex = 1;
            // 
            // buttonF1
            // 
            this.buttonF1.Location = new System.Drawing.Point(40, 89);
            this.buttonF1.Name = "buttonF1";
            this.buttonF1.Size = new System.Drawing.Size(403, 34);
            this.buttonF1.TabIndex = 2;
            this.buttonF1.Text = "Получить данные";
            this.buttonF1.UseVisualStyleBackColor = true;
            this.buttonF1.Click += new System.EventHandler(this.buttonF1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonF1);
            this.Controls.Add(this.textBoxF2);
            this.Controls.Add(this.textBoxF1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxF1;
        private System.Windows.Forms.TextBox textBoxF2;
        private System.Windows.Forms.Button buttonF1;
    }
}

