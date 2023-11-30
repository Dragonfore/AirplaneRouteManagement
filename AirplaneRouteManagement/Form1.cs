using AirplaneRouteManagement.Constants;
using AirplaneRouteManagement.DataTransferObjects;
using AirplaneRouteManagement.Models;
using AirplaneRouteManagement.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            SetupData();
        }

        private void SetupData()
        {
            var cities = _cityService.GetCities();
            CityList.Items.Clear();
            CityList.Items.AddRange(cities.ToArray());
            TotalCitiesValue.Text = cities.Count().ToString();
        }

        private void BtnEditCity_Click(object sender, EventArgs e)
        {
            var selectedItem = CityList.SelectedItem as City;

            if (selectedItem is null)
            {
                return;
            }

            AddEditCityNameValue.Text = selectedItem.Name;
            AddEditCityDescriptionValue.Text = selectedItem.Description;
            AddEditCityDataValue.Text = selectedItem.Id.ToString();
        }

        private void BtnDeleteCity_Click(object sender, EventArgs e)
        {
            var selectedItem = CityList.SelectedItem as City;

            if (selectedItem is null)
            {
                return;
            }

            var result = _cityService.DeleteCity(new DataTransferObjects.DeleteCityDto
            {
                CityId = selectedItem.Id,
                Operation = AppConstants.DeleteCityType,
            });

            if (result)
            {
                CityList.Items.Remove(selectedItem);
                CityLookupList.Items.Clear();
                FlightsList.Items.Clear();
                CurrentlySelectedCityValue.Text = "None";
                AddEditCityNameValue.Clear();
                AddEditCityDescriptionValue.Clear();

                SetupData();
            }
            else
            {
                // TODO handle false return
            }
        }

        private void BtnSaveCity_Click(object sender, EventArgs e)
        {
            var selectedItem = CityList.SelectedItem as City;
            var cityName = AddEditCityNameValue.Text;
            var cityDescription = AddEditCityDescriptionValue.Text;
            var cityData = AddEditCityDataValue.Text;

            if (cityName == null)
            {
                // TODO notify user via dialog
                return;
            }

            if (cityDescription == null)
            {
                // TODO notify user via dialog
                return;
            }

            // Add Flow
            if (string.IsNullOrWhiteSpace(cityData))
            {
                var result = _cityService.AddEditCity(new DataTransferObjects.AddEditCityDto
                {
                    CityName = cityName,
                    CityDescription = cityDescription,
                    Operation = AppConstants.AddCityType,
                });

                if (result != null)
                {
                    ClearAddEditCityForm();
                    ResetAfterSave();
                }
                else
                {
                    // TODO Handle failure
                }
            }
            // Edit Flow
            else
            {
                if (selectedItem == null)
                {
                    // TODO Add callback to notify user that no item is selected
                    return;
                }
                var result = _cityService.AddEditCity(new DataTransferObjects.AddEditCityDto
                {
                    CityId = selectedItem.Id,
                    CityName = cityName,
                    CityDescription = cityDescription,
                    Operation = AppConstants.EditCityType,
                });

                if (result != null)
                {
                    ClearAddEditCityForm();
                    ResetAfterSave();
                }
                else
                {
                    // TODO handle failure
                }
            }
        }

        private void ClearAddEditCityForm()
        {
            AddEditCityNameValue.Clear();
            AddEditCityDescriptionValue.Clear();
            AddEditCityDataValue.Clear();
        }

        private void ResetAfterSave()
        {
            // Clear City Name just in case the name has changed 
            // TODO Improve to only edit if name is different
            CityList.Items.Clear();
            CityLookupList.Items.Clear();
            FlightsList.Items.Clear();
            SetupData();
        }

        private void BtnCancelAddEditCity_Click(object sender, EventArgs e)
        {
            ClearAddEditCityForm();
        }

        private void ExportToFile_Click(object sender, EventArgs e)
        {
            // TODO Finish this with export to file
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.FileName = "Response.txt";
                saveFileDialog.Filter = "Text Files | *.txt";
                var cities = _cityService.GetCities().ToList();
                var routes = _routeService.GetRoutes().ToList();
                StreamWriter writer = new StreamWriter(saveFileDialog.FileName);
                if (cities.Any())
                {
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        foreach(var city in cities)
                        {
                            writer.WriteLine(city.Name + " - " + city.Description);
                            writer.WriteLine("Inbound");
                            foreach(var route in routes.Where(x => x.NodeId1 == city.Id))
                            {
                                var city2 = cities.First(x => x.Id == route.NodeId2);
                                writer.WriteLine(city2.Name + " - " + city2.Description);
                            }

                            writer.WriteLine("Outbound");
                            foreach (var route in routes.Where(x => x.NodeId2 == city.Id))
                            {
                                var city2 = cities.First(x => x.Id == route.NodeId1);
                                writer.WriteLine(city2.Name + " - " + city2.Description);
                            }
                            writer.WriteLine();
                        }
                    }
                }
                writer.Close();
                
            }
            catch (Exception ex)
            {
                // Fill out error
            }
        }

        private void BtnSearchByName_Click(object sender, EventArgs e)
        {
            var selectedItem = CityList.SelectedItem as City;
            var searchValue = SearchByNameValue.Text;

            if (selectedItem is null)
            {
                return;
            }

            var returnedCities = _cityService.GetCitiesByKeyword(searchValue, selectedItem.Id);
            CityLookupList.Items.Clear();
            CityLookupList.Items.AddRange(returnedCities.ToArray());
        }

        private void BtnAddInbound_Click(object sender, EventArgs e)
        {
            var selectedItem = CityLookupList.SelectedItem as City;
            var currentActiveCity = CityList.SelectedItem as City;

            if (selectedItem is null || currentActiveCity is null)
            {
                return;
            }

            var result = _routeService.AddEditRoute(new DataTransferObjects.AddEditRouteDto
            {
                CityId1 = currentActiveCity.Id,
                CityId2 = selectedItem.Id,
                Operation = AppConstants.AddInboundRouteType,
            });

            if (result != null)
            {
                FlightsList.Items.Clear();
                RefreshFlightList();
            }
            else
            {
                // TODO Notify user
            }
        }

        private void BtnAddOutbound_Click(object sender, EventArgs e)
        {
            var selectedItem = CityLookupList.SelectedItem as City;
            var currentActiveCity = CityList.SelectedItem as City;

            if (selectedItem is null || currentActiveCity is null)
            {
                return;
            }

            var result = _routeService.AddEditRoute(new DataTransferObjects.AddEditRouteDto
            {
                CityId1 = selectedItem.Id,
                CityId2 = currentActiveCity.Id,
                Operation = AppConstants.AddInboundRouteType,
            });

            if (result != null)
            {
                FlightsList.Items.Clear();
                RefreshFlightList();
            }
            else
            {
                // TODO Notify user
            }
        }

        private void BtnDeleteSelectedFlight_Click(object sender, EventArgs e)
        {
            var selectedItem = FlightsList.SelectedItem as FlightListDto;

            if (selectedItem is null)
            {
                return;
            }

            var result = _routeService.DeleteRoute(new DataTransferObjects.DeleteRouteDto
            {
                RouteId = selectedItem.RouteId,
                Operation = AppConstants.DeleteRoute,
            });

            if (result)
            {
                FlightsList.Items.Remove(selectedItem);
            }
            else
            {
                // TODO Notify user of failure to delete
            }
        }

        private void CityList_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshFlightList();
        }

        private void RefreshFlightList()
        {

            var currentSelection = CityList.SelectedItem as City;
            if (currentSelection is null)
            {
                return;
            }

            // Clear Existing
            FlightsList.Items.Clear();
            CityLookupList.Items.Clear();

            // Set Currently Selected City
            CurrentlySelectedCityValue.Text = currentSelection.Name;

            // Set Flight list
            (var inboundFlights, var outboundFlights) = _routeService.GetRoutesByCityId(currentSelection.Id);
            var inboundData = _cityService.GetFlightListDtoFromCityList(inboundFlights, "Inbound");
            var outboundData = _cityService.GetFlightListDtoFromCityList(outboundFlights, "Outbound");
            FlightsList.Items.AddRange(inboundData.ToArray());
            FlightsList.Items.AddRange(outboundData.ToArray());

            // Set City Lookup
            // TODO Set to exclude current city
            var cityLookupItems = _cityService.GetCitiesExceptActive(currentSelection.Id);
            CityLookupList.Items.AddRange(cityLookupItems.ToArray());
        }

        private void CityLookupList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
