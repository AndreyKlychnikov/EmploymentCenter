using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace EmploymentCenter
{
    public partial class NewApplicantForm : Form
    {
        public MainForm MainForm;

        public NewApplicantForm(MainForm form)
        {
            InitializeComponent();
            MainForm = form;
            QualificationCB.DataSource = Enum.GetValues(typeof(Qualification));
        }
        
        /// <summary>
        /// Обработчик клика по кнопке добавить на учет.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateApplicantBtn_Click(object sender, EventArgs e)
        {
            if (FullNameField.Text.Equals(""))
            {
                MessageBox.Show("Поле 'Фамилия Имя' должно быть заполнено!", "Ошибка",
                    MessageBoxButtons.OK);
                return;
            }
            var applicant = new Applicant(FullNameField.Text, (int) ExperienceField.Value, 
                AddressField.Text, (Qualification) QualificationCB.SelectedItem, 
                OnlyQualificationField.Checked);
            MainForm.ApplicantSource.Add(applicant);
            Close();
        }
    }
}