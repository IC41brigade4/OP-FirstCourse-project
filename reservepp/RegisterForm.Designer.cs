namespace reservepp
{
    partial class RegisterForm
    {
       
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_exit = new System.Windows.Forms.Label();
            this.register_title = new System.Windows.Forms.Label();
            this.login_text = new System.Windows.Forms.Label();
            this.login_textbox = new System.Windows.Forms.TextBox();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.password_text = new System.Windows.Forms.Label();
            this.register_button = new System.Windows.Forms.Button();
            this.login_button = new System.Windows.Forms.Button();
            this.text_if_login = new System.Windows.Forms.Label();
            this.key_label = new System.Windows.Forms.Label();
            this.key_textbox = new System.Windows.Forms.TextBox();
            this.radioOfficer = new System.Windows.Forms.RadioButton();
            this.radiotck = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Brown;
            this.panel1.Controls.Add(this.button_exit);
            this.panel1.Controls.Add(this.register_title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 71);
            this.panel1.TabIndex = 0;
            // 
            // button_exit
            // 
            this.button_exit.AutoSize = true;
            this.button_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_exit.ForeColor = System.Drawing.SystemColors.Control;
            this.button_exit.Location = new System.Drawing.Point(382, 9);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(26, 25);
            this.button_exit.TabIndex = 1;
            this.button_exit.Text = "X";
            this.button_exit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label2_MouseClick);
            // 
            // register_title
            // 
            this.register_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.register_title.ForeColor = System.Drawing.SystemColors.Control;
            this.register_title.Location = new System.Drawing.Point(12, 18);
            this.register_title.Name = "register_title";
            this.register_title.Size = new System.Drawing.Size(153, 38);
            this.register_title.TabIndex = 0;
            this.register_title.Text = "Register";
            // 
            // login_text
            // 
            this.login_text.AutoSize = true;
            this.login_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_text.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.login_text.Location = new System.Drawing.Point(27, 91);
            this.login_text.Name = "login_text";
            this.login_text.Size = new System.Drawing.Size(259, 31);
            this.login_text.TabIndex = 1;
            this.login_text.Text = "Login (document ID)";
            // 
            // login_textbox
            // 
            this.login_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_textbox.Location = new System.Drawing.Point(33, 136);
            this.login_textbox.Multiline = true;
            this.login_textbox.Name = "login_textbox";
            this.login_textbox.Size = new System.Drawing.Size(232, 38);
            this.login_textbox.TabIndex = 2;
            // 
            // password_textbox
            // 
            this.password_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_textbox.Location = new System.Drawing.Point(33, 241);
            this.password_textbox.Multiline = true;
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.PasswordChar = '*';
            this.password_textbox.Size = new System.Drawing.Size(232, 40);
            this.password_textbox.TabIndex = 4;
            // 
            // password_text
            // 
            this.password_text.AutoSize = true;
            this.password_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_text.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.password_text.Location = new System.Drawing.Point(27, 197);
            this.password_text.Name = "password_text";
            this.password_text.Size = new System.Drawing.Size(134, 31);
            this.password_text.TabIndex = 3;
            this.password_text.Text = "Password";
            // 
            // register_button
            // 
            this.register_button.BackColor = System.Drawing.Color.Brown;
            this.register_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.register_button.ForeColor = System.Drawing.SystemColors.Control;
            this.register_button.Location = new System.Drawing.Point(33, 413);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(348, 46);
            this.register_button.TabIndex = 5;
            this.register_button.Text = "Register";
            this.register_button.UseVisualStyleBackColor = false;
            this.register_button.Click += new System.EventHandler(this.register_button_Click);
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.Color.Brown;
            this.login_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_button.ForeColor = System.Drawing.SystemColors.Control;
            this.login_button.Location = new System.Drawing.Point(154, 508);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(111, 37);
            this.login_button.TabIndex = 6;
            this.login_button.Text = "Log in";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // text_if_login
            // 
            this.text_if_login.AutoSize = true;
            this.text_if_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_if_login.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.text_if_login.Location = new System.Drawing.Point(81, 477);
            this.text_if_login.Name = "text_if_login";
            this.text_if_login.Size = new System.Drawing.Size(243, 18);
            this.text_if_login.TabIndex = 7;
            this.text_if_login.Text = "Already have an account, then log in";
            this.text_if_login.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // key_label
            // 
            this.key_label.AutoSize = true;
            this.key_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.key_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.key_label.Location = new System.Drawing.Point(29, 314);
            this.key_label.Name = "key_label";
            this.key_label.Size = new System.Drawing.Size(157, 24);
            this.key_label.TabIndex = 8;
            this.key_label.Text = "Key for employee";
            // 
            // key_textbox
            // 
            this.key_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.key_textbox.Location = new System.Drawing.Point(33, 341);
            this.key_textbox.Multiline = true;
            this.key_textbox.Name = "key_textbox";
            this.key_textbox.PasswordChar = '*';
            this.key_textbox.Size = new System.Drawing.Size(232, 26);
            this.key_textbox.TabIndex = 9;
            // 
            // radioOfficer
            // 
            this.radioOfficer.AutoSize = true;
            this.radioOfficer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioOfficer.Location = new System.Drawing.Point(33, 373);
            this.radioOfficer.Name = "radioOfficer";
            this.radioOfficer.Size = new System.Drawing.Size(70, 22);
            this.radioOfficer.TabIndex = 10;
            this.radioOfficer.TabStop = true;
            this.radioOfficer.Text = "Officer";
            this.radioOfficer.UseVisualStyleBackColor = true;
            // 
            // radiotck
            // 
            this.radiotck.AutoSize = true;
            this.radiotck.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radiotck.Location = new System.Drawing.Point(139, 373);
            this.radiotck.Name = "radiotck";
            this.radiotck.Size = new System.Drawing.Size(126, 22);
            this.radiotck.TabIndex = 11;
            this.radiotck.TabStop = true;
            this.radiotck.Text = "TCK Employee";
            this.radiotck.UseVisualStyleBackColor = true;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(411, 569);
            this.Controls.Add(this.radiotck);
            this.Controls.Add(this.radioOfficer);
            this.Controls.Add(this.key_textbox);
            this.Controls.Add(this.key_label);
            this.Controls.Add(this.text_if_login);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.register_button);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.password_text);
            this.Controls.Add(this.login_textbox);
            this.Controls.Add(this.login_text);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RegisterForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RegisterForm_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label button_exit;
        private System.Windows.Forms.Label register_title;
        private System.Windows.Forms.Label login_text;
        private System.Windows.Forms.TextBox login_textbox;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.Label password_text;
        private System.Windows.Forms.Button register_button;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Label text_if_login;
        private System.Windows.Forms.Label key_label;
        private System.Windows.Forms.TextBox key_textbox;
        private System.Windows.Forms.RadioButton radioOfficer;
        private System.Windows.Forms.RadioButton radiotck;
    }
}

