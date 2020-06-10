using System.Linq;
using System.Windows.Forms;

namespace EmploymentCenter
{
    public partial class SignedOffersForm : Form
    {
        private BindingSource OffersSource;
        public SignedOffersForm(Applicant applicant, EmploymentCenter center)
        {
            InitializeComponent();
            OffersSource = new BindingSource
                {DataSource = applicant.ConsideredOffers};
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
        }
        
    }
}