
using RazorPagesMovie.Models;
using Xunit;

namespace RazorPagesMovie.Tests
{
    public class PeliculaTests
    {
        [Fact]
        public void TestMovieTitle()
        {
            // objeto con valores
            var movie = new Movie
            {
                Title = "Rambo",
                ReleaseDate = DateTime.Parse("1990-03-17"),
                Genre = "Action",
                Price = 9.99M
            };

            // valores de la propiedad title
            var title = movie.Title;

            // validación valor title sea "Rambo"
            Assert.Equal("Rambo", title);
        }
    }
}
