using System.ComponentModel;

namespace EmploymentCenter
{
    partial class NewOffer
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
            this.CompanyNameTb = new System.Windows.Forms.TextBox();
            this.SalaryField = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.QualificationCB = new System.Windows.Forms.ComboBox();
            this.NameField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CreateOfferBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.SalaryField)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.CompanyNameTb, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.SalaryField, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.QualificationCB, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.NameField, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(444, 142);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // CompanyNameTb
            // 
            this.CompanyNameTb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CompanyNameTb.Location = new System.Drawing.Point(136, 34);
            this.CompanyNameTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CompanyNameTb.Name = "CompanyNameTb";
            this.CompanyNameTb.Size = new System.Drawing.Size(305, 27);
            this.CompanyNameTb.TabIndex = 16;
            // 
            // SalaryField
            // 
            this.SalaryField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalaryField.Location = new System.Drawing.Point(136, 66);
            this.SalaryField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SalaryField.Maximum = new decimal(new int[] {99999999, 0, 0, 0});
            this.SalaryField.Name = "SalaryField";
            this.SalaryField.Size = new System.Drawing.Size(305, 27);
            this.SalaryField.TabIndex = 16;
            this.SalaryField.ThousandsSeparator = true;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // QualificationCB
            // 
            this.QualificationCB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QualificationCB.FormattingEnabled = true;
            this.QualificationCB.Location = new System.Drawing.Point(136, 98);
            this.QualificationCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.QualificationCB.Name = "QualificationCB";
            this.QualificationCB.Size = new System.Drawing.Size(305, 28);
            this.QualificationCB.TabIndex = 12;
            // 
            // NameField
            // 
            this.NameField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameField.Location = new System.Drawing.Point(136, 2);
            this.NameField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NameField.Name = "NameField";
            this.NameField.Size = new System.Drawing.Size(305, 27);
            this.NameField.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Компания";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 48);
            this.label4.TabIndex = 3;
            this.label4.Text = "Необходимая квалификация";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Зарплата";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CreateOfferBtn
            // 
            this.CreateOfferBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CreateOfferBtn.Location = new System.Drawing.Point(0, 180);
            this.CreateOfferBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreateOfferBtn.Name = "CreateOfferBtn";
            this.CreateOfferBtn.Size = new System.Drawing.Size(444, 51);
            this.CreateOfferBtn.TabIndex = 15;
            this.CreateOfferBtn.Text = "Создать";
            this.CreateOfferBtn.UseVisualStyleBackColor = true;
            this.CreateOfferBtn.Click += new System.EventHandler(this.CreateOfferBtn_Click);
            // 
            // NewOffer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 231);
            this.Controls.Add(this.CreateOfferBtn);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "NewOffer";
            this.Text = "Новая вакансия";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.SalaryField)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox QualificationCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox CompanyNameTb;
        private System.Windows.Forms.NumericUpDown SalaryField;
        private System.Windows.Forms.Button CreateOfferBtn;
        private System.Windows.Forms.TextBox NameField;
    }
}