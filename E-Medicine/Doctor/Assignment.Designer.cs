namespace E_Medicine
{
    partial class SetAssignment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetAssignment));
            this.CheckIINButton = new System.Windows.Forms.Button();
            this.LabelIIN = new System.Windows.Forms.Label();
            this.TextIIN = new System.Windows.Forms.TextBox();
            this.CreateButton = new System.Windows.Forms.Button();
            this.ChooseButton = new System.Windows.Forms.Button();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.ViewButton = new System.Windows.Forms.Button();
            this.ExitButtom = new System.Windows.Forms.Button();
            this.ChoosePanel = new System.Windows.Forms.Panel();
            this.ApplyButtonCh = new System.Windows.Forms.Button();
            this.CBSetAssign = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CreatePanel = new System.Windows.Forms.Panel();
            this.TextAssign = new System.Windows.Forms.TextBox();
            this.ApplyButtonCr = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ViewAssignment = new System.Windows.Forms.DataGridView();
            this.ChoosePanel.SuspendLayout();
            this.CreatePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewAssignment)).BeginInit();
            this.SuspendLayout();
            // 
            // CheckIINButton
            // 
            this.CheckIINButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckIINButton.Location = new System.Drawing.Point(15, 54);
            this.CheckIINButton.Name = "CheckIINButton";
            this.CheckIINButton.Size = new System.Drawing.Size(100, 35);
            this.CheckIINButton.TabIndex = 49;
            this.CheckIINButton.Text = "Проверить";
            this.CheckIINButton.UseVisualStyleBackColor = true;
            this.CheckIINButton.Click += new System.EventHandler(this.CheckIIN);
            this.CheckIINButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CheckIINButton_MouseMove);
            // 
            // LabelIIN
            // 
            this.LabelIIN.AutoSize = true;
            this.LabelIIN.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelIIN.Location = new System.Drawing.Point(10, 17);
            this.LabelIIN.Name = "LabelIIN";
            this.LabelIIN.Size = new System.Drawing.Size(157, 30);
            this.LabelIIN.TabIndex = 47;
            this.LabelIIN.Text = "ИИН пациента";
            // 
            // TextIIN
            // 
            this.TextIIN.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextIIN.Location = new System.Drawing.Point(281, 12);
            this.TextIIN.MaxLength = 12;
            this.TextIIN.Name = "TextIIN";
            this.TextIIN.Size = new System.Drawing.Size(379, 35);
            this.TextIIN.TabIndex = 48;
            this.TextIIN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckDigit);
            // 
            // CreateButton
            // 
            this.CreateButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateButton.Location = new System.Drawing.Point(136, 54);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(100, 35);
            this.CreateButton.TabIndex = 50;
            this.CreateButton.Text = "Создать";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Visible = false;
            this.CreateButton.Click += new System.EventHandler(this.CreateNewAssignmentMode);
            this.CreateButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CreateButton_MouseMove);
            // 
            // ChooseButton
            // 
            this.ChooseButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseButton.Location = new System.Drawing.Point(242, 54);
            this.ChooseButton.Name = "ChooseButton";
            this.ChooseButton.Size = new System.Drawing.Size(100, 35);
            this.ChooseButton.TabIndex = 51;
            this.ChooseButton.Text = "Выбрать";
            this.ChooseButton.UseVisualStyleBackColor = true;
            this.ChooseButton.Visible = false;
            this.ChooseButton.Click += new System.EventHandler(this.SelectAssignment);
            this.ChooseButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChooseButton_MouseMove);
            // 
            // ChangeButton
            // 
            this.ChangeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeButton.Location = new System.Drawing.Point(348, 53);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(100, 35);
            this.ChangeButton.TabIndex = 52;
            this.ChangeButton.Text = "Удалить";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Visible = false;
            this.ChangeButton.Click += new System.EventHandler(this.DeleteAssignment);
            this.ChangeButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChangeButton_MouseMove);
            // 
            // ViewButton
            // 
            this.ViewButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ViewButton.Location = new System.Drawing.Point(454, 54);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(100, 35);
            this.ViewButton.TabIndex = 53;
            this.ViewButton.Text = "Просмотр";
            this.ViewButton.UseVisualStyleBackColor = true;
            this.ViewButton.Visible = false;
            this.ViewButton.Click += new System.EventHandler(this.ViewAssignmentMode);
            this.ViewButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ViewButton_MouseMove);
            // 
            // ExitButtom
            // 
            this.ExitButtom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButtom.Location = new System.Drawing.Point(560, 54);
            this.ExitButtom.Name = "ExitButtom";
            this.ExitButtom.Size = new System.Drawing.Size(100, 35);
            this.ExitButtom.TabIndex = 54;
            this.ExitButtom.Text = "Выход";
            this.ExitButtom.UseVisualStyleBackColor = true;
            this.ExitButtom.Click += new System.EventHandler(this.Exit);
            this.ExitButtom.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ExitButtom_MouseMove);
            // 
            // ChoosePanel
            // 
            this.ChoosePanel.Controls.Add(this.ApplyButtonCh);
            this.ChoosePanel.Controls.Add(this.CBSetAssign);
            this.ChoosePanel.Controls.Add(this.label1);
            this.ChoosePanel.Location = new System.Drawing.Point(15, 208);
            this.ChoosePanel.Name = "ChoosePanel";
            this.ChoosePanel.Size = new System.Drawing.Size(645, 100);
            this.ChoosePanel.TabIndex = 55;
            this.ChoosePanel.Visible = false;
            this.ChoosePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChoosePanel_MouseMove);
            // 
            // ApplyButtonCh
            // 
            this.ApplyButtonCh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ApplyButtonCh.Location = new System.Drawing.Point(523, 62);
            this.ApplyButtonCh.Name = "ApplyButtonCh";
            this.ApplyButtonCh.Size = new System.Drawing.Size(114, 35);
            this.ApplyButtonCh.TabIndex = 56;
            this.ApplyButtonCh.Text = "Подтвердить";
            this.ApplyButtonCh.UseVisualStyleBackColor = true;
            this.ApplyButtonCh.Click += new System.EventHandler(this.ModifyAssignmen);
            this.ApplyButtonCh.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ApplyButtonCh_MouseMove);
            // 
            // CBSetAssign
            // 
            this.CBSetAssign.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBSetAssign.FormattingEnabled = true;
            this.CBSetAssign.Location = new System.Drawing.Point(266, 5);
            this.CBSetAssign.Name = "CBSetAssign";
            this.CBSetAssign.Size = new System.Drawing.Size(371, 38);
            this.CBSetAssign.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 30);
            this.label1.TabIndex = 56;
            this.label1.Text = "Выбрать назначение";
            // 
            // CreatePanel
            // 
            this.CreatePanel.Controls.Add(this.TextAssign);
            this.CreatePanel.Controls.Add(this.ApplyButtonCr);
            this.CreatePanel.Controls.Add(this.label2);
            this.CreatePanel.Location = new System.Drawing.Point(15, 314);
            this.CreatePanel.Name = "CreatePanel";
            this.CreatePanel.Size = new System.Drawing.Size(645, 100);
            this.CreatePanel.TabIndex = 58;
            this.CreatePanel.Visible = false;
            this.CreatePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CreatePanel_MouseMove);
            // 
            // TextAssign
            // 
            this.TextAssign.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextAssign.Location = new System.Drawing.Point(266, 8);
            this.TextAssign.MaxLength = 100;
            this.TextAssign.Name = "TextAssign";
            this.TextAssign.Size = new System.Drawing.Size(371, 35);
            this.TextAssign.TabIndex = 59;
            // 
            // ApplyButtonCr
            // 
            this.ApplyButtonCr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ApplyButtonCr.Location = new System.Drawing.Point(523, 62);
            this.ApplyButtonCr.Name = "ApplyButtonCr";
            this.ApplyButtonCr.Size = new System.Drawing.Size(114, 35);
            this.ApplyButtonCr.TabIndex = 56;
            this.ApplyButtonCr.Text = "Подтвердить";
            this.ApplyButtonCr.UseVisualStyleBackColor = true;
            this.ApplyButtonCr.Click += new System.EventHandler(this.CreateNewAssignment);
            this.ApplyButtonCr.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ApplyButtonCr_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(16, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 30);
            this.label2.TabIndex = 56;
            this.label2.Text = "Создать назначение";
            // 
            // ViewAssignment
            // 
            this.ViewAssignment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ViewAssignment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewAssignment.Location = new System.Drawing.Point(15, 102);
            this.ViewAssignment.Name = "ViewAssignment";
            this.ViewAssignment.Size = new System.Drawing.Size(645, 100);
            this.ViewAssignment.TabIndex = 0;
            this.ViewAssignment.Visible = false;
            // 
            // SetAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 426);
            this.Controls.Add(this.ViewAssignment);
            this.Controls.Add(this.CreatePanel);
            this.Controls.Add(this.ChoosePanel);
            this.Controls.Add(this.ExitButtom);
            this.Controls.Add(this.ViewButton);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.ChooseButton);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.CheckIINButton);
            this.Controls.Add(this.LabelIIN);
            this.Controls.Add(this.TextIIN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SetAssignment";
            this.Text = "E-Medicine. Назначения.";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SetAssignment_MouseMove);
            this.ChoosePanel.ResumeLayout(false);
            this.ChoosePanel.PerformLayout();
            this.CreatePanel.ResumeLayout(false);
            this.CreatePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewAssignment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CheckIINButton;
        private System.Windows.Forms.Label LabelIIN;
        private System.Windows.Forms.TextBox TextIIN;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Button ChooseButton;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.Button ExitButtom;
        private System.Windows.Forms.Panel ChoosePanel;
        private System.Windows.Forms.Button ApplyButtonCh;
        private System.Windows.Forms.ComboBox CBSetAssign;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel CreatePanel;
        private System.Windows.Forms.TextBox TextAssign;
        private System.Windows.Forms.Button ApplyButtonCr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView ViewAssignment;
    }
}