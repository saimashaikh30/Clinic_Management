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
    public partial class ShowMedicine : UserControl
    {
        public ShowMedicine()
        {
            InitializeComponent();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void ShowMedicine_Load(object sender, EventArgs e)
        {
            DataGridViewLinkColumn link = new DataGridViewLinkColumn()
            {
                Name = "updateLink",
                Text="Update",
                UseColumnTextForLinkValue = true
            };
            dataGridView1.Columns.Add(link);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["updateLink"].Index && e.RowIndex >= 0)
            {
                //string medicineName = dataGridView1.Rows[e.RowIndex].Cells["Column Name"].Value.ToString ();
                //string companyName = dataGridView1.Rows[e.RowIndex].Cells["Column Name"].Value.ToString();
                //string stock = dataGridView1.Rows[e.RowIndex].Cells["Column Name"].Value.ToString();
                //string expiryDate = dataGridView1.Rows[e.RowIndex].Cells["Column Name"].Value.ToString();

                UpdateMedicine updateMedicine = new UpdateMedicine();
                updateMedicine.setDetails("hello");
                panelShowMedicine.Controls.Clear();
                panelShowMedicine.Controls.Add(updateMedicine);

            }
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {

        }
    }
}
