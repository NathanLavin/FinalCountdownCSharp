using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final
{
    public partial class Form2 : Form
    {
        const double generalAdmission = 9.99;
        const double frontAdmission = 14.99;
        const double vipAdmission = 19.99;

        double guestTotal = 0;

        List<Band> newBand;

        public Form2(List<Band> bands)
        {
            InitializeComponent();
            newBand = bands;
            foreach (Band band in newBand)
            {
                lblBands.Text += band.ToString();
            }
            grpbxReciept.Visible = false;
            btnPurchaseTickets.Enabled = false;
        }

        public void ticketPurchases(double generalAmt, double frontAmt, double vipAmt)
        {
            Ticket ticketTotal = new Ticket();
            ticketTotal.GeneralAdmission = generalAmt;
            ticketTotal.FrontAdmission = frontAmt;
            ticketTotal.VipAdmission = vipAmt;
            if (chkbxGenAdmis.Checked == true)
            {
                ticketTotal.TicketPrice += generalAdmission * generalAmt;
            }
            if (chkbxFrontAdmis.Checked == true)
            {
                ticketTotal.TicketPrice += frontAdmission * frontAmt;
            }
            if (chkbxVipAdmis.Checked == true)
            {
                ticketTotal.TicketPrice += vipAdmission * vipAmt;
            }
            lblTotal.Text = ticketTotal.ToString();
        }

        private void btnPrintReciept_Click(object sender, EventArgs e)
        {
            double generalAmt = 0;
            double frontAmt = 0;
            double vipAmt = 0;
            if (txtGenQuant.Text == "" && txtFrontQuant.Text == "" && txtVipQuant.Text == "")
            {
                MessageBox.Show("Please Enter a Number");
                grpbxReciept.Visible = false;
            }
            else
            {
                if (txtGenQuant.Text != "")
                {
                    if (chkbxGenAdmis.Checked)
                    {
                        if (double.TryParse(txtGenQuant.Text, out generalAmt))
                        {
                            generalAmt = double.Parse(txtGenQuant.Text);
                        }
                        else
                        {
                            MessageBox.Show("Please enter a number.");
                            txtGenQuant.Text = string.Empty;
                            grpbxReciept.Visible = false;
                        }
                    }
                }
                if (txtFrontQuant.Text != "")
                {
                    if (chkbxFrontAdmis.Checked)
                    {
                        if (double.TryParse(txtFrontQuant.Text, out frontAmt))
                        {
                            frontAmt = double.Parse(txtFrontQuant.Text);
                        }
                        else
                        {
                            MessageBox.Show("Please enter a number.");
                            txtFrontQuant.Text = string.Empty;
                            grpbxReciept.Visible = false;
                        }
                    }
                }
                if (txtVipQuant.Text != "")
                {
                    if (chkbxVipAdmis.Checked)
                    {
                        if (double.TryParse(txtVipQuant.Text, out vipAmt))
                        {
                            vipAmt = double.Parse(txtVipQuant.Text);
                        }
                        else
                        {
                            MessageBox.Show("Please enter a number.");
                            txtVipQuant.Text = string.Empty;
                            grpbxReciept.Visible = false;
                        }
                    }
                }
            }
            grpbxReciept.Visible = true;
            btnPurchaseTickets.Enabled = true;
            ticketPurchases(generalAmt, frontAmt, vipAmt);
        }

        private void btnPurchaseTickets_Click(object sender, EventArgs e)
        {
            double generalAmt = 0;
            double frontAmt = 0;
            double vipAmt = 0;
            if (txtGenQuant.Text != "")
            {
                generalAmt = double.Parse(txtGenQuant.Text);
            }
            if (txtFrontQuant.Text != "")
            {
                frontAmt = double.Parse(txtFrontQuant.Text);
            }
            if (txtVipQuant.Text != "")
            {
                vipAmt = double.Parse(txtVipQuant.Text);
            }
            if (chkbxGenAdmis.Checked == false)
            {
                generalAmt = 0;
            }
            if (chkbxFrontAdmis.Checked == false)
            {
                frontAmt = 0;
            }
            if (chkbxVipAdmis.Checked == false)
            {
                vipAmt = 0;
            }
            grpbxReciept.Visible = false;
            //lblGuestQuantity.Text = ticketPurchases(generalAmt, frontAmt, vipAmt).ToString();
            guestTotal += generalAmt + frontAmt + vipAmt; 
            lblGuestQuantity.Text = $"{guestTotal} guest(s) are coming to the event.";
            chkbxGenAdmis.Checked = false;
            chkbxFrontAdmis.Checked = false;
            chkbxVipAdmis.Checked = false;
            txtGenQuant.Text = string.Empty;
            txtFrontQuant.Text = string.Empty;
            txtVipQuant.Text = string.Empty;
        }
    }
}
