using eTickets.Data.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Principal;

namespace eTickets.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImageURL { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
                
        public DateTime UpdatedDate { get; set; }
        public MovieCategory MovieCategory { get; set; }

        //ERD Relationships

        public List<Actor_Movie> Actors_Movies { get; set; }

        //Cinema relationship
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]

        public Cinema Cinema { get; set; }

        //Producer relationship
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer  Producer { get; set; }


    }
}
