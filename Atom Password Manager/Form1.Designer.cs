namespace Atom_Password_Manager
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.load = new System.Windows.Forms.Button();
            this.create = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // load
            // 
            this.load.BackColor = global::Atom_Password_Manager.Properties.Settings.Default.BackColor;
            this.load.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Atom_Password_Manager.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.load.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Atom_Password_Manager.Properties.Settings.Default, "BackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.load.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Atom_Password_Manager.Properties.Settings.Default, "Font", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.load.Font = global::Atom_Password_Manager.Properties.Settings.Default.Font;
            this.load.ForeColor = global::Atom_Password_Manager.Properties.Settings.Default.TextColor;
            this.load.Location = new System.Drawing.Point(44, 127);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(99, 55);
            this.load.TabIndex = 1;
            this.load.Text = "Select Backup";
            this.load.UseVisualStyleBackColor = false;
            this.load.Click += new System.EventHandler(this.Load_Click);
            // 
            // create
            // 
            this.create.BackColor = global::Atom_Password_Manager.Properties.Settings.Default.BackColor;
            this.create.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Atom_Password_Manager.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.create.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Atom_Password_Manager.Properties.Settings.Default, "BackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.create.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Atom_Password_Manager.Properties.Settings.Default, "Font", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create.Font = global::Atom_Password_Manager.Properties.Settings.Default.Font;
            this.create.ForeColor = global::Atom_Password_Manager.Properties.Settings.Default.TextColor;
            this.create.Location = new System.Drawing.Point(185, 127);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(99, 55);
            this.create.TabIndex = 2;
            this.create.Text = "Create Backup";
            this.create.UseVisualStyleBackColor = false;
            this.create.Click += new System.EventHandler(this.Create_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Atom_Password_Manager.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Atom_Password_Manager.Properties.Settings.Default, "Font", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = global::Atom_Password_Manager.Properties.Settings.Default.Font;
            this.label1.ForeColor = global::Atom_Password_Manager.Properties.Settings.Default.TextColor;
            this.label1.Location = new System.Drawing.Point(116, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Atom_Password_Manager.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label2.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Atom_Password_Manager.Properties.Settings.Default, "Font", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = global::Atom_Password_Manager.Properties.Settings.Default.Font;
            this.label2.ForeColor = global::Atom_Password_Manager.Properties.Settings.Default.TextColor;
            this.label2.Location = new System.Drawing.Point(25, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "Please select a backup or create\na new one!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::Atom_Password_Manager.Properties.Settings.Default.BackColor;
            this.ClientSize = new System.Drawing.Size(326, 216);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.create);
            this.Controls.Add(this.load);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Atom_Password_Manager.Properties.Settings.Default, "BackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(342, 255);
            this.MinimumSize = new System.Drawing.Size(342, 255);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atom Password Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button load;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

