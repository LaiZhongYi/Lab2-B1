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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(txtPassword.Text == "" || txtUserName.Text == "")
            {
                MessageBox.Show("Please fill user name and user password","Error" ,MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                User user = new User();

                if (txtUserName.Text == user.UserName && txtPassword.Text == user.Password)
                {
                    

                    Employee emp = new Employee();

                    emp.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Wrong user name or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPassword.Text = txtUserName.Text = "";
                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtPassword.Text = txtUserName.Text = "";
        }
    }
}
