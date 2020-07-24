namespace E_Medicine
{
    partial class CreateMedicine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateMedicine));
            this.panel1 = new System.Windows.Forms.Panel();
            this.CBSetType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CBSetGroup = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CBSetCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextNameMedicine = new System.Windows.Forms.TextBox();
            this.LabelNameClPh = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CBSetType);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.CBSetGroup);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.CBSetCategory);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TextNameMedicine);
            this.panel1.Controls.Add(this.LabelNameClPh);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 192);
            this.panel1.TabIndex = 0;
            // 
            // CBSetType
            // 
            this.CBSetType.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBSetType.FormattingEnabled = true;
            this.CBSetType.Location = new System.Drawing.Point(274, 142);
            this.CBSetType.Name = "CBSetType";
            this.CBSetType.Size = new System.Drawing.Size(421, 38);
            this.CBSetType.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(4, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 30);
            this.label4.TabIndex = 41;
            this.label4.Text = "Тип препарата";
            // 
            // CBSetGroup
            // 
            this.CBSetGroup.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBSetGroup.FormattingEnabled = true;
            this.CBSetGroup.Location = new System.Drawing.Point(274, 98);
            this.CBSetGroup.Name = "CBSetGroup";
            this.CBSetGroup.Size = new System.Drawing.Size(421, 38);
            this.CBSetGroup.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(4, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 30);
            this.label3.TabIndex = 39;
            this.label3.Text = "Группа препарата";
            // 
            // CBSetCategory
            // 
            this.CBSetCategory.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBSetCategory.FormattingEnabled = true;
            this.CBSetCategory.Location = new System.Drawing.Point(274, 54);
            this.CBSetCategory.Name = "CBSetCategory";
            this.CBSetCategory.Size = new System.Drawing.Size(421, 38);
            this.CBSetCategory.TabIndex = 38;
            this.CBSetCategory.SelectedIndexChanged += new System.EventHandler(this.SelectCategory);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(4, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 30);
            this.label2.TabIndex = 37;
            this.label2.Text = "Категория препарата";
            // 
            // TextNameMedicine
            // 
            this.TextNameMedicine.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextNameMedicine.Location = new System.Drawing.Point(274, 13);
            this.TextNameMedicine.MaxLength = 45;
            this.TextNameMedicine.Name = "TextNameMedicine";
            this.TextNameMedicine.Size = new System.Drawing.Size(421, 35);
            this.TextNameMedicine.TabIndex = 29;
            // 
            // LabelNameClPh
            // 
            this.LabelNameClPh.AutoSize = true;
            this.LabelNameClPh.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelNameClPh.Location = new System.Drawing.Point(3, 18);
            this.LabelNameClPh.Name = "LabelNameClPh";
            this.LabelNameClPh.Size = new System.Drawing.Size(212, 30);
            this.LabelNameClPh.TabIndex = 28;
            this.LabelNameClPh.Text = "Название препарата";
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.Location = new System.Drawing.Point(453, 210);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(124, 40);
            this.CancelButton.TabIndex = 35;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.Cancel);
            this.CancelButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CancelButton_MouseMove);
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(583, 210);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(124, 40);
            this.AddButton.TabIndex = 34;
            this.AddButton.Text = "Создать";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.CreateNewDrug);
            this.AddButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AddButton_MouseMove);
            // 
            // CreateMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 260);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CreateMedicine";
            this.Text = "E-Medicine. Создание медицинского препарата.";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CreateMedicine_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TextNameMedicine;
        private System.Windows.Forms.Label LabelNameClPh;
        private System.Windows.Forms.ComboBox CBSetGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBSetCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ComboBox CBSetType;
        private System.Windows.Forms.Label label4;
    }
}