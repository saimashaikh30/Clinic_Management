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
            this.button3 = new System.Windows.Forms.Button();
            this.btnMedicine = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.dashboardPanel.Controls.Add(this.button3);
            this.dashboardPanel.Controls.Add(this.btnMedicine);
            this.dashboardPanel.Controls.Add(this.button1);
            this.dashboardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardPanel.Location = new System.Drawing.Point(0, 0);
            this.dashboardPanel.Name = "dashboardPanel";
            this.dashboardPanel.Size = new System.Drawing.Size(1042, 703);
            this.dashboardPanel.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PowderBlue;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(784, 254);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(174, 127);
            this.button3.TabIndex = 5;
            this.button3.Text = "In-House Details";
            this.button3.UseVisualStyleBackColor = false;
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PowderBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(268, 254);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(174, 127);
            this.button1.TabIndex = 3;
            this.button1.Text = "Patient Info";
            this.button1.UseVisualStyleBackColor = false;
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnMedicine;
        private System.Windows.Forms.Button button1;
    }
}