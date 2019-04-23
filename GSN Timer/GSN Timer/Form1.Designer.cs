namespace GSN_Timer
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
            this.components = new System.ComponentModel.Container();
            this.buttonTime1 = new System.Windows.Forms.Button();
            this.buttonTime5 = new System.Windows.Forms.Button();
            this.buttonTime8 = new System.Windows.Forms.Button();
            this.buttonTimeSet = new System.Windows.Forms.Button();
            this.textBoxCustomTimeMinutes = new System.Windows.Forms.TextBox();
            this.labelInfo1 = new System.Windows.Forms.Label();
            this.buttonTimeStart = new System.Windows.Forms.Button();
            this.buttonTimeStop = new System.Windows.Forms.Button();
            this.buttonBuzz = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCustomTimeSeconds = new System.Windows.Forms.TextBox();
            this.labelTimeDisplay = new System.Windows.Forms.Label();
            this.checkBoxBuzz = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonTime1
            // 
            this.buttonTime1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTime1.Location = new System.Drawing.Point(12, 12);
            this.buttonTime1.Name = "buttonTime1";
            this.buttonTime1.Size = new System.Drawing.Size(156, 75);
            this.buttonTime1.TabIndex = 0;
            this.buttonTime1.Text = "1 Minute";
            this.buttonTime1.UseVisualStyleBackColor = true;
            this.buttonTime1.Click += new System.EventHandler(this.buttonTime1_Click);
            // 
            // buttonTime5
            // 
            this.buttonTime5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTime5.Location = new System.Drawing.Point(12, 93);
            this.buttonTime5.Name = "buttonTime5";
            this.buttonTime5.Size = new System.Drawing.Size(156, 75);
            this.buttonTime5.TabIndex = 1;
            this.buttonTime5.Text = "5 Minutes";
            this.buttonTime5.UseVisualStyleBackColor = true;
            this.buttonTime5.Click += new System.EventHandler(this.buttonTime5_Click);
            // 
            // buttonTime8
            // 
            this.buttonTime8.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTime8.Location = new System.Drawing.Point(12, 174);
            this.buttonTime8.Name = "buttonTime8";
            this.buttonTime8.Size = new System.Drawing.Size(156, 75);
            this.buttonTime8.TabIndex = 2;
            this.buttonTime8.Text = "8 Minute";
            this.buttonTime8.UseVisualStyleBackColor = true;
            this.buttonTime8.Click += new System.EventHandler(this.buttonTime8_Click);
            // 
            // buttonTimeSet
            // 
            this.buttonTimeSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimeSet.Location = new System.Drawing.Point(172, 93);
            this.buttonTimeSet.Name = "buttonTimeSet";
            this.buttonTimeSet.Size = new System.Drawing.Size(156, 35);
            this.buttonTimeSet.TabIndex = 3;
            this.buttonTimeSet.Text = "Set Time";
            this.buttonTimeSet.UseVisualStyleBackColor = true;
            this.buttonTimeSet.Click += new System.EventHandler(this.buttonTimeSet_Click);
            // 
            // textBoxCustomTimeMinutes
            // 
            this.textBoxCustomTimeMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustomTimeMinutes.Location = new System.Drawing.Point(172, 56);
            this.textBoxCustomTimeMinutes.Name = "textBoxCustomTimeMinutes";
            this.textBoxCustomTimeMinutes.Size = new System.Drawing.Size(47, 31);
            this.textBoxCustomTimeMinutes.TabIndex = 4;
            // 
            // labelInfo1
            // 
            this.labelInfo1.AutoSize = true;
            this.labelInfo1.Font = new System.Drawing.Font("Microsoft NeoGothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo1.Location = new System.Drawing.Point(171, 21);
            this.labelInfo1.Name = "labelInfo1";
            this.labelInfo1.Size = new System.Drawing.Size(157, 32);
            this.labelInfo1.TabIndex = 5;
            this.labelInfo1.Text = "Custom Time";
            // 
            // buttonTimeStart
            // 
            this.buttonTimeStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimeStart.Location = new System.Drawing.Point(172, 133);
            this.buttonTimeStart.Name = "buttonTimeStart";
            this.buttonTimeStart.Size = new System.Drawing.Size(156, 35);
            this.buttonTimeStart.TabIndex = 6;
            this.buttonTimeStart.Text = "Start";
            this.buttonTimeStart.UseVisualStyleBackColor = true;
            this.buttonTimeStart.Click += new System.EventHandler(this.buttonTimeStart_Click);
            // 
            // buttonTimeStop
            // 
            this.buttonTimeStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimeStop.Location = new System.Drawing.Point(172, 174);
            this.buttonTimeStop.Name = "buttonTimeStop";
            this.buttonTimeStop.Size = new System.Drawing.Size(156, 35);
            this.buttonTimeStop.TabIndex = 7;
            this.buttonTimeStop.Text = "Stop";
            this.buttonTimeStop.UseVisualStyleBackColor = true;
            this.buttonTimeStop.Click += new System.EventHandler(this.buttonTimeStop_Click);
            // 
            // buttonBuzz
            // 
            this.buttonBuzz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuzz.Location = new System.Drawing.Point(172, 214);
            this.buttonBuzz.Name = "buttonBuzz";
            this.buttonBuzz.Size = new System.Drawing.Size(156, 35);
            this.buttonBuzz.TabIndex = 8;
            this.buttonBuzz.Text = "Buzz";
            this.buttonBuzz.UseVisualStyleBackColor = true;
            this.buttonBuzz.Click += new System.EventHandler(this.buttonBuzz_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft NeoGothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = ":";
            // 
            // textBoxCustomTimeSeconds
            // 
            this.textBoxCustomTimeSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustomTimeSeconds.Location = new System.Drawing.Point(240, 56);
            this.textBoxCustomTimeSeconds.Name = "textBoxCustomTimeSeconds";
            this.textBoxCustomTimeSeconds.Size = new System.Drawing.Size(72, 31);
            this.textBoxCustomTimeSeconds.TabIndex = 10;
            // 
            // labelTimeDisplay
            // 
            this.labelTimeDisplay.AutoSize = true;
            this.labelTimeDisplay.Font = new System.Drawing.Font("Microsoft NeoGothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeDisplay.Location = new System.Drawing.Point(169, 6);
            this.labelTimeDisplay.Name = "labelTimeDisplay";
            this.labelTimeDisplay.Size = new System.Drawing.Size(47, 21);
            this.labelTimeDisplay.TabIndex = 11;
            this.labelTimeDisplay.Text = "Time:";
            // 
            // checkBoxBuzz
            // 
            this.checkBoxBuzz.AutoSize = true;
            this.checkBoxBuzz.Checked = true;
            this.checkBoxBuzz.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBuzz.Location = new System.Drawing.Point(267, 9);
            this.checkBoxBuzz.Name = "checkBoxBuzz";
            this.checkBoxBuzz.Size = new System.Drawing.Size(74, 17);
            this.checkBoxBuzz.TabIndex = 12;
            this.checkBoxBuzz.Text = "Auto Buzz";
            this.checkBoxBuzz.UseVisualStyleBackColor = true;
            this.checkBoxBuzz.CheckedChanged += new System.EventHandler(this.checkBoxBuzz_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 271);
            this.Controls.Add(this.checkBoxBuzz);
            this.Controls.Add(this.labelTimeDisplay);
            this.Controls.Add(this.textBoxCustomTimeSeconds);
            this.Controls.Add(this.textBoxCustomTimeMinutes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBuzz);
            this.Controls.Add(this.buttonTimeStop);
            this.Controls.Add(this.buttonTimeStart);
            this.Controls.Add(this.labelInfo1);
            this.Controls.Add(this.buttonTimeSet);
            this.Controls.Add(this.buttonTime8);
            this.Controls.Add(this.buttonTime5);
            this.Controls.Add(this.buttonTime1);
            this.Name = "Form1";
            this.Text = "Game Show Night 2017!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTime1;
        private System.Windows.Forms.Button buttonTime5;
        private System.Windows.Forms.Button buttonTime8;
        private System.Windows.Forms.Button buttonTimeSet;
        private System.Windows.Forms.TextBox textBoxCustomTimeMinutes;
        private System.Windows.Forms.Label labelInfo1;
        private System.Windows.Forms.Button buttonTimeStart;
        private System.Windows.Forms.Button buttonTimeStop;
        private System.Windows.Forms.Button buttonBuzz;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCustomTimeSeconds;
        private System.Windows.Forms.Label labelTimeDisplay;
        private System.Windows.Forms.CheckBox checkBoxBuzz;
    }
}

