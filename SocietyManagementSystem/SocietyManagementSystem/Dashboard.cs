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
using System.Threading;

namespace SocietyManagementSystem {
    public partial class Dashboard : UserControl {
        public Dashboard() {
            InitializeComponent();
            LoadChart();
            guna2CircleProgressBar1.Value = int.Parse(GetCharge());
            Thread t = new Thread(delegate () {
                while (true) {
                    Thread.Sleep(10000);
                    guna2CircleProgressBar1.Value = int.Parse(GetCharge());
                }
            });
            t.Start();
            this.Disposed += delegate (object sender, EventArgs e) {
                t.Abort();
            };
            
            this.VisibleChanged += delegate (object sender, EventArgs e) {
                string quote = "Total No. of Donations: " + Society.GetInstance().Donate.Count;
                totalDonations.Text = quote;
                string totalAmountQuote = "Total Amount: Rs.";
                double totalDonation = 0;
                Society.GetInstance().Donate.ForEach(x => {
                    totalDonation += x.Amount;
                });
                totalAmount.Text = totalAmountQuote + totalDonation;
                this.chairmanName.Text = Society.GetInstance().Chairperson.Name;
            };
        }
        private static string GetCharge() {
            string perc = null;
            ManagementObjectSearcher mos = new ManagementObjectSearcher("select * from Win32_Battery");
            foreach (ManagementObject mo in mos.Get()) {
                perc = mo["EstimatedChargeRemaining"].ToString();
            }
            return perc;
        }

        private void gunaLabel2_Click(object sender, EventArgs e) {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e) {

        }
        private void LoadChart() {
            chart1.Series["Buildings"].Points.AddXY("Homes", "377");
            chart1.Series["Buildings"].Points.AddXY("Hospitals", "10");
            chart1.Series["Buildings"].Points.AddXY("Schools", "25");
            chart1.Titles.Add("Buildings");
        }

        private void gunaImageButton1_Click(object sender, EventArgs e) {

        }
    }
}
