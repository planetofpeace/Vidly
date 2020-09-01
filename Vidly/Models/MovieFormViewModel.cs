﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vidly.Domain;

namespace Vidly.Models
{
    public class MovieFormViewModel
    {
        public Movie Movie { get; set; }
        public IEnumerable<Genre> Genres { get; set; }

        public string Title => Movie == null ? "New Movie" : "Edit Movie";
    }
}
