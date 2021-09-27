
namespace aircraftCreator
{
    partial class SaveAsForm
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
            this.lbl_SaveAsLabel = new System.Windows.Forms.Label();
            this.tb_AircraftName = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_SaveAsLabel
            // 
            this.lbl_SaveAsLabel.AutoSize = true;
            this.lbl_SaveAsLabel.Location = new System.Drawing.Point(85, 25);
            this.lbl_SaveAsLabel.Name = "lbl_SaveAsLabel";
            this.lbl_SaveAsLabel.Size = new System.Drawing.Size(126, 13);
            this.lbl_SaveAsLabel.TabIndex = 0;
            this.lbl_SaveAsLabel.Text = "Give your Aircraft a name";
            // 
            // tb_AircraftName
            // 
            this.tb_AircraftName.Location = new System.Drawing.Point(35, 51);
            this.tb_AircraftName.Name = "tb_AircraftName";
            this.tb_AircraftName.Size = new System.Drawing.Size(235, 20);
            this.tb_AircraftName.TabIndex = 1;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(116, 87);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 2;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // SaveAsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 133);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tb_AircraftName);
            this.Controls.Add(this.lbl_SaveAsLabel);
            this.Name = "SaveAsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Save Aircraft Configuration";
            this.Load += new System.EventHandler(this.SaveAsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_SaveAsLabel;
        private System.Windows.Forms.TextBox tb_AircraftName;
        private System.Windows.Forms.Button btn_Save;
    }
}