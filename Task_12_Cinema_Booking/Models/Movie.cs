namespace Task_12_Cinema_Booking.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime ShowTime { get; set; }
        public int CinemaId { get; set; }
        public Cinema Cinema { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<Actor> Actors { get; set; }
        public int Duration { get; set; }
        public decimal Rate { get; set; }
        public string MainImg { get; set; }
    }
}
