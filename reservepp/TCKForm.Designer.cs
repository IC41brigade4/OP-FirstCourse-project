namespace reservepp
{
    partial class TCKForm
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
            panel1 = new Panel();
            button_exit = new Label();
            TCK_title = new Label();
            get_inf_text = new Label();
            get_inf_btn = new Button();
            Inf_panel = new Panel();
            city_text = new Label();
            docid_text = new Label();
            age_text = new Label();
            lastname_text = new Label();
            firstname_text = new Label();
            change_inf_btn = new Button();
            change_inf_text = new Label();
            Inf_panel_change = new Panel();
            city_textbox = new TextBox();
            age_textbox = new TextBox();
            lastname_textbox = new TextBox();
            firstname_textbox = new TextBox();
            city_text2 = new Label();
            age_text2 = new Label();
            lastname_text2 = new Label();
            firstname_text2 = new Label();
            Change_btn = new Button();
            permission_btn = new Button();
            permission_text = new Label();
            panel2 = new Panel();
            Text_for_permision = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            panel1.SuspendLayout();
            Inf_panel.SuspendLayout();
            Inf_panel_change.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 64, 0);
            panel1.Controls.Add(button_exit);
            panel1.Controls.Add(TCK_title);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(933, 109);
            panel1.TabIndex = 0;
            // 
            // button_exit
            // 
            button_exit.AutoSize = true;
            button_exit.Cursor = Cursors.Hand;
            button_exit.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button_exit.ForeColor = SystemColors.Control;
            button_exit.Location = new Point(883, 14);
            button_exit.Margin = new Padding(4, 0, 4, 0);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(32, 31);
            button_exit.TabIndex = 1;
            button_exit.Text = "X";
            button_exit.MouseClick += label2_MouseClick;
            // 
            // TCK_title
            // 
            TCK_title.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            TCK_title.ForeColor = Color.Bisque;
            TCK_title.Location = new Point(16, 28);
            TCK_title.Margin = new Padding(4, 0, 4, 0);
            TCK_title.Name = "TCK_title";
            TCK_title.Size = new Size(381, 58);
            TCK_title.TabIndex = 0;
            TCK_title.Text = "TCK employee";
            // 
            // get_inf_text
            // 
            get_inf_text.AutoSize = true;
            get_inf_text.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            get_inf_text.ForeColor = Color.SaddleBrown;
            get_inf_text.Location = new Point(23, 148);
            get_inf_text.Margin = new Padding(4, 0, 4, 0);
            get_inf_text.Name = "get_inf_text";
            get_inf_text.Size = new Size(363, 29);
            get_inf_text.TabIndex = 6;
            get_inf_text.Text = "Get all information about yourself";
            // 
            // get_inf_btn
            // 
            get_inf_btn.BackColor = Color.FromArgb(192, 64, 0);
            get_inf_btn.FlatStyle = FlatStyle.Flat;
            get_inf_btn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            get_inf_btn.ForeColor = Color.Bisque;
            get_inf_btn.Location = new Point(28, 203);
            get_inf_btn.Margin = new Padding(4, 5, 4, 5);
            get_inf_btn.Name = "get_inf_btn";
            get_inf_btn.Size = new Size(369, 58);
            get_inf_btn.TabIndex = 7;
            get_inf_btn.Text = "Get all information";
            get_inf_btn.UseVisualStyleBackColor = false;
            // 
            // Inf_panel
            // 
            Inf_panel.BackColor = Color.BurlyWood;
            Inf_panel.Controls.Add(city_text);
            Inf_panel.Controls.Add(docid_text);
            Inf_panel.Controls.Add(age_text);
            Inf_panel.Controls.Add(lastname_text);
            Inf_panel.Controls.Add(firstname_text);
            Inf_panel.Location = new Point(28, 288);
            Inf_panel.Margin = new Padding(4, 5, 4, 5);
            Inf_panel.Name = "Inf_panel";
            Inf_panel.Size = new Size(369, 268);
            Inf_panel.TabIndex = 8;
            // 
            // city_text
            // 
            city_text.AutoSize = true;
            city_text.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            city_text.ForeColor = Color.SaddleBrown;
            city_text.Location = new Point(19, 206);
            city_text.Margin = new Padding(4, 0, 4, 0);
            city_text.Name = "city_text";
            city_text.Size = new Size(57, 25);
            city_text.TabIndex = 4;
            city_text.Text = "City: ";
            // 
            // docid_text
            // 
            docid_text.AutoSize = true;
            docid_text.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            docid_text.ForeColor = Color.SaddleBrown;
            docid_text.Location = new Point(19, 162);
            docid_text.Margin = new Padding(4, 0, 4, 0);
            docid_text.Name = "docid_text";
            docid_text.Size = new Size(74, 25);
            docid_text.TabIndex = 3;
            docid_text.Text = "DocId: ";
            // 
            // age_text
            // 
            age_text.AutoSize = true;
            age_text.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            age_text.ForeColor = Color.SaddleBrown;
            age_text.Location = new Point(19, 114);
            age_text.Margin = new Padding(4, 0, 4, 0);
            age_text.Name = "age_text";
            age_text.Size = new Size(59, 25);
            age_text.TabIndex = 2;
            age_text.Text = "Age: ";
            // 
            // lastname_text
            // 
            lastname_text.AutoSize = true;
            lastname_text.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lastname_text.ForeColor = Color.SaddleBrown;
            lastname_text.Location = new Point(19, 69);
            lastname_text.Margin = new Padding(4, 0, 4, 0);
            lastname_text.Name = "lastname_text";
            lastname_text.Size = new Size(114, 25);
            lastname_text.TabIndex = 1;
            lastname_text.Text = "Last name: ";
            // 
            // firstname_text
            // 
            firstname_text.AutoSize = true;
            firstname_text.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            firstname_text.ForeColor = Color.SaddleBrown;
            firstname_text.Location = new Point(19, 25);
            firstname_text.Margin = new Padding(4, 0, 4, 0);
            firstname_text.Name = "firstname_text";
            firstname_text.Size = new Size(114, 25);
            firstname_text.TabIndex = 0;
            firstname_text.Text = "First name: ";
            // 
            // change_inf_btn
            // 
            change_inf_btn.BackColor = Color.FromArgb(192, 64, 0);
            change_inf_btn.FlatStyle = FlatStyle.Flat;
            change_inf_btn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            change_inf_btn.ForeColor = Color.Bisque;
            change_inf_btn.Location = new Point(473, 203);
            change_inf_btn.Margin = new Padding(4, 5, 4, 5);
            change_inf_btn.Name = "change_inf_btn";
            change_inf_btn.Size = new Size(408, 58);
            change_inf_btn.TabIndex = 10;
            change_inf_btn.Text = "Change information";
            change_inf_btn.UseVisualStyleBackColor = false;
            change_inf_btn.Click += change_inf_btn_Click;
            // 
            // change_inf_text
            // 
            change_inf_text.AutoSize = true;
            change_inf_text.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            change_inf_text.ForeColor = Color.SaddleBrown;
            change_inf_text.Location = new Point(551, 148);
            change_inf_text.Margin = new Padding(4, 0, 4, 0);
            change_inf_text.Name = "change_inf_text";
            change_inf_text.Size = new Size(222, 29);
            change_inf_text.TabIndex = 9;
            change_inf_text.Text = "Change information";
            // 
            // Inf_panel_change
            // 
            Inf_panel_change.BackColor = Color.BurlyWood;
            Inf_panel_change.Controls.Add(city_textbox);
            Inf_panel_change.Controls.Add(age_textbox);
            Inf_panel_change.Controls.Add(lastname_textbox);
            Inf_panel_change.Controls.Add(firstname_textbox);
            Inf_panel_change.Controls.Add(city_text2);
            Inf_panel_change.Controls.Add(age_text2);
            Inf_panel_change.Controls.Add(lastname_text2);
            Inf_panel_change.Controls.Add(firstname_text2);
            Inf_panel_change.Location = new Point(473, 288);
            Inf_panel_change.Margin = new Padding(4, 5, 4, 5);
            Inf_panel_change.Name = "Inf_panel_change";
            Inf_panel_change.Size = new Size(408, 268);
            Inf_panel_change.TabIndex = 11;
            // 
            // city_textbox
            // 
            city_textbox.BorderStyle = BorderStyle.None;
            city_textbox.Location = new Point(149, 165);
            city_textbox.Margin = new Padding(4, 5, 4, 5);
            city_textbox.Multiline = true;
            city_textbox.Name = "city_textbox";
            city_textbox.Size = new Size(232, 31);
            city_textbox.TabIndex = 8;
            // 
            // age_textbox
            // 
            age_textbox.BorderStyle = BorderStyle.None;
            age_textbox.Location = new Point(149, 117);
            age_textbox.Margin = new Padding(4, 5, 4, 5);
            age_textbox.Multiline = true;
            age_textbox.Name = "age_textbox";
            age_textbox.Size = new Size(232, 31);
            age_textbox.TabIndex = 7;
            // 
            // lastname_textbox
            // 
            lastname_textbox.BorderStyle = BorderStyle.None;
            lastname_textbox.Location = new Point(149, 72);
            lastname_textbox.Margin = new Padding(4, 5, 4, 5);
            lastname_textbox.Multiline = true;
            lastname_textbox.Name = "lastname_textbox";
            lastname_textbox.Size = new Size(232, 31);
            lastname_textbox.TabIndex = 6;
            // 
            // firstname_textbox
            // 
            firstname_textbox.BorderStyle = BorderStyle.None;
            firstname_textbox.Location = new Point(149, 25);
            firstname_textbox.Margin = new Padding(4, 5, 4, 5);
            firstname_textbox.Multiline = true;
            firstname_textbox.Name = "firstname_textbox";
            firstname_textbox.Size = new Size(232, 31);
            firstname_textbox.TabIndex = 5;
            // 
            // city_text2
            // 
            city_text2.AutoSize = true;
            city_text2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            city_text2.ForeColor = Color.SaddleBrown;
            city_text2.Location = new Point(19, 162);
            city_text2.Margin = new Padding(4, 0, 4, 0);
            city_text2.Name = "city_text2";
            city_text2.Size = new Size(57, 25);
            city_text2.TabIndex = 4;
            city_text2.Text = "City: ";
            // 
            // age_text2
            // 
            age_text2.AutoSize = true;
            age_text2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            age_text2.ForeColor = Color.SaddleBrown;
            age_text2.Location = new Point(19, 114);
            age_text2.Margin = new Padding(4, 0, 4, 0);
            age_text2.Name = "age_text2";
            age_text2.Size = new Size(59, 25);
            age_text2.TabIndex = 2;
            age_text2.Text = "Age: ";
            // 
            // lastname_text2
            // 
            lastname_text2.AutoSize = true;
            lastname_text2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lastname_text2.ForeColor = Color.SaddleBrown;
            lastname_text2.Location = new Point(19, 69);
            lastname_text2.Margin = new Padding(4, 0, 4, 0);
            lastname_text2.Name = "lastname_text2";
            lastname_text2.Size = new Size(114, 25);
            lastname_text2.TabIndex = 1;
            lastname_text2.Text = "Last name: ";
            // 
            // firstname_text2
            // 
            firstname_text2.AutoSize = true;
            firstname_text2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            firstname_text2.ForeColor = Color.SaddleBrown;
            firstname_text2.Location = new Point(19, 25);
            firstname_text2.Margin = new Padding(4, 0, 4, 0);
            firstname_text2.Name = "firstname_text2";
            firstname_text2.Size = new Size(114, 25);
            firstname_text2.TabIndex = 0;
            firstname_text2.Text = "First name: ";
            // 
            // Change_btn
            // 
            Change_btn.BackColor = Color.FromArgb(192, 64, 0);
            Change_btn.FlatStyle = FlatStyle.Flat;
            Change_btn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Change_btn.ForeColor = Color.Bisque;
            Change_btn.Location = new Point(579, 582);
            Change_btn.Margin = new Padding(4, 5, 4, 5);
            Change_btn.Name = "Change_btn";
            Change_btn.Size = new Size(181, 54);
            Change_btn.TabIndex = 12;
            Change_btn.Text = "Change";
            Change_btn.UseVisualStyleBackColor = false;
            Change_btn.Click += Change_btn_Click;
            // 
            // permission_btn
            // 
            permission_btn.BackColor = Color.FromArgb(192, 64, 0);
            permission_btn.FlatStyle = FlatStyle.Flat;
            permission_btn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            permission_btn.ForeColor = Color.Bisque;
            permission_btn.Location = new Point(249, 918);
            permission_btn.Margin = new Padding(4, 5, 4, 5);
            permission_btn.Name = "permission_btn";
            permission_btn.Size = new Size(225, 58);
            permission_btn.TabIndex = 15;
            permission_btn.Text = "Send permission";
            permission_btn.UseVisualStyleBackColor = false;
            permission_btn.Click += permission_btn_Click;
            // 
            // permission_text
            // 
            permission_text.AutoSize = true;
            permission_text.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            permission_text.ForeColor = Color.SaddleBrown;
            permission_text.Location = new Point(23, 685);
            permission_text.Margin = new Padding(4, 0, 4, 0);
            permission_text.Name = "permission_text";
            permission_text.Size = new Size(455, 29);
            permission_text.TabIndex = 14;
            permission_text.Text = "Send permission to replenish the brigade";
            // 
            // panel2
            // 
            panel2.BackColor = Color.BurlyWood;
            panel2.Controls.Add(Text_for_permision);
            panel2.Location = new Point(24, 740);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(857, 163);
            panel2.TabIndex = 9;
            // 
            // Text_for_permision
            // 
            Text_for_permision.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Text_for_permision.ForeColor = Color.SaddleBrown;
            Text_for_permision.Location = new Point(21, 18);
            Text_for_permision.Margin = new Padding(4, 0, 4, 0);
            Text_for_permision.Name = "Text_for_permision";
            Text_for_permision.Size = new Size(809, 117);
            Text_for_permision.TabIndex = 5;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.Location = new Point(45, 929);
            radioButton1.Margin = new Padding(4, 5, 4, 5);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(83, 28);
            radioButton1.TabIndex = 17;
            radioButton1.TabStop = true;
            radioButton1.Text = "Agree";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.Location = new Point(139, 931);
            radioButton2.Margin = new Padding(4, 5, 4, 5);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(96, 28);
            radioButton2.TabIndex = 18;
            radioButton2.TabStop = true;
            radioButton2.Text = "Disgree";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // TCKForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(933, 1002);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(panel2);
            Controls.Add(permission_btn);
            Controls.Add(permission_text);
            Controls.Add(Change_btn);
            Controls.Add(Inf_panel_change);
            Controls.Add(change_inf_btn);
            Controls.Add(change_inf_text);
            Controls.Add(Inf_panel);
            Controls.Add(get_inf_btn);
            Controls.Add(get_inf_text);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "TCKForm";
            Text = "2";
            MouseDown += RegisterForm_MouseDown;
            MouseMove += RegisterForm_MouseMove;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            Inf_panel.ResumeLayout(false);
            Inf_panel.PerformLayout();
            Inf_panel_change.ResumeLayout(false);
            Inf_panel_change.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label button_exit;
        private Label TCK_title;
        private Label get_inf_text;
        private Button get_inf_btn;
        private Panel Inf_panel;
        private Label firstname_text;
        private Label age_text;
        private Label lastname_text;
        private Label city_text;
        private Label docid_text;
        private Button change_inf_btn;
        private Label change_inf_text;
        private Panel Inf_panel_change;
        private TextBox city_textbox;
        private TextBox age_textbox;
        private TextBox lastname_textbox;
        private TextBox firstname_textbox;
        private Label city_text2;
        private Label age_text2;
        private Label lastname_text2;
        private Label firstname_text2;
        private Button Change_btn;
        private Button permission_btn;
        private Label permission_text;
        private Panel panel2;
        private Label Text_for_permision;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
    }
}

