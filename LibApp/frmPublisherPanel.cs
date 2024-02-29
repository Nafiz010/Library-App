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
    public partial class frmPublisherPanel : Form
    {
        DatabaseLibEntities db;
        bool mouseDown;
        private Point offset;
        public frmPublisherPanel()
        {
            InitializeComponent();
        }

        private void frmPublisherPanel_Load(object sender, EventArgs e)
        {
            db = new DatabaseLibEntities();
            var data = db.Books.Select(d => new { d.Id, d.Name, d.Publisher_Name, d.Release_Date }).ToList();
            dvgBooks.DataSource = data;
            lblUN.Text = "Welcome, " + clsUser.userName.Substring(0, 1).ToUpper() + clsUser.userName.Substring(1).ToLower();
            lblUT.Text = clsUser.userRole;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            frmLogin lg = new frmLogin();
            lg.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            frmLogin lg = new frmLogin();
            lg.ShowDialog();
        }

        private void mouseMove_Event(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void mouseDown_Event(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void mouseUp_Event(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void btnPublishBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPublishBook pb = new frmPublishBook();
            pb.ShowDialog();
        }
    }
}
