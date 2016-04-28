using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CityCountryInfoManagement.Models
{
    public class CountryView
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string About { get; set; }
        public int NoOfCities { get; set; }
        public long NoOfDwellers { get; set; }
    }
}