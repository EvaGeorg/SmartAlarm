namespace AlarmClock
{
    partial class GuessWordQuiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuessWordQuiz));
            this.wordQuessMorning = new System.Windows.Forms.Label();
            this.wordGuess = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // wordQuessMorning
            // 
            this.wordQuessMorning.AutoSize = true;
            this.wordQuessMorning.BackColor = System.Drawing.Color.White;
            this.wordQuessMorning.Font = new System.Drawing.Font("Bahnschrift SemiBold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordQuessMorning.ForeColor = System.Drawing.Color.Teal;
            this.wordQuessMorning.Location = new System.Drawing.Point(190, 80);
            this.wordQuessMorning.Name = "wordQuessMorning";
            this.wordQuessMorning.Size = new System.Drawing.Size(121, 48);
            this.wordQuessMorning.TabIndex = 0;
            this.wordQuessMorning.Text = "label1";
            // 
            // wordGuess
            // 
            this.wordGuess.BackColor = System.Drawing.Color.White;
            this.wordGuess.Font = new System.Drawing.Font("Bahnschrift SemiBold", 30F, System.Drawing.FontStyle.Bold);
            this.wordGuess.ForeColor = System.Drawing.Color.Teal;
            this.wordGuess.Location = new System.Drawing.Point(68, 167);
            this.wordGuess.Name = "wordGuess";
            this.wordGuess.Size = new System.Drawing.Size(221, 56);
            this.wordGuess.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tomato;
            this.button1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(335, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 56);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(52, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(399, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "The words are of category \"Morning routine\"";
            // 
            // GuessWordQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(503, 252);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.wordGuess);
            this.Controls.Add(this.wordQuessMorning);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GuessWordQuiz";
            this.Text = "GuessWordQuiz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label wordQuessMorning;
        private System.Windows.Forms.TextBox wordGuess;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}