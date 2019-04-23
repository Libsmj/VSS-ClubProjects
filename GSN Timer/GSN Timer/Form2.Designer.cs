namespace GSN_Timer
{
    partial class Form2
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
            this.labelTime2 = new System.Windows.Forms.Label();
            this.labelTime1 = new System.Windows.Forms.Label();
            this.labelInfo1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTime2
            // 
            this.labelTime2.AutoSize = true;
            this.labelTime2.Font = new System.Drawing.Font("Broadway", 340F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime2.Location = new System.Drawing.Point(591, 202);
            this.labelTime2.Name = "labelTime2";
            this.labelTime2.Size = new System.Drawing.Size(1272, 514);
            this.labelTime2.TabIndex = 5;
            this.labelTime2.Text = "1:00";
            // 
            // labelTime1
            // 
            this.labelTime1.AutoSize = true;
            this.labelTime1.Font = new System.Drawing.Font("Broadway", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime1.Location = new System.Drawing.Point(-1, 271);
            this.labelTime1.Name = "labelTime1";
            this.labelTime1.Size = new System.Drawing.Size(586, 109);
            this.labelTime1.TabIndex = 4;
            this.labelTime1.Text = "Time Left:";
            // 
            // labelInfo1
            // 
            this.labelInfo1.AutoSize = true;
            this.labelInfo1.Font = new System.Drawing.Font("Broadway", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo1.Location = new System.Drawing.Point(12, 9);
            this.labelInfo1.Name = "labelInfo1";
            this.labelInfo1.Size = new System.Drawing.Size(1280, 109);
            this.labelInfo1.TabIndex = 3;
            this.labelInfo1.Text = "Game Show Night 2017!";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1777, 898);
            this.Controls.Add(this.labelTime2);
            this.Controls.Add(this.labelTime1);
            this.Controls.Add(this.labelInfo1);
            this.Name = "Form2";
            this.Text = "Game Show Night 2017";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label labelTime2;
        private System.Windows.Forms.Label labelTime1;
        private System.Windows.Forms.Label labelInfo1;
    }
}