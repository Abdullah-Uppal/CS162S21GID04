using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocietyManagementSystem
{
    public partial class AddComplaintForm : Form
    {
        public AddComplaintForm()
        {
            InitializeComponent();
            guna2ShadowForm1.SetShadowForm(this);
            dateTime.Text = DateTime.Now.ToString();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Complaint c = new Complaint()
            {
                Name = ComplaintTextBox3.Text,
                Description = DescriptionTextBox.Text,
                Date = DateTime.Parse(dateTime.Text),
                Status = PendingRadioButton.Checked == true ? PendingRadioButton.Text : SolvedRadioButton.Text,
                ComplainantName = NameTextBox.Text,
                ComplainantEmail = EmailTextBox.Text
            };
            Society.GetInstance().AddComplaint(c);
            ComplaintsForm.GetInstance().LoadComplaints();
            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddComplaintForm_MouseClick(object sender, MouseEventArgs e)
        {

            dateTime.Text = DateTime.Now.ToString();
        }
    }
}