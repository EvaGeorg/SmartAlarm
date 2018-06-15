namespace AlarmClock
{
    partial class SnoozeIt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SnoozeIt));
            this.Stop = new System.Windows.Forms.Button();
            this.snooze = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // Stop
            // 
            this.Stop.BackColor = System.Drawing.Color.Coral;
            this.Stop.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stop.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Stop.Location = new System.Drawing.Point(12, 45);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(120, 64);
            this.Stop.TabIndex = 0;
            this.Stop.Text = "I\'m awake";
            this.Stop.UseVisualStyleBackColor = false;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // snooze
            // 
            this.snooze.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.snooze.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snooze.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.snooze.Location = new System.Drawing.Point(152, 45);
            this.snooze.Name = "snooze";
            this.snooze.Size = new System.Drawing.Size(120, 64);
            this.snooze.TabIndex = 1;
            this.snooze.Text = "Snooze";
            this.snooze.UseVisualStyleBackColor = false;
            this.snooze.Click += new System.EventHandler(this.snooze_Click);
            // 
            // SnoozeIt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 162);
            this.Controls.Add(this.snooze);
            this.Controls.Add(this.Stop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SnoozeIt";
            this.Text = "SnoozeIt";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button snooze;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}