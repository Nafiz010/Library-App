namespace LibApp
{
    partial class frmPublisherPanel
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
            this.label2 = new System.Windows.Forms.Label();
            this.dvgBooks = new System.Windows.Forms.DataGridView();
            this.btnPublishBook = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblUT = new System.Windows.Forms.Label();
            this.lblUN = new System.Windows.Forms.Label();
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
            this.btnClose.Location = new System.Drawing.Point(602, 2);
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
            this.panel1.Size = new System.Drawing.Size(641, 36);
            this.panel1.TabIndex = 45;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(257, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 57);
            this.label2.TabIndex = 51;
            this.label2.Text = "Books";
            // 
            // dvgBooks
            // 
            this.dvgBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgBooks.Location = new System.Drawing.Point(5, 89);
            this.dvgBooks.Name = "dvgBooks";
            this.dvgBooks.RowTemplate.Height = 24;
            this.dvgBooks.Size = new System.Drawing.Size(627, 298);
            this.dvgBooks.TabIndex = 50;
            // 
            // btnPublishBook
            // 
            this.btnPublishBook.BackColor = System.Drawing.Color.DimGray;
            this.btnPublishBook.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPublishBook.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPublishBook.ForeColor = System.Drawing.Color.White;
            this.btnPublishBook.Location = new System.Drawing.Point(442, 428);
            this.btnPublishBook.Name = "btnPublishBook";
            this.btnPublishBook.Size = new System.Drawing.Size(190, 49);
            this.btnPublishBook.TabIndex = 49;
            this.btnPublishBook.Text = "Publish Book";
            this.btnPublishBook.UseVisualStyleBackColor = false;
            this.btnPublishBook.Click += new System.EventHandler(this.btnPublishBook_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.DimGray;
            this.btnLogout.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLogout.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(442, 505);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(190, 49);
            this.btnLogout.TabIndex = 48;
            this.btnLogout.Text = "LOGOUT ";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblUT
            // 
            this.lblUT.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblUT.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUT.Location = new System.Drawing.Point(12, 527);
            this.lblUT.Name = "lblUT";
            this.lblUT.Size = new System.Drawing.Size(190, 29);
            this.lblUT.TabIndex = 46;
            this.lblUT.Text = "Admin";
            this.lblUT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUN
            // 
            this.lblUN.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblUN.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUN.Location = new System.Drawing.Point(12, 488);
            this.lblUN.Name = "lblUN";
            this.lblUN.Size = new System.Drawing.Size(190, 29);
            this.lblUN.TabIndex = 47;
            this.lblUN.Text = "Welcome, Admin";
            this.lblUN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmPublisherPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(641, 569);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dvgBooks);
            this.Controls.Add(this.btnPublishBook);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblUT);
            this.Controls.Add(this.lblUN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPublisherPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPublisherPanel";
            this.Load += new System.EventHandler(this.frmPublisherPanel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dvgBooks;
        private System.Windows.Forms.Button btnPublishBook;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblUT;
        private System.Windows.Forms.Label lblUN;
    }
}