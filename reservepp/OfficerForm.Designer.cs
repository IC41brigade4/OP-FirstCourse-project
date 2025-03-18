namespace reservepp
{
    partial class OfficerForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
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
            this.TCK_title = new System.Windows.Forms.Label();
            this.get_inf_text = new System.Windows.Forms.Label();
            this.get_inf_btn = new System.Windows.Forms.Button();
            this.Inf_panel = new System.Windows.Forms.Panel();
            this.city_text = new System.Windows.Forms.Label();
            this.docid_text = new System.Windows.Forms.Label();
            this.age_text = new System.Windows.Forms.Label();
            this.lastname_text = new System.Windows.Forms.Label();
            this.firstname_text = new System.Windows.Forms.Label();
            this.change_inf_btn = new System.Windows.Forms.Button();
            this.change_inf_text = new System.Windows.Forms.Label();
            this.Inf_panel_change = new System.Windows.Forms.Panel();
            this.city_textbox = new System.Windows.Forms.TextBox();
            this.age_textbox = new System.Windows.Forms.TextBox();
            this.lastname_textbox = new System.Windows.Forms.TextBox();
            this.firstname_textbox = new System.Windows.Forms.TextBox();
            this.city_text2 = new System.Windows.Forms.Label();
            this.age_text2 = new System.Windows.Forms.Label();
            this.lastname_text2 = new System.Windows.Forms.Label();
            this.firstname_text2 = new System.Windows.Forms.Label();
            this.Change_btn = new System.Windows.Forms.Button();
            this.gotit_btn = new System.Windows.Forms.Button();
            this.permission_btn = new System.Windows.Forms.Button();
            this.permission_text = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.Inf_panel.SuspendLayout();
            this.Inf_panel_change.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Brown;
            this.panel1.Controls.Add(this.button_exit);
            this.panel1.Controls.Add(this.TCK_title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 71);
            this.panel1.TabIndex = 0;
            // 
            // button_exit
            // 
            this.button_exit.AutoSize = true;
            this.button_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_exit.ForeColor = System.Drawing.SystemColors.Control;
            this.button_exit.Location = new System.Drawing.Point(662, 9);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(26, 25);
            this.button_exit.TabIndex = 1;
            this.button_exit.Text = "X";
            this.button_exit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label2_MouseClick);
            // 
            // TCK_title
            // 
            this.TCK_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TCK_title.ForeColor = System.Drawing.SystemColors.Control;
            this.TCK_title.Location = new System.Drawing.Point(12, 18);
            this.TCK_title.Name = "TCK_title";
            this.TCK_title.Size = new System.Drawing.Size(286, 38);
            this.TCK_title.TabIndex = 0;
            this.TCK_title.Text = "TCK interface";
            // 
            // get_inf_text
            // 
            this.get_inf_text.AutoSize = true;
            this.get_inf_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.get_inf_text.Location = new System.Drawing.Point(17, 96);
            this.get_inf_text.Name = "get_inf_text";
            this.get_inf_text.Size = new System.Drawing.Size(281, 24);
            this.get_inf_text.TabIndex = 6;
            this.get_inf_text.Text = "Get all information about yourself";
            // 
            // get_inf_btn
            // 
            this.get_inf_btn.BackColor = System.Drawing.Color.Brown;
            this.get_inf_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.get_inf_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.get_inf_btn.Location = new System.Drawing.Point(21, 132);
            this.get_inf_btn.Name = "get_inf_btn";
            this.get_inf_btn.Size = new System.Drawing.Size(277, 38);
            this.get_inf_btn.TabIndex = 7;
            this.get_inf_btn.Text = "Get all information";
            this.get_inf_btn.UseVisualStyleBackColor = false;
            this.get_inf_btn.Click += new System.EventHandler(this.get_inf_btn_Click);
            // 
            // Inf_panel
            // 
            this.Inf_panel.BackColor = System.Drawing.SystemColors.Control;
            this.Inf_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Inf_panel.Controls.Add(this.city_text);
            this.Inf_panel.Controls.Add(this.docid_text);
            this.Inf_panel.Controls.Add(this.age_text);
            this.Inf_panel.Controls.Add(this.lastname_text);
            this.Inf_panel.Controls.Add(this.firstname_text);
            this.Inf_panel.Location = new System.Drawing.Point(21, 187);
            this.Inf_panel.Name = "Inf_panel";
            this.Inf_panel.Size = new System.Drawing.Size(277, 174);
            this.Inf_panel.TabIndex = 8;
            this.Inf_panel.Visible = false;
            // 
            // city_text
            // 
            this.city_text.AutoSize = true;
            this.city_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.city_text.Location = new System.Drawing.Point(14, 134);
            this.city_text.Name = "city_text";
            this.city_text.Size = new System.Drawing.Size(43, 20);
            this.city_text.TabIndex = 4;
            this.city_text.Text = "City: ";
            // 
            // docid_text
            // 
            this.docid_text.AutoSize = true;
            this.docid_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.docid_text.Location = new System.Drawing.Point(14, 105);
            this.docid_text.Name = "docid_text";
            this.docid_text.Size = new System.Drawing.Size(60, 20);
            this.docid_text.TabIndex = 3;
            this.docid_text.Text = "DocId: ";
            // 
            // age_text
            // 
            this.age_text.AutoSize = true;
            this.age_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.age_text.Location = new System.Drawing.Point(14, 74);
            this.age_text.Name = "age_text";
            this.age_text.Size = new System.Drawing.Size(46, 20);
            this.age_text.TabIndex = 2;
            this.age_text.Text = "Age: ";
            // 
            // lastname_text
            // 
            this.lastname_text.AutoSize = true;
            this.lastname_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastname_text.Location = new System.Drawing.Point(14, 45);
            this.lastname_text.Name = "lastname_text";
            this.lastname_text.Size = new System.Drawing.Size(92, 20);
            this.lastname_text.TabIndex = 1;
            this.lastname_text.Text = "Last name: ";
            // 
            // firstname_text
            // 
            this.firstname_text.AutoSize = true;
            this.firstname_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstname_text.Location = new System.Drawing.Point(14, 16);
            this.firstname_text.Name = "firstname_text";
            this.firstname_text.Size = new System.Drawing.Size(92, 20);
            this.firstname_text.TabIndex = 0;
            this.firstname_text.Text = "First name: ";
            // 
            // change_inf_btn
            // 
            this.change_inf_btn.BackColor = System.Drawing.Color.Brown;
            this.change_inf_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.change_inf_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.change_inf_btn.Location = new System.Drawing.Point(355, 132);
            this.change_inf_btn.Name = "change_inf_btn";
            this.change_inf_btn.Size = new System.Drawing.Size(306, 38);
            this.change_inf_btn.TabIndex = 10;
            this.change_inf_btn.Text = "Change information";
            this.change_inf_btn.UseVisualStyleBackColor = false;
            this.change_inf_btn.Click += new System.EventHandler(this.change_inf_btn_Click);
            // 
            // change_inf_text
            // 
            this.change_inf_text.AutoSize = true;
            this.change_inf_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.change_inf_text.Location = new System.Drawing.Point(413, 96);
            this.change_inf_text.Name = "change_inf_text";
            this.change_inf_text.Size = new System.Drawing.Size(174, 24);
            this.change_inf_text.TabIndex = 9;
            this.change_inf_text.Text = "Change information";
            // 
            // Inf_panel_change
            // 
            this.Inf_panel_change.BackColor = System.Drawing.SystemColors.Control;
            this.Inf_panel_change.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Inf_panel_change.Controls.Add(this.city_textbox);
            this.Inf_panel_change.Controls.Add(this.age_textbox);
            this.Inf_panel_change.Controls.Add(this.lastname_textbox);
            this.Inf_panel_change.Controls.Add(this.firstname_textbox);
            this.Inf_panel_change.Controls.Add(this.city_text2);
            this.Inf_panel_change.Controls.Add(this.age_text2);
            this.Inf_panel_change.Controls.Add(this.lastname_text2);
            this.Inf_panel_change.Controls.Add(this.firstname_text2);
            this.Inf_panel_change.Location = new System.Drawing.Point(355, 187);
            this.Inf_panel_change.Name = "Inf_panel_change";
            this.Inf_panel_change.Size = new System.Drawing.Size(306, 174);
            this.Inf_panel_change.TabIndex = 11;
            this.Inf_panel_change.Visible = false;
            // 
            // city_textbox
            // 
            this.city_textbox.Location = new System.Drawing.Point(112, 107);
            this.city_textbox.Multiline = true;
            this.city_textbox.Name = "city_textbox";
            this.city_textbox.Size = new System.Drawing.Size(174, 20);
            this.city_textbox.TabIndex = 8;
            // 
            // age_textbox
            // 
            this.age_textbox.Location = new System.Drawing.Point(112, 76);
            this.age_textbox.Multiline = true;
            this.age_textbox.Name = "age_textbox";
            this.age_textbox.Size = new System.Drawing.Size(174, 20);
            this.age_textbox.TabIndex = 7;
            // 
            // lastname_textbox
            // 
            this.lastname_textbox.Location = new System.Drawing.Point(112, 47);
            this.lastname_textbox.Multiline = true;
            this.lastname_textbox.Name = "lastname_textbox";
            this.lastname_textbox.Size = new System.Drawing.Size(174, 20);
            this.lastname_textbox.TabIndex = 6;
            // 
            // firstname_textbox
            // 
            this.firstname_textbox.Location = new System.Drawing.Point(112, 16);
            this.firstname_textbox.Multiline = true;
            this.firstname_textbox.Name = "firstname_textbox";
            this.firstname_textbox.Size = new System.Drawing.Size(174, 20);
            this.firstname_textbox.TabIndex = 5;
            // 
            // city_text2
            // 
            this.city_text2.AutoSize = true;
            this.city_text2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.city_text2.Location = new System.Drawing.Point(14, 105);
            this.city_text2.Name = "city_text2";
            this.city_text2.Size = new System.Drawing.Size(43, 20);
            this.city_text2.TabIndex = 4;
            this.city_text2.Text = "City: ";
            // 
            // age_text2
            // 
            this.age_text2.AutoSize = true;
            this.age_text2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.age_text2.Location = new System.Drawing.Point(14, 74);
            this.age_text2.Name = "age_text2";
            this.age_text2.Size = new System.Drawing.Size(46, 20);
            this.age_text2.TabIndex = 2;
            this.age_text2.Text = "Age: ";
            // 
            // lastname_text2
            // 
            this.lastname_text2.AutoSize = true;
            this.lastname_text2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastname_text2.Location = new System.Drawing.Point(14, 45);
            this.lastname_text2.Name = "lastname_text2";
            this.lastname_text2.Size = new System.Drawing.Size(92, 20);
            this.lastname_text2.TabIndex = 1;
            this.lastname_text2.Text = "Last name: ";
            // 
            // firstname_text2
            // 
            this.firstname_text2.AutoSize = true;
            this.firstname_text2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstname_text2.Location = new System.Drawing.Point(14, 16);
            this.firstname_text2.Name = "firstname_text2";
            this.firstname_text2.Size = new System.Drawing.Size(92, 20);
            this.firstname_text2.TabIndex = 0;
            this.firstname_text2.Text = "First name: ";
            // 
            // Change_btn
            // 
            this.Change_btn.BackColor = System.Drawing.Color.Brown;
            this.Change_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Change_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.Change_btn.Location = new System.Drawing.Point(434, 378);
            this.Change_btn.Name = "Change_btn";
            this.Change_btn.Size = new System.Drawing.Size(136, 35);
            this.Change_btn.TabIndex = 12;
            this.Change_btn.Text = "Change";
            this.Change_btn.UseVisualStyleBackColor = false;
            this.Change_btn.Visible = false;
            this.Change_btn.Click += new System.EventHandler(this.Change_btn_Click);
            // 
            // gotit_btn
            // 
            this.gotit_btn.BackColor = System.Drawing.Color.Brown;
            this.gotit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gotit_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.gotit_btn.Location = new System.Drawing.Point(92, 378);
            this.gotit_btn.Name = "gotit_btn";
            this.gotit_btn.Size = new System.Drawing.Size(136, 35);
            this.gotit_btn.TabIndex = 13;
            this.gotit_btn.Text = "Got it";
            this.gotit_btn.UseVisualStyleBackColor = false;
            this.gotit_btn.Visible = false;
            this.gotit_btn.Click += new System.EventHandler(this.gotit_btn_Click);
            // 
            // permission_btn
            // 
            this.permission_btn.BackColor = System.Drawing.Color.Brown;
            this.permission_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.permission_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.permission_btn.Location = new System.Drawing.Point(18, 481);
            this.permission_btn.Name = "permission_btn";
            this.permission_btn.Size = new System.Drawing.Size(214, 38);
            this.permission_btn.TabIndex = 15;
            this.permission_btn.Text = "Send request";
            this.permission_btn.UseVisualStyleBackColor = false;
            // 
            // permission_text
            // 
            this.permission_text.AutoSize = true;
            this.permission_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.permission_text.Location = new System.Drawing.Point(17, 445);
            this.permission_text.Name = "permission_text";
            this.permission_text.Size = new System.Drawing.Size(318, 24);
            this.permission_text.TabIndex = 14;
            this.permission_text.Text = "Send a request to replenish the team";
            // 
            // OfficerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(700, 536);
            this.Controls.Add(this.permission_btn);
            this.Controls.Add(this.permission_text);
            this.Controls.Add(this.gotit_btn);
            this.Controls.Add(this.Change_btn);
            this.Controls.Add(this.Inf_panel_change);
            this.Controls.Add(this.change_inf_btn);
            this.Controls.Add(this.change_inf_text);
            this.Controls.Add(this.Inf_panel);
            this.Controls.Add(this.get_inf_btn);
            this.Controls.Add(this.get_inf_text);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OfficerForm";
            this.Text = "2";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RegisterForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RegisterForm_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Inf_panel.ResumeLayout(false);
            this.Inf_panel.PerformLayout();
            this.Inf_panel_change.ResumeLayout(false);
            this.Inf_panel_change.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label button_exit;
        private System.Windows.Forms.Label TCK_title;
        private System.Windows.Forms.Label get_inf_text;
        private System.Windows.Forms.Button get_inf_btn;
        private System.Windows.Forms.Panel Inf_panel;
        private System.Windows.Forms.Label firstname_text;
        private System.Windows.Forms.Label age_text;
        private System.Windows.Forms.Label lastname_text;
        private System.Windows.Forms.Label city_text;
        private System.Windows.Forms.Label docid_text;
        private System.Windows.Forms.Button change_inf_btn;
        private System.Windows.Forms.Label change_inf_text;
        private System.Windows.Forms.Panel Inf_panel_change;
        private System.Windows.Forms.TextBox city_textbox;
        private System.Windows.Forms.TextBox age_textbox;
        private System.Windows.Forms.TextBox lastname_textbox;
        private System.Windows.Forms.TextBox firstname_textbox;
        private System.Windows.Forms.Label city_text2;
        private System.Windows.Forms.Label age_text2;
        private System.Windows.Forms.Label lastname_text2;
        private System.Windows.Forms.Label firstname_text2;
        private System.Windows.Forms.Button Change_btn;
        private System.Windows.Forms.Button gotit_btn;
        private System.Windows.Forms.Button permission_btn;
        private System.Windows.Forms.Label permission_text;
    }
}

