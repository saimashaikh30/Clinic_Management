﻿using System;
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
    public partial class AdmitPatient : UserControl
    {
        public AdmitPatient()
        {
            InitializeComponent();
        }

        private void AdmitPatient_Load(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(new Dashboard());
        }
    }
}