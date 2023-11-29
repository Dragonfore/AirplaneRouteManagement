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
    }
}
