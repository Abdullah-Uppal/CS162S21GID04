﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocietyManagementSystem {
    public partial class ComplaintsForm : UserControl {
        public ComplaintsForm() {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e) {
            gunaLabel2.Text = "Pending";
        }

        private void guna2Button2_Click(object sender, EventArgs e) {
            gunaLabel2.Text = "Solved";
        }
    }
}
