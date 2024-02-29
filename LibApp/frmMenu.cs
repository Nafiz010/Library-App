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
    public partial class frmMenu : Form
    {
        int bookid = 0;
        DatabaseLibEntities db;
        bool mouseDown;
        private Point offset;
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            db = new DatabaseLibEntities();
            var data = db.Books.Select(d => new { d.Id, d.Name, d.Publisher_Name, d.Release_Date }).ToList();
            dvgBooks.DataSource = data;
            lblUN.Text = "Welcome, " + clsUser.userName.Substring(0, 1).ToUpper() + clsUser.userName.Substring(1).ToLower();
            lblUT.Text = clsUser.userRole;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            frmLogin lg = new frmLogin();
            lg.ShowDialog();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            if (bookid != 0)
            {
                Burrow br = new Burrow();
                br.userId = clsUser.userid;
                br.bookId = bookid;
                br.Lend_Date = DateTime.Now;
                br.Return_Date = DateTime.Now.AddDays(7);

                db.Burrows.Add(br);
                db.SaveChanges();
                MessageBox.Show("Book successfully borrowed !!");
            }

            else
            {
                MessageBox.Show("Please select a book !!");
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin lg = new frmLogin();
            this.Hide();
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

        private void dvgBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //bookid = Int32.Parse(dvgBooks.Rows[e.RowIndex].Cells[0].Value.ToString());
            //MessageBox.Show(bookid.ToString());
        }

        private void dvgBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bookid = Int32.Parse(dvgBooks.Rows[e.RowIndex].Cells[0].Value.ToString());
        }
    }
}
