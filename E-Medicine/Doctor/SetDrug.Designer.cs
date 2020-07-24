namespace E_Medicine
{
    partial class SetMedicine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetMedicine));
            this.PanelMedicine = new System.Windows.Forms.Panel();
            this.CBSetName = new System.Windows.Forms.ComboBox();
            this.CBSetGroup = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelNameClPh = new System.Windows.Forms.Label();
            this.CBSetCategory = new System.Windows.Forms.ComboBox();
            this.LabelIIN = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextIIN = new System.Windows.Forms.TextBox();
            this.CBSetType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.PanelMedicine.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMedicine
            // 
            this.PanelMedicine.Controls.Add(this.CBSetName);
            this.PanelMedicine.Controls.Add(this.CBSetGroup);
            this.PanelMedicine.Controls.Add(this.label3);
            this.PanelMedicine.Controls.Add(this.LabelNameClPh);
            this.PanelMedicine.Controls.Add(this.CBSetCategory);
            this.PanelMedicine.Controls.Add(this.LabelIIN);
            this.PanelMedicine.Controls.Add(this.label2);
            this.PanelMedicine.Controls.Add(this.TextIIN);
            this.PanelMedicine.Location = new System.Drawing.Point(12, 81);
            this.PanelMedicine.Name = "PanelMedicine";
            this.PanelMedicine.Size = new System.Drawing.Size(718, 196);
            this.PanelMedicine.TabIndex = 1;
            this.PanelMedicine.Visible = false;
            // 
            // CBSetName
            // 
            this.CBSetName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBSetName.FormattingEnabled = true;
            this.CBSetName.Location = new System.Drawing.Point(281, 134);
            this.CBSetName.Name = "CBSetName";
            this.CBSetName.Size = new System.Drawing.Size(421, 38);
            this.CBSetName.TabIndex = 41;
            // 
            // CBSetGroup
            // 
            this.CBSetGroup.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBSetGroup.FormattingEnabled = true;
            this.CBSetGroup.Location = new System.Drawing.Point(281, 90);
            this.CBSetGroup.Name = "CBSetGroup";
            this.CBSetGroup.Size = new System.Drawing.Size(421, 38);
            this.CBSetGroup.TabIndex = 40;
            this.CBSetGroup.SelectedIndexChanged += new System.EventHandler(this.SelectGroup);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(11, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 30);
            this.label3.TabIndex = 39;
            this.label3.Text = "Группа препарата";
            // 
            // LabelNameClPh
            // 
            this.LabelNameClPh.AutoSize = true;
            this.LabelNameClPh.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelNameClPh.Location = new System.Drawing.Point(11, 142);
            this.LabelNameClPh.Name = "LabelNameClPh";
            this.LabelNameClPh.Size = new System.Drawing.Size(212, 30);
            this.LabelNameClPh.TabIndex = 28;
            this.LabelNameClPh.Text = "Название препарата";
            // 
            // CBSetCategory
            // 
            this.CBSetCategory.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBSetCategory.FormattingEnabled = true;
            this.CBSetCategory.Location = new System.Drawing.Point(281, 46);
            this.CBSetCategory.Name = "CBSetCategory";
            this.CBSetCategory.Size = new System.Drawing.Size(421, 38);
            this.CBSetCategory.TabIndex = 38;
            this.CBSetCategory.SelectedIndexChanged += new System.EventHandler(this.SelectCategory);
            // 
            // LabelIIN
            // 
            this.LabelIIN.AutoSize = true;
            this.LabelIIN.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelIIN.Location = new System.Drawing.Point(10, 10);
            this.LabelIIN.Name = "LabelIIN";
            this.LabelIIN.Size = new System.Drawing.Size(157, 30);
            this.LabelIIN.TabIndex = 30;
            this.LabelIIN.Text = "ИИН пациента";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(11, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 30);
            this.label2.TabIndex = 37;
            this.label2.Text = "Категория препарата";
            // 
            // TextIIN
            // 
            this.TextIIN.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextIIN.Location = new System.Drawing.Point(281, 5);
            this.TextIIN.MaxLength = 12;
            this.TextIIN.Name = "TextIIN";
            this.TextIIN.Size = new System.Drawing.Size(421, 35);
            this.TextIIN.TabIndex = 31;
            this.TextIIN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckDigit);
            // 
            // CBSetType
            // 
            this.CBSetType.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBSetType.FormattingEnabled = true;
            this.CBSetType.Items.AddRange(new object[] {
            "Рекомендуемые",
            "Запрещенные"});
            this.CBSetType.Location = new System.Drawing.Point(197, 1);
            this.CBSetType.Name = "CBSetType";
            this.CBSetType.Size = new System.Drawing.Size(286, 38);
            this.CBSetType.TabIndex = 42;
            this.CBSetType.SelectedIndexChanged += new System.EventHandler(this.SelectType);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 30);
            this.label4.TabIndex = 41;
            this.label4.Text = "Тип препарата";
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.Location = new System.Drawing.Point(460, 283);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(124, 40);
            this.CancelButton.TabIndex = 43;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.Cancel);
            this.CancelButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CancelButton_MouseMove);
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(590, 283);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(124, 40);
            this.AddButton.TabIndex = 42;
            this.AddButton.Text = "Создать";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.SetMedicineToPerson);
            this.AddButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AddButton_MouseMove);
            // 
            // SetMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 334);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.CBSetType);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.PanelMedicine);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SetMedicine";
            this.Text = "E-Medicine. Назначить препарат.";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SetMedicine_MouseMove);
            this.PanelMedicine.ResumeLayout(false);
            this.PanelMedicine.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelMedicine;
        private System.Windows.Forms.ComboBox CBSetType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CBSetGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBSetCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextIIN;
        private System.Windows.Forms.Label LabelIIN;
        private System.Windows.Forms.Label LabelNameClPh;
        private System.Windows.Forms.ComboBox CBSetName;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AddButton;
    }
}