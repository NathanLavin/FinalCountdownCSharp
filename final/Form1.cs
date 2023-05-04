using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace final
{
    public partial class Form1 : Form
    {
        List<Band> bands = new List<Band>();
        Event events = new Event();
        string[] admins = new string[1] { "#npl66399" };
        public Form1()
        {
            InitializeComponent();
            bands.Add(new Band("Greenday"));
            bands.Add(new Band("Polyphia"));
            bands.Add(new Band("Purrple Cat"));
            bands.Add(new Band("Neon Trees"));

            events.Events = bands;

            foreach (Band band in events.Events)
            {
                lblBandNames.Text += band.ToString();
                cbobxUpdateDelete.Items.Add(band.Name);
            }

            grpbxAdminWindow.Visible = false;
        }

        private void btnTicketPurchaser_Click(object sender, EventArgs e)
        {
            Form2 ticketpurchaser = new Form2(bands);
            ticketpurchaser.Show();
        }

        private void btnBookUs_Click(object sender, EventArgs e)
        {
            string addedBand = txtBandName.Text;

            if (addedBand != "")
            {
                bands.Add(new Band(addedBand));
                lblBandAdded.Text = $"{addedBand} has been added to the bookings list.";
                
            }
            else
            {
                lblBandAdded.Text = "Please enter a band name.";
            }

            cbobxUpdateDelete.Items.Clear();
            lblBandNames.Text = string.Empty;
            events.Events = bands;
            foreach (Band band in events.Events)
            {
                lblBandNames.Text += band.ToString();
                cbobxUpdateDelete.Items.Add(band.Name);
            }
            txtBandName.Text = string.Empty;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string adminLogin;
            adminLogin = txtAdminLogin.Text;
            //logins
            //#npl66399
            //#sh69696
            //#jav34343

            try
            {
                for (int i = 0; i < admins.Length - 1; i++)
                {
                    if (adminLogin == admins[i])
                    {
                        adminLogin = txtAdminLogin.Text;
                        txtAdminLogin.Text = string.Empty;
                        txtAdminLogin.Enabled = false;
                        lblAccess.Text = "Access Granted";
                        lblAccess.ForeColor = System.Drawing.Color.Green;
                        btnLogin.Enabled = false;
                        grpbxAdminWindow.Visible = true;
                    }
                    else
                    {
                        lblAccess.Text = "Access Denied";
                        lblAccess.ForeColor = System.Drawing.Color.Red;
                        txtAdminLogin.Text = string.Empty;
                    }
                }
                
            }
            catch
            {
                lblAccess.Text = "Access Denied";
                lblAccess.ForeColor = System.Drawing.Color.Red;
            }


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string updateBand = cbobxUpdateDelete.Text;
            string updateBandTxt = txtUpdate.Text;

            foreach (Band band in events.Events)
            {
                if (band.Name == updateBand)
                {
                    band.Name = updateBandTxt;
                }
            }

            lblBandNames.Text = "";
            cbobxUpdateDelete.Items.Clear();

            foreach (Band bandUpdate in events.Events)
            {
                lblBandNames.Text += bandUpdate.ToString();
                cbobxUpdateDelete.Items.Add(bandUpdate.Name);
            }
            cbobxUpdateDelete.Text = string.Empty;
            txtUpdate.Text = string.Empty;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string deleteBand = cbobxUpdateDelete.Text;

            for (int i = 0; i < events.Events.Count; i++)
            {
                if (deleteBand == events.Events[i].Name)
                {
                    events.Events.Remove(events.Events[i]);
                }
            }

            lblBandNames.Text = "";
            cbobxUpdateDelete.Items.Clear();

            foreach (Band bandDelete in events.Events)
            {
                lblBandNames.Text += bandDelete.ToString();
                cbobxUpdateDelete.Items.Add(bandDelete.Name);
            }
            cbobxUpdateDelete.Text =string.Empty;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            txtAdminLogin.Enabled = true;
            grpbxAdminWindow.Visible = false;
            lblAccess.Text = string.Empty;
            btnLogin.Enabled = true;
        }
    }
}