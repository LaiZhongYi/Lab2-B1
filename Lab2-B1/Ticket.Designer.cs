namespace Lab2_B1
{
    partial class Ticket
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

        private void InitializeComponent()
        {
            this.pnHeader = new System.Windows.Forms.Panel();
            this.lbHeader = new System.Windows.Forms.Label();
            this.pnFooter = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.pnBody = new System.Windows.Forms.Panel();
            this.lstSer = new System.Windows.Forms.CheckedListBox();
            this.lstDes = new System.Windows.Forms.ListBox();
            this.lbDes = new System.Windows.Forms.Label();
            this.lstSource = new System.Windows.Forms.ListBox();
            this.lbSource = new System.Windows.Forms.Label();
            this.txtPassportNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPasName = new System.Windows.Forms.TextBox();
            this.dateJoin = new System.Windows.Forms.DateTimePicker();
            this.cboClass = new System.Windows.Forms.ComboBox();
            this.txtTicketNum = new System.Windows.Forms.TextBox();
            this.lbSer = new System.Windows.Forms.Label();
            this.lbClass = new System.Windows.Forms.Label();
            this.lbDateFly = new System.Windows.Forms.Label();
            this.lbPasName = new System.Windows.Forms.Label();
            this.lbEmpName = new System.Windows.Forms.Label();
            this.pnHeader.SuspendLayout();
            this.pnFooter.SuspendLayout();
            this.pnBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnHeader
            // 
            this.pnHeader.Controls.Add(this.lbHeader);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(493, 52);
            this.pnHeader.TabIndex = 0;
            // 
            // lbHeader
            // 
            this.lbHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader.Location = new System.Drawing.Point(0, 0);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(493, 52);
            this.lbHeader.TabIndex = 0;
            this.lbHeader.Text = "Flight Reservation Details";
            this.lbHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnFooter
            // 
            this.pnFooter.Controls.Add(this.btnExit);
            this.pnFooter.Controls.Add(this.btnClear);
            this.pnFooter.Controls.Add(this.btnConfirm);
            this.pnFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnFooter.Location = new System.Drawing.Point(0, 568);
            this.pnFooter.Name = "pnFooter";
            this.pnFooter.Size = new System.Drawing.Size(493, 100);
            this.pnFooter.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(390, 20);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 49);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(293, 20);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(91, 49);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(12, 20);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(144, 49);
            this.btnConfirm.TabIndex = 9;
            this.btnConfirm.Text = "Save";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // pnBody
            // 
            this.pnBody.Controls.Add(this.lstSer);
            this.pnBody.Controls.Add(this.lstDes);
            this.pnBody.Controls.Add(this.lbDes);
            this.pnBody.Controls.Add(this.lstSource);
            this.pnBody.Controls.Add(this.lbSource);
            this.pnBody.Controls.Add(this.txtPassportNum);
            this.pnBody.Controls.Add(this.label1);
            this.pnBody.Controls.Add(this.txtPasName);
            this.pnBody.Controls.Add(this.dateJoin);
            this.pnBody.Controls.Add(this.cboClass);
            this.pnBody.Controls.Add(this.txtTicketNum);
            this.pnBody.Controls.Add(this.lbSer);
            this.pnBody.Controls.Add(this.lbClass);
            this.pnBody.Controls.Add(this.lbDateFly);
            this.pnBody.Controls.Add(this.lbPasName);
            this.pnBody.Controls.Add(this.lbEmpName);
            this.pnBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBody.Location = new System.Drawing.Point(0, 52);
            this.pnBody.Name = "pnBody";
            this.pnBody.Size = new System.Drawing.Size(493, 516);
            this.pnBody.TabIndex = 2;
            // 
            // lstSer
            // 
            this.lstSer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSer.FormattingEnabled = true;
            this.lstSer.Items.AddRange(new object[] {
            "Child Care",
            "Nurse"});
            this.lstSer.Location = new System.Drawing.Point(161, 439);
            this.lstSer.Name = "lstSer";
            this.lstSer.Size = new System.Drawing.Size(158, 38);
            this.lstSer.TabIndex = 8;
            // 
            // lstDes
            // 
            this.lstDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDes.FormattingEnabled = true;
            this.lstDes.ItemHeight = 16;
            this.lstDes.Items.AddRange(new object[] {
            "Amsterdam",
            "Ha Noi",
            "Singapore"});
            this.lstDes.Location = new System.Drawing.Point(161, 275);
            this.lstDes.Name = "lstDes";
            this.lstDes.Size = new System.Drawing.Size(159, 52);
            this.lstDes.TabIndex = 5;
            // 
            // lbDes
            // 
            this.lbDes.AutoSize = true;
            this.lbDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDes.Location = new System.Drawing.Point(14, 275);
            this.lbDes.Name = "lbDes";
            this.lbDes.Size = new System.Drawing.Size(90, 20);
            this.lbDes.TabIndex = 18;
            this.lbDes.Text = "Destination";
            // 
            // lstSource
            // 
            this.lstSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSource.FormattingEnabled = true;
            this.lstSource.ItemHeight = 16;
            this.lstSource.Items.AddRange(new object[] {
            "Amsterdam",
            "Ha Noi",
            "Singapore"});
            this.lstSource.Location = new System.Drawing.Point(160, 207);
            this.lstSource.Name = "lstSource";
            this.lstSource.Size = new System.Drawing.Size(159, 52);
            this.lstSource.TabIndex = 4;
            // 
            // lbSource
            // 
            this.lbSource.AutoSize = true;
            this.lbSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSource.Location = new System.Drawing.Point(13, 207);
            this.lbSource.Name = "lbSource";
            this.lbSource.Size = new System.Drawing.Size(60, 20);
            this.lbSource.TabIndex = 16;
            this.lbSource.Text = "Source";
            // 
            // txtPassportNum
            // 
            this.txtPassportNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassportNum.Location = new System.Drawing.Point(161, 145);
            this.txtPassportNum.MaxLength = 10;
            this.txtPassportNum.Name = "txtPassportNum";
            this.txtPassportNum.Size = new System.Drawing.Size(159, 26);
            this.txtPassportNum.TabIndex = 3;
            this.txtPassportNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassportNum_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Passport Number";
            // 
            // txtPasName
            // 
            this.txtPasName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasName.Location = new System.Drawing.Point(161, 80);
            this.txtPasName.Name = "txtPasName";
            this.txtPasName.Size = new System.Drawing.Size(273, 26);
            this.txtPasName.TabIndex = 2;
            // 
            // dateJoin
            // 
            this.dateJoin.CustomFormat = "";
            this.dateJoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateJoin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateJoin.Location = new System.Drawing.Point(160, 342);
            this.dateJoin.Name = "dateJoin";
            this.dateJoin.Size = new System.Drawing.Size(159, 22);
            this.dateJoin.TabIndex = 6;
            // 
            // cboClass
            // 
            this.cboClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboClass.Items.AddRange(new object[] {
            "Ecodamic",
            "Boss",
            "VIP"});
            this.cboClass.Location = new System.Drawing.Point(161, 388);
            this.cboClass.Name = "cboClass";
            this.cboClass.Size = new System.Drawing.Size(158, 28);
            this.cboClass.TabIndex = 7;
            // 
            // txtTicketNum
            // 
            this.txtTicketNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTicketNum.Location = new System.Drawing.Point(160, 22);
            this.txtTicketNum.MaxLength = 10;
            this.txtTicketNum.Name = "txtTicketNum";
            this.txtTicketNum.Size = new System.Drawing.Size(159, 26);
            this.txtTicketNum.TabIndex = 1;
            this.txtTicketNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTicketNum_KeyPress);
            // 
            // lbSer
            // 
            this.lbSer.AutoSize = true;
            this.lbSer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSer.Location = new System.Drawing.Point(14, 448);
            this.lbSer.Name = "lbSer";
            this.lbSer.Size = new System.Drawing.Size(69, 20);
            this.lbSer.TabIndex = 4;
            this.lbSer.Text = "Services";
            // 
            // lbClass
            // 
            this.lbClass.AutoSize = true;
            this.lbClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClass.Location = new System.Drawing.Point(13, 391);
            this.lbClass.Name = "lbClass";
            this.lbClass.Size = new System.Drawing.Size(48, 20);
            this.lbClass.TabIndex = 3;
            this.lbClass.Text = "Class";
            // 
            // lbDateFly
            // 
            this.lbDateFly.AutoSize = true;
            this.lbDateFly.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateFly.Location = new System.Drawing.Point(12, 343);
            this.lbDateFly.Name = "lbDateFly";
            this.lbDateFly.Size = new System.Drawing.Size(87, 20);
            this.lbDateFly.TabIndex = 2;
            this.lbDateFly.Text = "Flight Date";
            // 
            // lbPasName
            // 
            this.lbPasName.AutoSize = true;
            this.lbPasName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPasName.Location = new System.Drawing.Point(13, 80);
            this.lbPasName.Name = "lbPasName";
            this.lbPasName.Size = new System.Drawing.Size(131, 20);
            this.lbPasName.TabIndex = 1;
            this.lbPasName.Text = "Passenger Name";
            // 
            // lbEmpName
            // 
            this.lbEmpName.AutoSize = true;
            this.lbEmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpName.Location = new System.Drawing.Point(12, 28);
            this.lbEmpName.Name = "lbEmpName";
            this.lbEmpName.Size = new System.Drawing.Size(111, 20);
            this.lbEmpName.TabIndex = 0;
            this.lbEmpName.Text = "Ticket Number";
            // 
            // Ticket
            // 
            this.AcceptButton = this.btnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 668);
            this.Controls.Add(this.pnBody);
            this.Controls.Add(this.pnFooter);
            this.Controls.Add(this.pnHeader);
            this.Name = "Ticket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Details";
            this.Load += new System.EventHandler(this.Ticket_Load);
            this.pnHeader.ResumeLayout(false);
            this.pnFooter.ResumeLayout(false);
            this.pnBody.ResumeLayout(false);
            this.pnBody.PerformLayout();
            this.ResumeLayout(false);

        }

#endregion

        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.Panel pnFooter;
        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Panel pnBody;
        private System.Windows.Forms.ComboBox cboClass;
        private System.Windows.Forms.TextBox txtTicketNum;
        private System.Windows.Forms.Label lbSer;
        private System.Windows.Forms.Label lbClass;
        private System.Windows.Forms.Label lbDateFly;
        private System.Windows.Forms.Label lbPasName;
        private System.Windows.Forms.Label lbEmpName;
        private System.Windows.Forms.DateTimePicker dateJoin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtPasName;
        private System.Windows.Forms.ListBox lstDes;
        private System.Windows.Forms.Label lbDes;
        private System.Windows.Forms.ListBox lstSource;
        private System.Windows.Forms.Label lbSource;
        private System.Windows.Forms.TextBox txtPassportNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox lstSer;
    }
}