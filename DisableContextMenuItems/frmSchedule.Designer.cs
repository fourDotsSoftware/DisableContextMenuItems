namespace DisableContextMenuItems
{
    partial class frmSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSchedule));
            this.button2 = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.chkSun = new System.Windows.Forms.CheckBox();
            this.chkSat = new System.Windows.Forms.CheckBox();
            this.chkFri = new System.Windows.Forms.CheckBox();
            this.chkThu = new System.Windows.Forms.CheckBox();
            this.chkWed = new System.Windows.Forms.CheckBox();
            this.chkTue = new System.Windows.Forms.CheckBox();
            this.chkMon = new System.Windows.Forms.CheckBox();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.lblSWeek = new System.Windows.Forms.Label();
            this.lblSEnd = new System.Windows.Forms.Label();
            this.lblSStart = new System.Windows.Forms.Label();
            this.cmbSchedule = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button2.Image = global::DisableContextMenuItems.Properties.Resources.exit;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(361, 224);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 29);
            this.button2.TabIndex = 33;
            this.button2.Text = "&Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnOK.Image = global::DisableContextMenuItems.Properties.Resources.check;
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(207, 224);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(135, 29);
            this.btnOK.TabIndex = 32;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // chkSun
            // 
            this.chkSun.AutoSize = true;
            this.chkSun.BackColor = System.Drawing.Color.Transparent;
            this.chkSun.Checked = true;
            this.chkSun.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.chkSun.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkSun.Location = new System.Drawing.Point(599, 174);
            this.chkSun.Name = "chkSun";
            this.chkSun.Size = new System.Drawing.Size(73, 20);
            this.chkSun.TabIndex = 28;
            this.chkSun.Text = "Sunday";
            this.chkSun.UseVisualStyleBackColor = false;
            this.chkSun.Visible = false;
            // 
            // chkSat
            // 
            this.chkSat.AutoSize = true;
            this.chkSat.BackColor = System.Drawing.Color.Transparent;
            this.chkSat.Checked = true;
            this.chkSat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.chkSat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkSat.Location = new System.Drawing.Point(504, 174);
            this.chkSat.Name = "chkSat";
            this.chkSat.Size = new System.Drawing.Size(81, 20);
            this.chkSat.TabIndex = 27;
            this.chkSat.Text = "Saturday";
            this.chkSat.UseVisualStyleBackColor = false;
            this.chkSat.Visible = false;
            // 
            // chkFri
            // 
            this.chkFri.AutoSize = true;
            this.chkFri.BackColor = System.Drawing.Color.Transparent;
            this.chkFri.Checked = true;
            this.chkFri.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.chkFri.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkFri.Location = new System.Drawing.Point(425, 174);
            this.chkFri.Name = "chkFri";
            this.chkFri.Size = new System.Drawing.Size(65, 20);
            this.chkFri.TabIndex = 26;
            this.chkFri.Text = "Friday";
            this.chkFri.UseVisualStyleBackColor = false;
            this.chkFri.Visible = false;
            // 
            // chkThu
            // 
            this.chkThu.AutoSize = true;
            this.chkThu.BackColor = System.Drawing.Color.Transparent;
            this.chkThu.Checked = true;
            this.chkThu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.chkThu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkThu.Location = new System.Drawing.Point(327, 174);
            this.chkThu.Name = "chkThu";
            this.chkThu.Size = new System.Drawing.Size(84, 20);
            this.chkThu.TabIndex = 25;
            this.chkThu.Text = "Thursday";
            this.chkThu.UseVisualStyleBackColor = false;
            this.chkThu.Visible = false;
            // 
            // chkWed
            // 
            this.chkWed.AutoSize = true;
            this.chkWed.BackColor = System.Drawing.Color.Transparent;
            this.chkWed.Checked = true;
            this.chkWed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkWed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.chkWed.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkWed.Location = new System.Drawing.Point(212, 174);
            this.chkWed.Name = "chkWed";
            this.chkWed.Size = new System.Drawing.Size(101, 20);
            this.chkWed.TabIndex = 24;
            this.chkWed.Text = "Wednesday";
            this.chkWed.UseVisualStyleBackColor = false;
            this.chkWed.Visible = false;
            // 
            // chkTue
            // 
            this.chkTue.AutoSize = true;
            this.chkTue.BackColor = System.Drawing.Color.Transparent;
            this.chkTue.Checked = true;
            this.chkTue.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.chkTue.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkTue.Location = new System.Drawing.Point(117, 174);
            this.chkTue.Name = "chkTue";
            this.chkTue.Size = new System.Drawing.Size(81, 20);
            this.chkTue.TabIndex = 23;
            this.chkTue.Text = "Tuesday";
            this.chkTue.UseVisualStyleBackColor = false;
            this.chkTue.Visible = false;
            // 
            // chkMon
            // 
            this.chkMon.AutoSize = true;
            this.chkMon.BackColor = System.Drawing.Color.Transparent;
            this.chkMon.Checked = true;
            this.chkMon.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.chkMon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkMon.Location = new System.Drawing.Point(27, 174);
            this.chkMon.Name = "chkMon";
            this.chkMon.Size = new System.Drawing.Size(76, 20);
            this.chkMon.TabIndex = 22;
            this.chkMon.Text = "Monday";
            this.chkMon.UseVisualStyleBackColor = false;
            this.chkMon.Visible = false;
            // 
            // dtEnd
            // 
            this.dtEnd.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.dtEnd.CustomFormat = "";
            this.dtEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtEnd.Location = new System.Drawing.Point(177, 77);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.ShowUpDown = true;
            this.dtEnd.Size = new System.Drawing.Size(165, 22);
            this.dtEnd.TabIndex = 21;
            this.dtEnd.Visible = false;
            // 
            // dtStart
            // 
            this.dtStart.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.dtStart.CustomFormat = "";
            this.dtStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtStart.Location = new System.Drawing.Point(177, 47);
            this.dtStart.Name = "dtStart";
            this.dtStart.ShowUpDown = true;
            this.dtStart.Size = new System.Drawing.Size(165, 22);
            this.dtStart.TabIndex = 20;
            this.dtStart.Visible = false;
            // 
            // lblSWeek
            // 
            this.lblSWeek.AutoSize = true;
            this.lblSWeek.BackColor = System.Drawing.Color.Transparent;
            this.lblSWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblSWeek.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblSWeek.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSWeek.Location = new System.Drawing.Point(54, 119);
            this.lblSWeek.Name = "lblSWeek";
            this.lblSWeek.Size = new System.Drawing.Size(174, 16);
            this.lblSWeek.TabIndex = 31;
            this.lblSWeek.Text = "Schedule Day of Week :";
            this.lblSWeek.Visible = false;
            // 
            // lblSEnd
            // 
            this.lblSEnd.AutoSize = true;
            this.lblSEnd.BackColor = System.Drawing.Color.Transparent;
            this.lblSEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblSEnd.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblSEnd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSEnd.Location = new System.Drawing.Point(54, 82);
            this.lblSEnd.Name = "lblSEnd";
            this.lblSEnd.Size = new System.Drawing.Size(112, 16);
            this.lblSEnd.TabIndex = 30;
            this.lblSEnd.Text = "Schedule End :";
            this.lblSEnd.Visible = false;
            // 
            // lblSStart
            // 
            this.lblSStart.AutoSize = true;
            this.lblSStart.BackColor = System.Drawing.Color.Transparent;
            this.lblSStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblSStart.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblSStart.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSStart.Location = new System.Drawing.Point(54, 47);
            this.lblSStart.Name = "lblSStart";
            this.lblSStart.Size = new System.Drawing.Size(117, 16);
            this.lblSStart.TabIndex = 29;
            this.lblSStart.Text = "Schedule Start :";
            this.lblSStart.Visible = false;
            // 
            // cmbSchedule
            // 
            this.cmbSchedule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.cmbSchedule.FormattingEnabled = true;
            this.cmbSchedule.Location = new System.Drawing.Point(177, 12);
            this.cmbSchedule.Name = "cmbSchedule";
            this.cmbSchedule.Size = new System.Drawing.Size(219, 24);
            this.cmbSchedule.TabIndex = 1;
            this.cmbSchedule.SelectedIndexChanged += new System.EventHandler(this.cmbSchedule_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(101, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Disable :";
            // 
            // frmSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(697, 265);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.chkSun);
            this.Controls.Add(this.chkSat);
            this.Controls.Add(this.chkFri);
            this.Controls.Add(this.chkThu);
            this.Controls.Add(this.chkWed);
            this.Controls.Add(this.chkTue);
            this.Controls.Add(this.chkMon);
            this.Controls.Add(this.dtEnd);
            this.Controls.Add(this.dtStart);
            this.Controls.Add(this.lblSWeek);
            this.Controls.Add(this.lblSEnd);
            this.Controls.Add(this.lblSStart);
            this.Controls.Add(this.cmbSchedule);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSchedule";
            this.Text = "Disable When";
            this.Load += new System.EventHandler(this.frmSchedule_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSchedule;
        public System.Windows.Forms.CheckBox chkSun;
        public System.Windows.Forms.CheckBox chkSat;
        public System.Windows.Forms.CheckBox chkFri;
        public System.Windows.Forms.CheckBox chkThu;
        public System.Windows.Forms.CheckBox chkWed;
        public System.Windows.Forms.CheckBox chkTue;
        public System.Windows.Forms.CheckBox chkMon;
        public System.Windows.Forms.DateTimePicker dtEnd;
        public System.Windows.Forms.DateTimePicker dtStart;
        public System.Windows.Forms.Label lblSWeek;
        public System.Windows.Forms.Label lblSEnd;
        public System.Windows.Forms.Label lblSStart;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnOK;
    }
}
