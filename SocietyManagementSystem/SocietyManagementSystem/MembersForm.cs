using System;
using System.Windows.Forms;

namespace SocietyManagementSystem {
    public partial class MembersForm : UserControl {
        public MembersForm() {
            InitializeComponent();
            LoadMember();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void label4_Click(object sender, EventArgs e) {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Members m = new Members()
            {
                Name = NameTextBox.Text,
                PhoneNumber=PhoneNumberBox.Text,
                Email=EmailBox.Text,
                designation=DesignationBox.Text,
                Age=Int32.Parse(AgeBox.Text),
                Address=AddressBox.Text,
                CNIC=CNICBox.Text
            };
            Society.GetInstance().AddMember(m);
        }

        private void gunaLineTextBox5_TextChanged(object sender, EventArgs e)
        {

        }
        public void LoadMember()
        {
            guna2DataGridView1.DataSource = Society.GetInstance().Member;
        }
    }
}
