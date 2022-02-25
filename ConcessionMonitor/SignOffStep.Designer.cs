namespace ConcessionMonitor
{
    partial class SignOffStep
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
            this.lblStepName = new System.Windows.Forms.Label();
            this.lblConNo = new System.Windows.Forms.Label();
            this.cboStepComplete = new System.Windows.Forms.ComboBox();
            this.btnStepSave = new System.Windows.Forms.Button();
            this.txtStepComment = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblStepName
            // 
            this.lblStepName.AutoSize = true;
            this.lblStepName.Location = new System.Drawing.Point(31, 67);
            this.lblStepName.Name = "lblStepName";
            this.lblStepName.Size = new System.Drawing.Size(37, 17);
            this.lblStepName.TabIndex = 0;
            this.lblStepName.Text = "Step";
            // 
            // lblConNo
            // 
            this.lblConNo.AutoSize = true;
            this.lblConNo.Location = new System.Drawing.Point(31, 31);
            this.lblConNo.Name = "lblConNo";
            this.lblConNo.Size = new System.Drawing.Size(135, 17);
            this.lblConNo.TabIndex = 1;
            this.lblConNo.Text = "Concession Number";
            // 
            // cboStepComplete
            // 
            this.cboStepComplete.FormattingEnabled = true;
            this.cboStepComplete.Items.AddRange(new object[] {
            "Approved",
            "Rejected"});
            this.cboStepComplete.Location = new System.Drawing.Point(34, 241);
            this.cboStepComplete.Name = "cboStepComplete";
            this.cboStepComplete.Size = new System.Drawing.Size(158, 24);
            this.cboStepComplete.TabIndex = 2;
            // 
            // btnStepSave
            // 
            this.btnStepSave.Location = new System.Drawing.Point(362, 325);
            this.btnStepSave.Name = "btnStepSave";
            this.btnStepSave.Size = new System.Drawing.Size(96, 30);
            this.btnStepSave.TabIndex = 3;
            this.btnStepSave.Text = "Save";
            this.btnStepSave.UseVisualStyleBackColor = true;
            this.btnStepSave.Click += new System.EventHandler(this.btnStepSave_Click);
            // 
            // txtStepComment
            // 
            this.txtStepComment.Location = new System.Drawing.Point(34, 112);
            this.txtStepComment.Multiline = true;
            this.txtStepComment.Name = "txtStepComment";
            this.txtStepComment.Size = new System.Drawing.Size(424, 78);
            this.txtStepComment.TabIndex = 4;
            // 
            // SignOffStep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 373);
            this.Controls.Add(this.txtStepComment);
            this.Controls.Add(this.btnStepSave);
            this.Controls.Add(this.cboStepComplete);
            this.Controls.Add(this.lblConNo);
            this.Controls.Add(this.lblStepName);
            this.Name = "SignOffStep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign off Step";
            this.Load += new System.EventHandler(this.SignOffStep_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblStepName;
        public System.Windows.Forms.Label lblConNo;
        private System.Windows.Forms.ComboBox cboStepComplete;
        private System.Windows.Forms.Button btnStepSave;
        private System.Windows.Forms.TextBox txtStepComment;
    }
}