namespace NetLog
{
    partial class frmLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLog));
            this.cmdStart = new System.Windows.Forms.Button();
            this.lvLog = new System.Windows.Forms.ListView();
            this.chTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chStat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tipBallon = new System.Windows.Forms.ToolTip(this.components);
            this.sysIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.imgStatus = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // cmdStart
            // 
            this.cmdStart.Location = new System.Drawing.Point(278, 12);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(64, 25);
            this.cmdStart.TabIndex = 0;
            this.cmdStart.Text = "Start";
            this.cmdStart.UseVisualStyleBackColor = true;
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // lvLog
            // 
            this.lvLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chTime,
            this.chStat});
            this.lvLog.FullRowSelect = true;
            this.lvLog.GridLines = true;
            this.lvLog.Location = new System.Drawing.Point(12, 43);
            this.lvLog.Name = "lvLog";
            this.lvLog.Size = new System.Drawing.Size(330, 104);
            this.lvLog.TabIndex = 1;
            this.lvLog.UseCompatibleStateImageBehavior = false;
            this.lvLog.View = System.Windows.Forms.View.Details;
            // 
            // chTime
            // 
            this.chTime.Text = "Time";
            this.chTime.Width = 187;
            // 
            // chStat
            // 
            this.chStat.Text = "Status";
            this.chStat.Width = 108;
            // 
            // sysIcon
            // 
            this.sysIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.sysIcon.Text = "Net Monitor (Logger)";
            this.sysIcon.Visible = true;
            this.sysIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.sysIcon_MouseDoubleClick);
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(12, 15);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(260, 20);
            this.txtAdress.TabIndex = 2;
            this.txtAdress.Text = "62.45.30.177";
            // 
            // imgStatus
            // 
            this.imgStatus.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgStatus.ImageStream")));
            this.imgStatus.TransparentColor = System.Drawing.Color.Transparent;
            this.imgStatus.Images.SetKeyName(0, "UP");
            this.imgStatus.Images.SetKeyName(1, "DOWN");
            this.imgStatus.Images.SetKeyName(2, "ONBEKENT");
            // 
            // frmLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 159);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.lvLog);
            this.Controls.Add(this.cmdStart);
            this.MaximizeBox = false;
            this.Name = "frmLog";
            this.Text = "Net Monitor (Logger)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLog_FormClosing);
            this.Load += new System.EventHandler(this.frmLog_Load);
            this.ResizeBegin += new System.EventHandler(this.frmLog_ResizeBegin);
            this.StyleChanged += new System.EventHandler(this.frmLog_StyleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdStart;
        private System.Windows.Forms.ListView lvLog;
        private System.Windows.Forms.NotifyIcon sysIcon;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.ToolTip tipBallon;
        private System.Windows.Forms.ColumnHeader chTime;
        private System.Windows.Forms.ColumnHeader chStat;
        private System.Windows.Forms.ImageList imgStatus;
    }
}

