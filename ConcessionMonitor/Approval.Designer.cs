namespace ConcessionMonitor
{
    partial class Approval
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
            this.btnReject = new System.Windows.Forms.Button();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnPending = new System.Windows.Forms.Button();
            this.lblApproval = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReject
            // 
            this.btnReject.Location = new System.Drawing.Point(281, 69);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(108, 37);
            this.btnReject.TabIndex = 0;
            this.btnReject.Text = "Reject";
            this.btnReject.UseVisualStyleBackColor = true;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.Location = new System.Drawing.Point(12, 69);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(115, 37);
            this.btnApprove.TabIndex = 1;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = true;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnPending
            // 
            this.btnPending.Location = new System.Drawing.Point(147, 69);
            this.btnPending.Name = "btnPending";
            this.btnPending.Size = new System.Drawing.Size(108, 37);
            this.btnPending.TabIndex = 2;
            this.btnPending.Text = "Pending";
            this.btnPending.UseVisualStyleBackColor = true;
            this.btnPending.Click += new System.EventHandler(this.btnPending_Click);
            // 
            // lblApproval
            // 
            this.lblApproval.AutoSize = true;
            this.lblApproval.Location = new System.Drawing.Point(12, 27);
            this.lblApproval.Name = "lblApproval";
            this.lblApproval.Size = new System.Drawing.Size(46, 17);
            this.lblApproval.TabIndex = 3;
            this.lblApproval.Text = "label1";
            // 
            // Approval
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 125);
            this.Controls.Add(this.lblApproval);
            this.Controls.Add(this.btnPending);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.btnReject);
            this.Name = "Approval";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Approval";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnPending;
        public System.Windows.Forms.Label lblApproval;
    }
}