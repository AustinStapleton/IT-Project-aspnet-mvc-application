using IT_Project.Models;
using System.Collections.Generic;

namespace IT_Project.Data.ViewModel
{
    public class NewMovieDropdownsVM
    {
        public NewMovieDropdownsVM()
        {
            Producers = new List<Producer>();
            Studios = new List<Studio>();
            Actors = new List<Actor>();
        }

        public List<Producer> Producers { get; set; }
        public List<Studio> Studios { get; set; }
        public List<Actor> Actors { get; set; }
    }
}
