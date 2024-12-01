using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_Management
{
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dash_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            dashboardPanel.Controls.Clear();
            dashboardPanel.Controls.Add(patient);
        }

        private void btnMedicine_Click(object sender, EventArgs e)
        {
            Medicine medicine = new Medicine();
            dashboardPanel.Controls.Clear();
            dashboardPanel.Controls.Add(medicine);
        }

        private void dashboardPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
