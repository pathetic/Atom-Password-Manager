namespace Atom_Password_Manager
{
    partial class MainAtomForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainAtomForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.schimbareParola = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.salvareSchimbari = new System.Windows.Forms.Button();
            this.ascundeParole = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.replaceButton = new System.Windows.Forms.Button();
            this.delButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.arataParola = new System.Windows.Forms.Button();
            this.genButton = new System.Windows.Forms.Button();
            this.noteBox = new System.Windows.Forms.TextBox();
            this.siteBox = new System.Windows.Forms.TextBox();
            this.passBox = new System.Windows.Forms.TextBox();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.caractereParolaTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lungimeParolaTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.complexLabel = new System.Windows.Forms.Label();
            this.complexBar = new System.Windows.Forms.ProgressBar();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = global::Atom_Password_Manager.Properties.Settings.Default.SubButtonColor;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.schimbareParola);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.salvareSchimbari);
            this.panel1.Controls.Add(this.ascundeParole);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.replaceButton);
            this.panel1.Controls.Add(this.delButton);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.button1);
            this.panel1.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Atom_Password_Manager.Properties.Settings.Default, "SubButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 531);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = global::Atom_Password_Manager.Properties.Settings.Default.ButtonColor;
            this.button2.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Atom_Password_Manager.Properties.Settings.Default, "ButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button2.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Atom_Password_Manager.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button2.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Atom_Password_Manager.Properties.Settings.Default, "Font", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = global::Atom_Password_Manager.Properties.Settings.Default.Font;
            this.button2.ForeColor = global::Atom_Password_Manager.Properties.Settings.Default.TextColor;
            this.button2.Location = new System.Drawing.Point(0, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 31);
            this.button2.TabIndex = 19;
            this.button2.Text = "  Check complexity";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Complexitate_Click);
            // 
            // schimbareParola
            // 
            this.schimbareParola.BackColor = global::Atom_Password_Manager.Properties.Settings.Default.ButtonColor;
            this.schimbareParola.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Atom_Password_Manager.Properties.Settings.Default, "ButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.schimbareParola.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Atom_Password_Manager.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.schimbareParola.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Atom_Password_Manager.Properties.Settings.Default, "Font", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.schimbareParola.Dock = System.Windows.Forms.DockStyle.Top;
            this.schimbareParola.FlatAppearance.BorderSize = 0;
            this.schimbareParola.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.schimbareParola.Font = global::Atom_Password_Manager.Properties.Settings.Default.Font;
            this.schimbareParola.ForeColor = global::Atom_Password_Manager.Properties.Settings.Default.TextColor;
            this.schimbareParola.Location = new System.Drawing.Point(0, 194);
            this.schimbareParola.Name = "schimbareParola";
            this.schimbareParola.Size = new System.Drawing.Size(179, 48);
            this.schimbareParola.TabIndex = 13;
            this.schimbareParola.Text = "  Change master\n  password";
            this.schimbareParola.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.schimbareParola.UseVisualStyleBackColor = false;
            this.schimbareParola.Click += new System.EventHandler(this.SchimbareParola_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Atom_Password_Manager.Properties.Settings.Default, "Font", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label6.Font = global::Atom_Password_Manager.Properties.Settings.Default.Font;
            this.label6.Location = new System.Drawing.Point(3, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Options";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Atom_Password_Manager.Properties.Settings.Default, "Font", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label5.Font = global::Atom_Password_Manager.Properties.Settings.Default.Font;
            this.label5.Location = new System.Drawing.Point(3, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Edit Data";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // salvareSchimbari
            // 
            this.salvareSchimbari.BackColor = global::Atom_Password_Manager.Properties.Settings.Default.ButtonColor;
            this.salvareSchimbari.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Atom_Password_Manager.Properties.Settings.Default, "ButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.salvareSchimbari.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Atom_Password_Manager.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.salvareSchimbari.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Atom_Password_Manager.Properties.Settings.Default, "Font", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.salvareSchimbari.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.salvareSchimbari.FlatAppearance.BorderSize = 0;
            this.salvareSchimbari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salvareSchimbari.Font = global::Atom_Password_Manager.Properties.Settings.Default.Font;
            this.salvareSchimbari.ForeColor = global::Atom_Password_Manager.Properties.Settings.Default.TextColor;
            this.salvareSchimbari.Location = new System.Drawing.Point(0, 491);
            this.salvareSchimbari.Name = "salvareSchimbari";
            this.salvareSchimbari.Size = new System.Drawing.Size(179, 40);
            this.salvareSchimbari.TabIndex = 14;
            this.salvareSchimbari.Text = "Save changes";
            this.salvareSchimbari.UseVisualStyleBackColor = false;
            this.salvareSchimbari.Click += new System.EventHandler(this.SalvareSchimbari_Click);
            // 
            // ascundeParole
            // 
            this.ascundeParole.BackColor = global::Atom_Password_Manager.Properties.Settings.Default.ButtonColor;
            this.ascundeParole.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Atom_Password_Manager.Properties.Settings.Default, "ButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ascundeParole.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Atom_Password_Manager.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ascundeParole.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Atom_Password_Manager.Properties.Settings.Default, "Font", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ascundeParole.Dock = System.Windows.Forms.DockStyle.Top;
            this.ascundeParole.FlatAppearance.BorderSize = 0;
            this.ascundeParole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ascundeParole.Font = global::Atom_Password_Manager.Properties.Settings.Default.Font;
            this.ascundeParole.ForeColor = global::Atom_Password_Manager.Properties.Settings.Default.TextColor;
            this.ascundeParole.Location = new System.Drawing.Point(0, 163);
            this.ascundeParole.Name = "ascundeParole";
            this.ascundeParole.Size = new System.Drawing.Size(179, 31);
            this.ascundeParole.TabIndex = 12;
            this.ascundeParole.Text = "  Show passwords";
            this.ascundeParole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ascundeParole.UseVisualStyleBackColor = false;
            this.ascundeParole.Click += new System.EventHandler(this.AscundeColumnPass_Click);
            // 
            // button3
            // 
            this.button3.BackColor = global::Atom_Password_Manager.Properties.Settings.Default.SubButtonColor;
            this.button3.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Atom_Password_Manager.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button3.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Atom_Password_Manager.Properties.Settings.Default, "SubButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button3.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Atom_Password_Manager.Properties.Settings.Default, "Font", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Enabled = false;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = global::Atom_Password_Manager.Properties.Settings.Default.Font;
            this.button3.ForeColor = global::Atom_Password_Manager.Properties.Settings.Default.TextColor;
            this.button3.Location = new System.Drawing.Point(0, 128);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(179, 35);
            this.button3.TabIndex = 11;
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // replaceButton
            // 
            this.replaceButton.BackColor = global::Atom_Password_Manager.Properties.Settings.Default.ButtonColor;
            this.replaceButton.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Atom_Password_Manager.Properties.Settings.Default, "ButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.replaceButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Atom_Password_Manager.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.replaceButton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Atom_Password_Manager.Properties.Settings.Default, "Font", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.replaceButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.replaceButton.FlatAppearance.BorderSize = 0;
            this.replaceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.replaceButton.Font = global::Atom_Password_Manager.Properties.Settings.Default.Font;
            this.replaceButton.ForeColor = global::Atom_Password_Manager.Properties.Settings.Default.TextColor;
            this.replaceButton.Location = new System.Drawing.Point(0, 97);
            this.replaceButton.Name = "replaceButton";
            this.replaceButton.Size = new System.Drawing.Size(179, 31);
            this.replaceButton.TabIndex = 10;
            this.replaceButton.Text = "  Replace";
            this.replaceButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.replaceButton.UseVisualStyleBackColor = false;
            this.replaceButton.Click += new System.EventHandler(this.ReplaceButton_Click);
            // 
            // delButton
            // 
            this.delButton.BackColor = global::Atom_Password_Manager.Properties.Settings.Default.ButtonColor;
            this.delButton.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Atom_Password_Manager.Properties.Settings.Default, "ButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.delButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Atom_Password_Manager.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.delButton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Atom_Password_Manager.Properties.Settings.Default, "Font", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.delButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.delButton.FlatAppearance.BorderSize = 0;
            this.delButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delButton.Font = global::Atom_Password_Manager.Properties.Settings.Default.Font;
            this.delButton.ForeColor = global::Atom_Password_Manager.Properties.Settings.Default.TextColor;
            this.delButton.Location = new System.Drawing.Point(0, 66);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(179, 31);
            this.delButton.TabIndex = 9;
            this.delButton.Text = "  Delete account";
            this.delButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delButton.UseVisualStyleBackColor = false;
            this.delButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = global::Atom_Password_Manager.Properties.Settings.Default.ButtonColor;
            this.addButton.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Atom_Password_Manager.Properties.Settings.Default, "ButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.addButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Atom_Password_Manager.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.addButton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Atom_Password_Manager.Properties.Settings.Default, "Font", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.addButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = global::Atom_Password_Manager.Properties.Settings.Default.Font;
            this.addButton.ForeColor = global::Atom_Password_Manager.Properties.Settings.Default.TextColor;
            this.addButton.Location = new System.Drawing.Point(0, 35);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(179, 31);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "  Add account";
            this.addButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = global::Atom_Password_Manager.Properties.Settings.Default.SubButtonColor;
            this.button1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Atom_Password_Manager.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button1.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Atom_Password_Manager.Properties.Settings.Default, "SubButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button1.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Atom_Password_Manager.Properties.Settings.Default, "Font", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = global::Atom_Password_Manager.Properties.Settings.Default.Font;
            this.button1.ForeColor = global::Atom_Password_Manager.Properties.Settings.Default.TextColor;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 35);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // listView1
            // 
            this.listView1.BackColor = global::Atom_Password_Manager.Properties.Settings.Default.BackColor;
            this.listView1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Atom_Password_Manager.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.listView1.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Atom_Password_Manager.Properties.Settings.Default, "BackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.listView1.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Atom_Password_Manager.Properties.Settings.Default, "FontMic", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.listView1.Font = global::Atom_Password_Manager.Properties.Settings.Default.FontMic;
            this.listView1.ForeColor = global::Atom_Password_Manager.Properties.Settings.Default.TextColor;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(188, 9);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(603, 316);
            this.listView1.TabIndex = 15;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            this.listView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView1_KeyDown);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.arataParola);
            this.groupBox1.Controls.Add(this.genButton);
            this.groupBox1.Controls.Add(this.noteBox);
            this.groupBox1.Controls.Add(this.siteBox);
            this.groupBox1.Controls.Add(this.passBox);
            this.groupBox1.Controls.Add(this.loginBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Atom_Password_Manager.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.groupBox1.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Atom_Password_Manager.Properties.Settings.Default, "FontMic", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.groupBox1.Font = global::Atom_Password_Manager.Properties.Settings.Default.FontMic;
            this.groupBox1.ForeColor = global::Atom_Password_Manager.Properties.Settings.Default.TextColor;
            this.groupBox1.Location = new System.Drawing.Point(188, 331);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 104);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit Data";
            // 
            // arataParola
            // 
            this.arataParola.BackColor = global::Atom_Password_Manager.Properties.Settings.Default.ButtonColor;
            this.arataParola.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Atom_Password_Manager.Properties.Settings.Default, "ButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.arataParola.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Atom_Password_Manager.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.arataParola.FlatAppearance.BorderSize = 0;
            this.arataParola.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.arataParola.ForeColor = global::Atom_Password_Manager.Properties.Settings.Default.TextColor;
            this.arataParola.Location = new System.Drawing.Point(522, 21);
            this.arataParola.Name = "arataParola";
            this.arataParola.Size = new System.Drawing.Size(71, 23);
            this.arataParola.TabIndex = 6;
            this.arataParola.Text = "Show";
            this.arataParola.UseVisualStyleBackColor = false;
            this.arataParola.Click += new System.EventHandler(this.ArataParola_Click);
            // 
            // genButton
            // 
            this.genButton.BackColor = global::Atom_Password_Manager.Properties.Settings.Default.ButtonColor;
            this.genButton.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Atom_Password_Manager.Properties.Settings.Default, "ButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.genButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Atom_Password_Manager.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.genButton.FlatAppearance.BorderSize = 0;
            this.genButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genButton.ForeColor = global::Atom_Password_Manager.Properties.Settings.Default.TextColor;
            this.genButton.Location = new System.Drawing.Point(445, 21);
            this.genButton.Name = "genButton";
            this.genButton.Size = new System.Drawing.Size(71, 23);
            this.genButton.TabIndex = 5;
            this.genButton.Text = "Generate";
            this.genButton.UseVisualStyleBackColor = false;
            this.genButton.Click += new System.EventHandler(this.GenButton_Click);
            // 
            // noteBox
            // 
            this.noteBox.Location = new System.Drawing.Point(274, 61);
            this.noteBox.Name = "noteBox";
            this.noteBox.Size = new System.Drawing.Size(319, 21);
            this.noteBox.TabIndex = 4;
            // 
            // siteBox
            // 
            this.siteBox.Location = new System.Drawing.Point(57, 61);
            this.siteBox.Name = "siteBox";
            this.siteBox.Size = new System.Drawing.Size(165, 21);
            this.siteBox.TabIndex = 3;
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(274, 23);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(165, 21);
            this.passBox.TabIndex = 1;
            this.passBox.UseSystemPasswordChar = true;
            // 
            // loginBox
            // 
            this.loginBox.Location = new System.Drawing.Point(57, 23);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(165, 21);
            this.loginBox.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Atom_Password_Manager.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label4.ForeColor = global::Atom_Password_Manager.Properties.Settings.Default.TextColor;
            this.label4.Location = new System.Drawing.Point(230, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Notes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Atom_Password_Manager.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label3.ForeColor = global::Atom_Password_Manager.Properties.Settings.Default.TextColor;
            this.label3.Location = new System.Drawing.Point(23, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Site:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Atom_Password_Manager.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label2.ForeColor = global::Atom_Password_Manager.Properties.Settings.Default.TextColor;
            this.label2.Location = new System.Drawing.Point(235, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pass:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Atom_Password_Manager.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label1.ForeColor = global::Atom_Password_Manager.Properties.Settings.Default.TextColor;
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Atom_Password_Manager.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label7.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Atom_Password_Manager.Properties.Settings.Default, "FontMic", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label7.Font = global::Atom_Password_Manager.Properties.Settings.Default.FontMic;
            this.label7.ForeColor = global::Atom_Password_Manager.Properties.Settings.Default.TextColor;
            this.label7.Location = new System.Drawing.Point(15, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 14);
            this.label7.TabIndex = 17;
            this.label7.Text = "Accepeted chars for password:";
            // 
            // caractereParolaTextBox
            // 
            this.caractereParolaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Atom_Password_Manager.Properties.Settings.Default, "FontMic", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.caractereParolaTextBox.Font = global::Atom_Password_Manager.Properties.Settings.Default.FontMic;
            this.caractereParolaTextBox.ForeColor = System.Drawing.Color.Black;
            this.caractereParolaTextBox.Location = new System.Drawing.Point(213, 18);
            this.caractereParolaTextBox.Name = "caractereParolaTextBox";
            this.caractereParolaTextBox.Size = new System.Drawing.Size(380, 21);
            this.caractereParolaTextBox.TabIndex = 15;
            this.caractereParolaTextBox.TextChanged += new System.EventHandler(this.caractereParolaTextBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Atom_Password_Manager.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label8.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Atom_Password_Manager.Properties.Settings.Default, "FontMic", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label8.Font = global::Atom_Password_Manager.Properties.Settings.Default.FontMic;
            this.label8.ForeColor = global::Atom_Password_Manager.Properties.Settings.Default.TextColor;
            this.label8.Location = new System.Drawing.Point(15, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 14);
            this.label8.TabIndex = 18;
            this.label8.Text = "Pass Lenght:";
            // 
            // lungimeParolaTextBox
            // 
            this.lungimeParolaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Atom_Password_Manager.Properties.Settings.Default, "FontMic", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lungimeParolaTextBox.Font = global::Atom_Password_Manager.Properties.Settings.Default.FontMic;
            this.lungimeParolaTextBox.ForeColor = System.Drawing.Color.Black;
            this.lungimeParolaTextBox.Location = new System.Drawing.Point(118, 47);
            this.lungimeParolaTextBox.Name = "lungimeParolaTextBox";
            this.lungimeParolaTextBox.Size = new System.Drawing.Size(104, 21);
            this.lungimeParolaTextBox.TabIndex = 16;
            this.lungimeParolaTextBox.TextChanged += new System.EventHandler(this.lungimeParolaTextBox_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.complexLabel);
            this.groupBox2.Controls.Add(this.complexBar);
            this.groupBox2.Controls.Add(this.caractereParolaTextBox);
            this.groupBox2.Controls.Add(this.lungimeParolaTextBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Atom_Password_Manager.Properties.Settings.Default, "FontMic", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.groupBox2.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Atom_Password_Manager.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.groupBox2.Font = global::Atom_Password_Manager.Properties.Settings.Default.FontMic;
            this.groupBox2.ForeColor = global::Atom_Password_Manager.Properties.Settings.Default.TextColor;
            this.groupBox2.Location = new System.Drawing.Point(188, 441);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(602, 78);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // complexLabel
            // 
            this.complexLabel.AutoSize = true;
            this.complexLabel.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Atom_Password_Manager.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.complexLabel.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Atom_Password_Manager.Properties.Settings.Default, "FontMic", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.complexLabel.Font = global::Atom_Password_Manager.Properties.Settings.Default.FontMic;
            this.complexLabel.ForeColor = global::Atom_Password_Manager.Properties.Settings.Default.TextColor;
            this.complexLabel.Location = new System.Drawing.Point(230, 50);
            this.complexLabel.Name = "complexLabel";
            this.complexLabel.Size = new System.Drawing.Size(118, 14);
            this.complexLabel.TabIndex = 20;
            this.complexLabel.Text = "Complexity (0/100):";
            // 
            // complexBar
            // 
            this.complexBar.Location = new System.Drawing.Point(376, 47);
            this.complexBar.Name = "complexBar";
            this.complexBar.Size = new System.Drawing.Size(217, 21);
            this.complexBar.TabIndex = 19;
            // 
            // MainAtomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::Atom_Password_Manager.Properties.Settings.Default.BackColor;
            this.ClientSize = new System.Drawing.Size(800, 531);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Atom_Password_Manager.Properties.Settings.Default, "BackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Atom_Password_Manager.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ForeColor = global::Atom_Password_Manager.Properties.Settings.Default.TextColor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "MainAtomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atom Password Manager";
            this.Load += new System.EventHandler(this.MainAtomForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button replaceButton;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button genButton;
        private System.Windows.Forms.TextBox noteBox;
        private System.Windows.Forms.TextBox siteBox;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button arataParola;
        private System.Windows.Forms.Button ascundeParole;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button salvareSchimbari;
        private System.Windows.Forms.Button schimbareParola;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox caractereParolaTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox lungimeParolaTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label complexLabel;
        private System.Windows.Forms.ProgressBar complexBar;
    }
}