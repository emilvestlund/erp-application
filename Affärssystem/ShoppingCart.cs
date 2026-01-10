using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using static Product;

namespace Affärssystem
{
    public class ShoppingCart
    {
        public DataGridView cartItemsDisplay { get; set; }
        public TextBox TotalDisplay { get; set; }
        public List<Product> cartList { get; set; }
        public int TotalPrice { get; set; }


        public ShoppingCart(DataGridView cartItemsDisplay, TextBox TotalDisplay)
        {
            this.cartItemsDisplay = cartItemsDisplay;
            this.TotalDisplay = TotalDisplay;

            cartList = new List<Product>();
            TotalPrice = 0;
        }

        public void addToCart(Product product) //Lägg till vara
        {
            if (product != null)
            {
                cartList.Add(product);
                int productPrice = product.Price ?? 0;
                TotalPrice += productPrice;
                UpdateTotalPrice();


                cartItemsDisplay.DataSource = null;
                cartItemsDisplay.DataSource = cartList;


                foreach (Product b in cartList)
                {
                    Debug.WriteLine($" {b.ProductName}, Price: {b.Price} ");
                }
            }
        }
        public void UpdateTotalPrice() //Uppdaterar summan
        {

            TotalDisplay.Text = TotalPrice.ToString() + " SEK";
        }

        public void clearCart() //Rensar innehållet, kallas vid knapptryck
        {
            cartList.Clear();
            TotalPrice = 0;
            UpdateTotalPrice();
            cartItemsDisplay.DataSource = null;
            cartItemsDisplay.DataSource = cartList;
        }

    }
}



