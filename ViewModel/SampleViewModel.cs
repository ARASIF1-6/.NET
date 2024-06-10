using Lab1Task.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab1Task.ViewModel
{
    public class SampleViewModel
    {
        public List<Player> Player { get; set; }
        public List<Staff> Staff { get; set; }
        public Stadium Stadium { get; set; }    
    }
}