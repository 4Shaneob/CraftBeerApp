using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcBeerApp.Models
{
    public class Description
    {
        public int DescriptionID { get; set; }

        public int BeerID { get; set; }
        public Beer Beers { get; set; }

        public virtual Beer Beer { get; set; }

        public string Contents { get; set; }

        public string BreweryEmail { get; set; }
    }
}
