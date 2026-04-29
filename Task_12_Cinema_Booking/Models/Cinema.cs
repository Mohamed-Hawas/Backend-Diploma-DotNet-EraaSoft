namespace Task_12_Cinema_Booking.Models
{
    public class Cinema
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Img { get; set; }
        public IEnumerable<Movie> Movies { get; set; }
    }
}
