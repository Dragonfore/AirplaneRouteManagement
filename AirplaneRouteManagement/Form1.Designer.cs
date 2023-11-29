namespace AirplaneRouteManagement
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TotalCitiesLabel = new System.Windows.Forms.Label();
            this.TotalCitiesValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TotalCitiesLabel
            // 
            this.TotalCitiesLabel.AutoSize = true;
            this.TotalCitiesLabel.Location = new System.Drawing.Point(13, 13);
            this.TotalCitiesLabel.Name = "TotalCitiesLabel";
            this.TotalCitiesLabel.Size = new System.Drawing.Size(62, 13);
            this.TotalCitiesLabel.TabIndex = 0;
            this.TotalCitiesLabel.Text = "Total Cities:";
            // 
            // TotalCitiesValue
            // 
            this.TotalCitiesValue.AutoSize = true;
            this.TotalCitiesValue.Location = new System.Drawing.Point(72, 13);
            this.TotalCitiesValue.Name = "TotalCitiesValue";
            this.TotalCitiesValue.Size = new System.Drawing.Size(13, 13);
            this.TotalCitiesValue.TabIndex = 1;
            this.TotalCitiesValue.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 619);
            this.Controls.Add(this.TotalCitiesValue);
            this.Controls.Add(this.TotalCitiesLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Route Management";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TotalCitiesLabel;
        private System.Windows.Forms.Label TotalCitiesValue;
    }
}

