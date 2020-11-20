namespace Atom_Password_Manager
{
    partial class SchimbareParolaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchimbareParolaForm));
            this.OldPassBox = new System.Windows.Forms.TextBox();
            this.pwToggleButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.NewPassBox = new System.Windows.Forms.TextBox();
            this.CNewPassBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OldPassBox
            // 
            this.OldPassBox.BackColor = global::Atom_Password_Manager.Properties.Settings.Default.BackColor;
            this.OldPassBox.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Atom_Password_Manager.Properties.Settings.Default, "BackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.OldPassBox.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Atom_Password_Manager.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.OldPassBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Atom_Password_Manager.Properties.Settings.Default, "FontMic", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.OldPassBox.Font = global::Atom_Password_Manager.Properties.Settings.Default.FontMic;
            this.OldPassBox.ForeColor = global::Atom_Password_Manager.Properties.Settings.Default.TextColor;
            this.OldPassBox.Location = new System.Drawing.Point(134, 12);
            this.OldPassBox.Name = "OldPassBox";
            this.OldPassBox.Size = new System.Drawing.Size(344, 21);
            this.OldPassBox.TabIndex = 0;
            this.OldPassBox.UseSystemPasswordChar = true;
            // 
            // pwToggleButton
            // 
            this.pwToggleButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Atom_Password_Manager.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pwToggleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pwToggleButton.ForeColor = global::Atom_Password_Manager.Properties.Settings.Default.TextColor;
            this.pwToggleButton.Image = global::Atom_Password_Manager.Properties.Resources.apari;
            this.pwToggleButton.Location = new System.Drawing.Point(427, 111);
            this.pwToggleButton.Name = "pwToggleButton";
            this.pwToggleButton.Size = new System.Drawing.Size(55, 31);
            this.pwToggleButton.TabIndex = 3;
            this.pwToggleButton.UseVisualStyleBackColor = true;
            this.pwToggleButton.Click += new System.EventHandler(this.pwToggleButton_Click);
            // 
            // okButton
            // 
            this.okButton.BackColor = global::Atom_Password_Manager.Properties.Settings.Default.BackColor;
            this.okButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Atom_Password_Manager.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.okButton.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Atom_Password_Manager.Properties.Settings.Default, "BackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.okButton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Atom_Password_Manager.Properties.Settings.Default, "Font", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton.Font = global::Atom_Password_Manager.Properties.Settings.Default.Font;
            this.okButton.ForeColor = global::Atom_Password_Manager.Properties.Settings.Default.TextColor;
            this.okButton.Location = new System.Drawing.Point(13, 111);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(407, 31);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // NewPassBox
            // 
            this.NewPassBox.BackColor = global::Atom_Password_Manager.Properties.Settings.Default.BackColor;
            this.NewPassBox.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Atom_Password_Manager.Properties.Settings.Default, "BackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.NewPassBox.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Atom_Password_Manager.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.NewPassBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Atom_Password_Manager.Properties.Settings.Default, "FontMic", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.NewPassBox.Font = global::Atom_Password_Manager.Properties.Settings.Default.FontMic;
            this.NewPassBox.ForeColor = global::Atom_Password_Manager.Properties.Settings.Default.TextColor;
            this.NewPassBox.Location = new System.Drawing.Point(134, 46);
            this.NewPassBox.Name = "NewPassBox";
            this.NewPassBox.Size = new System.Drawing.Size(344, 21);
            this.NewPassBox.TabIndex = 1;
            this.NewPassBox.UseSystemPasswordChar = true;
            // 
            // CNewPassBox
            // 
            this.CNewPassBox.BackColor = global::Atom_Password_Manager.Properties.Settings.Default.BackColor;
            this.CNewPassBox.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Atom_Password_Manager.Properties.Settings.Default, "BackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.CNewPassBox.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Atom_Password_Manager.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.CNewPassBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Atom_Password_Manager.Properties.Settings.Default, "FontMic", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.CNewPassBox.Font = global::Atom_Password_Manager.Properties.Settings.Default.FontMic;
            this.CNewPassBox.ForeColor = global::Atom_Password_Manager.Properties.Settings.Default.TextColor;
            this.CNewPassBox.Location = new System.Drawing.Point(134, 79);
            this.CNewPassBox.Name = "CNewPassBox";
            this.CNewPassBox.Size = new System.Drawing.Size(344, 21);
            this.CNewPassBox.TabIndex = 2;
            this.CNewPassBox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Atom_Password_Manager.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Atom_Password_Manager.Properties.Settings.Default, "FontMic", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label1.Font = global::Atom_Password_Manager.Properties.Settings.Default.FontMic;
            this.label1.ForeColor = global::Atom_Password_Manager.Properties.Settings.Default.TextColor;
            this.label1.Location = new System.Drawing.Point(34, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "Old password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Atom_Password_Manager.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label2.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Atom_Password_Manager.Properties.Settings.Default, "FontMic", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label2.Font = global::Atom_Password_Manager.Properties.Settings.Default.FontMic;
            this.label2.ForeColor = global::Atom_Password_Manager.Properties.Settings.Default.TextColor;
            this.label2.Location = new System.Drawing.Point(29, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 14);
            this.label2.TabIndex = 6;
            this.label2.Text = "New password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Atom_Password_Manager.Properties.Settings.Default, "FontMic", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label3.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Atom_Password_Manager.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label3.Font = global::Atom_Password_Manager.Properties.Settings.Default.FontMic;
            this.label3.ForeColor = global::Atom_Password_Manager.Properties.Settings.Default.TextColor;
            this.label3.Location = new System.Drawing.Point(6, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "Confirm  password:";
            // 
            // SchimbareParolaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::Atom_Password_Manager.Properties.Settings.Default.BackColor;
            this.ClientSize = new System.Drawing.Size(490, 154);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CNewPassBox);
            this.Controls.Add(this.NewPassBox);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.pwToggleButton);
            this.Controls.Add(this.OldPassBox);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Atom_Password_Manager.Properties.Settings.Default, "BackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SchimbareParolaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change your master password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OldPassBox;
        private System.Windows.Forms.Button pwToggleButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TextBox NewPassBox;
        private System.Windows.Forms.TextBox CNewPassBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}