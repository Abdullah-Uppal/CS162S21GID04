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
    public partial class PopUpMenu : Form {
        int index;
        bool pending;
        public PopUpMenu(int i, bool p) {
            InitializeComponent();
            guna2ShadowForm1.SetShadowForm(this);
            index = i;
            this.Focus();
            pending = p;
        }

        private void deleteButton_Click(object sender, EventArgs e) {
            MessageBox.Show(sender.GetType().ToString());
            try {
                if (pending) {
                    Society s = Society.GetInstance();
                    s.Complaints.Remove(s.PendingComplaints[index]);
                }
                else {
                    Society s = Society.GetInstance();
                    s.Complaints.Remove(s.SolvedComplaints[index]);
                }
                ComplaintsForm.GetInstance().LoadComplaints();
            }
            catch {

            }
        }
    }
}
