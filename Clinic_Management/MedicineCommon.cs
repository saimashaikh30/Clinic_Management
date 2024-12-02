using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Clinic_Management
{
    public partial class MedicineCommon : UserControl
    {
        public MedicineCommon()
        {
            InitializeComponent();
        }

        private void Medicine_Load(object sender, EventArgs e)
        {
            ShowMedicine medicine = new ShowMedicine();
            switchPage(medicine);
        }

        private void medicineInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {          
            ShowMedicine medicine = new ShowMedicine();
            switchPage(medicine);                     
        }

        private void switchPage(Control Page)
        {
            panel1.Controls.Clear();        
            panel1.Controls.Add(Page);
        }

        private void addMedicinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMedicine addMedicine = new AddMedicine();
            switchPage(addMedicine);
        }
    }
}
