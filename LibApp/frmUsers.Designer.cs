namespace LibApp
{
    partial class frmUsers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dvgBooks = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DOB = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboRole = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnaddUser = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Silver;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnClose.Location = new System.Drawing.Point(839, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(39, 34);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-1, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Lib App";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(881, 36);
            this.panel1.TabIndex = 38;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown_Event);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove_Event);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUp_Event);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(391, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 46);
            this.label2.TabIndex = 46;
            this.label2.Text = "Users";
            // 
            // dvgBooks
            // 
            this.dvgBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgBooks.Location = new System.Drawing.Point(7, 88);
            this.dvgBooks.Name = "dvgBooks";
            this.dvgBooks.RowTemplate.Height = 24;
            this.dvgBooks.Size = new System.Drawing.Size(864, 331);
            this.dvgBooks.TabIndex = 45;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(129, 434);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(75, 22);
            this.txtID.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 24);
            this.label1.TabIndex = 53;
            this.label1.Text = "ID :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(129, 472);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(151, 22);
            this.txtName.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 470);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 24);
            this.label4.TabIndex = 55;
            this.label4.Text = "User Name :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(129, 510);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(151, 22);
            this.txtEmail.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 508);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 24);
            this.label5.TabIndex = 57;
            this.label5.Text = "Email :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // DOB
            // 
            this.DOB.CalendarForeColor = System.Drawing.Color.Black;
            this.DOB.CalendarMonthBackground = System.Drawing.Color.White;
            this.DOB.CalendarTitleBackColor = System.Drawing.Color.DeepSkyBlue;
            this.DOB.CalendarTitleForeColor = System.Drawing.Color.White;
            this.DOB.CalendarTrailingForeColor = System.Drawing.Color.DimGray;
            this.DOB.CustomFormat = "yyyy-MM-dd";
            this.DOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DOB.Location = new System.Drawing.Point(440, 472);
            this.DOB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(168, 22);
            this.DOB.TabIndex = 60;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Silver;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(310, 470);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 24);
            this.label6.TabIndex = 59;
            this.label6.Text = "Date Of Birth :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(440, 506);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(168, 22);
            this.txtPass.TabIndex = 62;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Silver;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(341, 506);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 24);
            this.label7.TabIndex = 61;
            this.label7.Text = "Password :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cboRole
            // 
            this.cboRole.BackColor = System.Drawing.Color.Silver;
            this.cboRole.ForeColor = System.Drawing.Color.Black;
            this.cboRole.FormattingEnabled = true;
            this.cboRole.Location = new System.Drawing.Point(695, 470);
            this.cboRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboRole.Name = "cboRole";
            this.cboRole.Size = new System.Drawing.Size(176, 24);
            this.cboRole.TabIndex = 64;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Silver;
            this.label8.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(636, 470);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 24);
            this.label8.TabIndex = 63;
            this.label8.Text = "Role :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DimGray;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDelete.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(276, 551);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(111, 45);
            this.btnDelete.TabIndex = 66;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DimGray;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSearch.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(129, 551);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(111, 45);
            this.btnSearch.TabIndex = 65;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnaddUser
            // 
            this.btnaddUser.BackColor = System.Drawing.Color.DimGray;
            this.btnaddUser.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnaddUser.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddUser.ForeColor = System.Drawing.Color.White;
            this.btnaddUser.Location = new System.Drawing.Point(695, 551);
            this.btnaddUser.Name = "btnaddUser";
            this.btnaddUser.Size = new System.Drawing.Size(111, 45);
            this.btnaddUser.TabIndex = 67;
            this.btnaddUser.Text = "Add Users";
            this.btnaddUser.UseVisualStyleBackColor = false;
            this.btnaddUser.Click += new System.EventHandler(this.btnaddUser_Click);
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(881, 608);
            this.Controls.Add(this.btnaddUser);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cboRole);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DOB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dvgBooks);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUsers";
            this.Load += new System.EventHandler(this.frmUsers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dvgBooks;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DOB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboRole;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnaddUser;
    }
}