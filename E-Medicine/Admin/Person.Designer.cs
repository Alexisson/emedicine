namespace E_Medicine
{
    partial class CreatePerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePerson));
            this.LabelLastName = new System.Windows.Forms.Label();
            this.PanelPersonal = new System.Windows.Forms.Panel();
            this.TextIIN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BirthdaySet = new System.Windows.Forms.DateTimePicker();
            this.LabelBirthday = new System.Windows.Forms.Label();
            this.LabelSex = new System.Windows.Forms.Label();
            this.LabelFirstName = new System.Windows.Forms.Label();
            this.LabelPatronymic = new System.Windows.Forms.Label();
            this.SexSet = new System.Windows.Forms.ComboBox();
            this.TextPatronymic = new System.Windows.Forms.TextBox();
            this.TextFirstName = new System.Windows.Forms.TextBox();
            this.TextLastName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TextRepPassword = new System.Windows.Forms.TextBox();
            this.LabelEmail = new System.Windows.Forms.Label();
            this.LabelRepPassword = new System.Windows.Forms.Label();
            this.LabelPhone = new System.Windows.Forms.Label();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.TextPassword = new System.Windows.Forms.TextBox();
            this.TextPhone = new System.Windows.Forms.TextBox();
            this.TextEmail = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.PanelPersonal.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelLastName
            // 
            this.LabelLastName.AutoSize = true;
            this.LabelLastName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelLastName.Location = new System.Drawing.Point(15, 17);
            this.LabelLastName.Name = "LabelLastName";
            this.LabelLastName.Size = new System.Drawing.Size(100, 30);
            this.LabelLastName.TabIndex = 0;
            this.LabelLastName.Text = "Фамилия";
            // 
            // PanelPersonal
            // 
            this.PanelPersonal.Controls.Add(this.TextIIN);
            this.PanelPersonal.Controls.Add(this.label1);
            this.PanelPersonal.Controls.Add(this.BirthdaySet);
            this.PanelPersonal.Controls.Add(this.LabelBirthday);
            this.PanelPersonal.Controls.Add(this.LabelLastName);
            this.PanelPersonal.Controls.Add(this.LabelSex);
            this.PanelPersonal.Controls.Add(this.LabelFirstName);
            this.PanelPersonal.Controls.Add(this.LabelPatronymic);
            this.PanelPersonal.Controls.Add(this.SexSet);
            this.PanelPersonal.Controls.Add(this.TextPatronymic);
            this.PanelPersonal.Controls.Add(this.TextFirstName);
            this.PanelPersonal.Controls.Add(this.TextLastName);
            this.PanelPersonal.Location = new System.Drawing.Point(12, 12);
            this.PanelPersonal.Name = "PanelPersonal";
            this.PanelPersonal.Size = new System.Drawing.Size(483, 261);
            this.PanelPersonal.TabIndex = 1;
            // 
            // TextIIN
            // 
            this.TextIIN.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextIIN.Location = new System.Drawing.Point(196, 216);
            this.TextIIN.MaxLength = 12;
            this.TextIIN.Name = "TextIIN";
            this.TextIIN.Size = new System.Drawing.Size(274, 33);
            this.TextIIN.TabIndex = 11;
            this.TextIIN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckDigit);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "ИИН";
            // 
            // BirthdaySet
            // 
            this.BirthdaySet.CustomFormat = "yyyy.MM.dd";
            this.BirthdaySet.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BirthdaySet.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.BirthdaySet.Location = new System.Drawing.Point(196, 175);
            this.BirthdaySet.MaxDate = new System.DateTime(2100, 4, 25, 0, 0, 0, 0);
            this.BirthdaySet.Name = "BirthdaySet";
            this.BirthdaySet.Size = new System.Drawing.Size(274, 35);
            this.BirthdaySet.TabIndex = 9;
            this.BirthdaySet.Value = new System.DateTime(2019, 4, 25, 0, 0, 0, 0);
            // 
            // LabelBirthday
            // 
            this.LabelBirthday.AutoSize = true;
            this.LabelBirthday.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelBirthday.Location = new System.Drawing.Point(15, 180);
            this.LabelBirthday.Name = "LabelBirthday";
            this.LabelBirthday.Size = new System.Drawing.Size(162, 30);
            this.LabelBirthday.TabIndex = 4;
            this.LabelBirthday.Text = "Дата рождения";
            // 
            // LabelSex
            // 
            this.LabelSex.AutoSize = true;
            this.LabelSex.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelSex.Location = new System.Drawing.Point(15, 139);
            this.LabelSex.Name = "LabelSex";
            this.LabelSex.Size = new System.Drawing.Size(51, 30);
            this.LabelSex.TabIndex = 3;
            this.LabelSex.Text = "Пол";
            // 
            // LabelFirstName
            // 
            this.LabelFirstName.AutoSize = true;
            this.LabelFirstName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelFirstName.Location = new System.Drawing.Point(15, 56);
            this.LabelFirstName.Name = "LabelFirstName";
            this.LabelFirstName.Size = new System.Drawing.Size(55, 30);
            this.LabelFirstName.TabIndex = 1;
            this.LabelFirstName.Text = "Имя";
            // 
            // LabelPatronymic
            // 
            this.LabelPatronymic.AutoSize = true;
            this.LabelPatronymic.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPatronymic.Location = new System.Drawing.Point(15, 95);
            this.LabelPatronymic.Name = "LabelPatronymic";
            this.LabelPatronymic.Size = new System.Drawing.Size(103, 30);
            this.LabelPatronymic.TabIndex = 2;
            this.LabelPatronymic.Text = "Отчество";
            // 
            // SexSet
            // 
            this.SexSet.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SexSet.FormattingEnabled = true;
            this.SexSet.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.SexSet.Location = new System.Drawing.Point(196, 131);
            this.SexSet.Name = "SexSet";
            this.SexSet.Size = new System.Drawing.Size(274, 38);
            this.SexSet.TabIndex = 8;
            // 
            // TextPatronymic
            // 
            this.TextPatronymic.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextPatronymic.Location = new System.Drawing.Point(196, 92);
            this.TextPatronymic.MaxLength = 45;
            this.TextPatronymic.Name = "TextPatronymic";
            this.TextPatronymic.Size = new System.Drawing.Size(274, 33);
            this.TextPatronymic.TabIndex = 7;
            // 
            // TextFirstName
            // 
            this.TextFirstName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextFirstName.Location = new System.Drawing.Point(196, 53);
            this.TextFirstName.MaxLength = 45;
            this.TextFirstName.Name = "TextFirstName";
            this.TextFirstName.Size = new System.Drawing.Size(274, 33);
            this.TextFirstName.TabIndex = 6;
            // 
            // TextLastName
            // 
            this.TextLastName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextLastName.Location = new System.Drawing.Point(196, 14);
            this.TextLastName.MaxLength = 45;
            this.TextLastName.Name = "TextLastName";
            this.TextLastName.Size = new System.Drawing.Size(274, 33);
            this.TextLastName.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TextRepPassword);
            this.panel1.Controls.Add(this.LabelEmail);
            this.panel1.Controls.Add(this.LabelRepPassword);
            this.panel1.Controls.Add(this.LabelPhone);
            this.panel1.Controls.Add(this.LabelPassword);
            this.panel1.Controls.Add(this.TextPassword);
            this.panel1.Controls.Add(this.TextPhone);
            this.panel1.Controls.Add(this.TextEmail);
            this.panel1.Location = new System.Drawing.Point(12, 279);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 197);
            this.panel1.TabIndex = 11;
            // 
            // TextRepPassword
            // 
            this.TextRepPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextRepPassword.Location = new System.Drawing.Point(224, 131);
            this.TextRepPassword.MaxLength = 16;
            this.TextRepPassword.Name = "TextRepPassword";
            this.TextRepPassword.PasswordChar = '*';
            this.TextRepPassword.Size = new System.Drawing.Size(246, 33);
            this.TextRepPassword.TabIndex = 8;
            // 
            // LabelEmail
            // 
            this.LabelEmail.AutoSize = true;
            this.LabelEmail.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelEmail.Location = new System.Drawing.Point(15, 17);
            this.LabelEmail.Name = "LabelEmail";
            this.LabelEmail.Size = new System.Drawing.Size(72, 30);
            this.LabelEmail.TabIndex = 0;
            this.LabelEmail.Text = "E-Mail";
            // 
            // LabelRepPassword
            // 
            this.LabelRepPassword.AutoSize = true;
            this.LabelRepPassword.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelRepPassword.Location = new System.Drawing.Point(15, 139);
            this.LabelRepPassword.Name = "LabelRepPassword";
            this.LabelRepPassword.Size = new System.Drawing.Size(191, 30);
            this.LabelRepPassword.TabIndex = 3;
            this.LabelRepPassword.Text = "Повторить пароль";
            // 
            // LabelPhone
            // 
            this.LabelPhone.AutoSize = true;
            this.LabelPhone.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPhone.Location = new System.Drawing.Point(15, 56);
            this.LabelPhone.Name = "LabelPhone";
            this.LabelPhone.Size = new System.Drawing.Size(175, 30);
            this.LabelPhone.TabIndex = 1;
            this.LabelPhone.Text = "Номер телефона";
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPassword.Location = new System.Drawing.Point(15, 95);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(85, 30);
            this.LabelPassword.TabIndex = 2;
            this.LabelPassword.Text = "Пароль";
            // 
            // TextPassword
            // 
            this.TextPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextPassword.Location = new System.Drawing.Point(224, 92);
            this.TextPassword.MaxLength = 16;
            this.TextPassword.Name = "TextPassword";
            this.TextPassword.PasswordChar = '*';
            this.TextPassword.Size = new System.Drawing.Size(246, 33);
            this.TextPassword.TabIndex = 7;
            // 
            // TextPhone
            // 
            this.TextPhone.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextPhone.Location = new System.Drawing.Point(224, 53);
            this.TextPhone.MaxLength = 12;
            this.TextPhone.Name = "TextPhone";
            this.TextPhone.Size = new System.Drawing.Size(246, 33);
            this.TextPhone.TabIndex = 6;
            this.TextPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckPhone);
            // 
            // TextEmail
            // 
            this.TextEmail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextEmail.Location = new System.Drawing.Point(224, 14);
            this.TextEmail.MaxLength = 45;
            this.TextEmail.Name = "TextEmail";
            this.TextEmail.Size = new System.Drawing.Size(246, 33);
            this.TextEmail.TabIndex = 5;
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(383, 482);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(99, 44);
            this.AddButton.TabIndex = 12;
            this.AddButton.Text = "Создать";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.CreateNewPerson);
            this.AddButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AddButton_MouseMove);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.Location = new System.Drawing.Point(278, 482);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(99, 44);
            this.CancelButton.TabIndex = 13;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.Cancel);
            this.CancelButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CancelButton_MouseMove);
            // 
            // CreatePerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 529);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelPersonal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CreatePerson";
            this.Text = "E-Medicine. Создание пациента.";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CreatePerson_MouseMove);
            this.PanelPersonal.ResumeLayout(false);
            this.PanelPersonal.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabelLastName;
        private System.Windows.Forms.Panel PanelPersonal;
        private System.Windows.Forms.DateTimePicker BirthdaySet;
        private System.Windows.Forms.Label LabelBirthday;
        private System.Windows.Forms.Label LabelSex;
        private System.Windows.Forms.Label LabelFirstName;
        private System.Windows.Forms.Label LabelPatronymic;
        private System.Windows.Forms.ComboBox SexSet;
        private System.Windows.Forms.TextBox TextPatronymic;
        private System.Windows.Forms.TextBox TextFirstName;
        private System.Windows.Forms.TextBox TextLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TextRepPassword;
        private System.Windows.Forms.Label LabelEmail;
        private System.Windows.Forms.Label LabelRepPassword;
        private System.Windows.Forms.Label LabelPhone;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.TextBox TextPassword;
        private System.Windows.Forms.TextBox TextPhone;
        private System.Windows.Forms.TextBox TextEmail;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TextBox TextIIN;
    }
}