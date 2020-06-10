using System.ComponentModel;

namespace EmploymentCenter
{
    partial class SignedOffersForm
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
            this.OffersDG = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize) (this.OffersDG)).BeginInit();
            this.SuspendLayout();
            // 
            // OffersDG
            // 
            this.OffersDG.AllowUserToAddRows = false;
            this.OffersDG.AllowUserToDeleteRows = false;
            this.OffersDG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OffersDG.BackgroundColor = System.Drawing.SystemColors.Control;
            this.OffersDG.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OffersDG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OffersDG.Location = new System.Drawing.Point(0, 0);
            this.OffersDG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OffersDG.Name = "OffersDG";
            this.OffersDG.ReadOnly = true;
            this.OffersDG.RowHeadersVisible = false;
            this.OffersDG.RowTemplate.Height = 24;
            this.OffersDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OffersDG.Size = new System.Drawing.Size(622, 460);
            this.OffersDG.TabIndex = 0;
            // 
            // SignedOffersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 460);
            this.Controls.Add(this.OffersDG);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SignedOffersForm";
            this.Text = "Рассматриваемые вакансии";
            ((System.ComponentModel.ISupportInitialize) (this.OffersDG)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView OffersDG;
    }
}