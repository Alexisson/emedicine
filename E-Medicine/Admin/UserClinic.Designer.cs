namespace E_Medicine
{
    partial class UserClinic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserClinic));
            this.CheckButton = new System.Windows.Forms.Button();
            this.TextIIN = new System.Windows.Forms.TextBox();
            this.LabelIIN = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.PanelClinic = new System.Windows.Forms.Panel();
            this.CBSetClinic = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CBCity = new System.Windows.Forms.ComboBox();
            this.CBRegion = new System.Windows.Forms.ComboBox();
            this.CBCountry = new System.Windows.Forms.ComboBox();
            this.LabelCityClPh = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelClinic.SuspendLayout();
            this.SuspendLayout();
            // 
            // CheckButton
            // 
            this.CheckButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckButton.Location = new System.Drawing.Point(347, 49);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(132, 44);
            this.CheckButton.TabIndex = 18;
            this.CheckButton.Text = "Проверить";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.CheckUser);
            this.CheckButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CheckButton_MouseMove);
            // 
            // TextIIN
            // 
            this.TextIIN.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextIIN.Location = new System.Drawing.Point(205, 12);
            this.TextIIN.MaxLength = 12;
            this.TextIIN.Name = "TextIIN";
            this.TextIIN.Size = new System.Drawing.Size(274, 33);
            this.TextIIN.TabIndex = 14;
            this.TextIIN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckDigit);
            // 
            // LabelIIN
            // 
            this.LabelIIN.AutoSize = true;
            this.LabelIIN.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelIIN.Location = new System.Drawing.Point(24, 15);
            this.LabelIIN.Name = "LabelIIN";
            this.LabelIIN.Size = new System.Drawing.Size(60, 30);
            this.LabelIIN.TabIndex = 13;
            this.LabelIIN.Text = "ИИН";
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.Location = new System.Drawing.Point(275, 323);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(99, 44);
            this.CancelButton.TabIndex = 17;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.Cancel);
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(380, 323);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(99, 44);
            this.AddButton.TabIndex = 16;
            this.AddButton.Text = "Создать";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.CreateNewRecord);
            // 
            // PanelClinic
            // 
            this.PanelClinic.Controls.Add(this.CBSetClinic);
            this.PanelClinic.Controls.Add(this.label3);
            this.PanelClinic.Controls.Add(this.label2);
            this.PanelClinic.Controls.Add(this.CBCity);
            this.PanelClinic.Controls.Add(this.CBRegion);
            this.PanelClinic.Controls.Add(this.CBCountry);
            this.PanelClinic.Controls.Add(this.LabelCityClPh);
            this.PanelClinic.Controls.Add(this.label1);
            this.PanelClinic.Location = new System.Drawing.Point(12, 99);
            this.PanelClinic.Name = "PanelClinic";
            this.PanelClinic.Size = new System.Drawing.Size(479, 218);
            this.PanelClinic.TabIndex = 18;
            this.PanelClinic.Visible = false;
            // 
            // CBSetClinic
            // 
            this.CBSetClinic.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBSetClinic.FormattingEnabled = true;
            this.CBSetClinic.Location = new System.Drawing.Point(193, 149);
            this.CBSetClinic.Name = "CBSetClinic";
            this.CBSetClinic.Size = new System.Drawing.Size(274, 38);
            this.CBSetClinic.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 30);
            this.label3.TabIndex = 45;
            this.label3.Text = "Поликлиника";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 30);
            this.label2.TabIndex = 44;
            this.label2.Text = "Страна";
            // 
            // CBCity
            // 
            this.CBCity.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBCity.FormattingEnabled = true;
            this.CBCity.Location = new System.Drawing.Point(193, 105);
            this.CBCity.Name = "CBCity";
            this.CBCity.Size = new System.Drawing.Size(274, 38);
            this.CBCity.TabIndex = 42;
            this.CBCity.SelectedIndexChanged += new System.EventHandler(this.SelectCity);
            // 
            // CBRegion
            // 
            this.CBRegion.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBRegion.FormattingEnabled = true;
            this.CBRegion.Location = new System.Drawing.Point(193, 61);
            this.CBRegion.Name = "CBRegion";
            this.CBRegion.Size = new System.Drawing.Size(274, 38);
            this.CBRegion.TabIndex = 43;
            this.CBRegion.SelectedIndexChanged += new System.EventHandler(this.SelectRegion);
            // 
            // CBCountry
            // 
            this.CBCountry.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBCountry.FormattingEnabled = true;
            this.CBCountry.Location = new System.Drawing.Point(193, 17);
            this.CBCountry.Name = "CBCountry";
            this.CBCountry.Size = new System.Drawing.Size(274, 38);
            this.CBCountry.TabIndex = 41;
            this.CBCountry.SelectedIndexChanged += new System.EventHandler(this.SelectCountry);
            // 
            // LabelCityClPh
            // 
            this.LabelCityClPh.AutoSize = true;
            this.LabelCityClPh.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCityClPh.Location = new System.Drawing.Point(12, 113);
            this.LabelCityClPh.Name = "LabelCityClPh";
            this.LabelCityClPh.Size = new System.Drawing.Size(70, 30);
            this.LabelCityClPh.TabIndex = 39;
            this.LabelCityClPh.Text = "Город";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 30);
            this.label1.TabIndex = 40;
            this.label1.Text = "Регион";
            // 
            // UserClinic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 376);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.PanelClinic);
            this.Controls.Add(this.TextIIN);
            this.Controls.Add(this.LabelIIN);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UserClinic";
            this.Text = "E-Medicine. Прикрепление пользователя к медицинскому учреждению.";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UserClinic_MouseMove);
            this.PanelClinic.ResumeLayout(false);
            this.PanelClinic.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelIIN;
        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Panel PanelClinic;
        private System.Windows.Forms.ComboBox CBRegion;
        private System.Windows.Forms.ComboBox CBCity;
        private System.Windows.Forms.ComboBox CBCountry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelCityClPh;
        private System.Windows.Forms.ComboBox CBSetClinic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextIIN;
    }
}