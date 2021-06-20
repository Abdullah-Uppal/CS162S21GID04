using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocietyManagementSystem {
    public partial class ComplaintsForm : UserControl {
        public static ComplaintsForm __instance = null;
        public static ComplaintsForm GetInstance()
        {
            if (__instance == null)
            {
                __instance = new ComplaintsForm();
            }
            return __instance;
        }
        public ComplaintsForm() {
            
            
            InitializeComponent();
            LoadPending();
        }
        public void LoadComplaints()
        {
            if (SolvedButton.Checked == true)
            {
                LoadSolved();
            }
            else if (PendingButton.Checked == true)
            {
                LoadPending();
            }
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void guna2Button1_Click(object sender, EventArgs e) {
            gunaLabel2.Text = "Pending";
            LoadPending();
        }
        public void LoadPending() {
            guna2DataGridView1.DataSource = Society.GetInstance().PendingComplaints;
        }
        public void LoadSolved() {
            guna2DataGridView1.DataSource = Society.GetInstance().SolvedComplaints;
        }

        private void guna2Button2_Click(object sender, EventArgs e) {
            gunaLabel2.Text = "Solved";
            //for (int i = 0; i < 10; i++) {
            //    Society.GetInstance().AddComplaint(
            //        new Complaint() {
            //            ComplainantName = "Abdullah" + i,
            //            ComplainantEmail = $"computerinsider{i}@gmail.com",
            //            Date = DateTime.Now,
            //            Status = "Pending",
            //            Name = "Water Problem",
            //            Description = "Water is not clean there and timing is very bad"
            //        }
            //        );
            //}
            LoadSolved();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void guna2Button3_Click(object sender, EventArgs e) {
            string smtpAddress = "smtp.gmail.com";
            int portNumber = 587;
            bool enableSSL = true;
            string emailFromAddress = senderEmail.Text;
            string Password = password.Text;
            string emailToAddress = receiverEmail.Text; //Receiver Email Address  
            string Subject = subject.Text;
            string Body = body.Text;
            using (MailMessage mail = new MailMessage()) {
                mail.From = new MailAddress(emailFromAddress);
                mail.To.Add(emailToAddress);
                mail.Subject = Subject;
                mail.Body = Body;
                mail.IsBodyHtml = true;
                //mail.Attachments.Add(new Attachment("D:\\TestFile.txt"));//--Uncomment this to send any attachment  
                using (SmtpClient smtp = new SmtpClient(smtpAddress, portNumber)) {
                    smtp.Credentials = new NetworkCredential(emailFromAddress, Password);
                    smtp.EnableSsl = enableSSL;
                    smtp.Send(mail);
                }
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            new AddComplaintForm().Show();
            LoadComplaints();
        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e) {
            
        }

        private void guna2DataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e) {
            MessageBox.Show(guna2DataGridView1.CurrentCell.RowIndex.ToString());
        }
    }
}
