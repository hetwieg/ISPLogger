namespace NetStatus
{
    partial class frmStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStatus));
            this.lvLog = new System.Windows.Forms.ListView();
            this.chTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chStat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imgStatus = new System.Windows.Forms.ImageList(this.components);
            this.lvGegevensUpDown = new System.Windows.Forms.ListView();
            this.chNaam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chUp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDown = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvGegevens = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chWaarde = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvLog
            // 
            this.lvLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lvLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chTime,
            this.chStat});
            this.lvLog.FullRowSelect = true;
            this.lvLog.GridLines = true;
            this.lvLog.LargeImageList = this.imgStatus;
            this.lvLog.Location = new System.Drawing.Point(12, 12);
            this.lvLog.Name = "lvLog";
            this.lvLog.Size = new System.Drawing.Size(330, 415);
            this.lvLog.SmallImageList = this.imgStatus;
            this.lvLog.TabIndex = 2;
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
            // imgStatus
            // 
            this.imgStatus.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgStatus.ImageStream")));
            this.imgStatus.TransparentColor = System.Drawing.Color.Transparent;
            this.imgStatus.Images.SetKeyName(0, "UP");
            this.imgStatus.Images.SetKeyName(1, "DOWN");
            this.imgStatus.Images.SetKeyName(2, "ONBEKENT");
            // 
            // lvGegevensUpDown
            // 
            this.lvGegevensUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvGegevensUpDown.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNaam,
            this.chUp,
            this.chDown});
            this.lvGegevensUpDown.FullRowSelect = true;
            this.lvGegevensUpDown.GridLines = true;
            this.lvGegevensUpDown.Location = new System.Drawing.Point(352, 173);
            this.lvGegevensUpDown.Name = "lvGegevensUpDown";
            this.lvGegevensUpDown.Size = new System.Drawing.Size(299, 254);
            this.lvGegevensUpDown.TabIndex = 7;
            this.lvGegevensUpDown.UseCompatibleStateImageBehavior = false;
            this.lvGegevensUpDown.View = System.Windows.Forms.View.Details;
            // 
            // chNaam
            // 
            this.chNaam.Text = "Naam";
            this.chNaam.Width = 150;
            // 
            // chUp
            // 
            this.chUp.Text = "Up";
            // 
            // chDown
            // 
            this.chDown.Text = "Down";
            // 
            // lvGegevens
            // 
            this.lvGegevens.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvGegevens.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.chWaarde});
            this.lvGegevens.FullRowSelect = true;
            this.lvGegevens.GridLines = true;
            this.lvGegevens.Location = new System.Drawing.Point(352, 12);
            this.lvGegevens.Name = "lvGegevens";
            this.lvGegevens.Size = new System.Drawing.Size(299, 155);
            this.lvGegevens.TabIndex = 8;
            this.lvGegevens.UseCompatibleStateImageBehavior = false;
            this.lvGegevens.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Naam";
            this.columnHeader1.Width = 150;
            // 
            // chWaarde
            // 
            this.chWaarde.Text = "Waarde";
            this.chWaarde.Width = 119;
            // 
            // frmStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 439);
            this.Controls.Add(this.lvGegevens);
            this.Controls.Add(this.lvGegevensUpDown);
            this.Controls.Add(this.lvLog);
            this.MaximizeBox = false;
            this.Name = "frmStatus";
            this.Text = "Logboek weergave";
            this.Load += new System.EventHandler(this.frmStatus_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvLog;
        private System.Windows.Forms.ColumnHeader chTime;
        private System.Windows.Forms.ColumnHeader chStat;
        private System.Windows.Forms.ListView lvGegevensUpDown;
        private System.Windows.Forms.ColumnHeader chNaam;
        private System.Windows.Forms.ColumnHeader chUp;
        private System.Windows.Forms.ColumnHeader chDown;
        private System.Windows.Forms.ListView lvGegevens;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader chWaarde;
        private System.Windows.Forms.ImageList imgStatus;
    }
}

