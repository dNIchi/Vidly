using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    //rep state && behavior of application in terms of its problem domain
    //ie /movies/random
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}