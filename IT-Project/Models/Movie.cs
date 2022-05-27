using IT_Project.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IT_Project.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime RunTime { get; set; }
        public MovieCategory MovieCategory { get; set; }

        //Relationships
        public List<Actor_Movie> Actors_Movies { get; set; }

        //Studio
        public int StudioId { get; set; }
        [ForeignKey("StudioId")]
        public Studio Studio { get; set; }

        //Producer
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; }

        //Rating
      //  public int RateId { get; set; }
       // [ForeignKey("RateId")]
      //  public Rate Rate { get; set; }

    }
}
