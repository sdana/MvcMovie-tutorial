﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcMovie.Models
{
    public class MovieGenreViewModel
    {
        public List<Movies> movies;
        public SelectList genres;
        public string movieGenre { get; set; }
    }
}