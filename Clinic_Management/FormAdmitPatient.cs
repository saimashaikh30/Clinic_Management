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
    public partial class FormAdmitPatient : Form
    {
        public FormAdmitPatient()
        {
            InitializeComponent();
        }

        private void FormAdmitPatient_Load(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FormDashboard d=new FormDashboard();
            this.Hide();
            d.ShowDialog();
            this.Close();
        }
    }
}
