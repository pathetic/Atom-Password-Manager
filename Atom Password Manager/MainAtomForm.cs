using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atom_Password_Manager
{
    public partial class MainAtomForm : Form
    {
        bool arata = false;
        public MainAtomForm()
        {
            InitializeComponent();
        }

        private void MainAtomForm_Load(object sender, EventArgs e)
        {
            caractereParolaTextBox.Text = Properties.Settings.Default.caractereParola;
            lungimeParolaTextBox.Text = Properties.Settings.Default.lungimeParola.ToString();
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Columns.Add("Login", 143, HorizontalAlignment.Left);
            listView1.Columns.Add("Password", 122, HorizontalAlignment.Left);
            listView1.Columns.Add("Site", 136, HorizontalAlignment.Left);
            listView1.Columns.Add("Notes", 198, HorizontalAlignment.Left);
            RefreshList(arata);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string login = loginBox.Text;
            string parola = passBox.Text;
            string site = siteBox.Text;
            string notita = noteBox.Text;
            if (login == "" && parola == "" && site == "" && notita == "")
            {
                MessageBox.Show("Please fill all the forms!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Cont.Conturi.Add(new Cont(login, parola, site, notita));
            RefreshList(arata);
            loginBox.Text = passBox.Text = siteBox.Text = noteBox.Text = "";
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please choose an account you want to edit!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult res = MessageBox.Show("Are you sure you want to delete the selected data?", "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                Cont.Conturi.RemoveAt(listView1.SelectedItems[0].Index);
                RefreshList(arata);
                loginBox.Text = passBox.Text = siteBox.Text = noteBox.Text = "";
            }
        }
        private void ReplaceButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please choose an account you want to edit!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Cont.Conturi.RemoveAt(listView1.SelectedItems[0].Index);
            string login = loginBox.Text;
            string parola = passBox.Text;
            string site = siteBox.Text;
            string notita = noteBox.Text;
            Cont.Conturi.Insert(listView1.SelectedItems[0].Index, new Cont(login, parola, site, notita));
            RefreshList(arata);
            loginBox.Text = passBox.Text = siteBox.Text = noteBox.Text = "";

        }
        private void GenButton_Click(object sender, EventArgs e)
        {
            passBox.Text = ManagerParole.RandomString(ManagerParole.LungimeParola);
        }

        private void ArataParola_Click(object sender, EventArgs e)
        {
            if (arataParola.Text == "Show")
            {
                arataParola.Text = "Hide";
                passBox.UseSystemPasswordChar = false;
            }
            else
            {
                arataParola.Text = "Show";
                passBox.UseSystemPasswordChar = true;
            }
        }

        private void AscundeColumnPass_Click(object sender, EventArgs e)
        {
            if (ascundeParole.Text == "  Show passwords")
            {
                arata = true;
                ascundeParole.Text = "  Hide passwords";
            }
            else
            {
                arata = false;
                ascundeParole.Text = "  Show passwords";
            }
            RefreshList(arata);

        }

        private void RefreshList(bool replaceparola)
        {
            listView1.Items.Clear();
            foreach (Cont contCurent in Cont.Conturi)
            {
                string parola;
                if (replaceparola)
                    parola = contCurent.parola;
                else
                    parola = "************";
                ListViewItem Date = new ListViewItem(new string[] { contCurent.email,
                                                                        parola,
                                                                        contCurent.site,
                                                                        contCurent.notite,
                                                                        });
                Date.Tag = contCurent.parola;
                listView1.Items.Add(Date);
            }
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                loginBox.Text = passBox.Text = siteBox.Text = noteBox.Text = "";
                return;
            }
            else
            {
                loginBox.Text = listView1.SelectedItems[0].SubItems[0].Text;
                passBox.Text = listView1.SelectedItems[0].Tag.ToString();
                siteBox.Text = listView1.SelectedItems[0].SubItems[2].Text;
                noteBox.Text = listView1.SelectedItems[0].SubItems[3].Text;
            }
        }

        private void SalvareSchimbari_Click(object sender, EventArgs e)
        {
            ManagerParole.SalveazaParolele(ManagerParole.LocatieFisier, ManagerParole.MainPassword);
            Properties.Settings.Default.caractereParola = ManagerParole.CaracterePermise;
            Properties.Settings.Default.lungimeParola = ManagerParole.LungimeParola;
            Properties.Settings.Default.Save();
        }

        private void SchimbareParola_Click(object sender, EventArgs e)
        {
            var Schimbare = new SchimbareParolaForm();
            Schimbare.Show();
        }

        public async void SetClipboardPw()
        {
            if (listView1.SelectedItems.Count != 0)
            {
                Clipboard.SetText(listView1.SelectedItems[0].Tag.ToString());
                await Task.Delay(TimeSpan.FromSeconds(ManagerParole.SecundeStergereParola));
                Clipboard.Clear();
            }
        }

        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
                SetClipboardPw();
        }

        private void caractereParolaTextBox_TextChanged(object sender, EventArgs e)
        {
            if (lungimeParolaTextBox.Text.Length == 0)
                return;
            ManagerParole.CaracterePermise = caractereParolaTextBox.Text;
        }

        private void lungimeParolaTextBox_TextChanged(object sender, EventArgs e)
        {
            if (lungimeParolaTextBox.Text.Length == 0)
                return;
            try
            {
                ManagerParole.LungimeParola = Int32.Parse(lungimeParolaTextBox.Text);
                if (ManagerParole.LungimeParola > 1000 || ManagerParole.LungimeParola < 1)
                    throw new Exception("Passsword lenght is invalid!");
            }
            catch { MessageBox.Show("Please enter a valid number!"); lungimeParolaTextBox.Text = ""; ManagerParole.LungimeParola = Properties.Settings.Default.lungimeParola; }
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SetClipboardPw();
        }

        private void Complexitate_Click(object sender, EventArgs e)
        {
            int putere = 0;
            if (passBox.Text.Length >= 4)
                putere += 10;
            if (passBox.Text.Length >= 8)
                putere += 10;
            if (passBox.Text.IndexOfAny("abcdefghijklmnopqrstuvwxyz".ToCharArray()) >= 0)
                putere += 15;
            if (passBox.Text.IndexOfAny("ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray()) >= 0)
                putere += 15;
            if (passBox.Text.IndexOfAny("0123456789".ToCharArray()) >= 0)
                putere += 25;
            if (passBox.Text.IndexOfAny("!@#$%^&*()_-=+;[]{}:.,<>/?".ToCharArray()) >= 0)
                putere += 25;
            complexBar.Value = putere;
            complexLabel.Text = $"Complexity ({putere}/100):";
            putere = 0;
        }
    }
}
