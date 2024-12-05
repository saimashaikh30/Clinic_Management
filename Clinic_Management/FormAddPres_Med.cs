using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Clinic_Management
{
    public partial class FormAddPres_Med : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=2002;Database=Clinic_Management;");
        NpgsqlDataAdapter adapter;
        private DataGridView dgvmeds;

        public FormAddPres_Med()
        {
            InitializeComponent();
            txtmedsearch.TextChanged += txtmedsearch_TextChanged;
            InitializeDataGridView();
        }

        private void FormAddPres_Med_Load(object sender, EventArgs e)
        {
            LoadAllMedicines(); 
        }

        private void InitializeDataGridView()
        {
            dgvmeds = new DataGridView
            {
                Location = new Point(5, 5),
                Width = panelmeds.Width - 10,
                Height = panelmeds.Height - 10,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                ReadOnly = true,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                Dock = DockStyle.Fill,
            };
            dgvmeds.CellClick += DgvMedicines_CellClick;

           
            panelmeds.Controls.Add(dgvmeds);
        }

        private void txtmedsearch_TextChanged(object sender, EventArgs e)
        {
            string query = txtmedsearch.Text.Trim();
            DataTable table = fetchdata(query);
            dgvmeds.DataSource = table; 
        }

        private DataTable fetchdata(string query)
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

            string sqlQuery;
            if (string.IsNullOrEmpty(query))
            {
                sqlQuery = "SELECT * FROM Medicines"; 
            }
            else
            {
                sqlQuery = "SELECT medicine_id, medicine_name FROM Medicines WHERE medicine_name LIKE @medicine || '%'";
            }

            adapter = new NpgsqlDataAdapter(sqlQuery, conn);

            if (!string.IsNullOrEmpty(query))
            {
                adapter.SelectCommand.Parameters.AddWithValue("@medicine", query);
            }

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        private void LoadAllMedicines()
        {
           
            DataTable table = fetchdata(""); 
            dgvmeds.DataSource = table;
        }

        private void DgvMedicines_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow row = dgvmeds.Rows[e.RowIndex];
                int medicineId = Convert.ToInt32(row.Cells["medicine_id"].Value);
                string medicineName = row.Cells["medicine_name"].Value.ToString();

                MessageBox.Show($"Selected Medicine:\nID: {medicineId}\nName: {medicineName}");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
        }
    }
}