namespace reservepp
{
    partial class ConscriptForm
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
            this.Login_title = new System.Windows.Forms.Label();
            this.get_inf_btn = new System.Windows.Forms.Button();
            this.Inf_panel = new System.Windows.Forms.Panel();
            this.city_text = new System.Windows.Forms.Label();
            this.docid_text = new System.Windows.Forms.Label();
            this.age_text = new System.Windows.Forms.Label();
            this.lastname_text = new System.Windows.Forms.Label();
            this.firstname_text = new System.Windows.Forms.Label();
            this.change_inf_btn = new System.Windows.Forms.Button();
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
            this.run_btn = new System.Windows.Forms.Button();
            this.run_text = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.Inf_panel.SuspendLayout();
            this.Inf_panel_change.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.button_exit);
            this.panel1.Controls.Add(this.Login_title);
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
            // Login_title
            // 
            this.Login_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login_title.ForeColor = System.Drawing.Color.Bisque;
            this.Login_title.Location = new System.Drawing.Point(12, 18);
            this.Login_title.Name = "Login_title";
            this.Login_title.Size = new System.Drawing.Size(286, 38);
            this.Login_title.TabIndex = 0;
            this.Login_title.Text = "Conscript interface";
            // 
            // get_inf_btn
            // 
            this.get_inf_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.get_inf_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.get_inf_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.get_inf_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.get_inf_btn.ForeColor = System.Drawing.Color.Bisque;
            this.get_inf_btn.Location = new System.Drawing.Point(18, 92);
            this.get_inf_btn.Name = "get_inf_btn";
            this.get_inf_btn.Size = new System.Drawing.Size(277, 38);
            this.get_inf_btn.TabIndex = 7;
            this.get_inf_btn.Text = "Get all information";
            this.get_inf_btn.UseVisualStyleBackColor = false;
            // 
            // Inf_panel
            // 
            this.Inf_panel.BackColor = System.Drawing.Color.BurlyWood;
            this.Inf_panel.Controls.Add(this.city_text);
            this.Inf_panel.Controls.Add(this.docid_text);
            this.Inf_panel.Controls.Add(this.age_text);
            this.Inf_panel.Controls.Add(this.lastname_text);
            this.Inf_panel.Controls.Add(this.firstname_text);
            this.Inf_panel.Location = new System.Drawing.Point(18, 147);
            this.Inf_panel.Name = "Inf_panel";
            this.Inf_panel.Size = new System.Drawing.Size(277, 174);
            this.Inf_panel.TabIndex = 8;
            // 
            // city_text
            // 
            this.city_text.AutoSize = true;
            this.city_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.city_text.ForeColor = System.Drawing.Color.SaddleBrown;
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
            this.docid_text.ForeColor = System.Drawing.Color.SaddleBrown;
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
            this.age_text.ForeColor = System.Drawing.Color.SaddleBrown;
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
            this.lastname_text.ForeColor = System.Drawing.Color.SaddleBrown;
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
            this.firstname_text.ForeColor = System.Drawing.Color.SaddleBrown;
            this.firstname_text.Location = new System.Drawing.Point(14, 16);
            this.firstname_text.Name = "firstname_text";
            this.firstname_text.Size = new System.Drawing.Size(92, 20);
            this.firstname_text.TabIndex = 0;
            this.firstname_text.Text = "First name: ";
            // 
            // change_inf_btn
            // 
            this.change_inf_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.change_inf_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.change_inf_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.change_inf_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.change_inf_btn.ForeColor = System.Drawing.Color.Bisque;
            this.change_inf_btn.Location = new System.Drawing.Point(352, 92);
            this.change_inf_btn.Name = "change_inf_btn";
            this.change_inf_btn.Size = new System.Drawing.Size(306, 38);
            this.change_inf_btn.TabIndex = 10;
            this.change_inf_btn.Text = "Change information";
            this.change_inf_btn.UseVisualStyleBackColor = false;
            // 
            // Inf_panel_change
            // 
            this.Inf_panel_change.BackColor = System.Drawing.Color.BurlyWood;
            this.Inf_panel_change.Controls.Add(this.city_textbox);
            this.Inf_panel_change.Controls.Add(this.age_textbox);
            this.Inf_panel_change.Controls.Add(this.lastname_textbox);
            this.Inf_panel_change.Controls.Add(this.firstname_textbox);
            this.Inf_panel_change.Controls.Add(this.city_text2);
            this.Inf_panel_change.Controls.Add(this.age_text2);
            this.Inf_panel_change.Controls.Add(this.lastname_text2);
            this.Inf_panel_change.Controls.Add(this.firstname_text2);
            this.Inf_panel_change.Location = new System.Drawing.Point(352, 147);
            this.Inf_panel_change.Name = "Inf_panel_change";
            this.Inf_panel_change.Size = new System.Drawing.Size(306, 174);
            this.Inf_panel_change.TabIndex = 11;
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
            this.city_text2.ForeColor = System.Drawing.Color.SaddleBrown;
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
            this.age_text2.ForeColor = System.Drawing.Color.SaddleBrown;
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
            this.lastname_text2.ForeColor = System.Drawing.Color.SaddleBrown;
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
            this.firstname_text2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.firstname_text2.Location = new System.Drawing.Point(14, 16);
            this.firstname_text2.Name = "firstname_text2";
            this.firstname_text2.Size = new System.Drawing.Size(92, 20);
            this.firstname_text2.TabIndex = 0;
            this.firstname_text2.Text = "First name: ";
            // 
            // Change_btn
            // 
            this.Change_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Change_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Change_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Change_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Change_btn.ForeColor = System.Drawing.Color.Bisque;
            this.Change_btn.Location = new System.Drawing.Point(431, 338);
            this.Change_btn.Name = "Change_btn";
            this.Change_btn.Size = new System.Drawing.Size(136, 35);
            this.Change_btn.TabIndex = 12;
            this.Change_btn.Text = "Change";
            this.Change_btn.UseVisualStyleBackColor = false;
            this.Change_btn.Click += new System.EventHandler(this.Change_btn_Click);
            // 
            // run_btn
            // 
            this.run_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.run_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.run_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.run_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.run_btn.ForeColor = System.Drawing.Color.Bisque;
            this.run_btn.Location = new System.Drawing.Point(206, 400);
            this.run_btn.Name = "run_btn";
            this.run_btn.Size = new System.Drawing.Size(277, 38);
            this.run_btn.TabIndex = 14;
            this.run_btn.Text = "Run, run for your life!!!";
            this.run_btn.UseVisualStyleBackColor = false;
            this.run_btn.Click += new System.EventHandler(this.run_btn_Click);
            // 
            // run_text
            // 
            this.run_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.run_text.Location = new System.Drawing.Point(239, 453);
            this.run_text.Name = "run_text";
            this.run_text.Size = new System.Drawing.Size(221, 51);
            this.run_text.TabIndex = 15;
            this.run_text.Text = " ";
            this.run_text.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ConscriptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(700, 525);
            this.Controls.Add(this.run_text);
            this.Controls.Add(this.run_btn);
            this.Controls.Add(this.Change_btn);
            this.Controls.Add(this.Inf_panel_change);
            this.Controls.Add(this.change_inf_btn);
            this.Controls.Add(this.Inf_panel);
            this.Controls.Add(this.get_inf_btn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConscriptForm";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RegisterForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RegisterForm_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Inf_panel.ResumeLayout(false);
            this.Inf_panel.PerformLayout();
            this.Inf_panel_change.ResumeLayout(false);
            this.Inf_panel_change.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label button_exit;
        private System.Windows.Forms.Label Login_title;
        private System.Windows.Forms.Button get_inf_btn;
        private System.Windows.Forms.Panel Inf_panel;
        private System.Windows.Forms.Label firstname_text;
        private System.Windows.Forms.Label age_text;
        private System.Windows.Forms.Label lastname_text;
        private System.Windows.Forms.Label city_text;
        private System.Windows.Forms.Label docid_text;
        private System.Windows.Forms.Button change_inf_btn;
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
        private System.Windows.Forms.Button run_btn;
        private System.Windows.Forms.Label run_text;
    }
}

