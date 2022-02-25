namespace ConcessionMonitor
{
    partial class StepReport
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
            this.lblStepNameR = new System.Windows.Forms.Label();
            this.lblConNoR = new System.Windows.Forms.Label();
            this.txtStepCommentR = new System.Windows.Forms.TextBox();
            this.lblStepCompR = new System.Windows.Forms.Label();
            this.lblUserR = new System.Windows.Forms.Label();
            this.lblStartR = new System.Windows.Forms.Label();
            this.lblCompR = new System.Windows.Forms.Label();
            this.lblRev = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStepNameR
            // 
            this.lblStepNameR.AutoSize = true;
            this.lblStepNameR.Location = new System.Drawing.Point(26, 69);
            this.lblStepNameR.Name = "lblStepNameR";
            this.lblStepNameR.Size = new System.Drawing.Size(37, 17);
            this.lblStepNameR.TabIndex = 1;
            this.lblStepNameR.Text = "Step";
            // 
            // lblConNoR
            // 
            this.lblConNoR.AutoSize = true;
            this.lblConNoR.Location = new System.Drawing.Point(26, 30);
            this.lblConNoR.Name = "lblConNoR";
            this.lblConNoR.Size = new System.Drawing.Size(135, 17);
            this.lblConNoR.TabIndex = 2;
            this.lblConNoR.Text = "Concession Number";
            // 
            // txtStepCommentR
            // 
            this.txtStepCommentR.Location = new System.Drawing.Point(29, 106);
            this.txtStepCommentR.Multiline = true;
            this.txtStepCommentR.Name = "txtStepCommentR";
            this.txtStepCommentR.ReadOnly = true;
            this.txtStepCommentR.Size = new System.Drawing.Size(416, 78);
            this.txtStepCommentR.TabIndex = 5;
            // 
            // lblStepCompR
            // 
            this.lblStepCompR.AutoSize = true;
            this.lblStepCompR.Location = new System.Drawing.Point(26, 218);
            this.lblStepCompR.Name = "lblStepCompR";
            this.lblStepCompR.Size = new System.Drawing.Size(0, 17);
            this.lblStepCompR.TabIndex = 6;
            // 
            // lblUserR
            // 
            this.lblUserR.AutoSize = true;
            this.lblUserR.Location = new System.Drawing.Point(269, 208);
            this.lblUserR.Name = "lblUserR";
            this.lblUserR.Size = new System.Drawing.Size(16, 17);
            this.lblUserR.TabIndex = 7;
            this.lblUserR.Text = "  ";
            // 
            // lblStartR
            // 
            this.lblStartR.AutoSize = true;
            this.lblStartR.Location = new System.Drawing.Point(26, 208);
            this.lblStartR.Name = "lblStartR";
            this.lblStartR.Size = new System.Drawing.Size(68, 17);
            this.lblStartR.TabIndex = 8;
            this.lblStartR.Text = "StartDate";
            // 
            // lblCompR
            // 
            this.lblCompR.AutoSize = true;
            this.lblCompR.Location = new System.Drawing.Point(26, 249);
            this.lblCompR.Name = "lblCompR";
            this.lblCompR.Size = new System.Drawing.Size(74, 17);
            this.lblCompR.TabIndex = 9;
            this.lblCompR.Text = "CompDate";
            // 
            // lblRev
            // 
            this.lblRev.AutoSize = true;
            this.lblRev.Location = new System.Drawing.Point(285, 30);
            this.lblRev.Name = "lblRev";
            this.lblRev.Size = new System.Drawing.Size(62, 17);
            this.lblRev.TabIndex = 10;
            this.lblRev.Text = "Revision";
            // 
            // StepReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 305);
            this.Controls.Add(this.lblRev);
            this.Controls.Add(this.lblCompR);
            this.Controls.Add(this.lblStartR);
            this.Controls.Add(this.lblUserR);
            this.Controls.Add(this.lblStepCompR);
            this.Controls.Add(this.txtStepCommentR);
            this.Controls.Add(this.lblConNoR);
            this.Controls.Add(this.lblStepNameR);
            this.Name = "StepReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Step Details";
            this.Load += new System.EventHandler(this.StepReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblStepNameR;
        public System.Windows.Forms.Label lblConNoR;
        private System.Windows.Forms.TextBox txtStepCommentR;
        private System.Windows.Forms.Label lblStepCompR;
        private System.Windows.Forms.Label lblUserR;
        private System.Windows.Forms.Label lblStartR;
        private System.Windows.Forms.Label lblCompR;
        private System.Windows.Forms.Label lblRev;
    }
}