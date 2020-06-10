using System;
using System.Linq;
using System.Windows.Forms;

namespace EmploymentCenter
{
    public partial class AvailableOffersForm : Form
    {
        private Applicant Applicant;
        private BindingSource OffersSource;

        public AvailableOffersForm(Applicant applicant, EmploymentCenter center)
        {
            InitializeComponent();
            Applicant = applicant;
            OffersSource = new BindingSource
                {DataSource = applicant.GetWorkOffers(center).Where(offer => !applicant.ConsideredOffers.Contains(offer))};
            OffersDG.AutoGenerateColumns = false;
            OffersDG.AllowUserToAddRows = false;
            OffersDG.DataSource = OffersSource;

            DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.Name = "Выбрать";
            OffersDG.Columns.Add(checkColumn);

            // Initialize and add a text box column.
            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Name";
            column.Name = "Название";
            column.ReadOnly = true;
            OffersDG.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "CompanyName";
            column.Name = "Название компании";
            column.ReadOnly = true;
            OffersDG.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Salary";
            column.Name = "Зарплата";
            column.ReadOnly = true;
            OffersDG.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "RequiredQualification";
            column.Name = "Необходимая квалификация";
            column.ReadOnly = true;
            OffersDG.Columns.Add(column);

            OffersDG.Update();
            OffersDG.Refresh();
        }

        /// <summary>
        /// Обработчик клика по кнопке откликнуться. Добавляет выбранные вакансии в рассматриваемые вакансии текущего
        /// безработного
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SignBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < OffersDG.RowCount; i++)
            {
                if (Convert.ToBoolean(OffersDG[0, i].Value) &&
                    !Applicant.ConsideredOffers.Contains((WorkOffer) OffersSource[i]))
                {
                    Applicant.RespondOffer((WorkOffer) OffersSource[i]);
                }
            }
            Close();
        }
    }
}