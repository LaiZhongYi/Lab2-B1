using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_B1
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            cboEdu.SelectedIndex = 0;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string result = String.Format("Employee Name is : {0} \nEmployee Address is : {1} \nDate of Joining is : {2} \nEmployee Education : {3} \nEmployee Department : {4} ",
                                        txtEmpName.Text , txtAddress.Text , dateJoin.Text, cboEdu.Text, cboDep.Text);

            MessageBox.Show(result,"Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmpName.Text = txtAddress.Text = "";
            dateJoin.Value = DateTime.Today;
            cboEdu.SelectedIndex = 0;
            cboDep.SelectedIndex = -1;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            form1.ShowDialog();
        }
    }
}
