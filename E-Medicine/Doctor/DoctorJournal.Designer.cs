namespace E_Medicine
{
    partial class DoctorJournal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorJournal));
            this.ExitButton = new System.Windows.Forms.Button();
            this.JournalList = new System.Windows.Forms.DataGridView();
            this.CBJType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.JournalList)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(690, 357);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(98, 46);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.Exit);
            this.ExitButton.MouseHover += new System.EventHandler(this.ExitButton_MouseHover);
            // 
            // JournalList
            // 
            this.JournalList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.JournalList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.JournalList.Location = new System.Drawing.Point(12, 58);
            this.JournalList.Name = "JournalList";
            this.JournalList.Size = new System.Drawing.Size(776, 282);
            this.JournalList.TabIndex = 2;
            // 
            // CBJType
            // 
            this.CBJType.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBJType.FormattingEnabled = true;
            this.CBJType.Items.AddRange(new object[] {
            "Журнал посещений",
            "Журнал рецептов"});
            this.CBJType.Location = new System.Drawing.Point(12, 12);
            this.CBJType.Name = "CBJType";
            this.CBJType.Size = new System.Drawing.Size(303, 38);
            this.CBJType.TabIndex = 4;
            this.CBJType.SelectedIndexChanged += new System.EventHandler(this.SetTypeOfJournal);
            // 
            // DoctorJournal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CBJType);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.JournalList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DoctorJournal";
            this.Text = "E-Medicine. Журнал врача.";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DoctorJournal_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.JournalList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.DataGridView JournalList;
        private System.Windows.Forms.ComboBox CBJType;
    }
}