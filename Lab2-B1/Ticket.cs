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
    public partial class Ticket : Form
    {
        public Ticket()
        {
            InitializeComponent();
        }

        private void Ticket_Load(object sender, EventArgs e)
        {
            cboClass.SelectedIndex = 0;
        }

        private void txtTicketNum_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        private void txtPassportNum_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(lstSource.SelectedItem.ToString() == lstDes.SelectedItem.ToString())
            {
                MessageBox.Show("Your Source should not matches with your Destination, Please try again!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int serCount = lstSer.CheckedItems.Count;

            string services = "";

            for (int i = 0; i <= serCount - 1; i++)
            {
                services += lstSer.CheckedItems[i].ToString();

                if(i < serCount - 1)
                {
                    services += ",";
                }
            }

            string result = String.Format("YOUR INFORMATION :\n" +
                                        "\nTicket Number: {0}" +
                                        "\nPassenger Name: {1}" +
                                        "\nPassport Number: {2}" +
                                        "\nSource: {3}" +
                                        "\nDestination: {4}" +
                                        "\nFlight Date: {5}" +
                                        "\nClass: {6}" +
                                        "\nServices: {7}",
                                        txtTicketNum.Text,
                                        txtPasName.Text,
                                        txtPassportNum.Text,
                                        lstSource.SelectedItem.ToString(),
                                        lstDes.SelectedItem.ToString(),
                                        dateJoin.Value.ToString(),
                                        cboClass.SelectedItem.ToString(),
                                        services);

            MessageBox.Show(result, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTicketNum.Text = txtPasName.Text = txtPassportNum.Text = "";
            lstSource.SelectedItem = null;
            lstDes.SelectedItem = null;
            dateJoin.Value = DateTime.Now;
            cboClass.SelectedItem = 0;

            for (int i = 0; i <= lstSer.CheckedItems.Count; i++)
            {
                lstSer.SetItemCheckState(i,CheckState.Unchecked);
            }
        }
    }
}
