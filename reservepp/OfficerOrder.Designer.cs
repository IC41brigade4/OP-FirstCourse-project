namespace reservepp
{
    partial class OfficerOrder
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
            this.button_exit = new System.Windows.Forms.Label();
            this.TCK_title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.permission_btn = new System.Windows.Forms.Button();
            this.permission_text = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_exit
            // 
            this.button_exit.AutoSize = true;
            this.button_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_exit.ForeColor = System.Drawing.Color.Bisque;
            this.button_exit.Location = new System.Drawing.Point(543, 9);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(26, 25);
            this.button_exit.TabIndex = 1;
            this.button_exit.Text = "X";
            // 
            // TCK_title
            // 
            this.TCK_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TCK_title.ForeColor = System.Drawing.Color.Bisque;
            this.TCK_title.Location = new System.Drawing.Point(16, 19);
            this.TCK_title.Name = "TCK_title";
            this.TCK_title.Size = new System.Drawing.Size(197, 38);
            this.TCK_title.TabIndex = 0;
            this.TCK_title.Text = "Officer order";
            this.TCK_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.button_exit);
            this.panel1.Controls.Add(this.TCK_title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(593, 71);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(18, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 24);
            this.label2.TabIndex = 28;
            this.label2.Text = "Деталі замовлення";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(22, 262);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 38);
            this.textBox1.TabIndex = 26;
            this.textBox1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.HideSelection = false;
            this.textBox2.Location = new System.Drawing.Point(22, 112);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(547, 112);
            this.textBox2.TabIndex = 27;
            this.textBox2.Visible = false;
            // 
            // permission_btn
            // 
            this.permission_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.permission_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.permission_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.permission_btn.ForeColor = System.Drawing.Color.Bisque;
            this.permission_btn.Location = new System.Drawing.Point(23, 324);
            this.permission_btn.Name = "permission_btn";
            this.permission_btn.Size = new System.Drawing.Size(214, 38);
            this.permission_btn.TabIndex = 25;
            this.permission_btn.Text = "Надіслати запит до ТЦК";
            this.permission_btn.UseVisualStyleBackColor = false;
            this.permission_btn.Click += new System.EventHandler(this.permission_btn_Click);
            // 
            // permission_text
            // 
            this.permission_text.AutoSize = true;
            this.permission_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.permission_text.ForeColor = System.Drawing.Color.SaddleBrown;
            this.permission_text.Location = new System.Drawing.Point(19, 235);
            this.permission_text.Name = "permission_text";
            this.permission_text.Size = new System.Drawing.Size(154, 24);
            this.permission_text.TabIndex = 24;
            this.permission_text.Text = "Кількість людей";
            // 
            // OfficerOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(593, 384);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.permission_btn);
            this.Controls.Add(this.permission_text);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OfficerOrder";
            this.Text = "OfficerOrder";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OfficerOrderForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OfficerOrderForm_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label button_exit;
        private System.Windows.Forms.Label TCK_title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button permission_btn;
        private System.Windows.Forms.Label permission_text;
    }
}