namespace Clinic_Management
{
    partial class AddPres_Med
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmedsearch = new System.Windows.Forms.TextBox();
            this.panelmeds = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panelresults = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1192, 76);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(473, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(261, 44);
            this.label6.TabIndex = 15;
            this.label6.Text = "Add Medicine";
            // 
            // txtmedsearch
            // 
            this.txtmedsearch.Location = new System.Drawing.Point(268, 101);
            this.txtmedsearch.Name = "txtmedsearch";
            this.txtmedsearch.Size = new System.Drawing.Size(708, 26);
            this.txtmedsearch.TabIndex = 1;
            this.txtmedsearch.TextChanged += new System.EventHandler(this.txtmedsearch_TextChanged);
            // 
            // panelmeds
            // 
            this.panelmeds.AutoScroll = true;
            this.panelmeds.AutoSize = true;
            this.panelmeds.BackColor = System.Drawing.Color.White;
            this.panelmeds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelmeds.Location = new System.Drawing.Point(268, 133);
            this.panelmeds.Name = "panelmeds";
            this.panelmeds.Size = new System.Drawing.Size(708, 384);
            this.panelmeds.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CadetBlue;
            this.button1.Location = new System.Drawing.Point(1024, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 56);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panelresults
            // 
            this.panelresults.AutoScroll = true;
            this.panelresults.AutoSize = true;
            this.panelresults.BackColor = System.Drawing.Color.White;
            this.panelresults.Location = new System.Drawing.Point(3, 133);
            this.panelresults.Name = "panelresults";
            this.panelresults.Size = new System.Drawing.Size(244, 384);
            this.panelresults.TabIndex = 5;
            // 
            // AddPres_Med
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.Controls.Add(this.panelresults);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelmeds);
            this.Controls.Add(this.txtmedsearch);
            this.Controls.Add(this.panel1);
            this.Name = "AddPres_Med";
            this.Size = new System.Drawing.Size(1192, 938);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtmedsearch;
        private System.Windows.Forms.Panel panelmeds;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel panelresults;
    }
}
