using eTickets.Data.Enums;
using eTickets.Models;

namespace eTickets.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                       new Cinema()
                    {
                        Name = "Ster-Kinekor",
                        Logo = "/images/cinemas/sk-logo.jpg", 
                        Description = "Ster-Kinekor is the largest cinema chain in South Africa, offering a wide range of movies from Hollywood blockbusters to local films. They provide state-of-the-art facilities, including IMAX and 3D screenings, and have numerous locations across the country."
                    },
                    new Cinema()
                    {
                        Name = "Nu Metro",
                        Logo = "/images/cinemas/numetro.jpg",
                        Description = "Nu Metro is another leading cinema chain in South Africa, known for its luxurious cinema experiences. They offer various formats such as 4DX, VIP lounges, and Scene Xtreme for an enhanced movie-watching experience."
                    },
                    new Cinema()
                    {
                        Name = "CineCenter",
                        Logo = "/images/cinemas/cinecenter.jpg", 
                        Description = "CineCentre is a smaller cinema chain that focuses on providing a family-friendly environment. They offer a mix of mainstream and Bollywood films, catering to diverse audiences."
                    },
                  
                  });
                    context.SaveChanges();
                }
                //Actors
                if (!context.Actors.Any())
                {

                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor() { FullNames = "Robert Downey Jr.", Bio = "An American actor and producer. Known for Iron Man, Sherlock Holmes, and Chaplin.", ProfilePictureURL = "/images/actors/robert.jpg" },
                        new Actor() { FullNames = "Scarlett Johansson", Bio = "An American actress and singer. Known for Lost in Translation, The Avengers, and Lucy.", ProfilePictureURL = "/images/actors/scarlett.jpg" },
                        new Actor() { FullNames = "Chris Hemsworth", Bio = "An Australian actor. Known for Thor, The Avengers, and Rush.", ProfilePictureURL = "/images/actors/chris.jpg" },
                        new Actor() { FullNames = "Tom Hanks", Bio = "An American actor and filmmaker. Known for Forrest Gump, Cast Away, and Toy Story.", ProfilePictureURL = "/images/actors/tom.jpg" },
                        new Actor() { FullNames = "Emma Watson", Bio = "A British actress and activist. Known for Harry Potter series, Beauty and the Beast, and Little Women.", ProfilePictureURL = "/images/actors/emma.jpg" }


                    });
                    context.SaveChanges();
                }
                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                       new Producer() { FullNames = "Kevin Feige", Bio = "An American film producer and president of Marvel Studios.", ProfilePicture = "/images/actors/kevin.jpg" },
                       new Producer() { FullNames = "Kathleen Kennedy", Bio = "An American film producer and president of Lucasfilm.", ProfilePicture = "/images/actors/kathleen.jpg" }
  

                });
                    context.SaveChanges();
                }
                //Movies
                if (!context.Movies.Any())
                {

                    context.Movies.AddRange(new List<Movie>()
                    {
                       // Action
                        new Movie() { Title = "Avengers: Endgame", Description = "After the devastating events of Avengers: Infinity War, the universe is in ruins. With the help of remaining allies, the Avengers assemble once more to reverse Thanos' actions and restore balance to the universe.", ImageURL = "/images/movies/endgame.jpg", MovieCategory = MovieCategory.Action, CreatedDate = DateTime.Now.AddDays(-10), UpdatedDate = DateTime.Now.AddDays(4), CinemaId = 3, ProducerId = 1 },
                        new Movie() { Title = "Mad Max: Fury Road", Description = "In a post-apocalyptic wasteland, Max teams up with Furiosa to escape a cult leader.", ImageURL = "/images/movies/madmax.jpg", MovieCategory = MovieCategory.Action , CreatedDate = DateTime.Now.AddDays(10), UpdatedDate = DateTime.Now, CinemaId = 2, ProducerId = 2},
        
                        // Animation
                        new Movie() { Title = "Toy Story", Description = "A cowboy doll is profoundly threatened and jealous when a new spaceman figure supplants him as top toy in a boy's room.", ImageURL = "/images/movies/toystory.jpg", MovieCategory = MovieCategory.Animation, CreatedDate = DateTime.Now.AddDays(4), UpdatedDate = DateTime.Now.AddDays(-1), CinemaId = 1, ProducerId = 2 },
                        new Movie() { Title = "Finding Nemo", Description = "After his son is captured in the Great Barrier Reef and taken to Sydney, a timid clownfish sets out on a journey to bring him home.", ImageURL = "/images/movies/nemo.jpg", MovieCategory = MovieCategory.Animation, CreatedDate = DateTime.Now.AddDays(-10), UpdatedDate = DateTime.Now, CinemaId = 3, ProducerId = 2 },
        
                        // Comedy
                        new Movie() { Title = "The Hangover", Description = "Three buddies wake up from a bachelor party in Las Vegas, with no memory of the previous night and the bachelor missing.", ImageURL = "/images/movies/hangover.jpg", MovieCategory = MovieCategory.Comedy, CreatedDate = DateTime.Now.AddDays(-5), UpdatedDate = DateTime.Now.AddDays(1), CinemaId = 3, ProducerId = 1 },
                        new Movie() { Title = "Superbad", Description = "Two co-dependent high school seniors are forced to deal with separation anxiety after their plan to stage a booze-soaked party goes awry.", ImageURL = "/images/movies/superbad.jpg", MovieCategory = MovieCategory.Comedy, CreatedDate = DateTime.Now.AddDays(-10), UpdatedDate = DateTime.Now, CinemaId = 1, ProducerId = 1 },
        
                        // Crime
                        new Movie() { Title = "The Godfather", Description = "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.", ImageURL = "/images/movies/godfather.jpg", MovieCategory = MovieCategory.Crime, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now.AddDays(20) , CinemaId = 2, ProducerId = 1},
                        new Movie() { Title = "Pulp Fiction", Description = "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.", ImageURL = "/images/movies/pulpfiction.jpg", MovieCategory = MovieCategory.Crime, CreatedDate = DateTime.Now.AddDays(3), UpdatedDate = DateTime.Now.AddDays(10), CinemaId = 2, ProducerId = 1 },
        
                        // Fantasy
                        new Movie() { Title = "Harry Potter and the Sorcerer's Stone", Description = "An orphaned boy enrolls in a school of wizardry, where he learns the truth about himself, his family and the terrible evil that haunts the magical world.", ImageURL = "/images/movies/harrypotter.jpg", MovieCategory = MovieCategory.Fantasy, CreatedDate = DateTime.Now.AddDays(8), UpdatedDate = DateTime.Now.AddDays(1), CinemaId = 1, ProducerId = 2 },
                        new Movie() { Title = "The Lord of the Rings: The Fellowship of the Ring", Description = "A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron.", ImageURL = "/images/movies/lotr.jpg", MovieCategory = MovieCategory.Fantasy, CreatedDate = DateTime.Now.AddDays(-10), UpdatedDate = DateTime.Now.AddDays(3) , CinemaId = 3, ProducerId = 1},
        
                        // Horror
                        new Movie() { Title = "The Exorcist", Description = "When a teenage girl is possessed by a mysterious entity, her mother seeks the help of two priests to save her daughter.", ImageURL = "/images/movies/exorcist.jpg", MovieCategory = MovieCategory.Horror, CreatedDate = DateTime.Now.AddDays(3), UpdatedDate = DateTime.Now, CinemaId = 2, ProducerId = 1 },
                        new Movie() { Title = "Get Out", Description = "A young African-American visits his white girlfriend's parents for the weekend, where his simmering uneasiness about their reception of him eventually reaches a boiling point.", ImageURL = "/images/movies/getout.jpg", MovieCategory = MovieCategory.Horror, CreatedDate = DateTime.Now.AddDays(20), UpdatedDate = DateTime.Now.AddDays(10), CinemaId = 3, ProducerId = 1 },
        
                        // Romance
                        new Movie() { Title = "The Notebook", Description = "A poor yet passionate young man falls in love with a rich young woman, giving her a sense of freedom, but they are soon separated because of their social differences.", ImageURL = "/images/movies/notebook.jpg", MovieCategory = MovieCategory.Romance, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now.AddDays(1) , CinemaId = 1, ProducerId = 1},
                        new Movie() { Title = "Pride and Prejudice", Description = "Sparks fly when spirited Elizabeth Bennet meets single, rich, and proud Mr. Darcy. But Mr. Darcy reluctantly finds himself falling in love with a woman beneath his class.", ImageURL = "/images/movies/pride.jpg", MovieCategory = MovieCategory.Romance, CreatedDate = DateTime.Now.AddDays(3), UpdatedDate = DateTime.Now.AddDays(1), CinemaId = 2, ProducerId = 2 },
        
                        // Science Fiction
                        new Movie() { Title = "Inception", Description = "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O.", ImageURL = "/images/movies/inception.jpg", MovieCategory = MovieCategory.Science_Fiction, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now.AddDays(3), CinemaId = 2 , ProducerId = 1},
                        new Movie() { Title = "The Matrix", Description = "A computer hacker learns from mysterious rebels about the true nature of his reality and his role in the war against its controllers.", ImageURL = "/images/movies/matrix.jpg", MovieCategory = MovieCategory.Science_Fiction, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now.AddDays(3), CinemaId = 1, ProducerId = 2 },
        
                        // Sports
                        new Movie() { Title = "Rocky", Description = "A small-time boxer gets a supremely rare chance to fight a heavyweight champion in a bout in which he strives to go the distance for his self-respect.", ImageURL = "/images/movies/rocky.jpg", MovieCategory = MovieCategory.Sports, CreatedDate = DateTime.Now.AddDays(3), UpdatedDate = DateTime.Now.AddDays(3), CinemaId = 3, ProducerId = 2 },
                        new Movie() { Title = "Remember the Titans", Description = "The true story of a newly appointed African-American coach and his high school team on their first season as a racially integrated unit.", ImageURL = "/images/movies/titans.jpg", MovieCategory = MovieCategory.Sports, CreatedDate = DateTime.Now.AddDays(12), UpdatedDate = DateTime.Now, CinemaId = 1, ProducerId = 2 }


                    });
                    context.SaveChanges();

                }
               // Actors & Movies
                    if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                        {
                            new Actor_Movie() { ActorId = 1, MovieId = 1 },
                            new Actor_Movie() { ActorId = 1, MovieId = 2 },
                            new Actor_Movie() { ActorId = 2, MovieId = 1 },
                            new Actor_Movie() { ActorId = 2, MovieId = 2 },
                            new Actor_Movie() { ActorId = 3, MovieId = 3 },
                            new Actor_Movie() { ActorId = 3, MovieId = 4 },
                            new Actor_Movie() { ActorId = 4, MovieId = 3 },
                            new Actor_Movie() { ActorId = 4, MovieId = 4 },
                            new Actor_Movie() { ActorId = 5, MovieId = 5 },
                            new Actor_Movie() { ActorId = 5, MovieId = 6 }
                        });
                    context.SaveChanges();
                }


            }

        }
    }
}
