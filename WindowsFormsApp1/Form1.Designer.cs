namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.PlayButton = new System.Windows.Forms.Label();
            this.Go1 = new System.Windows.Forms.Label();
            this.Go2 = new System.Windows.Forms.Label();
            this.Go3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(351, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // PlayButton
            // 
            this.PlayButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PlayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.PlayButton.Location = new System.Drawing.Point(265, 23);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(324, 128);
            this.PlayButton.TabIndex = 1;
            this.PlayButton.Text = "Start Game";
            this.PlayButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PlayButton.Click += new System.EventHandler(this.label2_Click);
            // 
            // Go1
            // 
            this.Go1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Go1.Location = new System.Drawing.Point(688, 65);
            this.Go1.Name = "Go1";
            this.Go1.Size = new System.Drawing.Size(100, 23);
            this.Go1.TabIndex = 2;
            this.Go1.Text = "Go";
            this.Go1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Go2
            // 
            this.Go2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Go2.Location = new System.Drawing.Point(12, 65);
            this.Go2.Name = "Go2";
            this.Go2.Size = new System.Drawing.Size(100, 23);
            this.Go2.TabIndex = 3;
            this.Go2.Text = "Go";
            this.Go2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Go3
            // 
            this.Go3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Go3.Location = new System.Drawing.Point(350, 214);
            this.Go3.Name = "Go3";
            this.Go3.Size = new System.Drawing.Size(100, 23);
            this.Go3.TabIndex = 4;
            this.Go3.Text = "Go";
            this.Go3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Go3);
            this.Controls.Add(this.Go2);
            this.Controls.Add(this.Go1);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PlayButton;
        private System.Windows.Forms.Label Go1;
        private System.Windows.Forms.Label Go2;
        private System.Windows.Forms.Label Go3;
    }
}

