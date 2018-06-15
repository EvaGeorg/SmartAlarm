namespace AlarmClock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSetAlarm = new System.Windows.Forms.Button();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.upDownMinutes = new System.Windows.Forms.NumericUpDown();
            this.upDownHours = new System.Windows.Forms.NumericUpDown();
            this.upDownPMAM = new System.Windows.Forms.DomainUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.upDownSnooze = new System.Windows.Forms.NumericUpDown();
            this.upDownTimes = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbAlarms = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.lbSongs = new System.Windows.Forms.ListBox();
            this.maze = new System.Windows.Forms.RadioButton();
            this.quiz = new System.Windows.Forms.RadioButton();
            this.shuffle = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.upDownMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownSnooze)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownTimes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSetAlarm
            // 
            this.btnSetAlarm.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSetAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetAlarm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSetAlarm.Location = new System.Drawing.Point(523, 64);
            this.btnSetAlarm.Name = "btnSetAlarm";
            this.btnSetAlarm.Size = new System.Drawing.Size(128, 48);
            this.btnSetAlarm.TabIndex = 0;
            this.btnSetAlarm.Text = "Set Alarm";
            this.btnSetAlarm.UseVisualStyleBackColor = false;
            this.btnSetAlarm.Click += new System.EventHandler(this.btnSetAlarm_Click);
            // 
            // DatePicker
            // 
            this.DatePicker.CalendarMonthBackground = System.Drawing.Color.White;
            this.DatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePicker.Location = new System.Drawing.Point(159, 78);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(325, 23);
            this.DatePicker.TabIndex = 1;
            this.DatePicker.Value = new System.DateTime(2018, 5, 28, 0, 0, 0, 0);
            // 
            // upDownMinutes
            // 
            this.upDownMinutes.BackColor = System.Drawing.Color.White;
            this.upDownMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upDownMinutes.Location = new System.Drawing.Point(279, 130);
            this.upDownMinutes.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.upDownMinutes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.upDownMinutes.Name = "upDownMinutes";
            this.upDownMinutes.Size = new System.Drawing.Size(90, 23);
            this.upDownMinutes.TabIndex = 3;
            this.upDownMinutes.ValueChanged += new System.EventHandler(this.upDownMinutes_ValueChanged);
            // 
            // upDownHours
            // 
            this.upDownHours.BackColor = System.Drawing.Color.White;
            this.upDownHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upDownHours.Location = new System.Drawing.Point(159, 129);
            this.upDownHours.Maximum = new decimal(new int[] {
            13,
            0,
            0,
            0});
            this.upDownHours.Name = "upDownHours";
            this.upDownHours.Size = new System.Drawing.Size(90, 23);
            this.upDownHours.TabIndex = 4;
            this.upDownHours.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.upDownHours.ValueChanged += new System.EventHandler(this.upDownHours_ValueChanged);
            // 
            // upDownPMAM
            // 
            this.upDownPMAM.BackColor = System.Drawing.Color.White;
            this.upDownPMAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upDownPMAM.Items.Add("PM");
            this.upDownPMAM.Items.Add("AM");
            this.upDownPMAM.Location = new System.Drawing.Point(394, 130);
            this.upDownPMAM.Name = "upDownPMAM";
            this.upDownPMAM.ReadOnly = true;
            this.upDownPMAM.Size = new System.Drawing.Size(90, 23);
            this.upDownPMAM.TabIndex = 5;
            this.upDownPMAM.Text = "PM";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // upDownSnooze
            // 
            this.upDownSnooze.BackColor = System.Drawing.Color.White;
            this.upDownSnooze.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upDownSnooze.Location = new System.Drawing.Point(159, 178);
            this.upDownSnooze.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.upDownSnooze.Name = "upDownSnooze";
            this.upDownSnooze.Size = new System.Drawing.Size(90, 23);
            this.upDownSnooze.TabIndex = 6;
            this.upDownSnooze.ValueChanged += new System.EventHandler(this.upDownSnooze_ValueChanged);
            // 
            // upDownTimes
            // 
            this.upDownTimes.BackColor = System.Drawing.Color.White;
            this.upDownTimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upDownTimes.Location = new System.Drawing.Point(159, 231);
            this.upDownTimes.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.upDownTimes.Name = "upDownTimes";
            this.upDownTimes.Size = new System.Drawing.Size(90, 23);
            this.upDownTimes.TabIndex = 7;
            this.upDownTimes.ValueChanged += new System.EventHandler(this.upDownTimes_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(15, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Snooze:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(15, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Limit:";
            // 
            // lbAlarms
            // 
            this.lbAlarms.BackColor = System.Drawing.Color.White;
            this.lbAlarms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAlarms.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbAlarms.FormattingEnabled = true;
            this.lbAlarms.ItemHeight = 20;
            this.lbAlarms.Location = new System.Drawing.Point(558, 183);
            this.lbAlarms.Name = "lbAlarms";
            this.lbAlarms.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbAlarms.Size = new System.Drawing.Size(310, 184);
            this.lbAlarms.TabIndex = 10;
            this.lbAlarms.SelectedIndexChanged += new System.EventHandler(this.lbAlarms_SelectedIndexChanged);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.DarkCyan;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRemove.Location = new System.Drawing.Point(558, 130);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(140, 34);
            this.btnRemove.TabIndex = 11;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.DarkCyan;
            this.btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnChange.Location = new System.Drawing.Point(728, 130);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(140, 34);
            this.btnChange.TabIndex = 12;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // lbSongs
            // 
            this.lbSongs.BackColor = System.Drawing.Color.White;
            this.lbSongs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSongs.FormattingEnabled = true;
            this.lbSongs.ItemHeight = 20;
            this.lbSongs.Location = new System.Drawing.Point(160, 283);
            this.lbSongs.Name = "lbSongs";
            this.lbSongs.Size = new System.Drawing.Size(364, 84);
            this.lbSongs.TabIndex = 13;
            // 
            // maze
            // 
            this.maze.AutoSize = true;
            this.maze.BackColor = System.Drawing.Color.Transparent;
            this.maze.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maze.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.maze.Location = new System.Drawing.Point(159, 408);
            this.maze.Name = "maze";
            this.maze.Size = new System.Drawing.Size(123, 24);
            this.maze.TabIndex = 14;
            this.maze.TabStop = true;
            this.maze.Text = "Maze Game";
            this.maze.UseVisualStyleBackColor = false;
            // 
            // quiz
            // 
            this.quiz.AutoSize = true;
            this.quiz.BackColor = System.Drawing.Color.Transparent;
            this.quiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quiz.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.quiz.Location = new System.Drawing.Point(423, 409);
            this.quiz.Name = "quiz";
            this.quiz.Size = new System.Drawing.Size(116, 24);
            this.quiz.TabIndex = 15;
            this.quiz.TabStop = true;
            this.quiz.Text = "Quiz Game";
            this.quiz.UseVisualStyleBackColor = false;
            // 
            // shuffle
            // 
            this.shuffle.AutoSize = true;
            this.shuffle.BackColor = System.Drawing.Color.Transparent;
            this.shuffle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shuffle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.shuffle.Location = new System.Drawing.Point(279, 408);
            this.shuffle.Name = "shuffle";
            this.shuffle.Size = new System.Drawing.Size(138, 24);
            this.shuffle.TabIndex = 16;
            this.shuffle.TabStop = true;
            this.shuffle.Text = "Shuffle Game";
            this.shuffle.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(399, 38);
            this.label3.TabIndex = 17;
            this.label3.Text = "Snooze Me Alarm Clock ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(15, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Set the date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(15, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Set the time:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(15, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Alarm sound:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(15, 409);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Alarm game:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.75F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(545, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(327, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Change the alarm setting in the current form or remove it";
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.DarkCyan;
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.btnOpen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOpen.Location = new System.Drawing.Point(787, 396);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(81, 31);
            this.btnOpen.TabIndex = 23;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(698, 396);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 31);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 456);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.shuffle);
            this.Controls.Add(this.quiz);
            this.Controls.Add(this.maze);
            this.Controls.Add(this.lbSongs);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lbAlarms);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.upDownTimes);
            this.Controls.Add(this.upDownSnooze);
            this.Controls.Add(this.upDownPMAM);
            this.Controls.Add(this.upDownHours);
            this.Controls.Add(this.upDownMinutes);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.btnSetAlarm);
            this.Name = "Form1";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.upDownMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownSnooze)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownTimes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSetAlarm;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.NumericUpDown upDownMinutes;
        private System.Windows.Forms.NumericUpDown upDownHours;
        private System.Windows.Forms.DomainUpDown upDownPMAM;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown upDownSnooze;
        private System.Windows.Forms.NumericUpDown upDownTimes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbAlarms;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.ListBox lbSongs;
        private System.Windows.Forms.RadioButton maze;
        private System.Windows.Forms.RadioButton quiz;
        private System.Windows.Forms.RadioButton shuffle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
    }
}

