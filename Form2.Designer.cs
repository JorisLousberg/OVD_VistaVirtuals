﻿
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
            this.PNL_ScenarioOverVieuw = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.PNL_ScenarioOverVieuw.SuspendLayout();
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
            // PNL_ScenarioOverVieuw
            // 
            this.PNL_ScenarioOverVieuw.BackColor = System.Drawing.Color.Transparent;
            this.PNL_ScenarioOverVieuw.Controls.Add(this.textBox2);
            this.PNL_ScenarioOverVieuw.Controls.Add(this.button1);
            this.PNL_ScenarioOverVieuw.Location = new System.Drawing.Point(0, 0);
            this.PNL_ScenarioOverVieuw.Margin = new System.Windows.Forms.Padding(4);
            this.PNL_ScenarioOverVieuw.Name = "PNL_ScenarioOverVieuw";
            this.PNL_ScenarioOverVieuw.Size = new System.Drawing.Size(1069, 554);
            this.PNL_ScenarioOverVieuw.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(398, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(400, 235);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(246, 22);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OVD_VistaVirtuals.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.ControlBox = false;
            this.Controls.Add(this.PNL_ScenarioOverVieuw);
            this.Controls.Add(this.PNL_authorisation);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "Admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Admin_Load);
            this.PNL_ScenarioOverVieuw.ResumeLayout(false);
            this.PNL_ScenarioOverVieuw.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PNL_authorisation;
        private System.Windows.Forms.Panel PNL_ScenarioOverVieuw;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
    }
}