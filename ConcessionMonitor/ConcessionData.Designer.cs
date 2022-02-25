namespace ConcessionMonitor
{
    partial class ConcessionData
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
            this.lblSerialNo = new System.Windows.Forms.Label();
            this.concessionReportTypeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtPrevention = new System.Windows.Forms.TextBox();
            this.txtCause = new System.Windows.Forms.TextBox();
            this.txtTreatment = new System.Windows.Forms.TextBox();
            this.lblConType = new System.Windows.Forms.Label();
            this.concessionReportTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblConError = new System.Windows.Forms.Label();
            this.gboNewCon = new System.Windows.Forms.GroupBox();
            this.lblPDF = new System.Windows.Forms.Label();
            this.lblPdfError = new System.Windows.Forms.Label();
            this.lblPartsDate = new System.Windows.Forms.Label();
            this.dtpPartsDate = new System.Windows.Forms.DateTimePicker();
            this.lblDeptError = new System.Windows.Forms.Label();
            this.lblTypeError = new System.Windows.Forms.Label();
            this.lblSerialError = new System.Windows.Forms.Label();
            this.lblMachError = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboDept = new System.Windows.Forms.ComboBox();
            this.lblStamp = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblConNo = new System.Windows.Forms.Label();
            this.lboPdf = new System.Windows.Forms.ListBox();
            this.cboMachType = new System.Windows.Forms.ComboBox();
            this.lblComment = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.cboType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.concessionReportTypeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.concessionReportTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.gboNewCon.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSerialNo
            // 
            this.lblSerialNo.AutoSize = true;
            this.lblSerialNo.Location = new System.Drawing.Point(32, 26);
            this.lblSerialNo.Name = "lblSerialNo";
            this.lblSerialNo.Size = new System.Drawing.Size(98, 17);
            this.lblSerialNo.TabIndex = 1;
            this.lblSerialNo.Text = "Serial Number";
            // 
            // concessionReportTypeBindingSource1
            // 
            this.concessionReportTypeBindingSource1.DataMember = "ConcessionReportType";
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
            this.lblMachine.Location = new System.Drawing.Point(247, 26);
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
            this.txtSerial.Location = new System.Drawing.Point(35, 46);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(160, 22);
            this.txtSerial.TabIndex = 10;
            this.txtSerial.TextChanged += new System.EventHandler(this.txtSerial_TextChanged);
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
            this.txtIssue.Location = new System.Drawing.Point(35, 212);
            this.txtIssue.Multiline = true;
            this.txtIssue.Name = "txtIssue";
            this.txtIssue.Size = new System.Drawing.Size(818, 90);
            this.txtIssue.TabIndex = 13;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(988, 662);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(108, 34);
            this.btnCreate.TabIndex = 15;
            this.btnCreate.Text = "Save";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtPrevention
            // 
            this.txtPrevention.Location = new System.Drawing.Point(35, 474);
            this.txtPrevention.Multiline = true;
            this.txtPrevention.Name = "txtPrevention";
            this.txtPrevention.Size = new System.Drawing.Size(818, 90);
            this.txtPrevention.TabIndex = 16;
            // 
            // txtCause
            // 
            this.txtCause.Location = new System.Drawing.Point(35, 341);
            this.txtCause.Multiline = true;
            this.txtCause.Name = "txtCause";
            this.txtCause.Size = new System.Drawing.Size(818, 90);
            this.txtCause.TabIndex = 17;
            // 
            // txtTreatment
            // 
            this.txtTreatment.Location = new System.Drawing.Point(35, 606);
            this.txtTreatment.Multiline = true;
            this.txtTreatment.Name = "txtTreatment";
            this.txtTreatment.Size = new System.Drawing.Size(818, 90);
            this.txtTreatment.TabIndex = 18;
            // 
            // lblConType
            // 
            this.lblConType.AutoSize = true;
            this.lblConType.Location = new System.Drawing.Point(455, 26);
            this.lblConType.Name = "lblConType";
            this.lblConType.Size = new System.Drawing.Size(117, 17);
            this.lblConType.TabIndex = 20;
            this.lblConType.Text = "Concession Type";
            // 
            // concessionReportTypeBindingSource
            // 
            this.concessionReportTypeBindingSource.DataMember = "ConcessionReportType";
            // 
            // usersBindingSource1
            // 
            this.usersBindingSource1.DataMember = "Users";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
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
            // gboNewCon
            // 
            this.gboNewCon.Controls.Add(this.lblPDF);
            this.gboNewCon.Controls.Add(this.txtCause);
            this.gboNewCon.Controls.Add(this.lblPdfError);
            this.gboNewCon.Controls.Add(this.lblPartsDate);
            this.gboNewCon.Controls.Add(this.dtpPartsDate);
            this.gboNewCon.Controls.Add(this.txtIssue);
            this.gboNewCon.Controls.Add(this.lblDeptError);
            this.gboNewCon.Controls.Add(this.lblTypeError);
            this.gboNewCon.Controls.Add(this.lblSerialError);
            this.gboNewCon.Controls.Add(this.lblMachError);
            this.gboNewCon.Controls.Add(this.label1);
            this.gboNewCon.Controls.Add(this.cboDept);
            this.gboNewCon.Controls.Add(this.lblStamp);
            this.gboNewCon.Controls.Add(this.btnDelete);
            this.gboNewCon.Controls.Add(this.lblConNo);
            this.gboNewCon.Controls.Add(this.lboPdf);
            this.gboNewCon.Controls.Add(this.cboMachType);
            this.gboNewCon.Controls.Add(this.txtSerial);
            this.gboNewCon.Controls.Add(this.lblMachine);
            this.gboNewCon.Controls.Add(this.lblComment);
            this.gboNewCon.Controls.Add(this.lblConType);
            this.gboNewCon.Controls.Add(this.txtComment);
            this.gboNewCon.Controls.Add(this.cboType);
            this.gboNewCon.Controls.Add(this.txtTreatment);
            this.gboNewCon.Controls.Add(this.btnCreate);
            this.gboNewCon.Controls.Add(this.lblSerialNo);
            this.gboNewCon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gboNewCon.Location = new System.Drawing.Point(0, 0);
            this.gboNewCon.Name = "gboNewCon";
            this.gboNewCon.Size = new System.Drawing.Size(1108, 736);
            this.gboNewCon.TabIndex = 25;
            this.gboNewCon.TabStop = false;
            // 
            // lblPDF
            // 
            this.lblPDF.AutoSize = true;
            this.lblPDF.Location = new System.Drawing.Point(775, 101);
            this.lblPDF.Name = "lblPDF";
            this.lblPDF.Size = new System.Drawing.Size(126, 17);
            this.lblPDF.TabIndex = 41;
            this.lblPDF.Text = "PDF Attachment 1:";
            // 
            // lblPdfError
            // 
            this.lblPdfError.AutoSize = true;
            this.lblPdfError.ForeColor = System.Drawing.Color.Red;
            this.lblPdfError.Location = new System.Drawing.Point(976, 189);
            this.lblPdfError.Name = "lblPdfError";
            this.lblPdfError.Size = new System.Drawing.Size(102, 17);
            this.lblPdfError.TabIndex = 40;
            this.lblPdfError.Text = "*PDF Required";
            this.lblPdfError.Visible = false;
            // 
            // lblPartsDate
            // 
            this.lblPartsDate.AutoSize = true;
            this.lblPartsDate.Location = new System.Drawing.Point(893, 26);
            this.lblPartsDate.Name = "lblPartsDate";
            this.lblPartsDate.Size = new System.Drawing.Size(108, 17);
            this.lblPartsDate.TabIndex = 39;
            this.lblPartsDate.Text = "Date Parts Sent";
            this.lblPartsDate.Visible = false;
            // 
            // dtpPartsDate
            // 
            this.dtpPartsDate.Location = new System.Drawing.Point(896, 46);
            this.dtpPartsDate.Name = "dtpPartsDate";
            this.dtpPartsDate.Size = new System.Drawing.Size(200, 22);
            this.dtpPartsDate.TabIndex = 38;
            this.dtpPartsDate.Visible = false;
            // 
            // lblDeptError
            // 
            this.lblDeptError.AutoSize = true;
            this.lblDeptError.ForeColor = System.Drawing.Color.Red;
            this.lblDeptError.Location = new System.Drawing.Point(661, 72);
            this.lblDeptError.Name = "lblDeptError";
            this.lblDeptError.Size = new System.Drawing.Size(122, 17);
            this.lblDeptError.TabIndex = 37;
            this.lblDeptError.Text = "*Section Required";
            this.lblDeptError.Visible = false;
            // 
            // lblTypeError
            // 
            this.lblTypeError.AutoSize = true;
            this.lblTypeError.ForeColor = System.Drawing.Color.Red;
            this.lblTypeError.Location = new System.Drawing.Point(458, 72);
            this.lblTypeError.Name = "lblTypeError";
            this.lblTypeError.Size = new System.Drawing.Size(184, 17);
            this.lblTypeError.TabIndex = 36;
            this.lblTypeError.Text = "*Concession Type Required";
            this.lblTypeError.Visible = false;
            // 
            // lblSerialError
            // 
            this.lblSerialError.AutoSize = true;
            this.lblSerialError.ForeColor = System.Drawing.Color.Red;
            this.lblSerialError.Location = new System.Drawing.Point(35, 72);
            this.lblSerialError.Name = "lblSerialError";
            this.lblSerialError.Size = new System.Drawing.Size(181, 17);
            this.lblSerialError.TabIndex = 35;
            this.lblSerialError.Text = "*Serial/Stamp No. Required";
            this.lblSerialError.Visible = false;
            // 
            // lblMachError
            // 
            this.lblMachError.AutoSize = true;
            this.lblMachError.ForeColor = System.Drawing.Color.Red;
            this.lblMachError.Location = new System.Drawing.Point(247, 73);
            this.lblMachError.Name = "lblMachError";
            this.lblMachError.Size = new System.Drawing.Size(164, 17);
            this.lblMachError.TabIndex = 34;
            this.lblMachError.Text = "*Machine Type Required";
            this.lblMachError.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(661, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Problem Causing Section";
            // 
            // cboDept
            // 
            this.cboDept.FormattingEnabled = true;
            this.cboDept.Items.AddRange(new object[] {
            "Quality",
            "QT Lathe Group",
            "VTC/VCN Commodity Group",
            "VTC800 Group",
            "Logistics",
            "EDM",
            "Machining",
            "SMD",
            "Purchasing",
            "General Assembly",
            "Elec/Modular/Unit",
            "Powder Line",
            "Shipping"});
            this.cboDept.Location = new System.Drawing.Point(661, 46);
            this.cboDept.Name = "cboDept";
            this.cboDept.Size = new System.Drawing.Size(192, 24);
            this.cboDept.TabIndex = 32;
            this.cboDept.SelectedIndexChanged += new System.EventHandler(this.cboDept_SelectedIndexChanged);
            // 
            // lblStamp
            // 
            this.lblStamp.AutoSize = true;
            this.lblStamp.Location = new System.Drawing.Point(32, 26);
            this.lblStamp.Name = "lblStamp";
            this.lblStamp.Size = new System.Drawing.Size(102, 17);
            this.lblStamp.TabIndex = 26;
            this.lblStamp.Text = "Stamp Number";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(988, 606);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 35);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblConNo
            // 
            this.lblConNo.AutoSize = true;
            this.lblConNo.Location = new System.Drawing.Point(32, 18);
            this.lblConNo.Name = "lblConNo";
            this.lblConNo.Size = new System.Drawing.Size(0, 17);
            this.lblConNo.TabIndex = 29;
            // 
            // lboPdf
            // 
            this.lboPdf.AllowDrop = true;
            this.lboPdf.FormattingEnabled = true;
            this.lboPdf.ItemHeight = 16;
            this.lboPdf.Location = new System.Drawing.Point(778, 121);
            this.lboPdf.Name = "lboPdf";
            this.lboPdf.Size = new System.Drawing.Size(300, 68);
            this.lboPdf.TabIndex = 28;
            this.lboPdf.Tag = "";
            this.lboPdf.DragDrop += new System.Windows.Forms.DragEventHandler(this.lboPdf_DragDrop);
            this.lboPdf.DragEnter += new System.Windows.Forms.DragEventHandler(this.lboPdf_DragEnter);
            // 
            // cboMachType
            // 
            this.cboMachType.FormattingEnabled = true;
            this.cboMachType.Items.AddRange(new object[] {
            "VTC800",
            "QT200/250",
            "QT300/350",
            "VCN430A/530C",
            "VTC530C/760C"});
            this.cboMachType.Location = new System.Drawing.Point(250, 46);
            this.cboMachType.Name = "cboMachType";
            this.cboMachType.Size = new System.Drawing.Size(158, 24);
            this.cboMachType.TabIndex = 27;
            this.cboMachType.SelectedIndexChanged += new System.EventHandler(this.cboMachType_SelectedIndexChanged);
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(455, 101);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(67, 17);
            this.lblComment.TabIndex = 26;
            this.lblComment.Text = "Comment";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(458, 121);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(270, 71);
            this.txtComment.TabIndex = 26;
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "Full",
            "Stamp",
            "Short-Ship"});
            this.cboType.Location = new System.Drawing.Point(458, 46);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(158, 24);
            this.cboType.TabIndex = 2;
            this.cboType.SelectedIndexChanged += new System.EventHandler(this.cboType_SelectedIndexChanged);
            // 
            // ConcessionData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 736);
            this.Controls.Add(this.lblConError);
            this.Controls.Add(this.txtPrevention);
            this.Controls.Add(this.txtPartName);
            this.Controls.Add(this.txtPartNo);
            this.Controls.Add(this.lblTreatment);
            this.Controls.Add(this.lblPrevention);
            this.Controls.Add(this.lblCause);
            this.Controls.Add(this.lblIssue);
            this.Controls.Add(this.lblPartName);
            this.Controls.Add(this.lblPartNo);
            this.Controls.Add(this.gboNewCon);
            this.Name = "ConcessionData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Concession Data";
            this.Load += new System.EventHandler(this.ConcessionCreate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.concessionReportTypeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.concessionReportTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.gboNewCon.ResumeLayout(false);
            this.gboNewCon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.BindingSource usersBindingSource1;
        private System.Windows.Forms.BindingSource concessionReportTypeBindingSource1;
        public System.Windows.Forms.TextBox txtSerial;
        public System.Windows.Forms.TextBox txtPartNo;
        public System.Windows.Forms.TextBox txtPartName;
        public System.Windows.Forms.TextBox txtIssue;
        public System.Windows.Forms.TextBox txtPrevention;
        public System.Windows.Forms.TextBox txtCause;
        public System.Windows.Forms.TextBox txtTreatment;
        private System.Windows.Forms.Label lblConError;
        private System.Windows.Forms.GroupBox gboNewCon;
        public System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label lblComment;
        public System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.ComboBox cboMachType;
        private System.Windows.Forms.ListBox lboPdf;
        private System.Windows.Forms.Label lblConNo;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblStamp;
        public System.Windows.Forms.ComboBox cboDept;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMachError;
        private System.Windows.Forms.Label lblSerialError;
        private System.Windows.Forms.Label lblTypeError;
        private System.Windows.Forms.Label lblPartsDate;
        private System.Windows.Forms.DateTimePicker dtpPartsDate;
        private System.Windows.Forms.Label lblPdfError;
        private System.Windows.Forms.Label lblDeptError;
        private System.Windows.Forms.Label lblPDF;
    }
}