using Task_12_Cinema_Booking.Models;

namespace Task_12_Cinema_Booking.ViewModels
{
    public class MovieWithCategory
    {
        public Movie? Movie { get; set; }
        public Category? Category { get; set; }
        public Cinema? Cinema { get; set; }
        public IEnumerable<Actor>? Actors { get; set; }

        public int? Id { get; set; }
        public string? MovieName { get; set; }
        public string? Description { get; set; }
        public string? Img { get; set; }
        public int? CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public string? CategoryDescription { get; set; }

    }
}
