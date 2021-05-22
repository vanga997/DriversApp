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
    public partial class DriversLicense : Form
    {
        public DriversLicense()
        {
            InitializeComponent();
        }

        private void DriversLicenseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.driversLicenseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.driversDatabaseDataSet);

        }

        private void DriversLicense_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "driversDatabaseDataSet.DriversLicense". При необходимости она может быть перемещена или удалена.
            this.driversLicenseTableAdapter.Fill(this.driversDatabaseDataSet.DriversLicense);

        }

        private void ButtonDrivers_Click(object sender, EventArgs e)
        {
            this.Hide();
            Drivers f = new Drivers();
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
