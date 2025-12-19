using HouseLibrarys;

namespace HouseWinFormsApp

{

    public partial class Form1 : Form

    {

        public Form1()
        {

            InitializeComponent();

            InitializeCompanyList();

        }



        private void InitializeCompanyList()

        {

            comboBoxCompanies.Items.Add("Дерев'яне будівництво");

            comboBoxCompanies.Items.Add("Цегляне будівництво");

            comboBoxCompanies.Items.Add("Скляні конструкції");

            comboBoxCompanies.SelectedIndex = 0;

        }



        private void btnBuild_Click(object sender, EventArgs e)

        {

            IHouseCompany company;

            switch (comboBoxCompanies.SelectedIndex)

            {

                case 0:
                    company = new WoodConstructionCompany();
                    break;
                case 1:
                    company = new BrickConstructionCompany();
                    break;
                case 2:
                    company = new GlassConstructionCompany();
                    break;
                default:
                    return;

            }

            string report = company.StartProject();

            txtLog.Text = report;

        }

    }

}