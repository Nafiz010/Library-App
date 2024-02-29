using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibApp
{
    public partial class frmAdminPanel : Form
    {
        bool mouseDown;
        private Point offset;
        public frmAdminPanel()
        {
            InitializeComponent();
        }

        private void frmAdminPanel_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "../../Resources/books-open-on-table.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            lblUN.Text = "Welcome, " + clsUser.userName.Substring(0, 1).ToUpper() + clsUser.userName.Substring(1).ToLower();
            lblUT.Text = clsUser.userRole;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            frmLogin lg = new frmLogin();
            lg.ShowDialog();
        }

        private void mouseDown_Event(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void mouseMove_Event(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void mouseUp_Event(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin lg = new frmLogin();
            lg.ShowDialog();
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBooks bk = new frmBooks();
            bk.ShowDialog();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUsers us = new frmUsers();
            us.ShowDialog();
        }

        private void btnBBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBurrowedBooks BB = new frmBurrowedBooks();
            BB.ShowDialog();
        }

        private void btnGenre_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGenre ge = new frmGenre();
            ge.ShowDialog();
        }
    }
}
