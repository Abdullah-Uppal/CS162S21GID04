﻿
namespace SocietyManagementSystem {
    partial class ComplaintsForm {
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
            this.PendingButton = new Guna.UI2.WinForms.Guna2Button();
            this.SolvedButton = new Guna.UI2.WinForms.Guna2Button();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.senderEmail = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.password = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.receiverEmail = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.subject = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.body = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // PendingButton
            // 
            this.PendingButton.Animated = true;
            this.PendingButton.BackColor = System.Drawing.Color.Transparent;
            this.PendingButton.BorderRadius = 10;
            this.PendingButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.PendingButton.Checked = true;
            this.PendingButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(43)))), ((int)(((byte)(93)))));
            this.PendingButton.CheckedState.ForeColor = System.Drawing.Color.White;
            this.PendingButton.CheckedState.Parent = this.PendingButton;
            this.PendingButton.CustomImages.Parent = this.PendingButton;
            this.PendingButton.FillColor = System.Drawing.Color.White;
            this.PendingButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PendingButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(43)))), ((int)(((byte)(93)))));
            this.PendingButton.HoverState.Parent = this.PendingButton;
            this.PendingButton.Location = new System.Drawing.Point(23, 19);
            this.PendingButton.Name = "PendingButton";
            this.PendingButton.ShadowDecoration.Parent = this.PendingButton;
            this.PendingButton.Size = new System.Drawing.Size(133, 40);
            this.PendingButton.TabIndex = 2;
            this.PendingButton.Text = "Pending";
            this.PendingButton.UseTransparentBackground = true;
            this.PendingButton.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // SolvedButton
            // 
            this.SolvedButton.Animated = true;
            this.SolvedButton.BackColor = System.Drawing.Color.Transparent;
            this.SolvedButton.BorderRadius = 10;
            this.SolvedButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.SolvedButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(43)))), ((int)(((byte)(93)))));
            this.SolvedButton.CheckedState.ForeColor = System.Drawing.Color.White;
            this.SolvedButton.CheckedState.Parent = this.SolvedButton;
            this.SolvedButton.CustomImages.Parent = this.SolvedButton;
            this.SolvedButton.FillColor = System.Drawing.Color.White;
            this.SolvedButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SolvedButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(43)))), ((int)(((byte)(93)))));
            this.SolvedButton.HoverState.Parent = this.SolvedButton;
            this.SolvedButton.Location = new System.Drawing.Point(173, 19);
            this.SolvedButton.Name = "SolvedButton";
            this.SolvedButton.ShadowDecoration.Parent = this.SolvedButton;
            this.SolvedButton.Size = new System.Drawing.Size(133, 40);
            this.SolvedButton.TabIndex = 2;
            this.SolvedButton.Text = "Solved";
            this.SolvedButton.UseTransparentBackground = true;
            this.SolvedButton.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(759, 35);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(81, 24);
            this.gunaLabel2.TabIndex = 4;
            this.gunaLabel2.Text = "Pending";
            this.gunaLabel2.Click += new System.EventHandler(this.gunaLabel2_Click);
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToAddRows = false;
            this.guna2DataGridView1.AllowUserToDeleteRows = false;
            this.guna2DataGridView1.AllowUserToResizeColumns = false;
            this.guna2DataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 21;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.guna2DataGridView1.EnableHeadersVisualStyles = false;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(23, 69);
            this.guna2DataGridView1.MultiSelect = false;
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.guna2DataGridView1.Size = new System.Drawing.Size(846, 363);
            this.guna2DataGridView1.TabIndex = 5;
            this.guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Light;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 21;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.guna2DataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellClick);
            this.guna2DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
            this.guna2DataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentDoubleClick);
            this.guna2DataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellDoubleClick);
            this.guna2DataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.guna2DataGridView1_CellMouseDoubleClick);
            this.guna2DataGridView1.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.guna2DataGridView1_RowStateChanged);
            this.guna2DataGridView1.Click += new System.EventHandler(this.guna2DataGridView1_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(39, 435);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(165, 15);
            this.gunaLabel1.TabIndex = 6;
            this.gunaLabel1.Text = "Give Response to a Complaint";
            // 
            // senderEmail
            // 
            this.senderEmail.BackColor = System.Drawing.Color.White;
            this.senderEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.senderEmail.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.senderEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.senderEmail.LineColor = System.Drawing.Color.Gainsboro;
            this.senderEmail.Location = new System.Drawing.Point(143, 463);
            this.senderEmail.Name = "senderEmail";
            this.senderEmail.PasswordChar = '\0';
            this.senderEmail.SelectedText = "";
            this.senderEmail.Size = new System.Drawing.Size(244, 26);
            this.senderEmail.TabIndex = 7;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(42, 468);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(83, 21);
            this.gunaLabel3.TabIndex = 8;
            this.gunaLabel3.Text = "Email (Sender)";
            this.gunaLabel3.UseCompatibleTextRendering = true;
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.White;
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.password.LineColor = System.Drawing.Color.Gainsboro;
            this.password.Location = new System.Drawing.Point(143, 505);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.SelectedText = "";
            this.password.Size = new System.Drawing.Size(244, 26);
            this.password.TabIndex = 9;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel5.Location = new System.Drawing.Point(42, 510);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(56, 21);
            this.gunaLabel5.TabIndex = 10;
            this.gunaLabel5.Text = "Password";
            this.gunaLabel5.UseCompatibleTextRendering = true;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.Location = new System.Drawing.Point(42, 552);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(90, 21);
            this.gunaLabel4.TabIndex = 12;
            this.gunaLabel4.Text = "Email (Receiver)";
            this.gunaLabel4.UseCompatibleTextRendering = true;
            // 
            // receiverEmail
            // 
            this.receiverEmail.BackColor = System.Drawing.Color.White;
            this.receiverEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.receiverEmail.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.receiverEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.receiverEmail.LineColor = System.Drawing.Color.Gainsboro;
            this.receiverEmail.Location = new System.Drawing.Point(143, 547);
            this.receiverEmail.Name = "receiverEmail";
            this.receiverEmail.PasswordChar = '\0';
            this.receiverEmail.SelectedText = "";
            this.receiverEmail.Size = new System.Drawing.Size(244, 26);
            this.receiverEmail.TabIndex = 11;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel6.Location = new System.Drawing.Point(428, 473);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(45, 21);
            this.gunaLabel6.TabIndex = 14;
            this.gunaLabel6.Text = "Subject";
            this.gunaLabel6.UseCompatibleTextRendering = true;
            // 
            // subject
            // 
            this.subject.BackColor = System.Drawing.Color.White;
            this.subject.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.subject.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.subject.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.subject.LineColor = System.Drawing.Color.Gainsboro;
            this.subject.Location = new System.Drawing.Point(529, 468);
            this.subject.Name = "subject";
            this.subject.PasswordChar = '\0';
            this.subject.SelectedText = "";
            this.subject.Size = new System.Drawing.Size(244, 26);
            this.subject.TabIndex = 13;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel7.Location = new System.Drawing.Point(428, 510);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(32, 21);
            this.gunaLabel7.TabIndex = 14;
            this.gunaLabel7.Text = "Body";
            this.gunaLabel7.UseCompatibleTextRendering = true;
            // 
            // body
            // 
            this.body.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.body.DefaultText = "";
            this.body.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.body.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.body.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.body.DisabledState.Parent = this.body;
            this.body.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.body.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.body.FocusedState.Parent = this.body;
            this.body.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.body.HoverState.Parent = this.body;
            this.body.Location = new System.Drawing.Point(529, 510);
            this.body.Name = "body";
            this.body.PasswordChar = '\0';
            this.body.PlaceholderText = "";
            this.body.SelectedText = "";
            this.body.ShadowDecoration.Parent = this.body;
            this.body.Size = new System.Drawing.Size(244, 101);
            this.body.TabIndex = 15;
            // 
            // guna2Button3
            // 
            this.guna2Button3.Animated = true;
            this.guna2Button3.AutoRoundedCorners = true;
            this.guna2Button3.BorderRadius = 17;
            this.guna2Button3.CheckedState.Parent = this.guna2Button3;
            this.guna2Button3.CustomImages.Parent = this.guna2Button3;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.HoverState.Parent = this.guna2Button3;
            this.guna2Button3.Location = new System.Drawing.Point(763, 617);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.Size = new System.Drawing.Size(106, 36);
            this.guna2Button3.TabIndex = 16;
            this.guna2Button3.Text = "Send";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // guna2Button4
            // 
            this.guna2Button4.BorderRadius = 10;
            this.guna2Button4.CheckedState.Parent = this.guna2Button4;
            this.guna2Button4.CustomImages.Parent = this.guna2Button4;
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.HoverState.Parent = this.guna2Button4;
            this.guna2Button4.Location = new System.Drawing.Point(312, 19);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.ShadowDecoration.Parent = this.guna2Button4;
            this.guna2Button4.Size = new System.Drawing.Size(133, 40);
            this.guna2Button4.TabIndex = 17;
            this.guna2Button4.Text = "Add Complaint";
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // ComplaintsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2Button4);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.body);
            this.Controls.Add(this.gunaLabel7);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.subject);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.receiverEmail);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.password);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.senderEmail);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.SolvedButton);
            this.Controls.Add(this.PendingButton);
            this.Name = "ComplaintsForm";
            this.Size = new System.Drawing.Size(892, 661);
            this.Enter += new System.EventHandler(this.ComplaintsForm_Enter);
            this.MouseEnter += new System.EventHandler(this.ComplaintsForm_MouseEnter);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button PendingButton;
        private Guna.UI2.WinForms.Guna2Button SolvedButton;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLineTextBox senderEmail;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLineTextBox password;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLineTextBox receiverEmail;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLineTextBox subject;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI2.WinForms.Guna2TextBox body;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
    }
}
