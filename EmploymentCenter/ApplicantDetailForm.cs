using System;
using System.Windows.Forms;

namespace EmploymentCenter
{
    public partial class ApplicantDetailForm : Form
    {
        private Applicant Applicant;
        private EmploymentCenter Center;
        private BindingSource ApplicantSource;

        public ApplicantDetailForm(Applicant applicant, EmploymentCenter center, BindingSource applicantSource)
        {
            InitializeComponent();
            Applicant = applicant;
            Center = center;
            ApplicantSource = applicantSource;
            FullNameField.Text = applicant.FullName;
            ExperienceField.Value = applicant.Experience;
            AddressField.Text = applicant.Address;
            OnlyQualificationField.Checked = applicant.WantOnlyQualificationWork;
            QualificationCB.DataSource = Enum.GetValues(typeof(Qualification));
            QualificationCB.SelectedItem = applicant.Qualification;
        }
        
        /// <summary>
        /// Обработчик клика по кнопке сохранить. Сохраняет измененные данные безработного
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Applicant.FullName = FullNameField.Text;
            Applicant.Experience = (int) ExperienceField.Value;
            Applicant.Address = AddressField.Text;
            Applicant.WantOnlyQualificationWork = OnlyQualificationField.Checked;
            Applicant.Qualification = (Qualification) QualificationCB.SelectedItem;
            Close();
        }

        /// <summary>
        /// Обработчик клика по кнопке доступные вакансии. Открывает форму с доступными вакансиями
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowAvailableOffers_Click(object sender, EventArgs e)
        {
            var availableOffersForm = new AvailableOffersForm(Applicant, Center);
            availableOffersForm.Show();
        }

        /// <summary>
        /// Обработчик клика по кнопке рассматриваемые вакансии. Открывает форму с рассматриваемыми вакансиями
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SignedOffersBtn_Click(object sender, EventArgs e)
        {
            var signedOffersForm = new SignedOffersForm(Applicant, Center);
            signedOffersForm.Show();
        }

        /// <summary>
        /// Обработчик клика по кнопке снять с учета. Удаляет безработного из базы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            ApplicantSource.Remove(Applicant);
            Center.Applicants.Remove(Applicant);
            Close();
        }
    }
}