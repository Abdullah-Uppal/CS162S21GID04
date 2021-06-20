using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocietyManagementSystem {
    public partial class DonationForm : UserControl {
        public DonationForm() {
            InitializeComponent();
            LoadDonor();
        }

        private void gunaLabel2_Click(object sender, EventArgs e) {

        }

        private void gunaLabel4_Click(object sender, EventArgs e) {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Donation d = new Donation()
            {
                Name = NameBox.Text,
                Email=EmailBox.Text,
                PhoneNumber=PhoneBox.Text,
                Amount=Int32.Parse(AmountBox.Text),
                CNIC=CNICBox.Text,
                GenderType=Male.Checked==true?Male.Text:Female.Text


            };
            Society.GetInstance().AddDonor(d);
        }

        private void SearchBox_Enter(object sender, EventArgs e)
        {
            LoadSearch();
        }
        public void LoadSearch()
        {
            guna2DataGridView1.DataSource = Society.GetInstance().SearchByCNIC(SearchBox.Text);
        }
        public void LoadDonor()
        {
            guna2DataGridView1.DataSource = Society.GetInstance().Donate;
        }
    }
}
