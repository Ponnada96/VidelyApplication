using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidelyApplication.Models;

namespace VidelyApplication.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movies Movie { get; set; }
        public List<Customers> Customers { get; set; }
    }
}