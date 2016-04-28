using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CityCountryInfoManagement.Gateway;
using CityCountryInfoManagement.Models;

namespace CityCountryInfoManagement.BLL
{
    public class CountryManager
    {
         CountryGateway countryGateway=new CountryGateway();
        public string save(Country country)
        {
            if (!countryGateway.IsCountryExists(country))
                {

                    if (countryGateway.Save(country) > 0)
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
                    return "This country is already existed";
                }
            }

        //public static List<Country> GetByCountryName(string searchName)
        //{
        //    return countryGateway.GetByCountryName(searchName);
        //}

        public  List<Country> LoadAllCountry()
        {
            return countryGateway.LoadAllCountry();
        }

        

        public List<CountryView> GetByCountryName(string countrySearchName)
        {
            return countryGateway.GetByCountryName(countrySearchName);
        }

        

        public List<CountryView> GetAllCountry()
        {
            return CountryGateway.GetAllCountry();
        }
    }
    }
