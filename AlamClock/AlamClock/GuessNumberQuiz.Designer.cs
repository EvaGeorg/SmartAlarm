﻿namespace AlarmClock
{
    partial class GuessNumberQuiz
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
            this.guessBtn = new System.Windows.Forms.Button();
            this.guessLabel = new System.Windows.Forms.Label();
            this.guessBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // guessBtn
            // 
            this.guessBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessBtn.Location = new System.Drawing.Point(12, 132);
            this.guessBtn.Name = "guessBtn";
            this.guessBtn.Size = new System.Drawing.Size(346, 30);
            this.guessBtn.TabIndex = 2;
            this.guessBtn.Text = "Guess";
            this.guessBtn.UseVisualStyleBackColor = true;
            this.guessBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // guessLabel
            // 
            this.guessLabel.AutoSize = true;
            this.guessLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessLabel.Location = new System.Drawing.Point(12, 9);
            this.guessLabel.Name = "guessLabel";
            this.guessLabel.Size = new System.Drawing.Size(0, 24);
            this.guessLabel.TabIndex = 3;
            // 
            // guessBox
            // 
            this.guessBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessBox.Location = new System.Drawing.Point(12, 71);
            this.guessBox.Name = "guessBox";
            this.guessBox.Size = new System.Drawing.Size(346, 29);
            this.guessBox.TabIndex = 4;
            // 
            // GuessNumberQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 186);
            this.Controls.Add(this.guessBox);
            this.Controls.Add(this.guessLabel);
            this.Controls.Add(this.guessBtn);
            this.Name = "GuessNumberQuiz";
            this.Text = "GuessNumberQuiz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button guessBtn;
        private System.Windows.Forms.Label guessLabel;
        private System.Windows.Forms.TextBox guessBox;
    }
}