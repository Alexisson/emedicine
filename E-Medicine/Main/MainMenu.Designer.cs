namespace E_Medicine
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PersonButton = new System.Windows.Forms.Button();
            this.DoctorButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.LogoLabel = new System.Windows.Forms.Label();
            this.VersionInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PersonButton
            // 
            this.PersonButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PersonButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PersonButton.Location = new System.Drawing.Point(12, 97);
            this.PersonButton.Name = "PersonButton";
            this.PersonButton.Size = new System.Drawing.Size(256, 72);
            this.PersonButton.TabIndex = 0;
            this.PersonButton.Text = "Я пациент";
            this.PersonButton.UseVisualStyleBackColor = true;
            this.PersonButton.Click += new System.EventHandler(this.GoToPersonMode);
            this.PersonButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PersonButton_MouseMove);
            // 
            // DoctorButton
            // 
            this.DoctorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoctorButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DoctorButton.Location = new System.Drawing.Point(12, 175);
            this.DoctorButton.Name = "DoctorButton";
            this.DoctorButton.Size = new System.Drawing.Size(256, 72);
            this.DoctorButton.TabIndex = 1;
            this.DoctorButton.Text = "Я врач";
            this.DoctorButton.UseVisualStyleBackColor = true;
            this.DoctorButton.Click += new System.EventHandler(this.GoToDoctorMode);
            this.DoctorButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DoctorButton_MouseMove);
            // 
            // ExitButton
            // 
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(92, 331);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(105, 49);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.Exit);
            this.ExitButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ExitButton_MouseMove);
            // 
            // LogoLabel
            // 
            this.LogoLabel.AutoSize = true;
            this.LogoLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogoLabel.Location = new System.Drawing.Point(42, 9);
            this.LogoLabel.Name = "LogoLabel";
            this.LogoLabel.Size = new System.Drawing.Size(205, 50);
            this.LogoLabel.TabIndex = 4;
            this.LogoLabel.Text = "E-Medicine";
            this.LogoLabel.DoubleClick += new System.EventHandler(this.GoToAdminMode);
            // 
            // VersionInfo
            // 
            this.VersionInfo.AutoSize = true;
            this.VersionInfo.Location = new System.Drawing.Point(187, 390);
            this.VersionInfo.Name = "VersionInfo";
            this.VersionInfo.Size = new System.Drawing.Size(75, 13);
            this.VersionInfo.TabIndex = 5;
            this.VersionInfo.Text = "Version 9.9.30";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(280, 412);
            this.Controls.Add(this.VersionInfo);
            this.Controls.Add(this.LogoLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.DoctorButton);
            this.Controls.Add(this.PersonButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "E-Medicine";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PersonButton;
        private System.Windows.Forms.Button DoctorButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label LogoLabel;
        private System.Windows.Forms.Label VersionInfo;
    }
}

