namespace Lab2_B1
{
    partial class Form1
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
            this.pnFooter = new System.Windows.Forms.Panel();
            this.lbHeader = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnBody = new System.Windows.Forms.Panel();
            this.lbStudent = new System.Windows.Forms.Label();
            this.lbBirth = new System.Windows.Forms.Label();
            this.lbClass = new System.Windows.Forms.Label();
            this.lbDiv = new System.Windows.Forms.Label();
            this.lbHob = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.cboDiv = new System.Windows.Forms.ComboBox();
            this.lstClass = new System.Windows.Forms.ListBox();
            this.lstHob = new System.Windows.Forms.CheckedListBox();
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
            // pnFooter
            // 
            this.pnFooter.Controls.Add(this.btnClear);
            this.pnFooter.Controls.Add(this.btnConfirm);
            this.pnFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnFooter.Location = new System.Drawing.Point(0, 568);
            this.pnFooter.Name = "pnFooter";
            this.pnFooter.Size = new System.Drawing.Size(493, 100);
            this.pnFooter.TabIndex = 1;
            // 
            // lbHeader
            // 
            this.lbHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader.Location = new System.Drawing.Point(0, 0);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(493, 52);
            this.lbHeader.TabIndex = 0;
            this.lbHeader.Text = "Student\'s Class Details";
            this.lbHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(63, 20);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(175, 49);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "Confirm Student Details";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(288, 20);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(143, 49);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pnBody
            // 
            this.pnBody.Controls.Add(this.lstHob);
            this.pnBody.Controls.Add(this.lstClass);
            this.pnBody.Controls.Add(this.cboDiv);
            this.pnBody.Controls.Add(this.txtYear);
            this.pnBody.Controls.Add(this.txtName);
            this.pnBody.Controls.Add(this.lbHob);
            this.pnBody.Controls.Add(this.lbDiv);
            this.pnBody.Controls.Add(this.lbClass);
            this.pnBody.Controls.Add(this.lbBirth);
            this.pnBody.Controls.Add(this.lbStudent);
            this.pnBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBody.Location = new System.Drawing.Point(0, 52);
            this.pnBody.Name = "pnBody";
            this.pnBody.Size = new System.Drawing.Size(493, 516);
            this.pnBody.TabIndex = 2;
            // 
            // lbStudent
            // 
            this.lbStudent.AutoSize = true;
            this.lbStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudent.Location = new System.Drawing.Point(12, 28);
            this.lbStudent.Name = "lbStudent";
            this.lbStudent.Size = new System.Drawing.Size(112, 20);
            this.lbStudent.TabIndex = 0;
            this.lbStudent.Text = "Student Name";
            // 
            // lbBirth
            // 
            this.lbBirth.AutoSize = true;
            this.lbBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBirth.Location = new System.Drawing.Point(12, 83);
            this.lbBirth.Name = "lbBirth";
            this.lbBirth.Size = new System.Drawing.Size(101, 20);
            this.lbBirth.TabIndex = 1;
            this.lbBirth.Text = "Year Of Birth";
            // 
            // lbClass
            // 
            this.lbClass.AutoSize = true;
            this.lbClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClass.Location = new System.Drawing.Point(12, 139);
            this.lbClass.Name = "lbClass";
            this.lbClass.Size = new System.Drawing.Size(118, 20);
            this.lbClass.TabIndex = 2;
            this.lbClass.Text = "Standard/Class";
            // 
            // lbDiv
            // 
            this.lbDiv.AutoSize = true;
            this.lbDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiv.Location = new System.Drawing.Point(12, 266);
            this.lbDiv.Name = "lbDiv";
            this.lbDiv.Size = new System.Drawing.Size(63, 20);
            this.lbDiv.TabIndex = 3;
            this.lbDiv.Text = "Division";
            // 
            // lbHob
            // 
            this.lbHob.AutoSize = true;
            this.lbHob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHob.Location = new System.Drawing.Point(12, 344);
            this.lbHob.Name = "lbHob";
            this.lbHob.Size = new System.Drawing.Size(68, 20);
            this.lbHob.TabIndex = 4;
            this.lbHob.Text = "Hobbies";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(141, 22);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(273, 26);
            this.txtName.TabIndex = 5;
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.Location = new System.Drawing.Point(141, 83);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(139, 26);
            this.txtYear.TabIndex = 6;
            // 
            // cboDiv
            // 
            this.cboDiv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDiv.FormattingEnabled = true;
            this.cboDiv.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cboDiv.Location = new System.Drawing.Point(141, 263);
            this.cboDiv.Name = "cboDiv";
            this.cboDiv.Size = new System.Drawing.Size(139, 28);
            this.cboDiv.TabIndex = 7;
            // 
            // lstClass
            // 
            this.lstClass.FormattingEnabled = true;
            this.lstClass.Items.AddRange(new object[] {
            "I",
            "II",
            "III",
            "IV",
            "V",
            "VI",
            "VII",
            "VIII",
            "IX",
            "X"});
            this.lstClass.Location = new System.Drawing.Point(141, 139);
            this.lstClass.Name = "lstClass";
            this.lstClass.Size = new System.Drawing.Size(139, 95);
            this.lstClass.TabIndex = 8;
            // 
            // lstHob
            // 
            this.lstHob.FormattingEnabled = true;
            this.lstHob.Items.AddRange(new object[] {
            "Singing",
            "Dancing",
            "Swimming",
            "Reading",
            "Travelling"});
            this.lstHob.Location = new System.Drawing.Point(141, 344);
            this.lstHob.Name = "lstHob";
            this.lstHob.Size = new System.Drawing.Size(139, 94);
            this.lstHob.TabIndex = 9;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 668);
            this.Controls.Add(this.pnBody);
            this.Controls.Add(this.pnFooter);
            this.Controls.Add(this.pnHeader);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Details";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.CheckedListBox lstHob;
        private System.Windows.Forms.ListBox lstClass;
        private System.Windows.Forms.ComboBox cboDiv;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbHob;
        private System.Windows.Forms.Label lbDiv;
        private System.Windows.Forms.Label lbClass;
        private System.Windows.Forms.Label lbBirth;
        private System.Windows.Forms.Label lbStudent;
    }
}

