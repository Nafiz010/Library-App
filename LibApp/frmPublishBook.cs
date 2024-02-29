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
    public partial class frmPublishBook : Form
    {
        DatabaseLibEntities db;
        StringBuilder errors;
        bool mouseDown;
        private Point offset;
        public frmPublishBook()
        {
            InitializeComponent();
        }

        private void frmPublishBook_Load(object sender, EventArgs e)
        {
            db = new DatabaseLibEntities();
            errors = new StringBuilder();
            var bookGenre = db.Categories.Select(d => new { d.Id, d.Book_Genre }).ToList();
            cboGenre.DataSource = bookGenre;
            cboGenre.DisplayMember = "Book_Genre";
            cboGenre.ValueMember = "Id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            frmPublisherPanel pp = new frmPublisherPanel();
            pp.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            frmPublisherPanel pp = new frmPublisherPanel();
            pp.ShowDialog();
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                errors.AppendLine("Book Name cannot be blank");

            }

            if (txtpubName.Text == "")
            {
                errors.AppendLine("Publisher Name cannot be blank");
            }


            //Show error message
            if (errors.ToString() != string.Empty)
            {
                MessageBox.Show(errors.ToString(), "Validation failed !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Book bk = new Book();
            bk.Name = txtName.Text;
            bk.Publisher_Name = txtpubName.Text;
            bk.Release_Date = dtRD.Value;
            bk.Genre = Int32.Parse(cboGenre.SelectedValue.ToString());


            db.Books.Add(bk);
            db.SaveChanges();

            MessageBox.Show("Book Added Successfully !!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmPublisherPanel pp = new frmPublisherPanel();
            this.Hide();
            pp.ShowDialog();
        }
    }
}
