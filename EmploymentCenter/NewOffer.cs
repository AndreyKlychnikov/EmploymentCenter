using System;
using System.Windows.Forms;

namespace EmploymentCenter
{
    public partial class NewOffer : Form
    {
        public MainForm MainForm;
        
        public NewOffer(MainForm form)
        {
            InitializeComponent();
            MainForm = form;
            QualificationCB.DataSource = Enum.GetValues(typeof(Qualification));
        }
        
        /// <summary>
        /// Обработчик клика по кнопке поставить на учет.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateOfferBtn_Click(object sender, EventArgs e)
        {
            if (NameField.Text.Equals("") || CompanyNameTb.Text.Equals(""))
            {
                MessageBox.Show("Названия должности и компании не могут быть пустыми!", "Ошибка",
                    MessageBoxButtons.OK);
                return;
            }
            var offer = new WorkOffer(NameField.Text, CompanyNameTb.Text, 
                (int) SalaryField.Value, (Qualification)  QualificationCB.SelectedItem);
            MainForm.OffersSource.Add(offer);
            Close();
        }
    }
}