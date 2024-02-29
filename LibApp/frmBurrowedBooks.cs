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
    public partial class frmBurrowedBooks : Form
    {
        DatabaseLibEntities db;
        bool mouseDown;
        private Point offset;
        public frmBurrowedBooks()
        {
            InitializeComponent();
        }

        private void frmBurrowedBooks_Load(object sender, EventArgs e)
        {
            db = new DatabaseLibEntities();
            var data = db.Burrows.Select(d => new { Username = d.User.Name, BookName = d.Book.Name, LendDate = d.Lend_Date, ReturnDate = d.Return_Date }).ToList();
            dvgBooks.DataSource = data;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdminPanel AP = new frmAdminPanel();
            AP.ShowDialog();
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
    }
}
