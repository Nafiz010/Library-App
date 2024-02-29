namespace LibApp
{
    partial class frmAdminPanel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblUT = new System.Windows.Forms.Label();
            this.lblUN = new System.Windows.Forms.Label();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnBooks = new System.Windows.Forms.Button();
            this.btnBBooks = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenre = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Silver;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnClose.Location = new System.Drawing.Point(794, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(39, 34);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 36);
            this.panel1.TabIndex = 38;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown_Event);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove_Event);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUp_Event);
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
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.DimGray;
            this.btnLogout.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLogout.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(4, 473);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(190, 49);
            this.btnLogout.TabIndex = 43;
            this.btnLogout.Text = "LOGOUT ";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblUT
            // 
            this.lblUT.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblUT.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUT.Location = new System.Drawing.Point(4, 438);
            this.lblUT.Name = "lblUT";
            this.lblUT.Size = new System.Drawing.Size(190, 29);
            this.lblUT.TabIndex = 41;
            this.lblUT.Text = "Admin";
            this.lblUT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUN
            // 
            this.lblUN.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblUN.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUN.Location = new System.Drawing.Point(4, 399);
            this.lblUN.Name = "lblUN";
            this.lblUN.Size = new System.Drawing.Size(190, 29);
            this.lblUN.TabIndex = 42;
            this.lblUN.Text = "Welcome, Admin";
            this.lblUN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.DimGray;
            this.btnUsers.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnUsers.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.Location = new System.Drawing.Point(4, 42);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(190, 49);
            this.btnUsers.TabIndex = 44;
            this.btnUsers.Text = "Users";
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnBooks
            // 
            this.btnBooks.BackColor = System.Drawing.Color.DimGray;
            this.btnBooks.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBooks.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBooks.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooks.ForeColor = System.Drawing.Color.White;
            this.btnBooks.Location = new System.Drawing.Point(4, 122);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Size = new System.Drawing.Size(190, 49);
            this.btnBooks.TabIndex = 45;
            this.btnBooks.Text = "Books";
            this.btnBooks.UseVisualStyleBackColor = false;
            this.btnBooks.Click += new System.EventHandler(this.btnBooks_Click);
            // 
            // btnBBooks
            // 
            this.btnBBooks.BackColor = System.Drawing.Color.DimGray;
            this.btnBBooks.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBBooks.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBBooks.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBBooks.ForeColor = System.Drawing.Color.White;
            this.btnBBooks.Location = new System.Drawing.Point(4, 290);
            this.btnBBooks.Name = "btnBBooks";
            this.btnBBooks.Size = new System.Drawing.Size(190, 49);
            this.btnBBooks.TabIndex = 46;
            this.btnBBooks.Text = "Borrowed Books";
            this.btnBBooks.UseVisualStyleBackColor = false;
            this.btnBBooks.Click += new System.EventHandler(this.btnBBooks_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(214, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(606, 425);
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(588, 484);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 28);
            this.label1.TabIndex = 48;
            this.label1.Text = "Powered By Nafiz Hasan";
            // 
            // btnGenre
            // 
            this.btnGenre.BackColor = System.Drawing.Color.DimGray;
            this.btnGenre.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGenre.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGenre.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenre.ForeColor = System.Drawing.Color.White;
            this.btnGenre.Location = new System.Drawing.Point(4, 205);
            this.btnGenre.Name = "btnGenre";
            this.btnGenre.Size = new System.Drawing.Size(190, 49);
            this.btnGenre.TabIndex = 49;
            this.btnGenre.Text = "Add Genre";
            this.btnGenre.UseVisualStyleBackColor = false;
            this.btnGenre.Click += new System.EventHandler(this.btnGenre_Click);
            // 
            // frmAdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(832, 534);
            this.Controls.Add(this.btnGenre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBBooks);
            this.Controls.Add(this.btnBooks);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblUT);
            this.Controls.Add(this.lblUN);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdminPanel";
            this.Load += new System.EventHandler(this.frmAdminPanel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblUT;
        private System.Windows.Forms.Label lblUN;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnBooks;
        private System.Windows.Forms.Button btnBBooks;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenre;
    }
}