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
            this.CityList = new System.Windows.Forms.ListBox();
            this.CityListLabel = new System.Windows.Forms.Label();
            this.AddEditCityBox = new System.Windows.Forms.GroupBox();
            this.BtnSaveCity = new System.Windows.Forms.Button();
            this.BtnCancelAddEditCity = new System.Windows.Forms.Button();
            this.BtnEditCity = new System.Windows.Forms.Button();
            this.BtnDeleteCity = new System.Windows.Forms.Button();
            this.AddEditCityNameValue = new System.Windows.Forms.TextBox();
            this.AddEditCityDescriptionValue = new System.Windows.Forms.TextBox();
            this.AddEditCityDataValue = new System.Windows.Forms.TextBox();
            this.AddEditCityNameLabel = new System.Windows.Forms.Label();
            this.AddEditCityDescriptionLabel = new System.Windows.Forms.Label();
            this.CurrentlySelectedCityLabel = new System.Windows.Forms.Label();
            this.CurrentlySelectedCityValue = new System.Windows.Forms.Label();
            this.OutboundFlightsLabel = new System.Windows.Forms.Label();
            this.FlightsList = new System.Windows.Forms.ListBox();
            this.BtnDeleteSelectedFlight = new System.Windows.Forms.Button();
            this.CityLookupList = new System.Windows.Forms.ListBox();
            this.SearchByNameBox = new System.Windows.Forms.GroupBox();
            this.SearchByNameLabel = new System.Windows.Forms.Label();
            this.SearchByNameValue = new System.Windows.Forms.TextBox();
            this.BtnSearchByName = new System.Windows.Forms.Button();
            this.BtnAddInbound = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ExportToFileLabel = new System.Windows.Forms.Label();
            this.ExportToFile = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddEditCityBox.SuspendLayout();
            this.SearchByNameBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            // CityList
            // 
            this.CityList.FormattingEnabled = true;
            this.CityList.Location = new System.Drawing.Point(16, 67);
            this.CityList.Name = "CityList";
            this.CityList.Size = new System.Drawing.Size(120, 290);
            this.CityList.TabIndex = 2;
            this.CityList.SelectedIndexChanged += new System.EventHandler(this.CityList_SelectedIndexChanged);
            // 
            // CityListLabel
            // 
            this.CityListLabel.AutoSize = true;
            this.CityListLabel.Location = new System.Drawing.Point(13, 49);
            this.CityListLabel.Name = "CityListLabel";
            this.CityListLabel.Size = new System.Drawing.Size(63, 13);
            this.CityListLabel.TabIndex = 3;
            this.CityListLabel.Text = "List of Cities";
            // 
            // AddEditCityBox
            // 
            this.AddEditCityBox.Controls.Add(this.AddEditCityDescriptionLabel);
            this.AddEditCityBox.Controls.Add(this.AddEditCityNameLabel);
            this.AddEditCityBox.Controls.Add(this.AddEditCityDataValue);
            this.AddEditCityBox.Controls.Add(this.AddEditCityDescriptionValue);
            this.AddEditCityBox.Controls.Add(this.AddEditCityNameValue);
            this.AddEditCityBox.Controls.Add(this.BtnCancelAddEditCity);
            this.AddEditCityBox.Controls.Add(this.BtnSaveCity);
            this.AddEditCityBox.Location = new System.Drawing.Point(183, 13);
            this.AddEditCityBox.Name = "AddEditCityBox";
            this.AddEditCityBox.Size = new System.Drawing.Size(202, 152);
            this.AddEditCityBox.TabIndex = 4;
            this.AddEditCityBox.TabStop = false;
            this.AddEditCityBox.Text = "Add or Edit City";
            // 
            // BtnSaveCity
            // 
            this.BtnSaveCity.Location = new System.Drawing.Point(119, 34);
            this.BtnSaveCity.Name = "BtnSaveCity";
            this.BtnSaveCity.Size = new System.Drawing.Size(75, 23);
            this.BtnSaveCity.TabIndex = 0;
            this.BtnSaveCity.Text = "Save";
            this.BtnSaveCity.UseVisualStyleBackColor = true;
            this.BtnSaveCity.Click += new System.EventHandler(this.BtnSaveCity_Click);
            // 
            // BtnCancelAddEditCity
            // 
            this.BtnCancelAddEditCity.Location = new System.Drawing.Point(119, 79);
            this.BtnCancelAddEditCity.Name = "BtnCancelAddEditCity";
            this.BtnCancelAddEditCity.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelAddEditCity.TabIndex = 1;
            this.BtnCancelAddEditCity.Text = "Cancel";
            this.BtnCancelAddEditCity.UseVisualStyleBackColor = true;
            this.BtnCancelAddEditCity.Click += new System.EventHandler(this.BtnCancelAddEditCity_Click);
            // 
            // BtnEditCity
            // 
            this.BtnEditCity.Location = new System.Drawing.Point(16, 363);
            this.BtnEditCity.Name = "BtnEditCity";
            this.BtnEditCity.Size = new System.Drawing.Size(120, 23);
            this.BtnEditCity.TabIndex = 5;
            this.BtnEditCity.Text = "Edit City";
            this.BtnEditCity.UseVisualStyleBackColor = true;
            this.BtnEditCity.Click += new System.EventHandler(this.BtnEditCity_Click);
            // 
            // BtnDeleteCity
            // 
            this.BtnDeleteCity.Location = new System.Drawing.Point(16, 392);
            this.BtnDeleteCity.Name = "BtnDeleteCity";
            this.BtnDeleteCity.Size = new System.Drawing.Size(120, 23);
            this.BtnDeleteCity.TabIndex = 6;
            this.BtnDeleteCity.Text = "Delete City";
            this.BtnDeleteCity.UseVisualStyleBackColor = true;
            this.BtnDeleteCity.Click += new System.EventHandler(this.BtnDeleteCity_Click);
            // 
            // AddEditCityNameValue
            // 
            this.AddEditCityNameValue.Location = new System.Drawing.Point(6, 36);
            this.AddEditCityNameValue.Name = "AddEditCityNameValue";
            this.AddEditCityNameValue.Size = new System.Drawing.Size(100, 20);
            this.AddEditCityNameValue.TabIndex = 2;
            // 
            // AddEditCityDescriptionValue
            // 
            this.AddEditCityDescriptionValue.Location = new System.Drawing.Point(6, 81);
            this.AddEditCityDescriptionValue.Multiline = true;
            this.AddEditCityDescriptionValue.Name = "AddEditCityDescriptionValue";
            this.AddEditCityDescriptionValue.Size = new System.Drawing.Size(100, 65);
            this.AddEditCityDescriptionValue.TabIndex = 3;
            // 
            // AddEditCityDataValue
            // 
            this.AddEditCityDataValue.Location = new System.Drawing.Point(119, 126);
            this.AddEditCityDataValue.Name = "AddEditCityDataValue";
            this.AddEditCityDataValue.Size = new System.Drawing.Size(75, 20);
            this.AddEditCityDataValue.TabIndex = 4;
            this.AddEditCityDataValue.Visible = false;
            // 
            // AddEditCityNameLabel
            // 
            this.AddEditCityNameLabel.AutoSize = true;
            this.AddEditCityNameLabel.Location = new System.Drawing.Point(7, 20);
            this.AddEditCityNameLabel.Name = "AddEditCityNameLabel";
            this.AddEditCityNameLabel.Size = new System.Drawing.Size(55, 13);
            this.AddEditCityNameLabel.TabIndex = 5;
            this.AddEditCityNameLabel.Text = "City Name";
            // 
            // AddEditCityDescriptionLabel
            // 
            this.AddEditCityDescriptionLabel.AutoSize = true;
            this.AddEditCityDescriptionLabel.Location = new System.Drawing.Point(6, 63);
            this.AddEditCityDescriptionLabel.Name = "AddEditCityDescriptionLabel";
            this.AddEditCityDescriptionLabel.Size = new System.Drawing.Size(80, 13);
            this.AddEditCityDescriptionLabel.TabIndex = 6;
            this.AddEditCityDescriptionLabel.Text = "City Description";
            // 
            // CurrentlySelectedCityLabel
            // 
            this.CurrentlySelectedCityLabel.AutoSize = true;
            this.CurrentlySelectedCityLabel.Location = new System.Drawing.Point(655, 35);
            this.CurrentlySelectedCityLabel.Name = "CurrentlySelectedCityLabel";
            this.CurrentlySelectedCityLabel.Size = new System.Drawing.Size(116, 13);
            this.CurrentlySelectedCityLabel.TabIndex = 7;
            this.CurrentlySelectedCityLabel.Text = "Currently Selected City:";
            // 
            // CurrentlySelectedCityValue
            // 
            this.CurrentlySelectedCityValue.AutoSize = true;
            this.CurrentlySelectedCityValue.Location = new System.Drawing.Point(775, 35);
            this.CurrentlySelectedCityValue.Name = "CurrentlySelectedCityValue";
            this.CurrentlySelectedCityValue.Size = new System.Drawing.Size(33, 13);
            this.CurrentlySelectedCityValue.TabIndex = 8;
            this.CurrentlySelectedCityValue.Text = "None";
            // 
            // OutboundFlightsLabel
            // 
            this.OutboundFlightsLabel.AutoSize = true;
            this.OutboundFlightsLabel.Location = new System.Drawing.Point(655, 64);
            this.OutboundFlightsLabel.Name = "OutboundFlightsLabel";
            this.OutboundFlightsLabel.Size = new System.Drawing.Size(51, 13);
            this.OutboundFlightsLabel.TabIndex = 10;
            this.OutboundFlightsLabel.Text = "Flight List";
            // 
            // FlightsList
            // 
            this.FlightsList.FormattingEnabled = true;
            this.FlightsList.Location = new System.Drawing.Point(658, 80);
            this.FlightsList.Name = "FlightsList";
            this.FlightsList.Size = new System.Drawing.Size(187, 277);
            this.FlightsList.TabIndex = 12;
            this.FlightsList.SelectedIndexChanged += new System.EventHandler(this.FlightsList_SelectedIndexChanged);
            // 
            // BtnDeleteSelectedFlight
            // 
            this.BtnDeleteSelectedFlight.Location = new System.Drawing.Point(689, 363);
            this.BtnDeleteSelectedFlight.Name = "BtnDeleteSelectedFlight";
            this.BtnDeleteSelectedFlight.Size = new System.Drawing.Size(129, 23);
            this.BtnDeleteSelectedFlight.TabIndex = 14;
            this.BtnDeleteSelectedFlight.Text = "Delete Selected";
            this.BtnDeleteSelectedFlight.UseVisualStyleBackColor = true;
            this.BtnDeleteSelectedFlight.Click += new System.EventHandler(this.BtnDeleteSelectedFlight_Click);
            // 
            // CityLookupList
            // 
            this.CityLookupList.FormattingEnabled = true;
            this.CityLookupList.Location = new System.Drawing.Point(418, 132);
            this.CityLookupList.Name = "CityLookupList";
            this.CityLookupList.Size = new System.Drawing.Size(163, 225);
            this.CityLookupList.TabIndex = 15;
            this.CityLookupList.SelectedIndexChanged += new System.EventHandler(this.CityLookupList_SelectedIndexChanged);
            // 
            // SearchByNameBox
            // 
            this.SearchByNameBox.Controls.Add(this.BtnSearchByName);
            this.SearchByNameBox.Controls.Add(this.SearchByNameValue);
            this.SearchByNameBox.Controls.Add(this.SearchByNameLabel);
            this.SearchByNameBox.Location = new System.Drawing.Point(418, 12);
            this.SearchByNameBox.Name = "SearchByNameBox";
            this.SearchByNameBox.Size = new System.Drawing.Size(163, 100);
            this.SearchByNameBox.TabIndex = 16;
            this.SearchByNameBox.TabStop = false;
            this.SearchByNameBox.Text = "Search by Name";
            // 
            // SearchByNameLabel
            // 
            this.SearchByNameLabel.AutoSize = true;
            this.SearchByNameLabel.Location = new System.Drawing.Point(37, 20);
            this.SearchByNameLabel.Name = "SearchByNameLabel";
            this.SearchByNameLabel.Size = new System.Drawing.Size(83, 13);
            this.SearchByNameLabel.TabIndex = 0;
            this.SearchByNameLabel.Text = "Enter City Name";
            // 
            // SearchByNameValue
            // 
            this.SearchByNameValue.Location = new System.Drawing.Point(10, 36);
            this.SearchByNameValue.Name = "SearchByNameValue";
            this.SearchByNameValue.Size = new System.Drawing.Size(143, 20);
            this.SearchByNameValue.TabIndex = 1;
            // 
            // BtnSearchByName
            // 
            this.BtnSearchByName.Location = new System.Drawing.Point(45, 71);
            this.BtnSearchByName.Name = "BtnSearchByName";
            this.BtnSearchByName.Size = new System.Drawing.Size(75, 23);
            this.BtnSearchByName.TabIndex = 2;
            this.BtnSearchByName.Text = "Search";
            this.BtnSearchByName.UseVisualStyleBackColor = true;
            this.BtnSearchByName.Click += new System.EventHandler(this.BtnSearchByName_Click);
            // 
            // BtnAddInbound
            // 
            this.BtnAddInbound.Location = new System.Drawing.Point(589, 170);
            this.BtnAddInbound.Name = "BtnAddInbound";
            this.BtnAddInbound.Size = new System.Drawing.Size(63, 64);
            this.BtnAddInbound.TabIndex = 17;
            this.BtnAddInbound.Text = "Add Inbound Route";
            this.BtnAddInbound.UseVisualStyleBackColor = true;
            this.BtnAddInbound.Click += new System.EventHandler(this.BtnAddInbound_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(589, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 64);
            this.button1.TabIndex = 18;
            this.button1.Text = "Add Outbound Route";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExportToFileLabel
            // 
            this.ExportToFileLabel.AutoSize = true;
            this.ExportToFileLabel.Location = new System.Drawing.Point(60, 34);
            this.ExportToFileLabel.Name = "ExportToFileLabel";
            this.ExportToFileLabel.Size = new System.Drawing.Size(68, 13);
            this.ExportToFileLabel.TabIndex = 19;
            this.ExportToFileLabel.Text = "Export to File";
            // 
            // ExportToFile
            // 
            this.ExportToFile.Location = new System.Drawing.Point(60, 51);
            this.ExportToFile.Name = "ExportToFile";
            this.ExportToFile.Size = new System.Drawing.Size(75, 23);
            this.ExportToFile.TabIndex = 20;
            this.ExportToFile.Text = "Export";
            this.ExportToFile.UseVisualStyleBackColor = true;
            this.ExportToFile.Click += new System.EventHandler(this.ExportToFile_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ExportToFile);
            this.groupBox1.Controls.Add(this.ExportToFileLabel);
            this.groupBox1.Location = new System.Drawing.Point(183, 257);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Export Controls";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 427);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnAddInbound);
            this.Controls.Add(this.SearchByNameBox);
            this.Controls.Add(this.CityLookupList);
            this.Controls.Add(this.BtnDeleteSelectedFlight);
            this.Controls.Add(this.FlightsList);
            this.Controls.Add(this.OutboundFlightsLabel);
            this.Controls.Add(this.CurrentlySelectedCityValue);
            this.Controls.Add(this.CurrentlySelectedCityLabel);
            this.Controls.Add(this.BtnDeleteCity);
            this.Controls.Add(this.BtnEditCity);
            this.Controls.Add(this.AddEditCityBox);
            this.Controls.Add(this.CityListLabel);
            this.Controls.Add(this.CityList);
            this.Controls.Add(this.TotalCitiesValue);
            this.Controls.Add(this.TotalCitiesLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Route Management";
            this.AddEditCityBox.ResumeLayout(false);
            this.AddEditCityBox.PerformLayout();
            this.SearchByNameBox.ResumeLayout(false);
            this.SearchByNameBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TotalCitiesLabel;
        private System.Windows.Forms.Label TotalCitiesValue;
        private System.Windows.Forms.ListBox CityList;
        private System.Windows.Forms.Label CityListLabel;
        private System.Windows.Forms.GroupBox AddEditCityBox;
        private System.Windows.Forms.Button BtnCancelAddEditCity;
        private System.Windows.Forms.Button BtnSaveCity;
        private System.Windows.Forms.Button BtnEditCity;
        private System.Windows.Forms.Button BtnDeleteCity;
        private System.Windows.Forms.TextBox AddEditCityDescriptionValue;
        private System.Windows.Forms.TextBox AddEditCityNameValue;
        private System.Windows.Forms.TextBox AddEditCityDataValue;
        private System.Windows.Forms.Label AddEditCityNameLabel;
        private System.Windows.Forms.Label AddEditCityDescriptionLabel;
        private System.Windows.Forms.Label CurrentlySelectedCityLabel;
        private System.Windows.Forms.Label CurrentlySelectedCityValue;
        private System.Windows.Forms.Label OutboundFlightsLabel;
        private System.Windows.Forms.ListBox FlightsList;
        private System.Windows.Forms.Button BtnDeleteSelectedFlight;
        private System.Windows.Forms.ListBox CityLookupList;
        private System.Windows.Forms.GroupBox SearchByNameBox;
        private System.Windows.Forms.Button BtnSearchByName;
        private System.Windows.Forms.TextBox SearchByNameValue;
        private System.Windows.Forms.Label SearchByNameLabel;
        private System.Windows.Forms.Button BtnAddInbound;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ExportToFileLabel;
        private System.Windows.Forms.Button ExportToFile;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

