using System;
using System.Windows.Forms;

namespace Clinic_Management
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

     

       
        private void Home_Load(object sender, EventArgs e)
        {
            
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            //if (txtUsername.Text == "Admin" && txtPassword.Text == "Admin123")
            //{
                Dashboard dashboard = new Dashboard();
                panel1.Controls.Clear();
                panel1.Controls.Add(dashboard);
            //}
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
