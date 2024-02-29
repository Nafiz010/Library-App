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
    public partial class frmGenre : Form
    {
        DatabaseLibEntities db;
        StringBuilder errors;
        public frmGenre()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdminPanel AP = new frmAdminPanel();
            AP.ShowDialog();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                errors.AppendLine("Genre type cannot be blank");

            }

            if (errors.ToString() != string.Empty)
            {
                MessageBox.Show(errors.ToString(), "Validation failed !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Category ct = new Category();
            ct.Book_Genre = txtName.Text;

            db.Categories.Add(ct);
            db.SaveChanges();

            MessageBox.Show("Genre Added Successfully !!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmAdminPanel ap = new frmAdminPanel();
            this.Hide();
            ap.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdminPanel AP = new frmAdminPanel();
            AP.ShowDialog();
        }

        private void frmGenre_Load(object sender, EventArgs e)
        {
            db = new DatabaseLibEntities();
            errors = new StringBuilder();
        }
    }
}
