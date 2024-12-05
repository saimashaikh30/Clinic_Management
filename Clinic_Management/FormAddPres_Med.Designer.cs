namespace Clinic_Management
{
    partial class FormAddPres_Med
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panelresults = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panelmeds = new System.Windows.Forms.Panel();
            this.txtmedsearch = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1042, 61);
            this.panel1.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(420, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(222, 37);
            this.label6.TabIndex = 15;
            this.label6.Text = "Add Medicine";
            // 
            // panelresults
            // 
            this.panelresults.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelresults.AutoScroll = true;
            this.panelresults.AutoSize = true;
            this.panelresults.BackColor = System.Drawing.Color.White;
            this.panelresults.Location = new System.Drawing.Point(12, 152);
            this.panelresults.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelresults.Name = "panelresults";
            this.panelresults.Size = new System.Drawing.Size(217, 307);
            this.panelresults.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.Color.CadetBlue;
            this.btnAdd.Location = new System.Drawing.Point(923, 80);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(107, 45);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panelmeds
            // 
            this.panelmeds.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelmeds.AutoScroll = true;
            this.panelmeds.AutoSize = true;
            this.panelmeds.BackColor = System.Drawing.Color.White;
            this.panelmeds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelmeds.Location = new System.Drawing.Point(265, 152);
            this.panelmeds.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelmeds.Name = "panelmeds";
            this.panelmeds.Size = new System.Drawing.Size(630, 308);
            this.panelmeds.TabIndex = 8;
            // 
            // txtmedsearch
            // 
            this.txtmedsearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtmedsearch.Location = new System.Drawing.Point(265, 80);
            this.txtmedsearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmedsearch.Name = "txtmedsearch";
            this.txtmedsearch.Size = new System.Drawing.Size(630, 22);
            this.txtmedsearch.TabIndex = 7;
            this.txtmedsearch.TextChanged += new System.EventHandler(this.txtmedsearch_TextChanged);
            // 
            // FormAddPres_Med
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1042, 703);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelresults);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panelmeds);
            this.Controls.Add(this.txtmedsearch);
            this.Name = "FormAddPres_Med";
            this.Text = "Add Medicine Prescription";
            this.Load += new System.EventHandler(this.FormAddPres_Med_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FlowLayoutPanel panelresults;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panelmeds;
        private System.Windows.Forms.TextBox txtmedsearch;
    }
}