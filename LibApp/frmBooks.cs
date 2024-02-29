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
    public partial class frmBooks : Form
    {
        DatabaseLibEntities db;
        bool mouseDown;
        private Point offset;
        public frmBooks()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdminPanel AP = new frmAdminPanel();
            AP.ShowDialog();
        }

        private void frmBooks_Load(object sender, EventArgs e)
        {
            db = new DatabaseLibEntities();
            var data = db.Books.Select(d => new { d.Id, d.Name, PublisherName = d.Publisher_Name, ReleasedDate = d.Release_Date, Genre = d.Category.Book_Genre }).ToList();
            dvgBooks.DataSource = data;
            var genre = db.Categories.ToList();
            cboGenre.DataSource = genre;
            cboGenre.DisplayMember = "Book_Genre";
            cboGenre.ValueMember = "Id";
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

       

        private void btnaddBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmaddBook adbook = new frmaddBook();
            adbook.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtID.Text);
            var data = db.Books.Where(d => d.Id == id).FirstOrDefault();

            if (data != null)
            {
                txtName.Text = data.Name;
                txtpubName.Text = data.Publisher_Name;
                dtRD.Value = data.Release_Date.Value;
                cboGenre.SelectedValue = data.Genre;

            }
            else
            {
                txtName.Text = "";
                txtpubName.Text = "";
                MessageBox.Show("Data not found", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtID.Text);
            var data = db.Books.Where(d => d.Id == id).FirstOrDefault();

            if (data != null)
            {
                data.Name = txtName.Text;
                data.Publisher_Name = txtpubName.Text;
                data.Release_Date = dtRD.Value;
                data.Genre = Int32.Parse(cboGenre.SelectedValue.ToString());


                db.SaveChanges();
                var dgv = db.Books.Select(d => new { Id = d.Id, Name = d.Name, PublisherName = d.Publisher_Name, ReleasedDate = d.Release_Date, Genre = d.Category.Book_Genre }).ToList();
                dvgBooks.DataSource = dgv;
                MessageBox.Show("Data updated successfully", "Updated !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                txtName.Text = "";
                txtpubName.Text = "";
                MessageBox.Show("Data not found", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtID.Text);
            var data = db.Books.Where(d => d.Id == id).FirstOrDefault();

            if (data != null)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete ?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {

                    db.Books.Remove(data);

                    db.SaveChanges();

                    txtName.Text = "";
                    txtpubName.Text = "";
                    dtRD.Text = "";
                    cboGenre.Text = "";
                    var dgv = db.Books.Select(d => new { Id = d.Id, Name = d.Name, PublisherName = d.Publisher_Name, ReleasedDate = d.Release_Date, Genre = d.Category.Book_Genre }).ToList();
                    dvgBooks.DataSource = dgv;
                    MessageBox.Show("Data deleted successfully", "Deleted !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                txtName.Text = "";
                txtpubName.Text = "";
                dtRD.Text = "";
                cboGenre.Text = "";
                MessageBox.Show("Data not found", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
