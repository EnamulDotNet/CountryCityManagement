using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CityCountryInfoManagement.Models
{
    public class City
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string About { get; set; }
        public long Dwellers { get; set; }
        public string Weather { get; set; }
        public string CountryId { get; set; }
        public int Id { get; set; }
    }
}