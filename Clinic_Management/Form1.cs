using System;
using System.Windows.Forms;

namespace Clinic_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     

        private void btnlogin_Click(object sender, EventArgs e)
        {
           if(txtname.Text=="Admin" && txtpass.Text == "Admin123")
            {
                home home = new home(); 
                home.Show();
            }
        }
    }
}
