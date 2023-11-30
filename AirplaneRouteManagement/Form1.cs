﻿using AirplaneRouteManagement.Constants;
using AirplaneRouteManagement.Models;
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
        }

        private void BtnSearchByName_Click(object sender, EventArgs e)
        {
            var selectedItem = CityList.SelectedItem as City;
            var searchValue = SearchByNameValue.Text;

            if (selectedItem is null)
            {
                return;
            }

            var returnedCities = _cityService.GetCitiesByKeyword(searchValue);
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
                FlightsList.Items.Add(result);
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
                FlightsList.Items.Add(result);
            }
            else
            {
                // TODO Notify user
            }
        }

        private void BtnDeleteSelectedFlight_Click(object sender, EventArgs e)
        {
            var selectedItem = FlightsList.SelectedItem as Route;

            if (selectedItem is null)
            {
                return;
            }

            var result = _routeService.DeleteRoute(new DataTransferObjects.DeleteRouteDto
            {
                RouteId = selectedItem.Id,
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
            FlightsList.Items.AddRange(inboundFlights.ToArray());
            FlightsList.Items.AddRange(outboundFlights.ToArray());

            // Set City Lookup
            // TODO Set to exclude current city
            var cityLookupItems = _cityService.GetCities();
            CityLookupList.Items.AddRange(cityLookupItems.ToArray());
        }
    }
}
