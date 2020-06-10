using System.Windows.Forms;

namespace EmploymentCenter
{
    partial class MainForm
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
            this.ApplicantsDG = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.ApplicantsTP = new System.Windows.Forms.TabPage();
            this.OffersTP = new System.Windows.Forms.TabPage();
            this.CreateOffer = new System.Windows.Forms.Button();
            this.OffersDG = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.ApplicantsDG)).BeginInit();
            this.TabControl.SuspendLayout();
            this.ApplicantsTP.SuspendLayout();
            this.OffersTP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.OffersDG)).BeginInit();
            this.SuspendLayout();
            // 
            // ApplicantsDG
            // 
            this.ApplicantsDG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ApplicantsDG.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ApplicantsDG.BackgroundColor = System.Drawing.SystemColors.Window;
            this.ApplicantsDG.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ApplicantsDG.Dock = System.Windows.Forms.DockStyle.Top;
            this.ApplicantsDG.Location = new System.Drawing.Point(3, 2);
            this.ApplicantsDG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ApplicantsDG.Name = "ApplicantsDG";
            this.ApplicantsDG.ReadOnly = true;
            this.ApplicantsDG.RowHeadersVisible = false;
            this.ApplicantsDG.RowTemplate.Height = 24;
            this.ApplicantsDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ApplicantsDG.Size = new System.Drawing.Size(679, 378);
            this.ApplicantsDG.TabIndex = 0;
            this.ApplicantsDG.CellDoubleClick +=
                new System.Windows.Forms.DataGridViewCellEventHandler(this.ApplicantsDG_CellContentDoubleClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 434);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(679, 0);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // CreateBtn
            // 
            this.CreateBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CreateBtn.Location = new System.Drawing.Point(3, 378);
            this.CreateBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(679, 56);
            this.CreateBtn.TabIndex = 0;
            this.CreateBtn.Text = "Добавить на учет";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.ApplicantsTP);
            this.TabControl.Controls.Add(this.OffersTP);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(693, 469);
            this.TabControl.TabIndex = 2;
            // 
            // ApplicantsTP
            // 
            this.ApplicantsTP.Controls.Add(this.CreateBtn);
            this.ApplicantsTP.Controls.Add(this.ApplicantsDG);
            this.ApplicantsTP.Controls.Add(this.tableLayoutPanel1);
            this.ApplicantsTP.Location = new System.Drawing.Point(4, 29);
            this.ApplicantsTP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ApplicantsTP.Name = "ApplicantsTP";
            this.ApplicantsTP.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ApplicantsTP.Size = new System.Drawing.Size(685, 436);
            this.ApplicantsTP.TabIndex = 0;
            this.ApplicantsTP.Text = "Безработные";
            this.ApplicantsTP.UseVisualStyleBackColor = true;
            // 
            // OffersTP
            // 
            this.OffersTP.Controls.Add(this.CreateOffer);
            this.OffersTP.Controls.Add(this.OffersDG);
            this.OffersTP.Controls.Add(this.button1);
            this.OffersTP.Controls.Add(this.button2);
            this.OffersTP.Location = new System.Drawing.Point(4, 25);
            this.OffersTP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OffersTP.Name = "OffersTP";
            this.OffersTP.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OffersTP.Size = new System.Drawing.Size(685, 440);
            this.OffersTP.TabIndex = 1;
            this.OffersTP.Text = "Предложения работы";
            this.OffersTP.UseVisualStyleBackColor = true;
            // 
            // CreateOffer
            // 
            this.CreateOffer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CreateOffer.Location = new System.Drawing.Point(3, 384);
            this.CreateOffer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreateOffer.Name = "CreateOffer";
            this.CreateOffer.Size = new System.Drawing.Size(679, 54);
            this.CreateOffer.TabIndex = 5;
            this.CreateOffer.Text = "Добавить вакансию";
            this.CreateOffer.UseVisualStyleBackColor = true;
            this.CreateOffer.Click += new System.EventHandler(this.CreateOffer_Click);
            // 
            // OffersDG
            // 
            this.OffersDG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OffersDG.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.OffersDG.BackgroundColor = System.Drawing.SystemColors.Window;
            this.OffersDG.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OffersDG.Dock = System.Windows.Forms.DockStyle.Top;
            this.OffersDG.Location = new System.Drawing.Point(3, 2);
            this.OffersDG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OffersDG.MultiSelect = false;
            this.OffersDG.Name = "OffersDG";
            this.OffersDG.ReadOnly = true;
            this.OffersDG.RowHeadersVisible = false;
            this.OffersDG.RowTemplate.Height = 24;
            this.OffersDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OffersDG.Size = new System.Drawing.Size(679, 374);
            this.OffersDG.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(679, 436);
            this.button1.TabIndex = 2;
            this.button1.Text = "Создать";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(3, 2);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(679, 436);
            this.button2.TabIndex = 4;
            this.button2.Text = "Отредактировать";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 469);
            this.Controls.Add(this.TabControl);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Центр занятости";
            ((System.ComponentModel.ISupportInitialize) (this.ApplicantsDG)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.ApplicantsTP.ResumeLayout(false);
            this.ApplicantsTP.PerformLayout();
            this.OffersTP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.OffersDG)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.TabPage ApplicantsTP;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage OffersTP;
        private System.Windows.Forms.DataGridView ApplicantsDG;
        private System.Windows.Forms.DataGridView OffersDG;
        private System.Windows.Forms.Button CreateOffer;
    }
}