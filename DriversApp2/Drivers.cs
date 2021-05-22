using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DriversApp2
{
    public partial class Drivers : Form
    {
        public Drivers()
        {
            InitializeComponent();
        }

        private void DriverBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.driverBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.driversDatabaseDataSet);

        }

        private void Drivers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "driversDatabaseDataSet.Driver". При необходимости она может быть перемещена или удалена.
            this.driverTableAdapter.Fill(this.driversDatabaseDataSet.Driver);

        }

        private void ButtonDriversLicense_Click(object sender, EventArgs e)
        {
            this.Hide();
            DriversLicense f = new DriversLicense();
            f.Show();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Authentication f = new Authentication();
            f.Show();
        }
    }
}
