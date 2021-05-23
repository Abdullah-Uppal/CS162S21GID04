using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace SocietyManagementSystem {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            complaintsForm1.Hide();
            membersForm1.Hide();
            donationForm1.Hide();
            dashboard1.Show();
            guna2ShadowForm1.SetShadowForm(this);
            propertyForm1.Hide();

        }
        private void guna2Button5_Click(object sender, EventArgs e) {
            this.Dispose();
        }

        private void guna2Button2_Click(object sender, EventArgs e) {
            complaintsForm1.Show();
            membersForm1.Hide();
            dashboard1.Hide();
            propertyForm1.Hide();
            donationForm1.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e) {
            complaintsForm1.Hide();
            membersForm1.Show();
            dashboard1.Hide();
            propertyForm1.Hide();
            donationForm1.Hide();
        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e) {

        }

        private void guna2Button4_Click(object sender, EventArgs e) {
            complaintsForm1.Hide();
            membersForm1.Hide();
            dashboard1.Hide();
            propertyForm1.Show();
            donationForm1.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e) {
            complaintsForm1.Hide();
            membersForm1.Hide();
            dashboard1.Show();
            propertyForm1.Hide();
            donationForm1.Hide();
        }


        private void complaintsForm1_Load(object sender, EventArgs e) {

            propertyForm1.Hide();
        }

        private void membersForm1_Load(object sender, EventArgs e) {

        }

        private void guna2Button6_Click_1(object sender, EventArgs e) {
            complaintsForm1.Hide();
            membersForm1.Hide();
            dashboard1.Hide();
            propertyForm1.Hide();
            donationForm1.Show();
        }
    }
}
