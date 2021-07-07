using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P3LogoStore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cboxLogo_CheckedChanged(object sender, EventArgs e)
        {
            if(cboxLogo.Checked)
            {
                lblNumColors.Visible = true;
                txtNumColors.Visible = true;
            }
            else
            {
                lblNumColors.Visible = false;
                txtNumColors.Visible = false;
            }
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            LogoOrderItem loi = new LogoOrderItem(txtPrintedText.Text, cboxLogo.Checked);
            loi.NumItems = Int32.Parse(txtNumItems.Text);
            if(rbtnMug.Checked)
            {
                loi.ItemType = "Mug";
            }
            else if (rbtnPen.Checked)
            {
                loi.ItemType = "Pen";
            }
            else
            {
                loi.ItemType = "USB";
            }
            if(cboxLogo.Checked)
            {
                loi.NumColors = Int32.Parse(txtNumColors.Text);
            }

            txtSummary.Text = loi.GetOrderSummary();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOrderNum.Clear();
            txtNumItems.Clear();
            txtPrintedText.Clear();
            cboxLogo.Checked = true;
            txtNumColors.Clear();
            txtSummary.Clear();
        }
    }
}
