namespace Lab2_B1
{
    partial class Employee
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
            this.pnHeader = new System.Windows.Forms.Panel();
            this.lbHeader = new System.Windows.Forms.Label();
            this.pnFooter = new System.Windows.Forms.Panel();
            this.btnStudent = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.pnBody = new System.Windows.Forms.Panel();
            this.cboDep = new System.Windows.Forms.ComboBox();
            this.dateJoin = new System.Windows.Forms.DateTimePicker();
            this.txtAddress = new System.Windows.Forms.RichTextBox();
            this.cboEdu = new System.Windows.Forms.ComboBox();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.lbDep = new System.Windows.Forms.Label();
            this.lbEdu = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbEmpAddr = new System.Windows.Forms.Label();
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
            this.lbHeader.Text = "Employee Details";
            this.lbHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnFooter
            // 
            this.pnFooter.Controls.Add(this.btnStudent);
            this.pnFooter.Controls.Add(this.btnExit);
            this.pnFooter.Controls.Add(this.btnClear);
            this.pnFooter.Controls.Add(this.btnConfirm);
            this.pnFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnFooter.Location = new System.Drawing.Point(0, 568);
            this.pnFooter.Name = "pnFooter";
            this.pnFooter.Size = new System.Drawing.Size(493, 100);
            this.pnFooter.TabIndex = 1;
            // 
            // btnStudent
            // 
            this.btnStudent.Location = new System.Drawing.Point(196, 20);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(91, 49);
            this.btnStudent.TabIndex = 13;
            this.btnStudent.Text = "Student";
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(390, 20);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 49);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(293, 20);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(91, 49);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(16, 20);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(138, 49);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "Save";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // pnBody
            // 
            this.pnBody.Controls.Add(this.cboDep);
            this.pnBody.Controls.Add(this.dateJoin);
            this.pnBody.Controls.Add(this.txtAddress);
            this.pnBody.Controls.Add(this.cboEdu);
            this.pnBody.Controls.Add(this.txtEmpName);
            this.pnBody.Controls.Add(this.lbDep);
            this.pnBody.Controls.Add(this.lbEdu);
            this.pnBody.Controls.Add(this.lbDate);
            this.pnBody.Controls.Add(this.lbEmpAddr);
            this.pnBody.Controls.Add(this.lbEmpName);
            this.pnBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBody.Location = new System.Drawing.Point(0, 52);
            this.pnBody.Name = "pnBody";
            this.pnBody.Size = new System.Drawing.Size(493, 516);
            this.pnBody.TabIndex = 2;
            // 
            // cboDep
            // 
            this.cboDep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDep.FormattingEnabled = true;
            this.cboDep.Items.AddRange(new object[] {
            "Human Resource",
            "Marketing",
            "R&D"});
            this.cboDep.Location = new System.Drawing.Point(160, 425);
            this.cboDep.Name = "cboDep";
            this.cboDep.Size = new System.Drawing.Size(139, 28);
            this.cboDep.TabIndex = 12;
            // 
            // dateJoin
            // 
            this.dateJoin.CustomFormat = "";
            this.dateJoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateJoin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateJoin.Location = new System.Drawing.Point(160, 261);
            this.dateJoin.Name = "dateJoin";
            this.dateJoin.Size = new System.Drawing.Size(139, 24);
            this.dateJoin.TabIndex = 11;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(160, 109);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(273, 96);
            this.txtAddress.TabIndex = 10;
            this.txtAddress.Text = "";
            // 
            // cboEdu
            // 
            this.cboEdu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEdu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEdu.Items.AddRange(new object[] {
            "UnderGraduate",
            "PostGraduate"});
            this.cboEdu.Location = new System.Drawing.Point(160, 340);
            this.cboEdu.Name = "cboEdu";
            this.cboEdu.Size = new System.Drawing.Size(139, 28);
            this.cboEdu.TabIndex = 7;
            // 
            // txtEmpName
            // 
            this.txtEmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpName.Location = new System.Drawing.Point(160, 22);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(273, 26);
            this.txtEmpName.TabIndex = 5;
            // 
            // lbDep
            // 
            this.lbDep.AutoSize = true;
            this.lbDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDep.Location = new System.Drawing.Point(12, 428);
            this.lbDep.Name = "lbDep";
            this.lbDep.Size = new System.Drawing.Size(94, 20);
            this.lbDep.TabIndex = 4;
            this.lbDep.Text = "Department";
            // 
            // lbEdu
            // 
            this.lbEdu.AutoSize = true;
            this.lbEdu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEdu.Location = new System.Drawing.Point(12, 343);
            this.lbEdu.Name = "lbEdu";
            this.lbEdu.Size = new System.Drawing.Size(81, 20);
            this.lbEdu.TabIndex = 3;
            this.lbEdu.Text = "Education";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(12, 262);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(111, 20);
            this.lbDate.TabIndex = 2;
            this.lbDate.Text = "Date of joining";
            // 
            // lbEmpAddr
            // 
            this.lbEmpAddr.AutoSize = true;
            this.lbEmpAddr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpAddr.Location = new System.Drawing.Point(12, 109);
            this.lbEmpAddr.Name = "lbEmpAddr";
            this.lbEmpAddr.Size = new System.Drawing.Size(142, 20);
            this.lbEmpAddr.TabIndex = 1;
            this.lbEmpAddr.Text = "Employee Address";
            // 
            // lbEmpName
            // 
            this.lbEmpName.AutoSize = true;
            this.lbEmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpName.Location = new System.Drawing.Point(12, 28);
            this.lbEmpName.Name = "lbEmpName";
            this.lbEmpName.Size = new System.Drawing.Size(125, 20);
            this.lbEmpName.TabIndex = 0;
            this.lbEmpName.Text = "Employee Name";
            // 
            // Employee
            // 
            this.AcceptButton = this.btnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 668);
            this.Controls.Add(this.pnBody);
            this.Controls.Add(this.pnFooter);
            this.Controls.Add(this.pnHeader);
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Details";
            this.Load += new System.EventHandler(this.Employee_Load);
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
        private System.Windows.Forms.ComboBox cboEdu;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.Label lbDep;
        private System.Windows.Forms.Label lbEdu;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbEmpAddr;
        private System.Windows.Forms.Label lbEmpName;
        private System.Windows.Forms.RichTextBox txtAddress;
        private System.Windows.Forms.DateTimePicker dateJoin;
        private System.Windows.Forms.ComboBox cboDep;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnStudent;
    }
}