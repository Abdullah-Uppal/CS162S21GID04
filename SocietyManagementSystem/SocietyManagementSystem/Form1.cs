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
<<<<<<< Updated upstream
=======
            membersForm1.Hide();
            dashboard1.Show();
            guna2ShadowForm1.SetShadowForm(this);
>>>>>>> Stashed changes
        }

        private void guna2Button5_Click(object sender, EventArgs e) {
            this.Dispose();
        }

        private void guna2Button2_Click(object sender, EventArgs e) {
            complaintsForm1.Show();
<<<<<<< Updated upstream
=======
            membersForm1.Hide();
            dashboard1.Hide();
>>>>>>> Stashed changes
        }

        private void guna2Button3_Click(object sender, EventArgs e) {
            complaintsForm1.Hide();
<<<<<<< Updated upstream
=======
            membersForm1.Show();
            dashboard1.Hide();
>>>>>>> Stashed changes
        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e) {

        }

        private void guna2Button4_Click(object sender, EventArgs e) {
            complaintsForm1.Hide();
<<<<<<< Updated upstream
=======
            membersForm1.Hide();
            dashboard1.Hide();
>>>>>>> Stashed changes
        }

        private void guna2Button1_Click(object sender, EventArgs e) {
            complaintsForm1.Hide();
<<<<<<< Updated upstream
=======
            membersForm1.Hide();
            dashboard1.Show();
>>>>>>> Stashed changes
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            complaintsForm1.Show();
<<<<<<< Updated upstream
=======
            membersForm1.Hide();
            dashboard1.Hide();
        }

        private void complaintsForm1_Load(object sender, EventArgs e) {

>>>>>>> Stashed changes
        }
    }
}
