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
    public partial class UpdateMedicine : UserControl
    {
        public UpdateMedicine()
        {
            InitializeComponent();
        }

        private void UpdateMedicine_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public void setDetails(string s)
        {
            txtName.Text=s.ToString();
        } 
    }
}
