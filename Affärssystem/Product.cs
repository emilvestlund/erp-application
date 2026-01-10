using static System.Windows.Forms.DataFormats;
using System.Diagnostics;
using System.Xml;

public class Product //bas klass för alla produkter
{
    public int ProductID { get; set; }  //egenskaper för alla produkter med getter och setter template (är inte publika)
    public string ProductName { get; set; }
    public int? Price { get; set; }
    public string Type { get; set; }
    public int Quantity { get; set; }



    public class Book : Product //subklass för böcker
    {
        public string Author { get; set; }
        public string Genre { get; set; }
        public string Format { get; set; }
        public string Language { get; set; }
       

        public void setBook(int productId, string productName, int price, string author, string genre, string format, string language, int quantity, string type)
        {
            ProductID = productId;
            ProductName = productName;
            Price = price;
            Author = author;
            Genre = genre;
            Format = format;
            Language = language;
            Quantity = quantity;
            Type = "Book";
        }
    }


    public class Videogame : Product //
    {
        public string Platform { get; set; }

        public void setVideogame(int productId, string productName, int price, string platform, int quantity, string type)
        {

            ProductID = productId;
            ProductName = productName;
            Price = price;
            Platform = platform;
            Quantity = quantity;
            Type = "Videogame";
        }
    }

    public class Movie : Product //subklass för filmer
    {
        public string Format { get; set; }
        public string Playtime { get; set; }

        public void setMovie(int productId, string productName, int price, string format, string playtime, int quantity, string type)
        {
            ProductID = productId;
            ProductName = productName;
            Price = price;
            Format = format;
            Playtime = playtime;
            Quantity = quantity;
            Type = "Movie";
        }
    }
}
