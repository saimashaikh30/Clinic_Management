namespace Clinic_Management
{
    partial class FormDashboard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dashboardPanel = new System.Windows.Forms.Panel();
            this.btnInHouse = new System.Windows.Forms.Button();
            this.btnMedicine = new System.Windows.Forms.Button();
            this.btnPatient = new System.Windows.Forms.Button();
            this.dashboardPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dashboardPanel
            // 
            this.dashboardPanel.AutoScroll = true;
            this.dashboardPanel.AutoSize = true;
            this.dashboardPanel.BackColor = System.Drawing.Color.FloralWhite;
            this.dashboardPanel.BackgroundImage = global::Clinic_Management.Properties.Resources.med2;
            this.dashboardPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dashboardPanel.Controls.Add(this.btnInHouse);
            this.dashboardPanel.Controls.Add(this.btnMedicine);
            this.dashboardPanel.Controls.Add(this.btnPatient);
            this.dashboardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardPanel.Location = new System.Drawing.Point(0, 0);
            this.dashboardPanel.Name = "dashboardPanel";
            this.dashboardPanel.Size = new System.Drawing.Size(1042, 703);
            this.dashboardPanel.TabIndex = 1;
            // 
            // btnInHouse
            // 
            this.btnInHouse.BackColor = System.Drawing.Color.PowderBlue;
            this.btnInHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInHouse.Location = new System.Drawing.Point(784, 254);
            this.btnInHouse.Name = "btnInHouse";
            this.btnInHouse.Size = new System.Drawing.Size(174, 127);
            this.btnInHouse.TabIndex = 5;
            this.btnInHouse.Text = "In-House Details";
            this.btnInHouse.UseVisualStyleBackColor = false;
            // 
            // btnMedicine
            // 
            this.btnMedicine.BackColor = System.Drawing.Color.PowderBlue;
            this.btnMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicine.Location = new System.Drawing.Point(537, 254);
            this.btnMedicine.Name = "btnMedicine";
            this.btnMedicine.Size = new System.Drawing.Size(174, 127);
            this.btnMedicine.TabIndex = 4;
            this.btnMedicine.Text = "Medicine Inventory";
            this.btnMedicine.UseVisualStyleBackColor = false;
            this.btnMedicine.Click += new System.EventHandler(this.btnMedicine_Click);
            // 
            // btnPatient
            // 
            this.btnPatient.BackColor = System.Drawing.Color.PowderBlue;
            this.btnPatient.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatient.Location = new System.Drawing.Point(268, 254);
            this.btnPatient.Name = "btnPatient";
            this.btnPatient.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnPatient.Size = new System.Drawing.Size(174, 127);
            this.btnPatient.TabIndex = 3;
            this.btnPatient.Text = "Patient Info";
            this.btnPatient.UseVisualStyleBackColor = false;
            this.btnPatient.Click += new System.EventHandler(this.btnPatient_Click);
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 703);
            this.Controls.Add(this.dashboardPanel);
            this.Name = "FormDashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            this.dashboardPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel dashboardPanel;
        private System.Windows.Forms.Button btnInHouse;
        private System.Windows.Forms.Button btnMedicine;
        private System.Windows.Forms.Button btnPatient;
    }
}