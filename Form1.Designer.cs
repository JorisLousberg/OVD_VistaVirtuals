
namespace OVD_VistaVirtuals
{
    partial class VistaVirtuals
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
            this.PNL_Start_Screen = new System.Windows.Forms.Panel();
            this.PNL_Study_Screen = new System.Windows.Forms.Panel();
            this.PNL_Scenario_Screen = new System.Windows.Forms.Panel();
            this.PNL_LoadDataToTable_Screen = new System.Windows.Forms.Panel();
            this.PNL_AddScenario_Screen = new System.Windows.Forms.Panel();
            this.PNL_authorisation_Screen = new System.Windows.Forms.Panel();
            this.PNL_ChangePassword_Screen = new System.Windows.Forms.Panel();
            this.BTN_start_exe = new System.Windows.Forms.Button();
            this.PNL_Scenario_Screen.SuspendLayout();
            this.SuspendLayout();
            // 
            // PNL_Start_Screen
            // 
            this.PNL_Start_Screen.BackColor = System.Drawing.Color.Transparent;
            this.PNL_Start_Screen.Location = new System.Drawing.Point(0, 0);
            this.PNL_Start_Screen.Name = "PNL_Start_Screen";
            this.PNL_Start_Screen.Size = new System.Drawing.Size(798, 451);
            this.PNL_Start_Screen.TabIndex = 2;
            this.PNL_Start_Screen.Visible = false;
            this.PNL_Start_Screen.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // PNL_Study_Screen
            // 
            this.PNL_Study_Screen.BackColor = System.Drawing.Color.Transparent;
            this.PNL_Study_Screen.Location = new System.Drawing.Point(0, 0);
            this.PNL_Study_Screen.Name = "PNL_Study_Screen";
            this.PNL_Study_Screen.Size = new System.Drawing.Size(801, 451);
            this.PNL_Study_Screen.TabIndex = 1;
            this.PNL_Study_Screen.Visible = false;
            // 
            // PNL_Scenario_Screen
            // 
            this.PNL_Scenario_Screen.BackColor = System.Drawing.Color.Transparent;
            this.PNL_Scenario_Screen.Controls.Add(this.BTN_start_exe);
            this.PNL_Scenario_Screen.Location = new System.Drawing.Point(0, 0);
            this.PNL_Scenario_Screen.Name = "PNL_Scenario_Screen";
            this.PNL_Scenario_Screen.Size = new System.Drawing.Size(801, 451);
            this.PNL_Scenario_Screen.TabIndex = 1;
            // 
            // PNL_LoadDataToTable_Screen
            // 
            this.PNL_LoadDataToTable_Screen.BackColor = System.Drawing.Color.Transparent;
            this.PNL_LoadDataToTable_Screen.Location = new System.Drawing.Point(0, 0);
            this.PNL_LoadDataToTable_Screen.Name = "PNL_LoadDataToTable_Screen";
            this.PNL_LoadDataToTable_Screen.Size = new System.Drawing.Size(801, 451);
            this.PNL_LoadDataToTable_Screen.TabIndex = 2;
            this.PNL_LoadDataToTable_Screen.Visible = false;
            // 
            // PNL_AddScenario_Screen
            // 
            this.PNL_AddScenario_Screen.BackColor = System.Drawing.Color.Transparent;
            this.PNL_AddScenario_Screen.Location = new System.Drawing.Point(0, 0);
            this.PNL_AddScenario_Screen.Name = "PNL_AddScenario_Screen";
            this.PNL_AddScenario_Screen.Size = new System.Drawing.Size(801, 451);
            this.PNL_AddScenario_Screen.TabIndex = 0;
            // 
            // PNL_authorisation_Screen
            // 
            this.PNL_authorisation_Screen.BackColor = System.Drawing.Color.Transparent;
            this.PNL_authorisation_Screen.Location = new System.Drawing.Point(0, 0);
            this.PNL_authorisation_Screen.Name = "PNL_authorisation_Screen";
            this.PNL_authorisation_Screen.Size = new System.Drawing.Size(801, 451);
            this.PNL_authorisation_Screen.TabIndex = 2;
            this.PNL_authorisation_Screen.Visible = false;
            // 
            // PNL_ChangePassword_Screen
            // 
            this.PNL_ChangePassword_Screen.BackColor = System.Drawing.Color.Transparent;
            this.PNL_ChangePassword_Screen.Location = new System.Drawing.Point(0, 0);
            this.PNL_ChangePassword_Screen.Name = "PNL_ChangePassword_Screen";
            this.PNL_ChangePassword_Screen.Size = new System.Drawing.Size(801, 451);
            this.PNL_ChangePassword_Screen.TabIndex = 3;
            this.PNL_ChangePassword_Screen.Visible = false;
            // 
            // BTN_start_exe
            // 
            this.BTN_start_exe.Location = new System.Drawing.Point(281, 186);
            this.BTN_start_exe.Name = "BTN_start_exe";
            this.BTN_start_exe.Size = new System.Drawing.Size(239, 66);
            this.BTN_start_exe.TabIndex = 0;
            this.BTN_start_exe.Text = "start program";
            this.BTN_start_exe.UseVisualStyleBackColor = true;
            this.BTN_start_exe.Click += new System.EventHandler(this.BTN_start_exe_Click);
            // 
            // VistaVirtuals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OVD_VistaVirtuals.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.PNL_Scenario_Screen);
            this.Controls.Add(this.PNL_authorisation_Screen);
            this.Controls.Add(this.PNL_LoadDataToTable_Screen);
            this.Controls.Add(this.PNL_AddScenario_Screen);
            this.Controls.Add(this.PNL_ChangePassword_Screen);
            this.Controls.Add(this.PNL_Start_Screen);
            this.Controls.Add(this.PNL_Study_Screen);
            this.DoubleBuffered = true;
            this.MinimizeBox = false;
            this.Name = "VistaVirtuals";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PNL_Scenario_Screen.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PNL_Start_Screen;
        private System.Windows.Forms.Panel PNL_Study_Screen;
        private System.Windows.Forms.Panel PNL_Scenario_Screen;
        private System.Windows.Forms.Panel PNL_LoadDataToTable_Screen;
        private System.Windows.Forms.Panel PNL_AddScenario_Screen;
        private System.Windows.Forms.Panel PNL_authorisation_Screen;
        private System.Windows.Forms.Panel PNL_ChangePassword_Screen;
        private System.Windows.Forms.Button BTN_start_exe;
    }
}

