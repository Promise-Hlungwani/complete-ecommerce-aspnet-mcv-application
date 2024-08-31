using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        public string ProfilePictureURL { get; set; }
        public string FullNames { get; set; }
        public string Bio { get; set; }

        //ERD Relationships(many-to-many)
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
