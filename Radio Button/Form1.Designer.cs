namespace Radio_Button
{
    partial class fTeaVsCofee
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
            gbChoice = new GroupBox();
            pPanel2 = new Panel();
            rMocha = new RadioButton();
            rBlackCofee = new RadioButton();
            pPanel1 = new Panel();
            rBlackTea = new RadioButton();
            rGreenTea = new RadioButton();
            rbChoice2 = new RadioButton();
            rbChoice1 = new RadioButton();
            bEnter = new Button();
            bEnter2 = new Button();
            gbLearningStyle = new GroupBox();
            rbReading = new RadioButton();
            rbListening = new RadioButton();
            gbChoice.SuspendLayout();
            pPanel2.SuspendLayout();
            pPanel1.SuspendLayout();
            gbLearningStyle.SuspendLayout();
            SuspendLayout();
            // 
            // gbChoice
            // 
            gbChoice.Controls.Add(pPanel2);
            gbChoice.Controls.Add(pPanel1);
            gbChoice.Controls.Add(rbChoice2);
            gbChoice.Controls.Add(rbChoice1);
            gbChoice.Location = new Point(62, 69);
            gbChoice.Name = "gbChoice";
            gbChoice.Size = new Size(371, 220);
            gbChoice.TabIndex = 0;
            gbChoice.TabStop = false;
            gbChoice.Text = "What do you like?";
            // 
            // pPanel2
            // 
            pPanel2.Controls.Add(rMocha);
            pPanel2.Controls.Add(rBlackCofee);
            pPanel2.Location = new Point(177, 121);
            pPanel2.Name = "pPanel2";
            pPanel2.Size = new Size(165, 75);
            pPanel2.TabIndex = 3;
            // 
            // rMocha
            // 
            rMocha.AutoSize = true;
            rMocha.Location = new Point(18, 43);
            rMocha.Name = "rMocha";
            rMocha.Size = new Size(62, 19);
            rMocha.TabIndex = 1;
            rMocha.TabStop = true;
            rMocha.Text = "Mocha";
            rMocha.UseVisualStyleBackColor = true;
            // 
            // rBlackCofee
            // 
            rBlackCofee.AutoSize = true;
            rBlackCofee.Location = new Point(19, 12);
            rBlackCofee.Name = "rBlackCofee";
            rBlackCofee.Size = new Size(91, 19);
            rBlackCofee.TabIndex = 0;
            rBlackCofee.TabStop = true;
            rBlackCofee.Text = "Black Coffee";
            rBlackCofee.UseVisualStyleBackColor = true;
            // 
            // pPanel1
            // 
            pPanel1.Controls.Add(rBlackTea);
            pPanel1.Controls.Add(rGreenTea);
            pPanel1.Location = new Point(176, 24);
            pPanel1.Name = "pPanel1";
            pPanel1.Size = new Size(166, 76);
            pPanel1.TabIndex = 2;
            // 
            // rBlackTea
            // 
            rBlackTea.AutoSize = true;
            rBlackTea.Location = new Point(13, 45);
            rBlackTea.Name = "rBlackTea";
            rBlackTea.Size = new Size(73, 19);
            rBlackTea.TabIndex = 1;
            rBlackTea.TabStop = true;
            rBlackTea.Text = "Black Tea";
            rBlackTea.UseVisualStyleBackColor = true;
            // 
            // rGreenTea
            // 
            rGreenTea.AutoSize = true;
            rGreenTea.Location = new Point(15, 8);
            rGreenTea.Name = "rGreenTea";
            rGreenTea.Size = new Size(76, 19);
            rGreenTea.TabIndex = 0;
            rGreenTea.TabStop = true;
            rGreenTea.Text = "Green Tea";
            rGreenTea.UseVisualStyleBackColor = true;
            // 
            // rbChoice2
            // 
            rbChoice2.AutoSize = true;
            rbChoice2.Location = new Point(32, 125);
            rbChoice2.Name = "rbChoice2";
            rbChoice2.Size = new Size(56, 19);
            rbChoice2.TabIndex = 1;
            rbChoice2.Text = "Cofee";
            rbChoice2.UseVisualStyleBackColor = true;
            rbChoice2.CheckedChanged += rbChoice2_CheckedChanged;
            // 
            // rbChoice1
            // 
            rbChoice1.AutoSize = true;
            rbChoice1.Location = new Point(24, 49);
            rbChoice1.Name = "rbChoice1";
            rbChoice1.Size = new Size(42, 19);
            rbChoice1.TabIndex = 0;
            rbChoice1.Text = "Tea";
            rbChoice1.UseVisualStyleBackColor = true;
            rbChoice1.CheckedChanged += rbChoice1_CheckedChanged;
            // 
            // bEnter
            // 
            bEnter.Location = new Point(209, 295);
            bEnter.Name = "bEnter";
            bEnter.Size = new Size(75, 23);
            bEnter.TabIndex = 1;
            bEnter.Text = "Enter";
            bEnter.UseVisualStyleBackColor = true;
            bEnter.Click += bEnter_Click;
            // 
            // bEnter2
            // 
            bEnter2.Location = new Point(685, 295);
            bEnter2.Name = "bEnter2";
            bEnter2.Size = new Size(75, 23);
            bEnter2.TabIndex = 3;
            bEnter2.Text = "Enter";
            bEnter2.UseVisualStyleBackColor = true;
            // 
            // gbLearningStyle
            // 
            gbLearningStyle.Controls.Add(rbReading);
            gbLearningStyle.Controls.Add(rbListening);
            gbLearningStyle.Location = new Point(538, 69);
            gbLearningStyle.Name = "gbLearningStyle";
            gbLearningStyle.Size = new Size(371, 220);
            gbLearningStyle.TabIndex = 2;
            gbLearningStyle.TabStop = false;
            gbLearningStyle.Text = "Learning Style";
            // 
            // rbReading
            // 
            rbReading.AutoSize = true;
            rbReading.Location = new Point(32, 125);
            rbReading.Name = "rbReading";
            rbReading.Size = new Size(68, 19);
            rbReading.TabIndex = 1;
            rbReading.Text = "Reading";
            rbReading.UseVisualStyleBackColor = true;
            // 
            // rbListening
            // 
            rbListening.AutoSize = true;
            rbListening.Location = new Point(24, 49);
            rbListening.Name = "rbListening";
            rbListening.Size = new Size(73, 19);
            rbListening.TabIndex = 0;
            rbListening.Text = "Listening";
            rbListening.UseVisualStyleBackColor = true;
            // 
            // fTeaVsCofee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1138, 630);
            Controls.Add(bEnter2);
            Controls.Add(gbLearningStyle);
            Controls.Add(bEnter);
            Controls.Add(gbChoice);
            Name = "fTeaVsCofee";
            Text = "Tea vs Cofee";
            gbChoice.ResumeLayout(false);
            gbChoice.PerformLayout();
            pPanel2.ResumeLayout(false);
            pPanel2.PerformLayout();
            pPanel1.ResumeLayout(false);
            pPanel1.PerformLayout();
            gbLearningStyle.ResumeLayout(false);
            gbLearningStyle.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbChoice;
        private RadioButton rbChoice2;
        private RadioButton rbChoice1;
        private Button bEnter;
        private Button bEnter2;
        private GroupBox gbLearningStyle;
        private RadioButton rbReading;
        private RadioButton rbListening;
        private Panel pPanel2;
        private RadioButton rMocha;
        private RadioButton rBlackCofee;
        private Panel pPanel1;
        private RadioButton rBlackTea;
        private RadioButton rGreenTea;
    }
}
