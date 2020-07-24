namespace E_Medicine
{
    partial class CreateClinic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateClinic));
            this.CBRegion = new System.Windows.Forms.ComboBox();
            this.CBCity = new System.Windows.Forms.ComboBox();
            this.CBCountry = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.TextPhoneClPh = new System.Windows.Forms.TextBox();
            this.TextBuildingClPh = new System.Windows.Forms.TextBox();
            this.TextStreetClPh = new System.Windows.Forms.TextBox();
            this.TextZipClPh = new System.Windows.Forms.TextBox();
            this.TextNameClPh = new System.Windows.Forms.TextBox();
            this.LabelClPh = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LabelBuildingClPh = new System.Windows.Forms.Label();
            this.LabelStreetClPh = new System.Windows.Forms.Label();
            this.LabelCityClPh = new System.Windows.Forms.Label();
            this.LabelZipClPh = new System.Windows.Forms.Label();
            this.LabelNameClPh = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CBRegion
            // 
            this.CBRegion.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBRegion.FormattingEnabled = true;
            this.CBRegion.Location = new System.Drawing.Point(284, 179);
            this.CBRegion.Name = "CBRegion";
            this.CBRegion.Size = new System.Drawing.Size(251, 38);
            this.CBRegion.TabIndex = 38;
            this.CBRegion.SelectedIndexChanged += new System.EventHandler(this.SelectRegion);
            // 
            // CBCity
            // 
            this.CBCity.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBCity.FormattingEnabled = true;
            this.CBCity.Location = new System.Drawing.Point(284, 220);
            this.CBCity.Name = "CBCity";
            this.CBCity.Size = new System.Drawing.Size(251, 38);
            this.CBCity.TabIndex = 37;
            // 
            // CBCountry
            // 
            this.CBCountry.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBCountry.FormattingEnabled = true;
            this.CBCountry.Location = new System.Drawing.Point(283, 138);
            this.CBCountry.Name = "CBCountry";
            this.CBCountry.Size = new System.Drawing.Size(251, 38);
            this.CBCountry.TabIndex = 36;
            this.CBCountry.SelectedIndexChanged += new System.EventHandler(this.SelectCountry);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 30);
            this.label1.TabIndex = 35;
            this.label1.Text = "Регион";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 30);
            this.label2.TabIndex = 34;
            this.label2.Text = "Страна";
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.Location = new System.Drawing.Point(451, 389);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(124, 40);
            this.CancelButton.TabIndex = 33;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.Cancel);
            this.CancelButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CancelButton_MouseMove);
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(581, 389);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(124, 40);
            this.AddButton.TabIndex = 32;
            this.AddButton.Text = "Создать";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.CreateNewClinic);
            this.AddButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AddButton_MouseMove);
            // 
            // TextPhoneClPh
            // 
            this.TextPhoneClPh.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextPhoneClPh.Location = new System.Drawing.Point(284, 346);
            this.TextPhoneClPh.MaxLength = 12;
            this.TextPhoneClPh.Name = "TextPhoneClPh";
            this.TextPhoneClPh.Size = new System.Drawing.Size(250, 35);
            this.TextPhoneClPh.TabIndex = 31;
            // 
            // TextBuildingClPh
            // 
            this.TextBuildingClPh.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBuildingClPh.Location = new System.Drawing.Point(284, 305);
            this.TextBuildingClPh.MaxLength = 20;
            this.TextBuildingClPh.Name = "TextBuildingClPh";
            this.TextBuildingClPh.Size = new System.Drawing.Size(250, 35);
            this.TextBuildingClPh.TabIndex = 30;
            // 
            // TextStreetClPh
            // 
            this.TextStreetClPh.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextStreetClPh.Location = new System.Drawing.Point(284, 264);
            this.TextStreetClPh.MaxLength = 45;
            this.TextStreetClPh.Name = "TextStreetClPh";
            this.TextStreetClPh.Size = new System.Drawing.Size(250, 35);
            this.TextStreetClPh.TabIndex = 29;
            // 
            // TextZipClPh
            // 
            this.TextZipClPh.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextZipClPh.Location = new System.Drawing.Point(283, 97);
            this.TextZipClPh.MaxLength = 6;
            this.TextZipClPh.Name = "TextZipClPh";
            this.TextZipClPh.Size = new System.Drawing.Size(250, 35);
            this.TextZipClPh.TabIndex = 28;
            // 
            // TextNameClPh
            // 
            this.TextNameClPh.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextNameClPh.Location = new System.Drawing.Point(283, 4);
            this.TextNameClPh.MaxLength = 255;
            this.TextNameClPh.Name = "TextNameClPh";
            this.TextNameClPh.Size = new System.Drawing.Size(421, 35);
            this.TextNameClPh.TabIndex = 27;
            // 
            // LabelClPh
            // 
            this.LabelClPh.AutoSize = true;
            this.LabelClPh.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelClPh.Location = new System.Drawing.Point(13, 351);
            this.LabelClPh.Name = "LabelClPh";
            this.LabelClPh.Size = new System.Drawing.Size(95, 30);
            this.LabelClPh.TabIndex = 26;
            this.LabelClPh.Text = "Телефон";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 30);
            this.label6.TabIndex = 25;
            this.label6.Text = "Адрес";
            // 
            // LabelBuildingClPh
            // 
            this.LabelBuildingClPh.AutoSize = true;
            this.LabelBuildingClPh.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelBuildingClPh.Location = new System.Drawing.Point(13, 310);
            this.LabelBuildingClPh.Name = "LabelBuildingClPh";
            this.LabelBuildingClPh.Size = new System.Drawing.Size(55, 30);
            this.LabelBuildingClPh.TabIndex = 24;
            this.LabelBuildingClPh.Text = "Дом";
            // 
            // LabelStreetClPh
            // 
            this.LabelStreetClPh.AutoSize = true;
            this.LabelStreetClPh.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelStreetClPh.Location = new System.Drawing.Point(13, 269);
            this.LabelStreetClPh.Name = "LabelStreetClPh";
            this.LabelStreetClPh.Size = new System.Drawing.Size(72, 30);
            this.LabelStreetClPh.TabIndex = 23;
            this.LabelStreetClPh.Text = "Улица";
            // 
            // LabelCityClPh
            // 
            this.LabelCityClPh.AutoSize = true;
            this.LabelCityClPh.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCityClPh.Location = new System.Drawing.Point(13, 228);
            this.LabelCityClPh.Name = "LabelCityClPh";
            this.LabelCityClPh.Size = new System.Drawing.Size(70, 30);
            this.LabelCityClPh.TabIndex = 22;
            this.LabelCityClPh.Text = "Город";
            // 
            // LabelZipClPh
            // 
            this.LabelZipClPh.AutoSize = true;
            this.LabelZipClPh.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelZipClPh.Location = new System.Drawing.Point(12, 102);
            this.LabelZipClPh.Name = "LabelZipClPh";
            this.LabelZipClPh.Size = new System.Drawing.Size(183, 30);
            this.LabelZipClPh.TabIndex = 21;
            this.LabelZipClPh.Text = "Почтовый индекс";
            // 
            // LabelNameClPh
            // 
            this.LabelNameClPh.AutoSize = true;
            this.LabelNameClPh.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelNameClPh.Location = new System.Drawing.Point(12, 9);
            this.LabelNameClPh.Name = "LabelNameClPh";
            this.LabelNameClPh.Size = new System.Drawing.Size(237, 30);
            this.LabelNameClPh.TabIndex = 20;
            this.LabelNameClPh.Text = "Название поликлиники";
            // 
            // CreateClinic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 450);
            this.Controls.Add(this.CBRegion);
            this.Controls.Add(this.CBCity);
            this.Controls.Add(this.CBCountry);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.TextPhoneClPh);
            this.Controls.Add(this.TextBuildingClPh);
            this.Controls.Add(this.TextStreetClPh);
            this.Controls.Add(this.TextZipClPh);
            this.Controls.Add(this.TextNameClPh);
            this.Controls.Add(this.LabelClPh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LabelBuildingClPh);
            this.Controls.Add(this.LabelStreetClPh);
            this.Controls.Add(this.LabelCityClPh);
            this.Controls.Add(this.LabelZipClPh);
            this.Controls.Add(this.LabelNameClPh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CreateClinic";
            this.Text = "E-Medicine. Создание медицинского учреждения.";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CreateClinic_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBRegion;
        private System.Windows.Forms.ComboBox CBCity;
        private System.Windows.Forms.ComboBox CBCountry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox TextPhoneClPh;
        private System.Windows.Forms.TextBox TextBuildingClPh;
        private System.Windows.Forms.TextBox TextStreetClPh;
        private System.Windows.Forms.TextBox TextZipClPh;
        private System.Windows.Forms.TextBox TextNameClPh;
        private System.Windows.Forms.Label LabelClPh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LabelBuildingClPh;
        private System.Windows.Forms.Label LabelStreetClPh;
        private System.Windows.Forms.Label LabelCityClPh;
        private System.Windows.Forms.Label LabelZipClPh;
        private System.Windows.Forms.Label LabelNameClPh;
    }
}