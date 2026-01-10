using Affärssystem;
using static System.Windows.Forms.DataFormats;
using System.Xml;

public class Inventory
{
    public List<Product.Book> BookList { get; set; }
    public List<Product.Videogame> VideogameList { get; set; }
    public List<Product.Movie> MovieList { get; set; }



    public Inventory()
    {
        BookList = new List<Product.Book>();
        VideogameList = new List<Product.Videogame>();
        MovieList = new List<Product.Movie>();     
    }


    public void AddBooks() //Add funktionerna används om start innehållet är tomt, detta för att programmet inte skall vara tillståndslöst eller kräva att en fil finns med innehåll när programmet körs.
    {
        Product.Book book1 = new Product.Book();
        book1.setBook(generateID(), "Bello Gallico et Civili", 449, "Julius Caesar", "Historia", "Inbunden", "Latin", 100, "Book");
        BookList.Add(book1);

        Product.Book book2 = new Product.Book();
        book2.setBook(generateID(), "How to Read a Book", 149, "Mortimer J. Adler", "Kursliteratur", "Pocket", " ", 100, "Book");
        BookList.Add(book2);

        Product.Book book3 = new Product.Book();
        book3.setBook(generateID(), "Moby Dick", 49, "Herman Melville", "Äventyr", "Pocket", " ", 100, "Book");
        BookList.Add(book3);

        Product.Book book4 = new Product.Book();
        book4.setBook(generateID(), "Great Gatsby", 79, "F. Scott Fitzgerald", "Noir", "E-Bok", " ", 100, "Book");
        BookList.Add(book4);

        Product.Book book5 = new Product.Book();
        book5.setBook(generateID(), "House of Leaves", 49, "Mark Z. Danielewski", "Skräck", " ", " ", 100, "Book");
        BookList.Add(book5);
    }

    public void AddVideogames()
    {
        Product.Videogame game1 = new Product.Videogame();
        game1.setVideogame(generateID(), "Elden Ring", 599, "Playstation 5", 100, "Videogame");
        VideogameList.Add(game1);

        Product.Videogame game2 = new Product.Videogame();
        game2.setVideogame(generateID(), "Demon's Souls", 499, "Playstation 5", 100, "Videogame");
        VideogameList.Add(game2);

        Product.Videogame game3 = new Product.Videogame();
        game3.setVideogame(generateID(), "Microsoft Flight Simulator", 499, "PC", 100, "Videogame");
        VideogameList.Add(game3);

        Product.Videogame game4 = new Product.Videogame();
        game4.setVideogame(generateID(), "Planescape Torment", 99, "PC", 100, "Videogame");
        VideogameList.Add(game4);

        Product.Videogame game5 = new Product.Videogame();
        game5.setVideogame(generateID(), "Disco Elysium", 399, "PC", 100, "Videogame");
        VideogameList.Add(game5);
    }

    public void AddMovies()
    {
        Product.Movie movie1 = new Product.Movie();
        movie1.setMovie(generateID(), "Nyckeln till frihet", 99, "DVD", "142 min", 100, "Movie");
        MovieList.Add(movie1);

        Product.Movie movie2 = new Product.Movie();
        movie2.setMovie(generateID(), "Gudfadern", 99, "DVD", "152 min", 100, "Movie");
        MovieList.Add(movie2);

        Product.Movie movie3 = new Product.Movie();
        movie3.setMovie(generateID(), "Konungens återkomst", 199, "Blu-Ray", "154 min", 100, "Movie");
        MovieList.Add(movie3);

        Product.Movie movie4 = new Product.Movie();
        movie4.setMovie(generateID(), "Pulp fiction", 199, "Blu-Ray", " ", 100, "Movie");
        MovieList.Add(movie4);

        Product.Movie movie5 = new Product.Movie();
        movie5.setMovie(generateID(), "Schindlers list", 99, "DVD", " ", 100, "Movie");
        MovieList.Add(movie5);

    }
    private int currentID = 0; // Håller reda på det senaste tilldelade ID:t

    public int generateID()
    {
        currentID++; // Öka det nuvarande ID:t varje gång en ny ID genereras
        return currentID; // Returnera det nya ID:t
    }
}

