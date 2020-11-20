using System;
using System.Windows.Forms;

namespace Atom_Password_Manager
{
    public partial class MainPasswordForm : Form
    {
        public string title  = "";
        public MainPasswordForm()
        {
            InitializeComponent();
        }

        private void pwToggleButton_Click(object sender, EventArgs e)
        {
            if (PasswordTextBox.UseSystemPasswordChar)
            { 
                PasswordTextBox.UseSystemPasswordChar = false;
                pwToggleButton.Image = Atom_Password_Manager.Properties.Resources.dispari;
            }
            else
            { 
                PasswordTextBox.UseSystemPasswordChar = true;
                pwToggleButton.Image = Atom_Password_Manager.Properties.Resources.apari;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text.Length==0)
            {
                MessageBox.Show("Please enter your password!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ManagerParole.MainPassword = PasswordTextBox.Text;
            this.Close();
        }

        private void MainPasswordForm_Load(object sender, EventArgs e)
        {
            this.Text = title;
        }
    }
}
