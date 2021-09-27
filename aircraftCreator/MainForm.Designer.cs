
namespace aircraftCreator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.cb_ACtype = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Calc = new System.Windows.Forms.Button();
            this.cb_MissionProfile = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Range = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_CruiseSpeed = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_EngineType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_WingSpan = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_WingConfig = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_LandingGearConfig = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_RootCordLength = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_SweepAngle = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_OutputInitialWeight = new System.Windows.Forms.Label();
            this.lblPayload = new System.Windows.Forms.Label();
            this.tb_PayloadWeight = new System.Windows.Forms.TextBox();
            this.btn_resetValues = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_acName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnSaveAs = new System.Windows.Forms.ToolStripButton();
            this.btnLoad = new System.Windows.Forms.ToolStripButton();
            this.label13 = new System.Windows.Forms.Label();
            this.lbl_LDmaxRatio = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aircraft Type";
            // 
            // cb_ACtype
            // 
            this.cb_ACtype.AllowDrop = true;
            this.cb_ACtype.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_ACtype.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_ACtype.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cb_ACtype.FormattingEnabled = true;
            this.cb_ACtype.Location = new System.Drawing.Point(150, 34);
            this.cb_ACtype.Name = "cb_ACtype";
            this.cb_ACtype.Size = new System.Drawing.Size(300, 21);
            this.cb_ACtype.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mission Profile";
            // 
            // btn_Calc
            // 
            this.btn_Calc.Location = new System.Drawing.Point(277, 391);
            this.btn_Calc.Name = "btn_Calc";
            this.btn_Calc.Size = new System.Drawing.Size(124, 28);
            this.btn_Calc.TabIndex = 3;
            this.btn_Calc.Text = "Calculate";
            this.btn_Calc.UseVisualStyleBackColor = true;
            this.btn_Calc.Click += new System.EventHandler(this.btn_Calc_Click);
            // 
            // cb_MissionProfile
            // 
            this.cb_MissionProfile.AllowDrop = true;
            this.cb_MissionProfile.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_MissionProfile.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_MissionProfile.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cb_MissionProfile.FormattingEnabled = true;
            this.cb_MissionProfile.Location = new System.Drawing.Point(150, 70);
            this.cb_MissionProfile.Name = "cb_MissionProfile";
            this.cb_MissionProfile.Size = new System.Drawing.Size(300, 21);
            this.cb_MissionProfile.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Range [m]";
            // 
            // tb_Range
            // 
            this.tb_Range.Location = new System.Drawing.Point(150, 134);
            this.tb_Range.Name = "tb_Range";
            this.tb_Range.Size = new System.Drawing.Size(100, 20);
            this.tb_Range.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cruise Speed [m/s]";
            // 
            // tb_CruiseSpeed
            // 
            this.tb_CruiseSpeed.Location = new System.Drawing.Point(150, 161);
            this.tb_CruiseSpeed.Name = "tb_CruiseSpeed";
            this.tb_CruiseSpeed.Size = new System.Drawing.Size(100, 20);
            this.tb_CruiseSpeed.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Engine Type";
            // 
            // cb_EngineType
            // 
            this.cb_EngineType.AllowDrop = true;
            this.cb_EngineType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_EngineType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_EngineType.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cb_EngineType.FormattingEnabled = true;
            this.cb_EngineType.Location = new System.Drawing.Point(150, 189);
            this.cb_EngineType.Name = "cb_EngineType";
            this.cb_EngineType.Size = new System.Drawing.Size(300, 21);
            this.cb_EngineType.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Wingspan [m]";
            // 
            // tb_WingSpan
            // 
            this.tb_WingSpan.Location = new System.Drawing.Point(150, 219);
            this.tb_WingSpan.Name = "tb_WingSpan";
            this.tb_WingSpan.Size = new System.Drawing.Size(100, 20);
            this.tb_WingSpan.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Wing Configuration";
            // 
            // cb_WingConfig
            // 
            this.cb_WingConfig.AllowDrop = true;
            this.cb_WingConfig.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_WingConfig.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_WingConfig.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cb_WingConfig.FormattingEnabled = true;
            this.cb_WingConfig.Location = new System.Drawing.Point(150, 248);
            this.cb_WingConfig.Name = "cb_WingConfig";
            this.cb_WingConfig.Size = new System.Drawing.Size(300, 21);
            this.cb_WingConfig.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 342);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Landing Gear Configuration";
            // 
            // cb_LandingGearConfig
            // 
            this.cb_LandingGearConfig.AllowDrop = true;
            this.cb_LandingGearConfig.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_LandingGearConfig.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_LandingGearConfig.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cb_LandingGearConfig.FormattingEnabled = true;
            this.cb_LandingGearConfig.Location = new System.Drawing.Point(150, 339);
            this.cb_LandingGearConfig.Name = "cb_LandingGearConfig";
            this.cb_LandingGearConfig.Size = new System.Drawing.Size(300, 21);
            this.cb_LandingGearConfig.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 282);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Root Cord Length [m]";
            // 
            // tb_RootCordLength
            // 
            this.tb_RootCordLength.Location = new System.Drawing.Point(150, 279);
            this.tb_RootCordLength.Name = "tb_RootCordLength";
            this.tb_RootCordLength.Size = new System.Drawing.Size(100, 20);
            this.tb_RootCordLength.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(50, 312);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Wing Sweep [deg]";
            // 
            // tb_SweepAngle
            // 
            this.tb_SweepAngle.Location = new System.Drawing.Point(150, 309);
            this.tb_SweepAngle.Name = "tb_SweepAngle";
            this.tb_SweepAngle.Size = new System.Drawing.Size(100, 20);
            this.tb_SweepAngle.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(158, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Estimiated Take Off Weight [kg]";
            // 
            // lbl_OutputInitialWeight
            // 
            this.lbl_OutputInitialWeight.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lbl_OutputInitialWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_OutputInitialWeight.Location = new System.Drawing.Point(48, 63);
            this.lbl_OutputInitialWeight.Name = "lbl_OutputInitialWeight";
            this.lbl_OutputInitialWeight.Size = new System.Drawing.Size(97, 20);
            this.lbl_OutputInitialWeight.TabIndex = 25;
            this.lbl_OutputInitialWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPayload
            // 
            this.lblPayload.AutoSize = true;
            this.lblPayload.Location = new System.Drawing.Point(79, 108);
            this.lblPayload.Name = "lblPayload";
            this.lblPayload.Size = new System.Drawing.Size(66, 13);
            this.lblPayload.TabIndex = 26;
            this.lblPayload.Text = "Payload [kg]";
            // 
            // tb_PayloadWeight
            // 
            this.tb_PayloadWeight.Location = new System.Drawing.Point(151, 105);
            this.tb_PayloadWeight.Name = "tb_PayloadWeight";
            this.tb_PayloadWeight.Size = new System.Drawing.Size(100, 20);
            this.tb_PayloadWeight.TabIndex = 27;
            // 
            // btn_resetValues
            // 
            this.btn_resetValues.Location = new System.Drawing.Point(137, 391);
            this.btn_resetValues.Name = "btn_resetValues";
            this.btn_resetValues.Size = new System.Drawing.Size(124, 28);
            this.btn_resetValues.TabIndex = 28;
            this.btn_resetValues.Text = "Rest Values";
            this.btn_resetValues.UseVisualStyleBackColor = true;
            this.btn_resetValues.Click += new System.EventHandler(this.btn_resetValues_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lb_acName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cb_EngineType);
            this.panel1.Controls.Add(this.btn_resetValues);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tb_PayloadWeight);
            this.panel1.Controls.Add(this.cb_ACtype);
            this.panel1.Controls.Add(this.lblPayload);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_Calc);
            this.panel1.Controls.Add(this.cb_MissionProfile);
            this.panel1.Controls.Add(this.tb_SweepAngle);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.tb_Range);
            this.panel1.Controls.Add(this.tb_RootCordLength);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.tb_CruiseSpeed);
            this.panel1.Controls.Add(this.cb_LandingGearConfig);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cb_WingConfig);
            this.panel1.Controls.Add(this.tb_WingSpan);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(12, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 428);
            this.panel1.TabIndex = 29;
            // 
            // lb_acName
            // 
            this.lb_acName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_acName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_acName.Location = new System.Drawing.Point(150, 6);
            this.lb_acName.Name = "lb_acName";
            this.lb_acName.Size = new System.Drawing.Size(300, 20);
            this.lb_acName.TabIndex = 30;
            this.lb_acName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Configuration Name";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbl_LDmaxRatio);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.lbl_OutputInitialWeight);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(479, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 428);
            this.panel2.TabIndex = 30;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave,
            this.btnSaveAs,
            this.btnLoad});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(699, 31);
            this.toolStrip1.TabIndex = 31;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(28, 28);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveAs.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveAs.Image")));
            this.btnSaveAs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(28, 28);
            this.btnSaveAs.Text = "Save As";
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.Image")));
            this.btnLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(28, 28);
            this.btnLoad.Text = "Load Configuration";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(34, 105);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Estimated L/Dmax Ratio";
            // 
            // lbl_LDmaxRatio
            // 
            this.lbl_LDmaxRatio.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lbl_LDmaxRatio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_LDmaxRatio.Location = new System.Drawing.Point(48, 130);
            this.lbl_LDmaxRatio.Name = "lbl_LDmaxRatio";
            this.lbl_LDmaxRatio.Size = new System.Drawing.Size(97, 20);
            this.lbl_LDmaxRatio.TabIndex = 27;
            this.lbl_LDmaxRatio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 471);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Aircraft Initial Sizing";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_ACtype;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Calc;
        private System.Windows.Forms.ComboBox cb_MissionProfile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Range;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_CruiseSpeed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_EngineType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_WingSpan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_WingConfig;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_LandingGearConfig;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_RootCordLength;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_SweepAngle;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_OutputInitialWeight;
        private System.Windows.Forms.Label lblPayload;
        private System.Windows.Forms.TextBox tb_PayloadWeight;
        private System.Windows.Forms.Button btn_resetValues;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnSaveAs;
        private System.Windows.Forms.ToolStripButton btnLoad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_acName;
        private System.Windows.Forms.Label lbl_LDmaxRatio;
        private System.Windows.Forms.Label label13;
    }
}

