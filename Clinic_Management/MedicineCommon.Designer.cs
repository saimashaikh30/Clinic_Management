namespace Clinic_Management
{
    partial class MedicineCommon
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.medicineInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMedicinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Cornsilk;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medicineInformationToolStripMenuItem,
            this.addMedicinesToolStripMenuItem,
            this.dashboardToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1060, 58);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // medicineInformationToolStripMenuItem
            // 
            this.medicineInformationToolStripMenuItem.ForeColor = System.Drawing.Color.Crimson;
            this.medicineInformationToolStripMenuItem.Name = "medicineInformationToolStripMenuItem";
            this.medicineInformationToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10);
            this.medicineInformationToolStripMenuItem.Size = new System.Drawing.Size(261, 54);
            this.medicineInformationToolStripMenuItem.Text = "Medicine Information";
            this.medicineInformationToolStripMenuItem.ToolTipText = "Show Medicine Information";
            this.medicineInformationToolStripMenuItem.Click += new System.EventHandler(this.medicineInformationToolStripMenuItem_Click);
            // 
            // addMedicinesToolStripMenuItem
            // 
            this.addMedicinesToolStripMenuItem.ForeColor = System.Drawing.Color.Crimson;
            this.addMedicinesToolStripMenuItem.Name = "addMedicinesToolStripMenuItem";
            this.addMedicinesToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10);
            this.addMedicinesToolStripMenuItem.Size = new System.Drawing.Size(191, 54);
            this.addMedicinesToolStripMenuItem.Text = "Add Medicines";
            this.addMedicinesToolStripMenuItem.ToolTipText = "To Add Medicines";
            this.addMedicinesToolStripMenuItem.Click += new System.EventHandler(this.addMedicinesToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 692);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.ForeColor = System.Drawing.Color.Crimson;
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(140, 54);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // MedicineCommon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MedicineCommon";
            this.Size = new System.Drawing.Size(1060, 750);
            this.Load += new System.EventHandler(this.Medicine_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem medicineInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMedicinesToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
    }
}
