using System;
using System.Windows.Forms;

namespace Atom_Password_Manager
{
    public partial class SchimbareParolaForm : Form
    {
        public SchimbareParolaForm()
        {
            InitializeComponent();
        }

        private void pwToggleButton_Click(object sender, EventArgs e)
        {
            if (OldPassBox.UseSystemPasswordChar)
            {
                Toggle(false);
                pwToggleButton.Image = Atom_Password_Manager.Properties.Resources.dispari;
            }
            else
            {
                Toggle(true);
                pwToggleButton.Image = Atom_Password_Manager.Properties.Resources.apari;
            }
        }

        private void Toggle(bool ok)
        {
            OldPassBox.UseSystemPasswordChar = ok;
            NewPassBox.UseSystemPasswordChar = ok;
            CNewPassBox.UseSystemPasswordChar = ok;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (NewPassBox.Text != CNewPassBox.Text)
                MessageBox.Show("The password is wrong in atleast one field!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (OldPassBox.Text == "" || NewPassBox.Text == "" || CNewPassBox.Text == "")
                MessageBox.Show("One or more fields are empty!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if(OldPassBox.Text != ManagerParole.MainPassword)
                MessageBox.Show("Old password is wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                ManagerParole.SalveazaParolele(ManagerParole.LocatieFisier, NewPassBox.Text);
                ManagerParole.MainPassword = NewPassBox.Text;
                MessageBox.Show("Password was changed succesfuly!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
