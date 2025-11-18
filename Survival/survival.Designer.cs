namespace Survival
{
    partial class survival
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            HitPoints = new Label();
            Gold = new Label();
            Experience = new Label();
            Level = new Label();
            btnTest = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 20);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 0;
            label1.Text = "Hit points";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 46);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 1;
            label2.Text = "Gold";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 74);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 2;
            label3.Text = "Experience";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 100);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 3;
            label4.Text = "Level";
            // 
            // HitPoints
            // 
            HitPoints.AutoSize = true;
            HitPoints.Location = new Point(110, 19);
            HitPoints.Name = "HitPoints";
            HitPoints.Size = new Size(50, 20);
            HitPoints.TabIndex = 4;
            HitPoints.Text = "label5";
            // 
            // Gold
            // 
            Gold.AutoSize = true;
            Gold.Location = new Point(110, 46);
            Gold.Name = "Gold";
            Gold.Size = new Size(50, 20);
            Gold.TabIndex = 5;
            Gold.Text = "label6";
            // 
            // Experience
            // 
            Experience.AutoSize = true;
            Experience.Location = new Point(110, 74);
            Experience.Name = "Experience";
            Experience.Size = new Size(50, 20);
            Experience.TabIndex = 6;
            Experience.Text = "label7";
            // 
            // Level
            // 
            Level.AutoSize = true;
            Level.Location = new Point(110, 100);
            Level.Name = "Level";
            Level.Size = new Size(50, 20);
            Level.TabIndex = 7;
            Level.Text = "label8";
            // 
            // btnTest
            // 
            btnTest.Location = new Point(223, 207);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(94, 29);
            btnTest.TabIndex = 8;
            btnTest.Text = "Test";
            btnTest.UseVisualStyleBackColor = true;
            btnTest.Click += btnTest_Click;
            // 
            // survival
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(717, 643);
            Controls.Add(btnTest);
            Controls.Add(Level);
            Controls.Add(Experience);
            Controls.Add(Gold);
            Controls.Add(HitPoints);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "survival";
            Text = "MyGame";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label HitPoints;
        private Label Gold;
        private Label Experience;
        private Label Level;
        private Button btnTest;
    }
}
