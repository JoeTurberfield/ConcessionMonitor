namespace ConcessionMonitor
{
    partial class ConcessionReport
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
            this.lblConcessionNo = new System.Windows.Forms.Label();
            this.lblSerialNo = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.concessionReportTypeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.concessionDataSet3 = new ConcessionMonitor.ConcessionDataSet3();
            this.lblPartNo = new System.Windows.Forms.Label();
            this.lblPartName = new System.Windows.Forms.Label();
            this.lblMachine = new System.Windows.Forms.Label();
            this.lblIssue = new System.Windows.Forms.Label();
            this.lblCause = new System.Windows.Forms.Label();
            this.lblPrevention = new System.Windows.Forms.Label();
            this.lblTreatment = new System.Windows.Forms.Label();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.txtPartNo = new System.Windows.Forms.TextBox();
            this.txtPartName = new System.Windows.Forms.TextBox();
            this.txtIssue = new System.Windows.Forms.TextBox();
            this.txtMachine = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtPrevention = new System.Windows.Forms.TextBox();
            this.txtCause = new System.Windows.Forms.TextBox();
            this.txtTreatment = new System.Windows.Forms.TextBox();
            this.txtConNo = new System.Windows.Forms.TextBox();
            this.lblConType = new System.Windows.Forms.Label();
            this.concessionReportTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboUser = new System.Windows.Forms.ComboBox();
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.concessionDataSet2 = new ConcessionMonitor.ConcessionDataSet2();
            this.lblUser = new System.Windows.Forms.Label();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter1 = new ConcessionMonitor.ConcessionDataSet2TableAdapters.UsersTableAdapter();
            this.concessionReportTypeTableAdapter1 = new ConcessionMonitor.ConcessionDataSet3TableAdapters.ConcessionReportTypeTableAdapter();
            this.lblConError = new System.Windows.Forms.Label();
            this.gboReport = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.concessionReportTypeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.concessionDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.concessionReportTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.concessionDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConcessionNo
            // 
            this.lblConcessionNo.AutoSize = true;
            this.lblConcessionNo.Location = new System.Drawing.Point(440, 43);
            this.lblConcessionNo.Name = "lblConcessionNo";
            this.lblConcessionNo.Size = new System.Drawing.Size(135, 17);
            this.lblConcessionNo.TabIndex = 0;
            this.lblConcessionNo.Text = "Concession Number";
            // 
            // lblSerialNo
            // 
            this.lblSerialNo.AutoSize = true;
            this.lblSerialNo.Location = new System.Drawing.Point(32, 43);
            this.lblSerialNo.Name = "lblSerialNo";
            this.lblSerialNo.Size = new System.Drawing.Size(98, 17);
            this.lblSerialNo.TabIndex = 1;
            this.lblSerialNo.Text = "Serial Number";
            // 
            // cboType
            // 
            this.cboType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.concessionReportTypeBindingSource1, "ConcessionType", true));
            this.cboType.DataSource = this.concessionReportTypeBindingSource1;
            this.cboType.DisplayMember = "ConcessionType";
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(640, 61);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(158, 24);
            this.cboType.TabIndex = 2;
            this.cboType.ValueMember = "TypeID";
            // 
            // concessionReportTypeBindingSource1
            // 
            this.concessionReportTypeBindingSource1.DataMember = "ConcessionReportType";
            this.concessionReportTypeBindingSource1.DataSource = this.concessionDataSet3;
            // 
            // concessionDataSet3
            // 
            this.concessionDataSet3.DataSetName = "ConcessionDataSet3";
            this.concessionDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblPartNo
            // 
            this.lblPartNo.AutoSize = true;
            this.lblPartNo.Location = new System.Drawing.Point(32, 101);
            this.lblPartNo.Name = "lblPartNo";
            this.lblPartNo.Size = new System.Drawing.Size(88, 17);
            this.lblPartNo.TabIndex = 3;
            this.lblPartNo.Text = "Part Number";
            // 
            // lblPartName
            // 
            this.lblPartName.AutoSize = true;
            this.lblPartName.Location = new System.Drawing.Point(247, 101);
            this.lblPartName.Name = "lblPartName";
            this.lblPartName.Size = new System.Drawing.Size(75, 17);
            this.lblPartName.TabIndex = 4;
            this.lblPartName.Text = "Part Name";
            // 
            // lblMachine
            // 
            this.lblMachine.AutoSize = true;
            this.lblMachine.Location = new System.Drawing.Point(247, 43);
            this.lblMachine.Name = "lblMachine";
            this.lblMachine.Size = new System.Drawing.Size(97, 17);
            this.lblMachine.TabIndex = 5;
            this.lblMachine.Text = "Machine Type";
            // 
            // lblIssue
            // 
            this.lblIssue.AutoSize = true;
            this.lblIssue.Location = new System.Drawing.Point(32, 189);
            this.lblIssue.Name = "lblIssue";
            this.lblIssue.Size = new System.Drawing.Size(174, 17);
            this.lblIssue.TabIndex = 6;
            this.lblIssue.Text = "Problem Clarification/Issue";
            // 
            // lblCause
            // 
            this.lblCause.AutoSize = true;
            this.lblCause.Location = new System.Drawing.Point(32, 321);
            this.lblCause.Name = "lblCause";
            this.lblCause.Size = new System.Drawing.Size(104, 17);
            this.lblCause.TabIndex = 7;
            this.lblCause.Text = "Problem Cause";
            // 
            // lblPrevention
            // 
            this.lblPrevention.AutoSize = true;
            this.lblPrevention.Location = new System.Drawing.Point(32, 454);
            this.lblPrevention.Name = "lblPrevention";
            this.lblPrevention.Size = new System.Drawing.Size(132, 17);
            this.lblPrevention.TabIndex = 8;
            this.lblPrevention.Text = "Problem Prevention";
            // 
            // lblTreatment
            // 
            this.lblTreatment.AutoSize = true;
            this.lblTreatment.Location = new System.Drawing.Point(32, 588);
            this.lblTreatment.Name = "lblTreatment";
            this.lblTreatment.Size = new System.Drawing.Size(73, 17);
            this.lblTreatment.TabIndex = 9;
            this.lblTreatment.Text = "Treatment";
            // 
            // txtSerial
            // 
            this.txtSerial.Location = new System.Drawing.Point(35, 63);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(160, 22);
            this.txtSerial.TabIndex = 10;
            // 
            // txtPartNo
            // 
            this.txtPartNo.Location = new System.Drawing.Point(35, 121);
            this.txtPartNo.Name = "txtPartNo";
            this.txtPartNo.Size = new System.Drawing.Size(160, 22);
            this.txtPartNo.TabIndex = 11;
            // 
            // txtPartName
            // 
            this.txtPartName.Location = new System.Drawing.Point(250, 121);
            this.txtPartName.Name = "txtPartName";
            this.txtPartName.Size = new System.Drawing.Size(158, 22);
            this.txtPartName.TabIndex = 12;
            // 
            // txtIssue
            // 
            this.txtIssue.Location = new System.Drawing.Point(35, 209);
            this.txtIssue.Multiline = true;
            this.txtIssue.Name = "txtIssue";
            this.txtIssue.Size = new System.Drawing.Size(566, 100);
            this.txtIssue.TabIndex = 13;
            // 
            // txtMachine
            // 
            this.txtMachine.Location = new System.Drawing.Point(250, 63);
            this.txtMachine.Name = "txtMachine";
            this.txtMachine.Size = new System.Drawing.Size(158, 22);
            this.txtMachine.TabIndex = 14;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(816, 674);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(108, 34);
            this.btnCreate.TabIndex = 15;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtPrevention
            // 
            this.txtPrevention.Location = new System.Drawing.Point(35, 474);
            this.txtPrevention.Multiline = true;
            this.txtPrevention.Name = "txtPrevention";
            this.txtPrevention.Size = new System.Drawing.Size(566, 100);
            this.txtPrevention.TabIndex = 16;
            // 
            // txtCause
            // 
            this.txtCause.Location = new System.Drawing.Point(35, 341);
            this.txtCause.Multiline = true;
            this.txtCause.Name = "txtCause";
            this.txtCause.Size = new System.Drawing.Size(566, 100);
            this.txtCause.TabIndex = 17;
            // 
            // txtTreatment
            // 
            this.txtTreatment.Location = new System.Drawing.Point(35, 608);
            this.txtTreatment.Multiline = true;
            this.txtTreatment.Name = "txtTreatment";
            this.txtTreatment.Size = new System.Drawing.Size(566, 100);
            this.txtTreatment.TabIndex = 18;
            // 
            // txtConNo
            // 
            this.txtConNo.Location = new System.Drawing.Point(443, 63);
            this.txtConNo.Name = "txtConNo";
            this.txtConNo.Size = new System.Drawing.Size(158, 22);
            this.txtConNo.TabIndex = 19;
            // 
            // lblConType
            // 
            this.lblConType.AutoSize = true;
            this.lblConType.Location = new System.Drawing.Point(637, 43);
            this.lblConType.Name = "lblConType";
            this.lblConType.Size = new System.Drawing.Size(117, 17);
            this.lblConType.TabIndex = 20;
            this.lblConType.Text = "Concession Type";
            // 
            // concessionReportTypeBindingSource
            // 
            this.concessionReportTypeBindingSource.DataMember = "ConcessionReportType";
            // 
            // cboUser
            // 
            this.cboUser.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.usersBindingSource1, "UserName", true));
            this.cboUser.DataSource = this.usersBindingSource1;
            this.cboUser.DisplayMember = "UserName";
            this.cboUser.FormattingEnabled = true;
            this.cboUser.Location = new System.Drawing.Point(443, 121);
            this.cboUser.MaxDropDownItems = 50;
            this.cboUser.Name = "cboUser";
            this.cboUser.Size = new System.Drawing.Size(158, 24);
            this.cboUser.TabIndex = 22;
            this.cboUser.ValueMember = "UserID";
            // 
            // usersBindingSource1
            // 
            this.usersBindingSource1.DataMember = "Users";
            this.usersBindingSource1.DataSource = this.concessionDataSet2;
            // 
            // concessionDataSet2
            // 
            this.concessionDataSet2.DataSetName = "ConcessionDataSet2";
            this.concessionDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(440, 101);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(79, 17);
            this.lblUser.TabIndex = 23;
            this.lblUser.Text = "User Name";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // concessionReportTypeTableAdapter1
            // 
            this.concessionReportTypeTableAdapter1.ClearBeforeFill = true;
            // 
            // lblConError
            // 
            this.lblConError.AutoSize = true;
            this.lblConError.ForeColor = System.Drawing.Color.Red;
            this.lblConError.Location = new System.Drawing.Point(32, 9);
            this.lblConError.Name = "lblConError";
            this.lblConError.Size = new System.Drawing.Size(0, 17);
            this.lblConError.TabIndex = 24;
            // 
            // gboReport
            // 
            this.gboReport.Location = new System.Drawing.Point(12, 12);
            this.gboReport.Name = "gboReport";
            this.gboReport.Size = new System.Drawing.Size(941, 711);
            this.gboReport.TabIndex = 25;
            this.gboReport.TabStop = false;
            // 
            // ConcessionReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 746);
            this.Controls.Add(this.lblConError);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.cboUser);
            this.Controls.Add(this.lblConType);
            this.Controls.Add(this.txtConNo);
            this.Controls.Add(this.txtTreatment);
            this.Controls.Add(this.txtCause);
            this.Controls.Add(this.txtPrevention);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtMachine);
            this.Controls.Add(this.txtIssue);
            this.Controls.Add(this.txtPartName);
            this.Controls.Add(this.txtPartNo);
            this.Controls.Add(this.txtSerial);
            this.Controls.Add(this.lblTreatment);
            this.Controls.Add(this.lblPrevention);
            this.Controls.Add(this.lblCause);
            this.Controls.Add(this.lblIssue);
            this.Controls.Add(this.lblMachine);
            this.Controls.Add(this.lblPartName);
            this.Controls.Add(this.lblPartNo);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.lblSerialNo);
            this.Controls.Add(this.lblConcessionNo);
            this.Controls.Add(this.gboReport);
            this.Name = "ConcessionReport";
            this.Text = "New Concession";
            this.Load += new System.EventHandler(this.ConcessionCreate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.concessionReportTypeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.concessionDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.concessionReportTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.concessionDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConcessionNo;
        private System.Windows.Forms.Label lblSerialNo;
        private System.Windows.Forms.Label lblPartNo;
        private System.Windows.Forms.Label lblPartName;
        private System.Windows.Forms.Label lblMachine;
        private System.Windows.Forms.Label lblIssue;
        private System.Windows.Forms.Label lblCause;
        private System.Windows.Forms.Label lblPrevention;
        private System.Windows.Forms.Label lblTreatment;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblConType;

        private System.Windows.Forms.BindingSource concessionReportTypeBindingSource;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private ConcessionDataSet2 concessionDataSet2;
        private System.Windows.Forms.BindingSource usersBindingSource1;
        private ConcessionDataSet2TableAdapters.UsersTableAdapter usersTableAdapter1;
        private ConcessionDataSet3 concessionDataSet3;
        private System.Windows.Forms.BindingSource concessionReportTypeBindingSource1;
        private ConcessionDataSet3TableAdapters.ConcessionReportTypeTableAdapter concessionReportTypeTableAdapter1;
        public System.Windows.Forms.ComboBox cboType;
        public System.Windows.Forms.TextBox txtSerial;
        public System.Windows.Forms.TextBox txtPartNo;
        public System.Windows.Forms.TextBox txtPartName;
        public System.Windows.Forms.TextBox txtIssue;
        public System.Windows.Forms.TextBox txtMachine;
        public System.Windows.Forms.TextBox txtPrevention;
        public System.Windows.Forms.TextBox txtCause;
        public System.Windows.Forms.TextBox txtTreatment;
        public System.Windows.Forms.TextBox txtConNo;
        public System.Windows.Forms.ComboBox cboUser;
        private System.Windows.Forms.Label lblConError;
        private System.Windows.Forms.GroupBox gboReport;
    }
}