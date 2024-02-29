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
    public partial class frmRegister : Form
    {
        DatabaseLibEntities db;
        StringBuilder errors;
        bool mouseDown;
        private Point offset;
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            db = new DatabaseLibEntities();
            errors = new StringBuilder();

            //Check User Name required
            if (string.IsNullOrEmpty(txtName.Text))
            {
                errors.AppendLine("UserName cannot be blank");

            }

            if (txtPass.Text == "")
            {
                errors.AppendLine("Password cannot be blank");
            }

            //Email Validation
            if (txtEmail.Text.Length > 0)
            {
                try
                {
                    new System.Net.Mail.MailAddress(txtEmail.Text);
                }
                catch (Exception)
                {
                    errors.AppendLine("Not a valid Email Address");

                }
            }
            

            //Show error message
            if (errors.ToString() != string.Empty)
            {
                MessageBox.Show(errors.ToString(), "Validation failed !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //User Info Data Insert Here
            User usr = new User();
            usr.Name = txtName.Text;
            usr.Email = txtEmail.Text;
            usr.Password = txtPass.Text;
            usr.DOB = dtDOB.Value;
            usr.roleId = Int32.Parse(cboUsertype.SelectedValue.ToString());

            
            db.Users.Add(usr);
            db.SaveChanges();

            MessageBox.Show("Registration Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmLogin lg = new frmLogin();
            this.Hide();
            lg.ShowDialog();
        }


    

        private void frmRegister_Load(object sender, EventArgs e)
        {
            db = new DatabaseLibEntities();
            var userRole = db.Roles.Select(d => new { d.Id, d.UserType }).Where(d=> d.UserType != "Admin").ToList();
            cboUsertype.DataSource = userRole;
            cboUsertype.DisplayMember = "UserType";
            cboUsertype.ValueMember = "Id";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin lg = new frmLogin();
            this.Hide();
            lg.ShowDialog();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
            frmLogin lg = new frmLogin();
            this.Hide();
            lg.ShowDialog();
        }

        private void mouseDown_event(object sender, MouseEventArgs e)
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
