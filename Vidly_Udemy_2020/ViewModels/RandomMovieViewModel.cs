using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly_Udemy_2020.Models;

namespace Vidly_Udemy_2020.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}