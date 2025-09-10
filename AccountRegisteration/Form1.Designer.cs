namespace AccountRegisteration
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
            this.label1 = new System.Windows.Forms.Label();
            this.StudentNo = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.MiddleName = new System.Windows.Forms.TextBox();
            this.StudentContact = new System.Windows.Forms.TextBox();
            this.StudentAge = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.ComboBox();
            this.Program = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Miriam CLM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(52, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "STUDENT NO.";
            // 
            // StudentNo
            // 
            this.StudentNo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.StudentNo.Location = new System.Drawing.Point(161, 94);
            this.StudentNo.Name = "StudentNo";
            this.StudentNo.Size = new System.Drawing.Size(176, 20);
            this.StudentNo.TabIndex = 4;
            this.StudentNo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LastName
            // 
            this.LastName.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.LastName.Location = new System.Drawing.Point(161, 158);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(176, 20);
            this.LastName.TabIndex = 6;
            // 
            // FirstName
            // 
            this.FirstName.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.FirstName.Location = new System.Drawing.Point(533, 158);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(147, 20);
            this.FirstName.TabIndex = 7;
            // 
            // MiddleName
            // 
            this.MiddleName.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.MiddleName.Location = new System.Drawing.Point(533, 222);
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.Size = new System.Drawing.Size(147, 20);
            this.MiddleName.TabIndex = 9;
            this.MiddleName.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // StudentContact
            // 
            this.StudentContact.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.StudentContact.Location = new System.Drawing.Point(533, 284);
            this.StudentContact.Name = "StudentContact";
            this.StudentContact.Size = new System.Drawing.Size(147, 20);
            this.StudentContact.TabIndex = 12;
            // 
            // StudentAge
            // 
            this.StudentAge.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.StudentAge.Location = new System.Drawing.Point(206, 220);
            this.StudentAge.Name = "StudentAge";
            this.StudentAge.Size = new System.Drawing.Size(78, 20);
            this.StudentAge.TabIndex = 13;
            this.StudentAge.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(282, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(215, 30);
            this.label9.TabIndex = 16;
            this.label9.Text = "REGISTRATION";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Miriam CLM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label10.Location = new System.Drawing.Point(63, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "LASTNAME :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Miriam CLM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(103, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "AGE :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Miriam CLM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(437, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "PROGRAM :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Miriam CLM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(430, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "FIRSTNAME :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Miriam CLM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(417, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "MIDDLENAME :";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Miriam CLM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(420, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "CONTACT NO :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Miriam CLM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(75, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "GENDER :";
            // 
            // Gender
            // 
            this.Gender.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Gender.FormattingEnabled = true;
            this.Gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.Gender.Location = new System.Drawing.Point(184, 270);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(119, 21);
            this.Gender.TabIndex = 24;
            // 
            // Program
            // 
            this.Program.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Program.FormattingEnabled = true;
            this.Program.Location = new System.Drawing.Point(550, 93);
            this.Program.Name = "Program";
            this.Program.Size = new System.Drawing.Size(119, 21);
            this.Program.TabIndex = 25;
            this.Program.SelectedIndexChanged += new System.EventHandler(this.Program_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Miriam CLM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label11.Location = new System.Drawing.Point(75, 324);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 17);
            this.label11.TabIndex = 26;
            this.label11.Text = "BIRTHDAY :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(161, 324);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(219, 20);
            this.dateTimePicker1.TabIndex = 28;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Liberation Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(308, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 38);
            this.button2.TabIndex = 30;
            this.button2.Text = "Register";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Program);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.StudentAge);
            this.Controls.Add(this.StudentContact);
            this.Controls.Add(this.MiddleName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.StudentNo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox StudentNo;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox MiddleName;
        private System.Windows.Forms.TextBox StudentContact;
        private System.Windows.Forms.TextBox StudentAge;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Gender;
        private System.Windows.Forms.ComboBox Program;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button2;
    }
}

