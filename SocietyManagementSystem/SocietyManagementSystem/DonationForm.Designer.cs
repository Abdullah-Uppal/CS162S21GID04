
namespace SocietyManagementSystem {
    partial class DonationForm {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.NameBox = new Guna.UI.WinForms.GunaLineTextBox();
            this.EmailBox = new Guna.UI.WinForms.GunaLineTextBox();
            this.PhoneBox = new Guna.UI.WinForms.GunaLineTextBox();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.AmountBox = new Guna.UI.WinForms.GunaLineTextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CNICBox = new Guna.UI.WinForms.GunaLineTextBox();
            this.CNIC = new Guna.UI.WinForms.GunaLabel();
            this.Male = new Guna.UI2.WinForms.Guna2RadioButton();
            this.Female = new Guna.UI2.WinForms.Guna2RadioButton();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(78, 84);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(39, 15);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Name";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(78, 198);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(88, 15);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "Phone Number";
            this.gunaLabel2.Click += new System.EventHandler(this.gunaLabel2_Click);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(78, 140);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(81, 15);
            this.gunaLabel3.TabIndex = 1;
            this.gunaLabel3.Text = "Email Address";
            // 
            // NameBox
            // 
            this.NameBox.BackColor = System.Drawing.Color.White;
            this.NameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameBox.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.NameBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NameBox.LineColor = System.Drawing.Color.Gainsboro;
            this.NameBox.Location = new System.Drawing.Point(217, 84);
            this.NameBox.Name = "NameBox";
            this.NameBox.PasswordChar = '\0';
            this.NameBox.SelectedText = "";
            this.NameBox.Size = new System.Drawing.Size(243, 26);
            this.NameBox.TabIndex = 2;
            // 
            // EmailBox
            // 
            this.EmailBox.BackColor = System.Drawing.Color.White;
            this.EmailBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailBox.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.EmailBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EmailBox.LineColor = System.Drawing.Color.Gainsboro;
            this.EmailBox.Location = new System.Drawing.Point(217, 140);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.PasswordChar = '\0';
            this.EmailBox.SelectedText = "";
            this.EmailBox.Size = new System.Drawing.Size(243, 26);
            this.EmailBox.TabIndex = 2;
            // 
            // PhoneBox
            // 
            this.PhoneBox.BackColor = System.Drawing.Color.White;
            this.PhoneBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PhoneBox.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.PhoneBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PhoneBox.LineColor = System.Drawing.Color.Gainsboro;
            this.PhoneBox.Location = new System.Drawing.Point(217, 198);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.PasswordChar = '\0';
            this.PhoneBox.SelectedText = "";
            this.PhoneBox.Size = new System.Drawing.Size(243, 26);
            this.PhoneBox.TabIndex = 2;
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 21;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.EnableHeadersVisualStyles = false;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(0, 508);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridView1.Size = new System.Drawing.Size(889, 150);
            this.guna2DataGridView1.TabIndex = 4;
            this.guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 21;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 471);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Search";
            // 
            // SearchBox
            // 
            this.SearchBox.BackColor = System.Drawing.Color.White;
            this.SearchBox.BorderRadius = 10;
            this.SearchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchBox.DefaultText = "";
            this.SearchBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SearchBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SearchBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchBox.DisabledState.Parent = this.SearchBox;
            this.SearchBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchBox.FillColor = System.Drawing.Color.Gainsboro;
            this.SearchBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchBox.FocusedState.Parent = this.SearchBox;
            this.SearchBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchBox.HoverState.Parent = this.SearchBox;
            this.SearchBox.Location = new System.Drawing.Point(116, 471);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.PasswordChar = '\0';
            this.SearchBox.PlaceholderText = "";
            this.SearchBox.SelectedText = "";
            this.SearchBox.ShadowDecoration.Parent = this.SearchBox;
            this.SearchBox.Size = new System.Drawing.Size(206, 31);
            this.SearchBox.TabIndex = 6;
            this.SearchBox.Enter += new System.EventHandler(this.SearchBox_Enter);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.Location = new System.Drawing.Point(78, 267);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(51, 15);
            this.gunaLabel4.TabIndex = 8;
            this.gunaLabel4.Text = "Amount";
            this.gunaLabel4.Click += new System.EventHandler(this.gunaLabel4_Click);
            // 
            // AmountBox
            // 
            this.AmountBox.BackColor = System.Drawing.Color.White;
            this.AmountBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AmountBox.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.AmountBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AmountBox.LineColor = System.Drawing.Color.Gainsboro;
            this.AmountBox.Location = new System.Drawing.Point(217, 267);
            this.AmountBox.Name = "AmountBox";
            this.AmountBox.PasswordChar = '\0';
            this.AmountBox.SelectedText = "";
            this.AmountBox.Size = new System.Drawing.Size(243, 26);
            this.AmountBox.TabIndex = 9;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(629, 198);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 10;
            this.guna2Button1.Text = "Donate";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Are you registered?";
            // 
            // CNICBox
            // 
            this.CNICBox.BackColor = System.Drawing.Color.White;
            this.CNICBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CNICBox.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CNICBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CNICBox.LineColor = System.Drawing.Color.Gainsboro;
            this.CNICBox.Location = new System.Drawing.Point(629, 84);
            this.CNICBox.Name = "CNICBox";
            this.CNICBox.PasswordChar = '\0';
            this.CNICBox.SelectedText = "";
            this.CNICBox.Size = new System.Drawing.Size(243, 26);
            this.CNICBox.TabIndex = 12;
            // 
            // CNIC
            // 
            this.CNIC.AutoSize = true;
            this.CNIC.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CNIC.Location = new System.Drawing.Point(548, 95);
            this.CNIC.Name = "CNIC";
            this.CNIC.Size = new System.Drawing.Size(35, 15);
            this.CNIC.TabIndex = 13;
            this.CNIC.Text = "CNIC";
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Male.CheckedState.BorderThickness = 0;
            this.Male.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Male.CheckedState.InnerColor = System.Drawing.Color.White;
            this.Male.CheckedState.InnerOffset = -4;
            this.Male.Location = new System.Drawing.Point(637, 140);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(48, 17);
            this.Male.TabIndex = 14;
            this.Male.TabStop = true;
            this.Male.Text = "Male";
            this.Male.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Male.UncheckedState.BorderThickness = 2;
            this.Male.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.Male.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.Male.UseVisualStyleBackColor = true;
            // 
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Female.CheckedState.BorderThickness = 0;
            this.Female.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Female.CheckedState.InnerColor = System.Drawing.Color.White;
            this.Female.CheckedState.InnerOffset = -4;
            this.Female.Location = new System.Drawing.Point(763, 140);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(59, 17);
            this.Female.TabIndex = 15;
            this.Female.TabStop = true;
            this.Female.Text = "Female";
            this.Female.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Female.UncheckedState.BorderThickness = 2;
            this.Female.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.Female.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.Female.UseVisualStyleBackColor = true;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel5.Location = new System.Drawing.Point(548, 142);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(45, 15);
            this.gunaLabel5.TabIndex = 16;
            this.gunaLabel5.Text = "Gender";
            // 
            // DonationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.Female);
            this.Controls.Add(this.Male);
            this.Controls.Add(this.CNIC);
            this.Controls.Add(this.CNICBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.AmountBox);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.PhoneBox);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Name = "DonationForm";
            this.Size = new System.Drawing.Size(892, 661);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLineTextBox NameBox;
        private Guna.UI.WinForms.GunaLineTextBox EmailBox;
        private Guna.UI.WinForms.GunaLineTextBox PhoneBox;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox SearchBox;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLineTextBox AmountBox;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaLineTextBox CNICBox;
        private Guna.UI.WinForms.GunaLabel CNIC;
        private Guna.UI2.WinForms.Guna2RadioButton Male;
        private Guna.UI2.WinForms.Guna2RadioButton Female;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
    }
}
