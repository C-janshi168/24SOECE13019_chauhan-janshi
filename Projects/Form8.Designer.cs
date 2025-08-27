namespace Projects
{
    partial class Form8
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
            NAMETXT = new TextBox();
            NAME = new Label();
            PASSWORD = new Label();
            BRANCH = new Label();
            CITY = new Label();
            GENDER = new Label();
            register = new Button();
            PWDTXT = new TextBox();
            branch_list = new ListBox();
            city_list = new ListBox();
            male = new RadioButton();
            female = new RadioButton();
            SuspendLayout();
            // 
            // NAMETXT
            // 
            NAMETXT.Location = new Point(140, 57);
            NAMETXT.Name = "NAMETXT";
            NAMETXT.Size = new Size(278, 27);
            NAMETXT.TabIndex = 0;
            NAMETXT.TextChanged += textBox1_TextChanged;
            // 
            // NAME
            // 
            NAME.AutoSize = true;
            NAME.Location = new Point(50, 60);
            NAME.Name = "NAME";
            NAME.Size = new Size(49, 20);
            NAME.TabIndex = 1;
            NAME.Text = "Name";
            NAME.Click += NAME_Click;
            // 
            // PASSWORD
            // 
            PASSWORD.AutoSize = true;
            PASSWORD.Location = new Point(50, 127);
            PASSWORD.Name = "PASSWORD";
            PASSWORD.Size = new Size(70, 20);
            PASSWORD.TabIndex = 2;
            PASSWORD.Text = "Password";
            // 
            // BRANCH
            // 
            BRANCH.AutoSize = true;
            BRANCH.Location = new Point(50, 196);
            BRANCH.Name = "BRANCH";
            BRANCH.Size = new Size(54, 20);
            BRANCH.TabIndex = 3;
            BRANCH.Text = "Branch";
            // 
            // CITY
            // 
            CITY.AutoSize = true;
            CITY.Location = new Point(50, 257);
            CITY.Name = "CITY";
            CITY.Size = new Size(34, 20);
            CITY.TabIndex = 4;
            CITY.Text = "City";
            // 
            // GENDER
            // 
            GENDER.AutoSize = true;
            GENDER.Location = new Point(50, 313);
            GENDER.Name = "GENDER";
            GENDER.Size = new Size(57, 20);
            GENDER.TabIndex = 5;
            GENDER.Text = "Gender";
            // 
            // register
            // 
            register.Location = new Point(364, 377);
            register.Name = "register";
            register.Size = new Size(94, 29);
            register.TabIndex = 6;
            register.Text = "REGISTER";
            register.UseVisualStyleBackColor = true;
            register.Click += register_Click;
            // 
            // PWDTXT
            // 
            PWDTXT.Location = new Point(140, 120);
            PWDTXT.Name = "PWDTXT";
            PWDTXT.PasswordChar = '*';
            PWDTXT.Size = new Size(278, 27);
            PWDTXT.TabIndex = 7;
            // 
            // branch_list
            // 
            branch_list.FormattingEnabled = true;
            branch_list.Items.AddRange(new object[] { "BTECH-CE", "BTECH-IT", "BTECH-CIVIL" });
            branch_list.Location = new Point(156, 192);
            branch_list.Name = "branch_list";
            branch_list.Size = new Size(277, 24);
            branch_list.TabIndex = 11;
            branch_list.SelectedIndexChanged += branch_list_SelectedIndexChanged;
            // 
            // city_list
            // 
            city_list.FormattingEnabled = true;
            city_list.Items.AddRange(new object[] { "PORBANDAR", "ADIPUR", "RAJKOT" });
            city_list.Location = new Point(156, 253);
            city_list.Name = "city_list";
            city_list.Size = new Size(277, 24);
            city_list.TabIndex = 12;
            // 
            // male
            // 
            male.AutoSize = true;
            male.Location = new Point(156, 309);
            male.Name = "male";
            male.Size = new Size(63, 24);
            male.TabIndex = 13;
            male.TabStop = true;
            male.Text = "Male";
            male.UseVisualStyleBackColor = true;
            // 
            // female
            // 
            female.AutoSize = true;
            female.Location = new Point(316, 311);
            female.Name = "female";
            female.Size = new Size(78, 24);
            female.TabIndex = 14;
            female.TabStop = true;
            female.Text = "Female";
            female.UseVisualStyleBackColor = true;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(female);
            Controls.Add(male);
            Controls.Add(city_list);
            Controls.Add(branch_list);
            Controls.Add(PWDTXT);
            Controls.Add(register);
            Controls.Add(GENDER);
            Controls.Add(CITY);
            Controls.Add(BRANCH);
            Controls.Add(PASSWORD);
            Controls.Add(NAME);
            Controls.Add(NAMETXT);
            Name = "Form8";
            Text = "Form8";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NAMETXT;
        private Label NAME;
        private Label PASSWORD;
        private Label BRANCH;
        private Label CITY;
        private Label GENDER;
        private Button register;
        private TextBox PWDTXT;
        private ListBox branch_list;
        private ListBox city_list;
        private RadioButton male;
        private RadioButton female;
    }
}