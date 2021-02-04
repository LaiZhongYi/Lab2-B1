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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int cnt = lstHob.CheckedItems.Count;

            string hobby = "";

            for (int i = 0; i <= cnt - 1; i++)
            {
                hobby = hobby + lstHob.CheckedItems[i];

                if (i < cnt - 1)
                {
                    hobby = hobby + ",";
                }
            }

            MessageBox.Show(txtName.Text + " born in " + txtYear.Text + " from Class " +
                                lstClass.Text + ", Division " + cboDiv.Text + " has fowllowing hobbies " + hobby);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtYear.Text = "";
            lstClass.ClearSelected();
            cboDiv.Text = "";
            lstHob.ClearSelected();
            for (int i = 0; i < lstHob.Items.Count - 1; i++)
            {
                if (lstHob.GetItemChecked(i))
                {
                    lstHob.SetItemChecked(i, false);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboDiv.SelectedIndex = 0;
        }
    }
}
