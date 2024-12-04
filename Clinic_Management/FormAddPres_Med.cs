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
        DataSet ds;
        NpgsqlCommand cmd;
        public FormAddPres_Med()
        {
            InitializeComponent();
            txtmedsearch.TextChanged += txtmedsearch_TextChanged;
        }

        private void FormAddPres_Med_Load(object sender, EventArgs e)
        {

        }

        private void txtmedsearch_TextChanged(object sender, EventArgs e)
        {
            string query = txtmedsearch.Text.Trim();
            if (string.IsNullOrEmpty(query))
            {
                panelmeds.Controls.Clear();
            }
            DataTable table = fetchdata(query);
            populatepanel(table);
        }

        private DataTable fetchdata(string query)
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            adapter = new NpgsqlDataAdapter("select * from Medicines where medicine_name like @medicine || '%'", conn);
            adapter.SelectCommand.Parameters.AddWithValue("@medicine", query);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        private void populatepanel(DataTable dataTable)
        {
            panelmeds.Controls.Clear();
            int y = 0;
            foreach (DataRow row in dataTable.Rows)
            {
                Label label = new Label()
                {
                    Text = row["medicine_name"].ToString(),
                    AutoSize = false,
                    Width = panelmeds.Width - 10,
                    Height = 30,
                    Location = new Point(5, y),
                    ForeColor = Color.Black
                };
                label.Click += (s, e) => clickfunc();
                panelmeds.Controls.Add(label);
                y = y + 5;
            }

        }

        private void clickfunc()
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
