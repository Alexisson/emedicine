namespace E_Medicine
{
    partial class SetGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetGroup));
            this.ButtonCreate = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.LabelGroup = new System.Windows.Forms.Label();
            this.LabelIIN = new System.Windows.Forms.Label();
            this.TextIIN = new System.Windows.Forms.TextBox();
            this.CBSetGroup = new System.Windows.Forms.ComboBox();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonCreate
            // 
            this.ButtonCreate.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonCreate.Location = new System.Drawing.Point(317, 140);
            this.ButtonCreate.Name = "ButtonCreate";
            this.ButtonCreate.Size = new System.Drawing.Size(97, 42);
            this.ButtonCreate.TabIndex = 18;
            this.ButtonCreate.Text = "Создать";
            this.ButtonCreate.UseVisualStyleBackColor = true;
            this.ButtonCreate.Click += new System.EventHandler(this.AddGroupToPerson);
            this.ButtonCreate.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonCreate_MouseMove);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.Location = new System.Drawing.Point(108, 140);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(97, 42);
            this.CancelButton.TabIndex = 17;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.Cancel);
            this.CancelButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CancelButton_MouseMove);
            // 
            // LabelGroup
            // 
            this.LabelGroup.AutoSize = true;
            this.LabelGroup.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelGroup.Location = new System.Drawing.Point(12, 82);
            this.LabelGroup.Name = "LabelGroup";
            this.LabelGroup.Size = new System.Drawing.Size(80, 30);
            this.LabelGroup.TabIndex = 16;
            this.LabelGroup.Text = "Группв";
            // 
            // LabelIIN
            // 
            this.LabelIIN.AutoSize = true;
            this.LabelIIN.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelIIN.Location = new System.Drawing.Point(12, 21);
            this.LabelIIN.Name = "LabelIIN";
            this.LabelIIN.Size = new System.Drawing.Size(60, 30);
            this.LabelIIN.TabIndex = 15;
            this.LabelIIN.Text = "ИИН";
            // 
            // TextIIN
            // 
            this.TextIIN.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextIIN.Location = new System.Drawing.Point(170, 16);
            this.TextIIN.MaxLength = 12;
            this.TextIIN.Name = "TextIIN";
            this.TextIIN.Size = new System.Drawing.Size(244, 35);
            this.TextIIN.TabIndex = 13;
            this.TextIIN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckDigit);
            // 
            // CBSetGroup
            // 
            this.CBSetGroup.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBSetGroup.FormattingEnabled = true;
            this.CBSetGroup.Location = new System.Drawing.Point(170, 74);
            this.CBSetGroup.Name = "CBSetGroup";
            this.CBSetGroup.Size = new System.Drawing.Size(244, 38);
            this.CBSetGroup.TabIndex = 19;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveButton.Location = new System.Drawing.Point(211, 140);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(100, 42);
            this.RemoveButton.TabIndex = 20;
            this.RemoveButton.Text = "Удалить";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.DeleteGroup);
            this.RemoveButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RemoveButton_MouseMove);
            // 
            // SetGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 198);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.CBSetGroup);
            this.Controls.Add(this.ButtonCreate);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.LabelGroup);
            this.Controls.Add(this.LabelIIN);
            this.Controls.Add(this.TextIIN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SetGroup";
            this.Text = "E-Medicine. Установка группы.";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SetGroup_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonCreate;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label LabelGroup;
        private System.Windows.Forms.Label LabelIIN;
        private System.Windows.Forms.TextBox TextIIN;
        private System.Windows.Forms.ComboBox CBSetGroup;
        private System.Windows.Forms.Button RemoveButton;
    }
}