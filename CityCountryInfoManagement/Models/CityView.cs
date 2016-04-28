using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CityCountryInfoManagement.Models
{
    public class CityView
    {
        public string CityName { get; set; }
        public string CityAbout { get; set; }
        public long NoOfDwellers { get; set; }
        public string Location { get; set; }
        public string Weather { get; set; }
        public string CountryName { get; set; }
        public string CountryAbout { get; set; }
        public int Id { get; set; }
    }
}