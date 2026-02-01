    public enum Availability
    {
        available = 1,
        borrowed = 2
    }

    public class Book(string title, string author, string iSBN, Availability isAvailable = Availability.available)
    {
        public string Title = title;
        public string Author = author;
        public string ISBN = iSBN;
        public Availability IsAvailable = isAvailable;


        // Title
        public string GetTitle() => this.Title;
        public void SetTitle(string title) => this.Title = title;


        // Author 
        public string GetAuthor() => this.Author;
        public void SetAuthor(string author) => this.Author = author;

        //ISBN
        public string GetISBN() => this.ISBN;
        public void SetISBN(string iSBN) => this.ISBN = iSBN;


        // isAvailable
        public Availability GetIsAvailable() => this.IsAvailable;
        public void SetIsAvailable(Availability isAvailable) => this.IsAvailable = isAvailable;

    }