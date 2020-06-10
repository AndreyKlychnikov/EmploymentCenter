using System.ComponentModel;

namespace EmploymentCenter
{
    partial class AvailableOffersForm
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
            this.SignBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.OffersDG)).BeginInit();
            this.SuspendLayout();
            // 
            // OffersDG
            // 
            this.OffersDG.AllowUserToAddRows = false;
            this.OffersDG.AllowUserToDeleteRows = false;
            this.OffersDG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OffersDG.BackgroundColor = System.Drawing.SystemColors.Control;
            this.OffersDG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OffersDG.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OffersDG.Dock = System.Windows.Forms.DockStyle.Top;
            this.OffersDG.GridColor = System.Drawing.SystemColors.Control;
            this.OffersDG.Location = new System.Drawing.Point(0, 0);
            this.OffersDG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OffersDG.Name = "OffersDG";
            this.OffersDG.RowHeadersVisible = false;
            this.OffersDG.RowTemplate.Height = 24;
            this.OffersDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OffersDG.Size = new System.Drawing.Size(673, 511);
            this.OffersDG.TabIndex = 0;
            // 
            // SignBtn
            // 
            this.SignBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SignBtn.Location = new System.Drawing.Point(0, 517);
            this.SignBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SignBtn.Name = "SignBtn";
            this.SignBtn.Size = new System.Drawing.Size(673, 45);
            this.SignBtn.TabIndex = 1;
            this.SignBtn.Text = "Откликнуться";
            this.SignBtn.UseVisualStyleBackColor = true;
            this.SignBtn.Click += new System.EventHandler(this.SignBtn_Click);
            // 
            // AvailableOffersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 562);
            this.Controls.Add(this.SignBtn);
            this.Controls.Add(this.OffersDG);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AvailableOffersForm";
            this.Text = "Доступные вакансии";
            ((System.ComponentModel.ISupportInitialize) (this.OffersDG)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView OffersDG;
        private System.Windows.Forms.Button SignBtn;
    }
}