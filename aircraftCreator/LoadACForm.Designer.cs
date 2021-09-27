
namespace aircraftCreator
{
    partial class LoadACForm
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
            this.lb_AircraftNames = new System.Windows.Forms.ListBox();
            this.btn_LoadACConfig = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_AircraftNames
            // 
            this.lb_AircraftNames.FormattingEnabled = true;
            this.lb_AircraftNames.Location = new System.Drawing.Point(124, 26);
            this.lb_AircraftNames.Name = "lb_AircraftNames";
            this.lb_AircraftNames.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_AircraftNames.Size = new System.Drawing.Size(149, 95);
            this.lb_AircraftNames.Sorted = true;
            this.lb_AircraftNames.TabIndex = 0;
            // 
            // btn_LoadACConfig
            // 
            this.btn_LoadACConfig.Location = new System.Drawing.Point(164, 137);
            this.btn_LoadACConfig.Name = "btn_LoadACConfig";
            this.btn_LoadACConfig.Size = new System.Drawing.Size(75, 23);
            this.btn_LoadACConfig.TabIndex = 1;
            this.btn_LoadACConfig.Text = "Load";
            this.btn_LoadACConfig.UseVisualStyleBackColor = true;
            this.btn_LoadACConfig.Click += new System.EventHandler(this.btn_LoadACConfig_Click);
            // 
            // LoadACForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 194);
            this.Controls.Add(this.btn_LoadACConfig);
            this.Controls.Add(this.lb_AircraftNames);
            this.Name = "LoadACForm";
            this.Text = "LoadACForm";
            this.Load += new System.EventHandler(this.LoadACForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_AircraftNames;
        private System.Windows.Forms.Button btn_LoadACConfig;
    }
}