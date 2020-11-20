using System;
using System.Windows.Forms;

namespace Atom_Password_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Load_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = $"{ManagerParole.NumeProgram} files |*{ManagerParole.Extensie}";
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;
            ManagerParole.LocatieFisier = openFileDialog.FileName;
            MainPasswordForm PasswordForm = new MainPasswordForm();
            PasswordForm.title = "Enter you master password";
            PasswordForm.ShowDialog();
            if (ManagerParole.MainPassword.Length == 0)
                return;
            if (ManagerParole.CitesteConturi(ManagerParole.LocatieFisier, ManagerParole.MainPassword))
            {
                this.Close();
                Program.CorrectPassword = true;
            }
            else
            {
                if (ManagerParole.MainPassword.Length != 0)
                    MessageBox.Show("Password is wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void Create_Click(object sender, System.EventArgs e)
        {
            
            MainPasswordForm PasswordForm = new MainPasswordForm();
            PasswordForm.title = "Create a master password";
            PasswordForm.ShowDialog();

            if (ManagerParole.MainPassword.Length == 0)
                return;

            ManagerParole.AdaugaExemple(1);

            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = $"{ManagerParole.NumeProgram} files |*{ManagerParole.Extensie}"; 
            saveFileDialog.DefaultExt = ManagerParole.Extensie;
            saveFileDialog.AddExtension = true;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                ManagerParole.SalveazaParolele(saveFileDialog.FileName, ManagerParole.MainPassword);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Select();
        }
    }
}
