using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CityCountryInfoManagement.Gateway;
using CityCountryInfoManagement.Models;

namespace CityCountryInfoManagement.BLL
{
    public class CityManager
    {
        CityGateway cityGateway = new CityGateway();
        public string Save(City city)
        {
            if (!cityGateway.IsCityExists(city))
            {

                if (cityGateway.Save(city) > 0)
                {
                    return "Save Succesfully";
                }
                else
                {
                    return "save failed";
                }
            }
            else
            {
                return "This City is already existed";
            }
        }

        public List<City> LoadAllCities()
        {
            return cityGateway.LoadAllCities();
        }

        public List<CityView> GetCityByCityName(string citySearchName)
        {
            return cityGateway.GetCityByCityName(citySearchName);
        }

        public List<Country> GetAllCountry()
        {
            return cityGateway.GetAllCountry();
        }

        public List<CityView> GetAllCity()
        {
            return cityGateway.GetAllCity();
        }

        public List<CityView> GetCityByCountryName(string countrySearchName)
        {
            return cityGateway.GetCityByCountryName(countrySearchName);
        }
    }
}