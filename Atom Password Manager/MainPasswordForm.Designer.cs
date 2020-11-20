namespace Atom_Password_Manager
{
    partial class MainPasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPasswordForm));
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.pwToggleButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = global::Atom_Password_Manager.Properties.Settings.Default.BackColor;
            this.PasswordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Atom_Password_Manager.Properties.Settings.Default, "BackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PasswordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Atom_Password_Manager.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PasswordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Atom_Password_Manager.Properties.Settings.Default, "FontMic", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PasswordTextBox.Font = global::Atom_Password_Manager.Properties.Settings.Default.FontMic;
            this.PasswordTextBox.ForeColor = global::Atom_Password_Manager.Properties.Settings.Default.TextColor;
            this.PasswordTextBox.Location = new System.Drawing.Point(12, 12);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(408, 21);
            this.PasswordTextBox.TabIndex = 0;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // pwToggleButton
            // 
            this.pwToggleButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Atom_Password_Manager.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pwToggleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pwToggleButton.ForeColor = global::Atom_Password_Manager.Properties.Settings.Default.TextColor;
            this.pwToggleButton.Image = global::Atom_Password_Manager.Properties.Resources.apari;
            this.pwToggleButton.Location = new System.Drawing.Point(427, 12);
            this.pwToggleButton.Name = "pwToggleButton";
            this.pwToggleButton.Size = new System.Drawing.Size(55, 55);
            this.pwToggleButton.TabIndex = 1;
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
            this.okButton.Location = new System.Drawing.Point(13, 39);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(407, 28);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // MainPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::Atom_Password_Manager.Properties.Settings.Default.BackColor;
            this.ClientSize = new System.Drawing.Size(490, 79);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.pwToggleButton);
            this.Controls.Add(this.PasswordTextBox);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Atom_Password_Manager.Properties.Settings.Default, "BackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(506, 118);
            this.MinimumSize = new System.Drawing.Size(506, 118);
            this.Name = "MainPasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enter your master password";
            this.Load += new System.EventHandler(this.MainPasswordForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button pwToggleButton;
        private System.Windows.Forms.Button okButton;
    }
}