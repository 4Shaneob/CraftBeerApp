using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcBeerApp.Models
{
    public class Brewery
    {

        public int BreweryID { get; set; }

        public String BreweryName { get; set; }

        public List<Beer> Beers { get; set; }
    }
}