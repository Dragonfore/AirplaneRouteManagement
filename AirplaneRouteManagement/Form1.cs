using AirplaneRouteManagement.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirplaneRouteManagement
{
    public partial class Form1 : Form
    {
        private readonly ICityService _cityService;
        private readonly IRouteService _routeService;

        public Form1(ICityService cityService, IRouteService routeService)
        {
            InitializeComponent();

            _cityService = cityService;
            _routeService = routeService;
        }

        private void BtnEditCity_Click(object sender, EventArgs e)
        {

        }

        private void BtnDeleteCity_Click(object sender, EventArgs e)
        {

        }

        private void BtnSaveCity_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancelAddEditCity_Click(object sender, EventArgs e)
        {

        }

        private void ExportToFile_Click(object sender, EventArgs e)
        {

        }

        private void BtnSearchByName_Click(object sender, EventArgs e)
        {

        }

        private void BtnAddInbound_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnDeleteSelectedFlight_Click(object sender, EventArgs e)
        {

        }

        private void CityList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CityLookupList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FlightsList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
