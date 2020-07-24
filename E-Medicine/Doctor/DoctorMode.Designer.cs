namespace E_Medicine
{
    partial class DoctorMode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorMode));
            this.AddPersonButton = new System.Windows.Forms.Button();
            this.AddMedicineButton = new System.Windows.Forms.Button();
            this.AddPrescriptionButton = new System.Windows.Forms.Button();
            this.JournalButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddPersonButton
            // 
            this.AddPersonButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddPersonButton.Location = new System.Drawing.Point(12, 49);
            this.AddPersonButton.Name = "AddPersonButton";
            this.AddPersonButton.Size = new System.Drawing.Size(290, 48);
            this.AddPersonButton.TabIndex = 0;
            this.AddPersonButton.Text = "Добавить пациента";
            this.AddPersonButton.UseVisualStyleBackColor = true;
            this.AddPersonButton.Click += new System.EventHandler(this.PersonDoctor);
            this.AddPersonButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AddPersonButton_MouseMove);
            // 
            // AddMedicineButton
            // 
            this.AddMedicineButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddMedicineButton.Location = new System.Drawing.Point(12, 103);
            this.AddMedicineButton.Name = "AddMedicineButton";
            this.AddMedicineButton.Size = new System.Drawing.Size(290, 48);
            this.AddMedicineButton.TabIndex = 1;
            this.AddMedicineButton.Text = "Назначить препараты";
            this.AddMedicineButton.UseVisualStyleBackColor = true;
            this.AddMedicineButton.Click += new System.EventHandler(this.SetDrug);
            this.AddMedicineButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AddMedicineButton_MouseMove);
            // 
            // AddPrescriptionButton
            // 
            this.AddPrescriptionButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddPrescriptionButton.Location = new System.Drawing.Point(12, 265);
            this.AddPrescriptionButton.Name = "AddPrescriptionButton";
            this.AddPrescriptionButton.Size = new System.Drawing.Size(290, 48);
            this.AddPrescriptionButton.TabIndex = 2;
            this.AddPrescriptionButton.Text = "Выписать рецепт";
            this.AddPrescriptionButton.UseVisualStyleBackColor = true;
            this.AddPrescriptionButton.Click += new System.EventHandler(this.SetPrescription);
            this.AddPrescriptionButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AddPrescriptionButton_MouseMove);
            // 
            // JournalButton
            // 
            this.JournalButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.JournalButton.Location = new System.Drawing.Point(12, 319);
            this.JournalButton.Name = "JournalButton";
            this.JournalButton.Size = new System.Drawing.Size(290, 48);
            this.JournalButton.TabIndex = 3;
            this.JournalButton.Text = "Просмотр журналов";
            this.JournalButton.UseVisualStyleBackColor = true;
            this.JournalButton.Click += new System.EventHandler(this.ViewJournal);
            this.JournalButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.JournalButton_MouseMove);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(12, 405);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(290, 48);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.Exit);
            this.ExitButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ExitButton_MouseMove);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(290, 48);
            this.button1.TabIndex = 5;
            this.button1.Text = "Изменить группу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SetGroup);
            this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button1_MouseMove);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(12, 211);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(290, 48);
            this.button2.TabIndex = 6;
            this.button2.Text = "Создать назначение";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.SetAssignment);
            this.button2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button2_MouseMove);
            // 
            // DoctorMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 465);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.JournalButton);
            this.Controls.Add(this.AddPrescriptionButton);
            this.Controls.Add(this.AddMedicineButton);
            this.Controls.Add(this.AddPersonButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DoctorMode";
            this.Text = "E-Medicine. Режим врача.";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DoctorMode_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddPersonButton;
        private System.Windows.Forms.Button AddMedicineButton;
        private System.Windows.Forms.Button AddPrescriptionButton;
        private System.Windows.Forms.Button JournalButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}