namespace AlarmClock
{
    partial class AnswerQuestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnswerQuestion));
            this.firstQ = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.secondQ = new System.Windows.Forms.Label();
            this.answer1 = new System.Windows.Forms.TextBox();
            this.answer2 = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstQ
            // 
            this.firstQ.AutoSize = true;
            this.firstQ.BackColor = System.Drawing.Color.White;
            this.firstQ.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstQ.ForeColor = System.Drawing.Color.Teal;
            this.firstQ.Location = new System.Drawing.Point(10, 75);
            this.firstQ.Name = "firstQ";
            this.firstQ.Size = new System.Drawing.Size(74, 29);
            this.firstQ.TabIndex = 0;
            this.firstQ.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(177, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(559, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "The questions are on the topic of General Knowledge";
            // 
            // secondQ
            // 
            this.secondQ.AutoSize = true;
            this.secondQ.BackColor = System.Drawing.Color.White;
            this.secondQ.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondQ.ForeColor = System.Drawing.Color.Teal;
            this.secondQ.Location = new System.Drawing.Point(10, 146);
            this.secondQ.Name = "secondQ";
            this.secondQ.Size = new System.Drawing.Size(79, 29);
            this.secondQ.TabIndex = 2;
            this.secondQ.Text = "label3";
            // 
            // answer1
            // 
            this.answer1.BackColor = System.Drawing.Color.White;
            this.answer1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold);
            this.answer1.ForeColor = System.Drawing.Color.Teal;
            this.answer1.Location = new System.Drawing.Point(753, 68);
            this.answer1.Name = "answer1";
            this.answer1.Size = new System.Drawing.Size(174, 36);
            this.answer1.TabIndex = 3;
            // 
            // answer2
            // 
            this.answer2.BackColor = System.Drawing.Color.White;
            this.answer2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold);
            this.answer2.ForeColor = System.Drawing.Color.Teal;
            this.answer2.Location = new System.Drawing.Point(753, 139);
            this.answer2.Name = "answer2";
            this.answer2.Size = new System.Drawing.Size(174, 36);
            this.answer2.TabIndex = 4;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Salmon;
            this.btnOK.Font = new System.Drawing.Font("Bahnschrift SemiBold", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(377, 219);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(156, 39);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // AnswerQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(939, 270);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.answer2);
            this.Controls.Add(this.answer1);
            this.Controls.Add(this.secondQ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstQ);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnswerQuestion";
            this.Text = "AnswerQuestion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstQ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label secondQ;
        private System.Windows.Forms.TextBox answer1;
        private System.Windows.Forms.TextBox answer2;
        private System.Windows.Forms.Button btnOK;
    }
}