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
    public partial class MenuUserControl : UserControl
    {
        public MenuUserControl()
        {
            InitializeComponent();
        }

        private void medicineInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new medicineForm());
        }

        private void addMedicinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new FormAddMedicine());
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new FormDashboard());
        }

        private void ShowForm(Form form)
        {
            Form currentForm = this.FindForm();
            //form.Owner=currentForm;
            
            currentForm?.Hide();
            form.ShowDialog();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
