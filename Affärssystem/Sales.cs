using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Product;

namespace Affärssystem
{
    public class Sales
    {
        private ShoppingCart cart;
        private Grossit grossit;
        private Inventory inventory;

        public Sales(ShoppingCart cart, Grossit grossit, Inventory inventory)
        {
            this.cart = cart;
            this.grossit = grossit;
            this.inventory = inventory;
        }


        public void checkOut()
        {
            try
            {
                // Skapa en temporär lista för att lagra alla produkter i kundvagnen, den temporära listan skapas för att inte modfiera foreach loopen vid metodens körning. Därför måste vi rensa listan efter foreach loopen men även ha tillgång till innehållet som lagras i kundvagnen
                List<Product> productsToDisplay = new List<Product>();
           
                foreach (Product cartProduct in cart.cartList)
                {
                    if (cartProduct is Book)
                    {
                        Book matchingBook = inventory.BookList.FirstOrDefault(book => book.ProductName == cartProduct.ProductName);

                        if (matchingBook != null)
                        {
                            if (matchingBook.Quantity <= 0 || matchingBook.Quantity < cartProduct.Quantity)
                            {
                                Debug.WriteLine("Köpet genomfördes inte...");

                                var result = MessageBox.Show("Felaktigt antal av boken: " + " " + "'" + matchingBook.ProductName + "'", "Bekräfta", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    cart.clearCart();

                                }
                            }
                            else if (matchingBook.Quantity >= cartProduct.Quantity) // Lägg till detta villkor för att säkerställa att köpet endast genomförs om det finns tillräckligt med varor i lagret
                            {
                                Debug.WriteLine("Antal uppdateras");
                                matchingBook.Quantity -= 1; // Minska antalet i lagret med 1
                                productsToDisplay.Add(cartProduct);
                            }

                        }
                    }

                    if (cartProduct is Videogame)
                    {
                        Videogame matchingVideogame = inventory.VideogameList.FirstOrDefault(videogame => videogame.ProductName == cartProduct.ProductName);

                        if (matchingVideogame != null)
                        {
                            if (matchingVideogame.Quantity <= 0 || matchingVideogame.Quantity < cartProduct.Quantity)
                            {
                                Debug.WriteLine("Köpet genomfördes inte...");

                                var result = MessageBox.Show("Felaktigt antal av boken: " + " " + "'" + matchingVideogame.ProductName + "'", "Bekräfta", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    cart.clearCart();

                                }
                            }
                            else if (matchingVideogame.Quantity >= cartProduct.Quantity) // Lägg till detta villkor för att säkerställa att köpet endast genomförs om det finns tillräckligt med varor i lagret
                            {
                                Debug.WriteLine("Antal uppdateras");
                                matchingVideogame.Quantity -= 1; // Minska antalet i lagret med 1
                                productsToDisplay.Add(cartProduct);
                            }

                        }
                    }
                    if (cartProduct is Movie)
                    {
                        Movie matchingMovie = inventory.MovieList.FirstOrDefault(movie => movie.ProductName == cartProduct.ProductName);

                        if (matchingMovie != null)
                        {
                            if (matchingMovie.Quantity <= 0 || matchingMovie.Quantity < cartProduct.Quantity)
                            {
                                Debug.WriteLine("Köpet genomfördes inte...");

                                var result = MessageBox.Show("Felaktigt antal av boken: " + " " + "'" + matchingMovie.ProductName + "'", "Bekräfta", MessageBoxButtons.OK);
                                if (result == DialogResult.OK)
                                {
                                    cart.clearCart();

                                }
                            }
                            else if (matchingMovie.Quantity >= cartProduct.Quantity) // Lägg till detta villkor för att säkerställa att köpet endast genomförs om det finns tillräckligt med varor i lagret
                            {
                                Debug.WriteLine("Antal uppdateras");
                                matchingMovie.Quantity -= 1; // Minska antalet i lagret med 1
                                productsToDisplay.Add(cartProduct);
                            }

                        }
                    }

                    // Lägg till produkten i temporär listan för att visa senare
                    
                }
                if (cart.cartList.Any())
                {
                    //Prompta användaren angående bekräftat köp
                    string productsMessage = "Köpet genomfördes för följande produkter:\n"; //Meddelande

                    foreach (Product product in productsToDisplay) //För varje produkt i den temporära listan
                    {
                        // Lägg till produktnamn och pris i meddelandet
                        productsMessage += $"{product.ProductName} : {product.Price} SEK\n"; //Bygger på meddelandet
                    }


                    productsMessage += "\n"; // Lägg till en extra radbrytning efter produkterna genom att tilldela \n till vårt meddelande för tydlig formatering av information

                    string productSum = "Summa: ";


                    productSum += $"{cart.TotalPrice} SEK";   // Beräkna summan av priset för alla produkter i kundvagnen

                    MessageBox.Show(productsMessage + productSum, "Bekräfta", MessageBoxButtons.OK); //Sätter ihop prompten, eftersom det bara finns ett val så behöver vi inte hantera det, efter användaren trycker på OK så rensar vi kundvagnen


                    cart.clearCart();
                    grossit.SaveCSVFile();  // Spara ändringarna till filen
                    grossit.readCSVFile();
                   

                }
            }
            catch (Exception ex)
            {

                Debug.WriteLine(ex.Message);
               
            }

        }

    }
}


