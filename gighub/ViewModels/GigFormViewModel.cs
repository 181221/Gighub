﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using gighub.Models;

namespace gighub.ViewModels
{
    public class GigFormViewModel
    {
        public string Venue { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public int Genre { get; set; }
        public IEnumerable<Genre> Genres  { get; set; }
    }
}