using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIDemo.Models
{
    public class StateDetails
    {
        public int Sid { get; set; }
        public string Sname { get; set; }
       public CountryDetails countryDetails { get; set; }
    }
}