using System.ComponentModel;

namespace EmploymentCenter
{
    partial class NewApplicantForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FullNameField = new System.Windows.Forms.TextBox();
            this.AddressField = new System.Windows.Forms.TextBox();
            this.OnlyQualificationField = new System.Windows.Forms.CheckBox();
            this.ExperienceField = new System.Windows.Forms.NumericUpDown();
            this.QualificationCB = new System.Windows.Forms.ComboBox();
            this.CreateApplicantBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize) (this.ExperienceField)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия Имя";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Стаж";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Адрес";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 43);
            this.label4.TabIndex = 3;
            this.label4.Text = "Квалификация";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FullNameField
            // 
            this.FullNameField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FullNameField.Location = new System.Drawing.Point(156, 2);
            this.FullNameField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FullNameField.Name = "FullNameField";
            this.FullNameField.Size = new System.Drawing.Size(354, 27);
            this.FullNameField.TabIndex = 4;
            // 
            // AddressField
            // 
            this.AddressField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddressField.Location = new System.Drawing.Point(156, 66);
            this.AddressField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddressField.Name = "AddressField";
            this.AddressField.Size = new System.Drawing.Size(354, 27);
            this.AddressField.TabIndex = 6;
            // 
            // OnlyQualificationField
            // 
            this.OnlyQualificationField.Location = new System.Drawing.Point(77, 152);
            this.OnlyQualificationField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OnlyQualificationField.Name = "OnlyQualificationField";
            this.OnlyQualificationField.Size = new System.Drawing.Size(356, 24);
            this.OnlyQualificationField.TabIndex = 8;
            this.OnlyQualificationField.Text = "Желает работать только по специальности";
            this.OnlyQualificationField.UseVisualStyleBackColor = true;
            // 
            // ExperienceField
            // 
            this.ExperienceField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExperienceField.Location = new System.Drawing.Point(156, 34);
            this.ExperienceField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExperienceField.Name = "ExperienceField";
            this.ExperienceField.Size = new System.Drawing.Size(354, 27);
            this.ExperienceField.TabIndex = 9;
            // 
            // QualificationCB
            // 
            this.QualificationCB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QualificationCB.FormattingEnabled = true;
            this.QualificationCB.Location = new System.Drawing.Point(156, 98);
            this.QualificationCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.QualificationCB.Name = "QualificationCB";
            this.QualificationCB.Size = new System.Drawing.Size(354, 28);
            this.QualificationCB.TabIndex = 12;
            // 
            // CreateApplicantBtn
            // 
            this.CreateApplicantBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CreateApplicantBtn.Location = new System.Drawing.Point(0, 199);
            this.CreateApplicantBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreateApplicantBtn.Name = "CreateApplicantBtn";
            this.CreateApplicantBtn.Size = new System.Drawing.Size(513, 51);
            this.CreateApplicantBtn.TabIndex = 12;
            this.CreateApplicantBtn.Text = "Создать";
            this.CreateApplicantBtn.UseVisualStyleBackColor = true;
            this.CreateApplicantBtn.Click += new System.EventHandler(this.CreateApplicantBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.QualificationCB, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.FullNameField, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.AddressField, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.ExperienceField, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(513, 139);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // NewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 250);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.CreateApplicantBtn);
            this.Controls.Add(this.OnlyQualificationField);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "NewOrder";
            this.Text = "Добавление безработного на учет";
            ((System.ComponentModel.ISupportInitialize) (this.ExperienceField)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox QualificationCB;
        private System.Windows.Forms.CheckBox OnlyQualificationField;
        private System.Windows.Forms.NumericUpDown ExperienceField;
        private System.Windows.Forms.TextBox FullNameField;
        private System.Windows.Forms.TextBox AddressField;
        private System.Windows.Forms.Button CreateApplicantBtn;
    }
}