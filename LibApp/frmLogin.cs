using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibApp
{
    public partial class frmLogin : Form
    {
        DatabaseLibEntities db;
        bool mouseDown;
        private Point offset;        
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            db = new DatabaseLibEntities();
            txtPass.PasswordChar = '\u2022';
            pictureBox1.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "../../Resources/opened.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txtPass.PasswordChar == '\u2022')
            {
                txtPass.PasswordChar = '\0';
                pictureBox1.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "../../Resources/closed.png");
            }
            else
            {
                txtPass.PasswordChar = '\u2022';
                pictureBox1.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "../../Resources/opened.png");
            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            frmRegister reg = new frmRegister();
            this.Hide();
            reg.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var data = db.Users.Where(d => d.Email.ToLower() == txtEmail.Text.ToLower() && d.Password == txtPass.Text).FirstOrDefault();

            if (data != null)
            {
                //Data storing to memory
                clsUser.userid = data.Id;
                clsUser.userName = data.Name;
                clsUser.userRole = data.Role.UserType;



                this.Hide();
                //frmMainMenu frm = new frmMainMenu();
                //frm.Show();
                MessageBox.Show("Login Successful !!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (clsUser.userRole == "Admin")
                {
                    frmAdminPanel AP = new frmAdminPanel();
                    AP.ShowDialog();
                }

                else if(clsUser.userRole == "Publisher")
                {
                    frmPublisherPanel PP = new frmPublisherPanel();
                    PP.ShowDialog();
                }

                else if (clsUser.userRole == "Customer")
                {
                    frmMenu mm = new frmMenu();
                    mm.ShowDialog();
                }

            }
            else
            {
                MessageBox.Show("Sorry, invalid user !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
