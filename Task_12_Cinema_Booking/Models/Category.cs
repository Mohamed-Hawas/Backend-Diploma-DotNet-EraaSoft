namespace Task_12_Cinema_Booking.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Movie> Movies { get; set; }
    }
}
