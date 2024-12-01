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

     

        private void btnlogin_Click(object sender, EventArgs e)
        {
           
        }

        private void Home_Load(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            panel1.Controls.Clear();
            panel1.Controls.Add(dashboard);
        }
    }
}
