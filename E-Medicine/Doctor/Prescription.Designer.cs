namespace E_Medicine
{
    partial class Prescription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prescription));
            this.LabelIIN = new System.Windows.Forms.Label();
            this.TextIIN = new System.Windows.Forms.TextBox();
            this.PanelMedicine1 = new System.Windows.Forms.Panel();
            this.CBSetName1 = new System.Windows.Forms.ComboBox();
            this.CBSetGroup1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelNameClPh = new System.Windows.Forms.Label();
            this.CBSetCategory1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PanelMedicine2 = new System.Windows.Forms.Panel();
            this.CBSetName2 = new System.Windows.Forms.ComboBox();
            this.CBSetGroup2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CBSetCategory2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PanelMedicine3 = new System.Windows.Forms.Panel();
            this.CBSetName3 = new System.Windows.Forms.ComboBox();
            this.CBSetGroup3 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CBSetCategory3 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PanelMedicine4 = new System.Windows.Forms.Panel();
            this.CBSetName4 = new System.Windows.Forms.ComboBox();
            this.CBSetGroup4 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CBSetCategory4 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CheckIINButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.PanelMedicine1.SuspendLayout();
            this.PanelMedicine2.SuspendLayout();
            this.PanelMedicine3.SuspendLayout();
            this.PanelMedicine4.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelIIN
            // 
            this.LabelIIN.AutoSize = true;
            this.LabelIIN.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelIIN.Location = new System.Drawing.Point(12, 9);
            this.LabelIIN.Name = "LabelIIN";
            this.LabelIIN.Size = new System.Drawing.Size(157, 30);
            this.LabelIIN.TabIndex = 32;
            this.LabelIIN.Text = "ИИН пациента";
            // 
            // TextIIN
            // 
            this.TextIIN.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextIIN.Location = new System.Drawing.Point(283, 4);
            this.TextIIN.MaxLength = 12;
            this.TextIIN.Name = "TextIIN";
            this.TextIIN.Size = new System.Drawing.Size(437, 35);
            this.TextIIN.TabIndex = 33;
            this.TextIIN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckDigit);
            // 
            // PanelMedicine1
            // 
            this.PanelMedicine1.Controls.Add(this.CBSetName1);
            this.PanelMedicine1.Controls.Add(this.CBSetGroup1);
            this.PanelMedicine1.Controls.Add(this.label3);
            this.PanelMedicine1.Controls.Add(this.LabelNameClPh);
            this.PanelMedicine1.Controls.Add(this.CBSetCategory1);
            this.PanelMedicine1.Controls.Add(this.label2);
            this.PanelMedicine1.Location = new System.Drawing.Point(17, 87);
            this.PanelMedicine1.Name = "PanelMedicine1";
            this.PanelMedicine1.Size = new System.Drawing.Size(718, 126);
            this.PanelMedicine1.TabIndex = 34;
            this.PanelMedicine1.Visible = false;
            // 
            // CBSetName1
            // 
            this.CBSetName1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBSetName1.FormattingEnabled = true;
            this.CBSetName1.Location = new System.Drawing.Point(282, 84);
            this.CBSetName1.Name = "CBSetName1";
            this.CBSetName1.Size = new System.Drawing.Size(421, 29);
            this.CBSetName1.TabIndex = 41;
            // 
            // CBSetGroup1
            // 
            this.CBSetGroup1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBSetGroup1.FormattingEnabled = true;
            this.CBSetGroup1.Location = new System.Drawing.Point(282, 49);
            this.CBSetGroup1.Name = "CBSetGroup1";
            this.CBSetGroup1.Size = new System.Drawing.Size(421, 29);
            this.CBSetGroup1.TabIndex = 40;
            this.CBSetGroup1.SelectedIndexChanged += new System.EventHandler(this.SelectGroup1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 21);
            this.label3.TabIndex = 39;
            this.label3.Text = "Группа препарата";
            // 
            // LabelNameClPh
            // 
            this.LabelNameClPh.AutoSize = true;
            this.LabelNameClPh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelNameClPh.Location = new System.Drawing.Point(12, 92);
            this.LabelNameClPh.Name = "LabelNameClPh";
            this.LabelNameClPh.Size = new System.Drawing.Size(157, 21);
            this.LabelNameClPh.TabIndex = 28;
            this.LabelNameClPh.Text = "Название препарата";
            // 
            // CBSetCategory1
            // 
            this.CBSetCategory1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBSetCategory1.FormattingEnabled = true;
            this.CBSetCategory1.Location = new System.Drawing.Point(282, 14);
            this.CBSetCategory1.Name = "CBSetCategory1";
            this.CBSetCategory1.Size = new System.Drawing.Size(421, 29);
            this.CBSetCategory1.TabIndex = 38;
            this.CBSetCategory1.SelectedIndexChanged += new System.EventHandler(this.SelectCategory1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 21);
            this.label2.TabIndex = 37;
            this.label2.Text = "Категория препарата";
            // 
            // PanelMedicine2
            // 
            this.PanelMedicine2.Controls.Add(this.CBSetName2);
            this.PanelMedicine2.Controls.Add(this.CBSetGroup2);
            this.PanelMedicine2.Controls.Add(this.label1);
            this.PanelMedicine2.Controls.Add(this.label4);
            this.PanelMedicine2.Controls.Add(this.CBSetCategory2);
            this.PanelMedicine2.Controls.Add(this.label5);
            this.PanelMedicine2.Location = new System.Drawing.Point(17, 219);
            this.PanelMedicine2.Name = "PanelMedicine2";
            this.PanelMedicine2.Size = new System.Drawing.Size(718, 124);
            this.PanelMedicine2.TabIndex = 42;
            this.PanelMedicine2.Visible = false;
            // 
            // CBSetName2
            // 
            this.CBSetName2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBSetName2.FormattingEnabled = true;
            this.CBSetName2.Location = new System.Drawing.Point(282, 84);
            this.CBSetName2.Name = "CBSetName2";
            this.CBSetName2.Size = new System.Drawing.Size(421, 29);
            this.CBSetName2.TabIndex = 41;
            // 
            // CBSetGroup2
            // 
            this.CBSetGroup2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBSetGroup2.FormattingEnabled = true;
            this.CBSetGroup2.Location = new System.Drawing.Point(282, 49);
            this.CBSetGroup2.Name = "CBSetGroup2";
            this.CBSetGroup2.Size = new System.Drawing.Size(421, 29);
            this.CBSetGroup2.TabIndex = 40;
            this.CBSetGroup2.SelectedIndexChanged += new System.EventHandler(this.SelectGroup2);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 21);
            this.label1.TabIndex = 39;
            this.label1.Text = "Группа препарата";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 21);
            this.label4.TabIndex = 28;
            this.label4.Text = "Название препарата";
            // 
            // CBSetCategory2
            // 
            this.CBSetCategory2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBSetCategory2.FormattingEnabled = true;
            this.CBSetCategory2.Location = new System.Drawing.Point(282, 14);
            this.CBSetCategory2.Name = "CBSetCategory2";
            this.CBSetCategory2.Size = new System.Drawing.Size(421, 29);
            this.CBSetCategory2.TabIndex = 38;
            this.CBSetCategory2.SelectedIndexChanged += new System.EventHandler(this.SelectCategory2);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 21);
            this.label5.TabIndex = 37;
            this.label5.Text = "Категория препарата";
            // 
            // PanelMedicine3
            // 
            this.PanelMedicine3.Controls.Add(this.CBSetName3);
            this.PanelMedicine3.Controls.Add(this.CBSetGroup3);
            this.PanelMedicine3.Controls.Add(this.label6);
            this.PanelMedicine3.Controls.Add(this.label7);
            this.PanelMedicine3.Controls.Add(this.CBSetCategory3);
            this.PanelMedicine3.Controls.Add(this.label8);
            this.PanelMedicine3.Location = new System.Drawing.Point(17, 349);
            this.PanelMedicine3.Name = "PanelMedicine3";
            this.PanelMedicine3.Size = new System.Drawing.Size(718, 123);
            this.PanelMedicine3.TabIndex = 43;
            this.PanelMedicine3.Visible = false;
            // 
            // CBSetName3
            // 
            this.CBSetName3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBSetName3.FormattingEnabled = true;
            this.CBSetName3.Location = new System.Drawing.Point(282, 84);
            this.CBSetName3.Name = "CBSetName3";
            this.CBSetName3.Size = new System.Drawing.Size(421, 29);
            this.CBSetName3.TabIndex = 41;
            // 
            // CBSetGroup3
            // 
            this.CBSetGroup3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBSetGroup3.FormattingEnabled = true;
            this.CBSetGroup3.Location = new System.Drawing.Point(282, 49);
            this.CBSetGroup3.Name = "CBSetGroup3";
            this.CBSetGroup3.Size = new System.Drawing.Size(421, 29);
            this.CBSetGroup3.TabIndex = 40;
            this.CBSetGroup3.SelectedIndexChanged += new System.EventHandler(this.SelectGroup3);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 21);
            this.label6.TabIndex = 39;
            this.label6.Text = "Группа препарата";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 21);
            this.label7.TabIndex = 28;
            this.label7.Text = "Название препарата";
            // 
            // CBSetCategory3
            // 
            this.CBSetCategory3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBSetCategory3.FormattingEnabled = true;
            this.CBSetCategory3.Location = new System.Drawing.Point(282, 14);
            this.CBSetCategory3.Name = "CBSetCategory3";
            this.CBSetCategory3.Size = new System.Drawing.Size(421, 29);
            this.CBSetCategory3.TabIndex = 38;
            this.CBSetCategory3.SelectedIndexChanged += new System.EventHandler(this.SelectCategory3);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(12, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 21);
            this.label8.TabIndex = 37;
            this.label8.Text = "Категория препарата";
            // 
            // PanelMedicine4
            // 
            this.PanelMedicine4.Controls.Add(this.CBSetName4);
            this.PanelMedicine4.Controls.Add(this.CBSetGroup4);
            this.PanelMedicine4.Controls.Add(this.label9);
            this.PanelMedicine4.Controls.Add(this.label10);
            this.PanelMedicine4.Controls.Add(this.CBSetCategory4);
            this.PanelMedicine4.Controls.Add(this.label11);
            this.PanelMedicine4.Location = new System.Drawing.Point(17, 478);
            this.PanelMedicine4.Name = "PanelMedicine4";
            this.PanelMedicine4.Size = new System.Drawing.Size(718, 125);
            this.PanelMedicine4.TabIndex = 44;
            this.PanelMedicine4.Visible = false;
            // 
            // CBSetName4
            // 
            this.CBSetName4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBSetName4.FormattingEnabled = true;
            this.CBSetName4.Location = new System.Drawing.Point(282, 84);
            this.CBSetName4.Name = "CBSetName4";
            this.CBSetName4.Size = new System.Drawing.Size(421, 29);
            this.CBSetName4.TabIndex = 41;
            // 
            // CBSetGroup4
            // 
            this.CBSetGroup4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBSetGroup4.FormattingEnabled = true;
            this.CBSetGroup4.Location = new System.Drawing.Point(282, 49);
            this.CBSetGroup4.Name = "CBSetGroup4";
            this.CBSetGroup4.Size = new System.Drawing.Size(421, 29);
            this.CBSetGroup4.TabIndex = 40;
            this.CBSetGroup4.SelectedIndexChanged += new System.EventHandler(this.SelectGroup4);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(12, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 21);
            this.label9.TabIndex = 39;
            this.label9.Text = "Группа препарата";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(12, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(157, 21);
            this.label10.TabIndex = 28;
            this.label10.Text = "Название препарата";
            // 
            // CBSetCategory4
            // 
            this.CBSetCategory4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBSetCategory4.FormattingEnabled = true;
            this.CBSetCategory4.Location = new System.Drawing.Point(282, 14);
            this.CBSetCategory4.Name = "CBSetCategory4";
            this.CBSetCategory4.Size = new System.Drawing.Size(421, 29);
            this.CBSetCategory4.TabIndex = 38;
            this.CBSetCategory4.SelectedIndexChanged += new System.EventHandler(this.SelectCategory4);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(12, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(162, 21);
            this.label11.TabIndex = 37;
            this.label11.Text = "Категория препарата";
            // 
            // CheckIINButton
            // 
            this.CheckIINButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckIINButton.Location = new System.Drawing.Point(17, 46);
            this.CheckIINButton.Name = "CheckIINButton";
            this.CheckIINButton.Size = new System.Drawing.Size(100, 35);
            this.CheckIINButton.TabIndex = 46;
            this.CheckIINButton.Text = "Проверить";
            this.CheckIINButton.UseVisualStyleBackColor = true;
            this.CheckIINButton.Click += new System.EventHandler(this.CheckIIN);
            this.CheckIINButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CheckIINButton_MouseMove);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(123, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.TabIndex = 47;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.AddPrescription);
            this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button1_MouseMove);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Enabled = false;
            this.RemoveButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveButton.Location = new System.Drawing.Point(229, 46);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(100, 35);
            this.RemoveButton.TabIndex = 48;
            this.RemoveButton.Text = "Убрать";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Visible = false;
            this.RemoveButton.Click += new System.EventHandler(this.DeletePrescription);
            this.RemoveButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RemoveButton_MouseMove);
            // 
            // ApplyButton
            // 
            this.ApplyButton.Enabled = false;
            this.ApplyButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ApplyButton.Location = new System.Drawing.Point(604, 45);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(116, 35);
            this.ApplyButton.TabIndex = 49;
            this.ApplyButton.Text = "Подтвердить";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Visible = false;
            this.ApplyButton.Click += new System.EventHandler(this.SetPrescription);
            this.ApplyButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ApplyButton_MouseMove);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(498, 45);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 35);
            this.button3.TabIndex = 50;
            this.button3.Text = "Отмена";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Cancel);
            this.button3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button3_MouseMove);
            // 
            // Prescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(750, 614);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CheckIINButton);
            this.Controls.Add(this.PanelMedicine4);
            this.Controls.Add(this.PanelMedicine3);
            this.Controls.Add(this.PanelMedicine2);
            this.Controls.Add(this.PanelMedicine1);
            this.Controls.Add(this.LabelIIN);
            this.Controls.Add(this.TextIIN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Prescription";
            this.Text = "E-Medicine. Рецепт.";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Prescription_MouseMove);
            this.PanelMedicine1.ResumeLayout(false);
            this.PanelMedicine1.PerformLayout();
            this.PanelMedicine2.ResumeLayout(false);
            this.PanelMedicine2.PerformLayout();
            this.PanelMedicine3.ResumeLayout(false);
            this.PanelMedicine3.PerformLayout();
            this.PanelMedicine4.ResumeLayout(false);
            this.PanelMedicine4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelIIN;
        private System.Windows.Forms.TextBox TextIIN;
        private System.Windows.Forms.Panel PanelMedicine1;
        private System.Windows.Forms.ComboBox CBSetName1;
        private System.Windows.Forms.ComboBox CBSetGroup1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabelNameClPh;
        private System.Windows.Forms.ComboBox CBSetCategory1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PanelMedicine2;
        private System.Windows.Forms.ComboBox CBSetName2;
        private System.Windows.Forms.ComboBox CBSetGroup2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CBSetCategory2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel PanelMedicine3;
        private System.Windows.Forms.ComboBox CBSetName3;
        private System.Windows.Forms.ComboBox CBSetGroup3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CBSetCategory3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel PanelMedicine4;
        private System.Windows.Forms.ComboBox CBSetName4;
        private System.Windows.Forms.ComboBox CBSetGroup4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CBSetCategory4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button CheckIINButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Button button3;
    }
}