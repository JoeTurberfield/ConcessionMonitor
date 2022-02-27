namespace ConcessionMonitor
{
    partial class ConcessionMain
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
            this.btnCreateFull = new System.Windows.Forms.Button();
            this.txtConSearch = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.dgvLog = new System.Windows.Forms.DataGridView();
            this.panLog = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.uSPLogDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).BeginInit();
            this.panLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uSPLogDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateFull
            // 
            this.btnCreateFull.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateFull.BackColor = System.Drawing.Color.Transparent;
            this.btnCreateFull.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCreateFull.Location = new System.Drawing.Point(812, 46);
            this.btnCreateFull.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCreateFull.Name = "btnCreateFull";
            this.btnCreateFull.Size = new System.Drawing.Size(152, 31);
            this.btnCreateFull.TabIndex = 0;
            this.btnCreateFull.Text = "Create New Concession";
            this.btnCreateFull.UseVisualStyleBackColor = false;
            this.btnCreateFull.Click += new System.EventHandler(this.btnCreateFull_Click);
            // 
            // txtConSearch
            // 
            this.txtConSearch.Location = new System.Drawing.Point(60, 52);
            this.txtConSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtConSearch.Name = "txtConSearch";
            this.txtConSearch.Size = new System.Drawing.Size(186, 20);
            this.txtConSearch.TabIndex = 2;
            this.txtConSearch.TextChanged += new System.EventHandler(this.txtConSearch_TextChanged_1);
            this.txtConSearch.MouseLeave += new System.EventHandler(this.txtConSearch_MouseLeave);
            this.txtConSearch.MouseHover += new System.EventHandler(this.txtConSearch_MouseHover);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblUser.Location = new System.Drawing.Point(0, 600);
            this.lblUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblUser.Size = new System.Drawing.Size(65, 21);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "UserName";
            // 
            // dgvLog
            // 
            this.dgvLog.AllowUserToAddRows = false;
            this.dgvLog.AllowUserToDeleteRows = false;
            this.dgvLog.AllowUserToOrderColumns = true;
            this.dgvLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLog.Location = new System.Drawing.Point(13, 81);
            this.dgvLog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvLog.Name = "dgvLog";
            this.dgvLog.RowHeadersWidth = 42;
            this.dgvLog.RowTemplate.Height = 24;
            this.dgvLog.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLog.Size = new System.Drawing.Size(951, 502);
            this.dgvLog.TabIndex = 5;
            this.dgvLog.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLog_CellClick_1);
            this.dgvLog.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvLog_ColumnHeaderMouseClick);
            // 
            // panLog
            // 
            this.panLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panLog.BackColor = System.Drawing.SystemColors.Control;
            this.panLog.Controls.Add(this.lblSearch);
            this.panLog.Controls.Add(this.dgvLog);
            this.panLog.Controls.Add(this.btnCreateFull);
            this.panLog.Controls.Add(this.txtConSearch);
            this.panLog.Location = new System.Drawing.Point(0, 0);
            this.panLog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panLog.Name = "panLog";
            this.panLog.Size = new System.Drawing.Size(974, 596);
            this.panLog.TabIndex = 6;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(13, 52);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(44, 13);
            this.lblSearch.TabIndex = 7;
            this.lblSearch.Text = "Search:";
            // 
            // uSPLogDataBindingSource
            // 
            this.uSPLogDataBindingSource.DataMember = "USP_LogData";
            // 
            // bindingSource1
            // 
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // ConcessionMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 621);
            this.Controls.Add(this.panLog);
            this.Controls.Add(this.lblUser);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ConcessionMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Concession Monitor";
            this.Load += new System.EventHandler(this.ConcessionMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).EndInit();
            this.panLog.ResumeLayout(false);
            this.panLog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uSPLogDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateFull;
        private System.Windows.Forms.TextBox txtConSearch;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.BindingSource uSPLogDataBindingSource;
        //private System.Windows.Forms.DataGridViewTextBoxColumn concessionNoDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn partNumberDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn createdDateDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn stepOneDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn stepTwoDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn stepThreeDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn stepFourDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dgvLog;
        private System.Windows.Forms.Panel panLog;
        private System.Windows.Forms.Label lblSearch;
    }
}

