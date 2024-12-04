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
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {

        }

        private void ShowForm(Form form)
        {
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void btnMedicine_Click(object sender, EventArgs e)
        {
            medicineForm f=new medicineForm();
            ShowForm(f);
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            ShowForm(new FormPatient());
        }
    }
}
