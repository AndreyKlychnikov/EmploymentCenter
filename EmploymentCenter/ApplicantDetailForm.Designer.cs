using System.ComponentModel;

namespace EmploymentCenter
{
    partial class ApplicantDetailForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.QualificationCB = new System.Windows.Forms.ComboBox();
            this.FullNameField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddressField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ExperienceField = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.ShowAvailableOffers = new System.Windows.Forms.Button();
            this.OnlyQualificationField = new System.Windows.Forms.CheckBox();
            this.SignedOffersBtn = new System.Windows.Forms.Button();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.ExperienceField)).BeginInit();
            this.SuspendLayout();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(418, 139);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия Имя";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // QualificationCB
            // 
            this.QualificationCB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QualificationCB.FormattingEnabled = true;
            this.QualificationCB.Location = new System.Drawing.Point(128, 98);
            this.QualificationCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.QualificationCB.Name = "QualificationCB";
            this.QualificationCB.Size = new System.Drawing.Size(287, 28);
            this.QualificationCB.TabIndex = 12;
            // 
            // FullNameField
            // 
            this.FullNameField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FullNameField.Location = new System.Drawing.Point(128, 2);
            this.FullNameField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FullNameField.Name = "FullNameField";
            this.FullNameField.Size = new System.Drawing.Size(287, 27);
            this.FullNameField.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Стаж";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AddressField
            // 
            this.AddressField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddressField.Location = new System.Drawing.Point(128, 66);
            this.AddressField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddressField.Name = "AddressField";
            this.AddressField.Size = new System.Drawing.Size(287, 27);
            this.AddressField.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 43);
            this.label4.TabIndex = 3;
            this.label4.Text = "Квалификация";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ExperienceField
            // 
            this.ExperienceField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExperienceField.Location = new System.Drawing.Point(128, 34);
            this.ExperienceField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExperienceField.Name = "ExperienceField";
            this.ExperienceField.Size = new System.Drawing.Size(287, 27);
            this.ExperienceField.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Адрес";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SaveBtn.Location = new System.Drawing.Point(0, 327);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(418, 35);
            this.SaveBtn.TabIndex = 15;
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // ShowAvailableOffers
            // 
            this.ShowAvailableOffers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ShowAvailableOffers.Location = new System.Drawing.Point(0, 289);
            this.ShowAvailableOffers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShowAvailableOffers.Name = "ShowAvailableOffers";
            this.ShowAvailableOffers.Size = new System.Drawing.Size(418, 38);
            this.ShowAvailableOffers.TabIndex = 16;
            this.ShowAvailableOffers.Text = "Доступные вакансии";
            this.ShowAvailableOffers.UseVisualStyleBackColor = true;
            this.ShowAvailableOffers.Click += new System.EventHandler(this.ShowAvailableOffers_Click);
            // 
            // OnlyQualificationField
            // 
            this.OnlyQualificationField.Location = new System.Drawing.Point(41, 161);
            this.OnlyQualificationField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OnlyQualificationField.Name = "OnlyQualificationField";
            this.OnlyQualificationField.Size = new System.Drawing.Size(356, 24);
            this.OnlyQualificationField.TabIndex = 17;
            this.OnlyQualificationField.Text = "Желает работать только по специальности";
            this.OnlyQualificationField.UseVisualStyleBackColor = true;
            // 
            // SignedOffersBtn
            // 
            this.SignedOffersBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SignedOffersBtn.Location = new System.Drawing.Point(0, 251);
            this.SignedOffersBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SignedOffersBtn.Name = "SignedOffersBtn";
            this.SignedOffersBtn.Size = new System.Drawing.Size(418, 38);
            this.SignedOffersBtn.TabIndex = 18;
            this.SignedOffersBtn.Text = "Рассматриваемые вакансии";
            this.SignedOffersBtn.UseVisualStyleBackColor = true;
            this.SignedOffersBtn.Click += new System.EventHandler(this.SignedOffersBtn_Click);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RemoveBtn.Location = new System.Drawing.Point(0, 212);
            this.RemoveBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(418, 39);
            this.RemoveBtn.TabIndex = 19;
            this.RemoveBtn.Text = "Снять с учета";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // ApplicantDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 362);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.SignedOffersBtn);
            this.Controls.Add(this.OnlyQualificationField);
            this.Controls.Add(this.ShowAvailableOffers);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ApplicantDetailForm";
            this.Text = "Анкета";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.ExperienceField)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown ExperienceField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AddressField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FullNameField;
        private System.Windows.Forms.ComboBox QualificationCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox OnlyQualificationField;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button ShowAvailableOffers;
        private System.Windows.Forms.Button SignedOffersBtn;
        private System.Windows.Forms.Button RemoveBtn;
    }
}