using System;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace EmploymentCenter
{
    public partial class MainForm : Form
    {
        public BindingSource ApplicantSource;
        public BindingSource OffersSource;
        private EmploymentCenter Center;

        public MainForm(EmploymentCenter center)
        {
            InitializeComponent();
            Center = center;
            ApplicantSource = new BindingSource {DataSource = center.Applicants};
            ApplicantsDG.AutoGenerateColumns = false;
            ApplicantsDG.DataSource = ApplicantSource;
            OffersSource = new BindingSource {DataSource = center.AvailableOffers};
            OffersDG.AutoGenerateColumns = false;
            OffersDG.DataSource = OffersSource;
            
            var column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "CompanyName";
            column.Name = "Название компании";
            OffersDG.Columns.Add(column);
            
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Name";
            column.Name = "Название";
            OffersDG.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Salary";
            column.Name = "Зарплата";
            OffersDG.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "RequiredQualification";
            column.Name = "Необходимая квалификация";
            OffersDG.Columns.Add(column);

            OffersDG.Update();
            OffersDG.Refresh();
            
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "FullName";
            column.Name = "Фамилия имя";
            ApplicantsDG.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Experience";
            column.Name = "Опыт работы";
            ApplicantsDG.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Address";
            column.Name = "Адрес";
            ApplicantsDG.Columns.Add(column);
            
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Qualification";
            column.Name = "Квалификация";
            ApplicantsDG.Columns.Add(column);

            DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.DataPropertyName = "WantOnlyQualificationWork";
            checkColumn.Name = "Только по своей квалификации";
            ApplicantsDG.Columns.Add(checkColumn);

            ApplicantsDG.Update();
            ApplicantsDG.Refresh();
            
            MessageBox.Show("Тема: 'Центр занятости'\nАвтор: студент группы 18ВП1 Ключников Андрей", 
                "Информация о программе", MessageBoxButtons.OK);
        }
        
        /// <summary>
        /// Обработчик клика по кнопке добавления безработного на учет, создает форму NewApplicantForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateBtn_Click(object sender, EventArgs e)
        {
            var newApplicantForm = new NewApplicantForm(this);
            newApplicantForm.FormClosing += newApplicantForm_FormClosing;
            newApplicantForm.Show();
        }
        
        /// <summary>
        /// Обработчик закрытия NewApplicantForm, сохраняет состояние в файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newApplicantForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveApplicants();
        }
        
        /// <summary>
        /// Обработчик клика по кнопке создания вакансии, создает форму NewOffer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateOffer_Click(object sender, EventArgs e)
        {
            var createOffer = new NewOffer(this);
            createOffer.FormClosing += CreateOfferForm_FormClosing;
            createOffer.Show();
        }
        
        /// <summary>
        /// Обработчик закрытия CreateOfferForm, сохраняет состояние в файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateOfferForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveOffers();
        }
        
        /// <summary>
        /// Обработчик двойного клика по строке ApplicantsDG, создает и отображает ApplicantDetailForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ApplicantsDG_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {    
                var applicantDetailForm = new ApplicantDetailForm((Applicant) ApplicantSource.Current, Center, ApplicantSource);
                applicantDetailForm.FormClosing += ApplicantDetailForm_FormClosing;
                applicantDetailForm.Show();
            }
        }
        
        /// <summary>
        /// Обработчик закрытия ApplicantDetailForm, обновляет ApplicantsDG и сохраняет состояние в файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ApplicantDetailForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ApplicantsDG.Update();
            ApplicantsDG.Refresh();
            SaveApplicants();
        }
        
        /// <summary>
        /// Сохраняет данные о безработных в файл applicants.json
        /// </summary>
        private void SaveApplicants()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("applicants.json", false, System.Text.Encoding.Default))
                {
                    sw.Write(JsonConvert.SerializeObject(Center.Applicants));
                }
            }
            catch (Exception)
            {
                // ignored
            }
        }
        
        /// <summary>
        /// Сохраняет данные о вакансиях в файл offers.json
        /// </summary>
        private void SaveOffers()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("offers.json", false, System.Text.Encoding.Default))
                {
                    sw.Write(JsonConvert.SerializeObject(Center.AvailableOffers));
                }
            }
            catch (Exception)
            {
                // ignored
            }
        }
    }
}