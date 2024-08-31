using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        public string ProfilePicture { get; set; }
        public string FullNames { get; set; }
        public string Bio { get; set; }

        //ERD Relationships(one-to-many)
        public List<Movie> Movies { get; set; }


    }
}
