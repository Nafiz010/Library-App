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
    public partial class frmUsers : Form
    {
        DatabaseLibEntities db;
        StringBuilder errors;
        bool mouseDown;
        private Point offset;
        public frmUsers()
        {
            InitializeComponent();
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            db = new DatabaseLibEntities();
            errors = new StringBuilder();
            var data = db.Users.Select(d => new { d.Id, d.Name, d.Email, d.Password, d.DOB, Role = d.Role.UserType }).ToList();
            dvgBooks.DataSource = data;
            var role = db.Roles.ToList();
            cboRole.DataSource = role;
            cboRole.DisplayMember = "UserType";
            cboRole.ValueMember = "Id";
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtID.Text);
            var data = db.Users.Where(d => d.Id == id).FirstOrDefault();

            if (data != null)
            {
                txtName.Text = data.Name;
                txtEmail.Text = data.Email;
                txtPass.Text = data.Password;
                DOB.Value = data.DOB.Value;
                cboRole.SelectedValue = data.roleId;

            }
            else
            {
                txtName.Text = "";
                txtEmail.Text = "";
                txtPass.Text = "";
                MessageBox.Show("Data not found", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtID.Text);
            var data = db.Users.Where(d => d.Id == id).FirstOrDefault();

            if (data != null)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete ?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {

                    db.Users.Remove(data);

                    db.SaveChanges();

                    txtName.Text = "";
                    txtEmail.Text = "";
                    txtPass.Text = "";
                    DOB.Text = "";
                    cboRole.Text = "";
                    var dgv = db.Users.Select(d => new { Id = d.Id, Name = d.Name, Email = d.Email, Password = d.Password, DOB = d.DOB, Role = d.Role.UserType }).ToList();
                    dvgBooks.DataSource = dgv;
                    MessageBox.Show("Data deleted successfully", "Deleted !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                txtName.Text = "";
                txtEmail.Text = "";
                txtPass.Text = "";
                DOB.Text = "";
                cboRole.Text = "";
                MessageBox.Show("Data not found", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnaddUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                errors.AppendLine("User Name cannot be blank");

            }

            if (txtPass.Text == "")
            {
                errors.AppendLine("Publisher Name cannot be blank");
            }


            //Show error message
            if (errors.ToString() != string.Empty)
            {
                MessageBox.Show(errors.ToString(), "Validation failed !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            User ur = new User();
            ur.Name = txtName.Text;
            ur.Email = txtEmail.Text;
            ur.Password = txtPass.Text;
            ur.DOB = DOB.Value;
            ur.roleId = Int32.Parse(cboRole.SelectedValue.ToString());


            db.Users.Add(ur);
            db.SaveChanges();

            MessageBox.Show("User Added Successfully !!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmUsers usr = new frmUsers();
            this.Hide();
            usr.ShowDialog();
        }
    }
}
