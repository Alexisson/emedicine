namespace E_Medicine
{
    partial class AdminMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMainForm));
            this.CreatePersonButton = new System.Windows.Forms.Button();
            this.CreateMedicineButton = new System.Windows.Forms.Button();
            this.CreateAdminButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.CreateClinicButton = new System.Windows.Forms.Button();
            this.DCButton = new System.Windows.Forms.Button();
            this.PCButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreatePersonButton
            // 
            this.CreatePersonButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreatePersonButton.Location = new System.Drawing.Point(34, 27);
            this.CreatePersonButton.Name = "CreatePersonButton";
            this.CreatePersonButton.Size = new System.Drawing.Size(262, 43);
            this.CreatePersonButton.TabIndex = 0;
            this.CreatePersonButton.Text = "Создать пациента";
            this.CreatePersonButton.UseVisualStyleBackColor = true;
            this.CreatePersonButton.Click += new System.EventHandler(this.CreatePerson);
            this.CreatePersonButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CreatePersonButton_MouseMove);
            // 
            // CreateMedicineButton
            // 
            this.CreateMedicineButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateMedicineButton.Location = new System.Drawing.Point(34, 174);
            this.CreateMedicineButton.Name = "CreateMedicineButton";
            this.CreateMedicineButton.Size = new System.Drawing.Size(262, 43);
            this.CreateMedicineButton.TabIndex = 4;
            this.CreateMedicineButton.Text = "Создать препарат";
            this.CreateMedicineButton.UseVisualStyleBackColor = true;
            this.CreateMedicineButton.Click += new System.EventHandler(this.CreateMedicine);
            this.CreateMedicineButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CreateMedicineButton_MouseMove);
            // 
            // CreateAdminButton
            // 
            this.CreateAdminButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateAdminButton.Location = new System.Drawing.Point(34, 125);
            this.CreateAdminButton.Name = "CreateAdminButton";
            this.CreateAdminButton.Size = new System.Drawing.Size(262, 43);
            this.CreateAdminButton.TabIndex = 3;
            this.CreateAdminButton.Text = "Создать администратора";
            this.CreateAdminButton.UseVisualStyleBackColor = true;
            this.CreateAdminButton.Click += new System.EventHandler(this.CreateAdministrator);
            this.CreateAdminButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CreateAdminButton_MouseMove);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(34, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Создать врача";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CreateDoctor);
            this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button1_MouseMove);
            // 
            // CreateClinicButton
            // 
            this.CreateClinicButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateClinicButton.Location = new System.Drawing.Point(325, 27);
            this.CreateClinicButton.Name = "CreateClinicButton";
            this.CreateClinicButton.Size = new System.Drawing.Size(262, 43);
            this.CreateClinicButton.TabIndex = 0;
            this.CreateClinicButton.Text = "Создать поликлинику";
            this.CreateClinicButton.UseVisualStyleBackColor = true;
            this.CreateClinicButton.Click += new System.EventHandler(this.CreateClinic);
            this.CreateClinicButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CreateClinicButton_MouseMove);
            // 
            // DCButton
            // 
            this.DCButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DCButton.Location = new System.Drawing.Point(325, 174);
            this.DCButton.Name = "DCButton";
            this.DCButton.Size = new System.Drawing.Size(262, 43);
            this.DCButton.TabIndex = 1;
            this.DCButton.Text = "Прикрепить врача к поликлинике";
            this.DCButton.UseVisualStyleBackColor = true;
            this.DCButton.Click += new System.EventHandler(this.UserClinicDoctor);
            this.DCButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DCButton_MouseMove);
            // 
            // PCButton
            // 
            this.PCButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PCButton.Location = new System.Drawing.Point(325, 125);
            this.PCButton.Name = "PCButton";
            this.PCButton.Size = new System.Drawing.Size(262, 43);
            this.PCButton.TabIndex = 0;
            this.PCButton.Text = "Прикрепить пациента к поликлинике";
            this.PCButton.UseVisualStyleBackColor = true;
            this.PCButton.Click += new System.EventHandler(this.UserClinicPerson);
            this.PCButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PCButton_MouseMove);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(180, 223);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(262, 43);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.Exit);
            this.ExitButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ExitButton_MouseMove);
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 344);
            this.Controls.Add(this.CreateClinicButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CreateMedicineButton);
            this.Controls.Add(this.CreatePersonButton);
            this.Controls.Add(this.DCButton);
            this.Controls.Add(this.CreateAdminButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.PCButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdminMainForm";
            this.Text = "E-Medicine. Режим администратора.";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AdminMainForm_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreatePersonButton;
        private System.Windows.Forms.Button CreateMedicineButton;
        private System.Windows.Forms.Button CreateAdminButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button CreateClinicButton;
        private System.Windows.Forms.Button DCButton;
        private System.Windows.Forms.Button PCButton;
        private System.Windows.Forms.Button ExitButton;
    }
}