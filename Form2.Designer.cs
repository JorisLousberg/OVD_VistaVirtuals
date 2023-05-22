
namespace OVD_VistaVirtuals
{
    partial class Admin
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
            this.PNL_authorisation = new System.Windows.Forms.Panel();
            this.PNL_ScenarioOverview = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // PNL_authorisation
            // 
            this.PNL_authorisation.BackColor = System.Drawing.Color.Transparent;
            this.PNL_authorisation.Location = new System.Drawing.Point(0, 0);
            this.PNL_authorisation.Margin = new System.Windows.Forms.Padding(4);
            this.PNL_authorisation.Name = "PNL_authorisation";
            this.PNL_authorisation.Size = new System.Drawing.Size(1069, 554);
            this.PNL_authorisation.TabIndex = 0;
            // 
            // PNL_ScenarioOverview
            // 
            this.PNL_ScenarioOverview.BackColor = System.Drawing.Color.Transparent;
            this.PNL_ScenarioOverview.Location = new System.Drawing.Point(0, 0);
            this.PNL_ScenarioOverview.Margin = new System.Windows.Forms.Padding(4);
            this.PNL_ScenarioOverview.Name = "PNL_ScenarioOverview";
            this.PNL_ScenarioOverview.Size = new System.Drawing.Size(1069, 554);
            this.PNL_ScenarioOverview.TabIndex = 1;
            this.PNL_ScenarioOverview.Paint += new System.Windows.Forms.PaintEventHandler(this.PNL_ScenarioOverview_Paint);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OVD_VistaVirtuals.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.ControlBox = false;
            this.Controls.Add(this.PNL_ScenarioOverview);
            this.Controls.Add(this.PNL_authorisation);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "Admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Admin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PNL_authorisation;
        private System.Windows.Forms.Panel PNL_ScenarioOverview;
    }
}