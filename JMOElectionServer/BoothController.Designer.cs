namespace JMOElectionServer
{
    partial class BoothController
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblVoteCount = new System.Windows.Forms.Label();
            this.cmdControl = new System.Windows.Forms.Button();
            this.lblBooth = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblVoteCount
            // 
            this.lblVoteCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoteCount.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblVoteCount.Location = new System.Drawing.Point(0, 37);
            this.lblVoteCount.Name = "lblVoteCount";
            this.lblVoteCount.Size = new System.Drawing.Size(150, 18);
            this.lblVoteCount.TabIndex = 3;
            this.lblVoteCount.Text = "VoteCount";
            this.lblVoteCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdControl
            // 
            this.cmdControl.Location = new System.Drawing.Point(6, 71);
            this.cmdControl.Name = "cmdControl";
            this.cmdControl.Size = new System.Drawing.Size(138, 40);
            this.cmdControl.TabIndex = 0;
            this.cmdControl.Text = "Stop";
            this.cmdControl.UseVisualStyleBackColor = true;
            this.cmdControl.Click += new System.EventHandler(this.cmdControl_Click);
            // 
            // lblBooth
            // 
            this.lblBooth.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBooth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBooth.ForeColor = System.Drawing.Color.Moccasin;
            this.lblBooth.Location = new System.Drawing.Point(0, 0);
            this.lblBooth.Name = "lblBooth";
            this.lblBooth.Size = new System.Drawing.Size(150, 22);
            this.lblBooth.TabIndex = 1;
            this.lblBooth.Text = "Booth";
            this.lblBooth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.Location = new System.Drawing.Point(6, 124);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(138, 13);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Status";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BoothController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblBooth);
            this.Controls.Add(this.lblVoteCount);
            this.Controls.Add(this.cmdControl);
            this.Controls.Add(this.lblStatus);
            this.Name = "BoothController";
            this.Size = new System.Drawing.Size(150, 148);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblVoteCount;
        private System.Windows.Forms.Button cmdControl;
        private System.Windows.Forms.Label lblBooth;
        private System.Windows.Forms.Label lblStatus;
    }
}
