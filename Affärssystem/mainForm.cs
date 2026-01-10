using System;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using static Product;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace Affärssystem //Emil Vestlund, DVGB07, Labboration 4, Grundversion (för 3 poäng) (Antagande är att alla produkter ska ha ett ID men att det ska presenteras som i bilagan till labben, därmed så presenteras inte ID i DataGridView)
{
    public partial class mainForm : Form
    {
        private Inventory inventory; // Skapar instanser av klasser i form av objekt
        private ShoppingCart cart;
        private Grossit grossit;
        private Sales sales;
        private bool hasLoaded = true; //Flagga för kontroller av inladdning


        public mainForm()
        {
            InitializeComponent(); // Initialiserar komponenter (gränsnittet)

            Debug.WriteLine("Initierar Form...");

            inventory = new Inventory();
            cart = new ShoppingCart(cartItemsDisplay, TotalDisplay);
            grossit = new Grossit(inventory, bookDataGrid, videogamesDataGrid, moviesDataGrid);
            sales = new Sales(cart, grossit, inventory);


            bookDataGrid.CellFormatting += bookDataGrid_CellFormatting; //För hantering av nya tillagda celler vars innehåll är tomt är grå
            videogamesDataGrid.CellFormatting += videogamesDataGrid_CellFormatting;
            moviesDataGrid.CellFormatting += moviesDataGrid_CellFormatting;
        }
        private void mainForm_Load(object sender, EventArgs e) //Händelsehantering för när formuläret laddas in
        {
            Debug.WriteLine("Form Laddades in...");

            grossit.readCSVFile();
            bookDataGrid.ClearSelection(); // Avmarkera alla rader i datagriden
            videogamesDataGrid.ClearSelection();
            moviesDataGrid.ClearSelection();
            hasLoaded = false; // Sätt hasLoaded till false för att indikera att formuläret har laddats in

            Debug.WriteLine("Products in BookList:");
            foreach (var book in inventory.BookList)
            {
                Debug.WriteLine($"Product ID: {book.ProductID}, Product Name: {book.ProductName}, Price: {book.Price}, Author: {book.Author}, Genre: {book.Genre}, Format: {book.Format}, Language: {book.Language}, Quantity: {book.Quantity}, Type: {book.Type}");
            }

            Debug.WriteLine("Products in VideogameList:");
            foreach (var videogame in inventory.VideogameList)
            {
                Debug.WriteLine($"Product ID: {videogame.ProductID}, Product Name: {videogame.ProductName}, Price: {videogame.Price}, Platform: {videogame.Platform}, Quantity: {videogame.Quantity}, Type: {videogame.Type}");
            }

            Debug.WriteLine("Products in MovieList:");
            foreach (var movie in inventory.MovieList)
            {
                Debug.WriteLine($"Product ID: {movie.ProductID}, Product Name: {movie.ProductName}, Price: {movie.Price}, Format: {movie.Format}, Playtime: {movie.Playtime}, Quantity: {movie.Quantity}, Type: {movie.Type}");
            }

        }

        private void lagerToolStripMenuItem_Click(object sender, EventArgs e) // Händelsehantering för när lagermenyn klickas på alla stripmenu hanterare gömmer och visar paneler som är kopplade till respektive meny
        {                                                                      // panelerna ligger på varandra och det är därför viktigt att de visas och göms i rätt ordning

            cashierPanel.Hide();
            deliveryPanel.Hide();
            deletePanel.Hide();
            panelUpdateItem.Hide();

            cashierPanel.SendToBack();
            deliveryPanel.SendToBack();
            deletePanel.SendToBack();
            panelUpdateItem.SendToBack();

            inventoryPanel.Show();
            inventoryPanel.BringToFront(); // BringToFront() metoden används för att se till att panelen visas över alla andra paneler, hade lite krångel med detta..
            mainForm.ActiveForm.Refresh();

            grossit.readCSVFile();
            bookDataGrid.ClearSelection(); // Avmarkera alla rader i datagriden
            videogamesDataGrid.ClearSelection();
            moviesDataGrid.ClearSelection();


            Debug.WriteLine("Öppnade lager..."); // Skriver ut en debugs för att säkerställa att eventen sker när de förväntas
        }
        private void btnUpdateStock_Click(object sender, EventArgs e)
        {
            inventoryPanel.Hide();
            deliveryPanel.Hide();
            deletePanel.Hide();
            cashierPanel.Hide();

            inventoryPanel.SendToBack();
            deliveryPanel.SendToBack();
            deletePanel.SendToBack();
            cashierPanel.SendToBack();

            panelUpdateItem.Show();
            panelUpdateItem.BringToFront();
            mainForm.ActiveForm.Refresh();

            grossit.fetchData();
            grossit.readCSVFile();

            bookDataGrid.ClearSelection(); // Avmarkera alla rader i datagriden
            videogamesDataGrid.ClearSelection();
            moviesDataGrid.ClearSelection();
        }

        private void kassaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            inventoryPanel.Hide();
            deliveryPanel.Hide();
            deletePanel.Hide();
            panelUpdateItem.Hide();

            inventoryPanel.SendToBack();
            deliveryPanel.SendToBack();
            deletePanel.SendToBack();
            panelUpdateItem.SendToBack();


            cashierPanel.Show();
            cashierPanel.BringToFront();
            mainForm.ActiveForm.Refresh();

            grossit.readCSVFile();
            bookDataGrid.ClearSelection(); // Avmarkera alla rader i datagriden
            videogamesDataGrid.ClearSelection();
            moviesDataGrid.ClearSelection();


            Debug.WriteLine("Öppnade kassan...");
        }


        private void btnClear_Click(object sender, EventArgs e)  //Hantering för rensning av kundvagnen
        {
            Debug.WriteLine("Rensar");

            cart.clearCart();
            cartItemsDisplay.DataSource = null; // Sätter datasource till null för att rensa datagriden
            TotalDisplay.Clear(); // Rensar totala priset

        }
        private void btnDelete_Click(object sender, EventArgs e) //Hantering för att ta bort produkter från lagret
        {
            cashierPanel.Hide();
            inventoryPanel.Hide();
            deliveryPanel.Hide();
            panelUpdateItem.Hide();
            panelUpdateItem.SendToBack();
            cashierPanel.SendToBack();
            inventoryPanel.SendToBack();
            deliveryPanel.SendToBack();

            deletePanel.Show();
            deletePanel.BringToFront();
            mainForm.ActiveForm.Refresh();
        }
        private void btnDelivery_Click(object sender, EventArgs e) //Hantering för att öppna leveranspanelen
        {
            cashierPanel.Hide();
            inventoryPanel.Hide();
            deletePanel.Hide();
            panelUpdateItem.Hide();
            panelUpdateItem.SendToBack();
            cashierPanel.SendToBack();
            inventoryPanel.SendToBack();
            deletePanel.SendToBack();

            deliveryPanel.Show();
            deliveryPanel.BringToFront();
            mainForm.ActiveForm.Refresh();


            Debug.WriteLine("Öppnade leverans...");
        }
        private void btnEscape_Click(object sender, EventArgs e) //Hantering för att gå ut från leveranspanelen och gå tillbaka till inventory där vi har två val, leverans eller borttagning av vara
        {

            inventoryPanel.Show();
            inventoryPanel.BringToFront();
            mainForm.ActiveForm.Refresh();


            Debug.WriteLine("OK trycktes...");

        }
        private void confirmButton_Click(object sender, EventArgs e) //Hantering för att bekräfta leverans och skicka in data till grossit, här sker en validering av inmatad data och sedan skickas den vidare om valideringen lyckas
        {
            Debug.WriteLine("confirmButton_Click()...");

            //out variabler används för att skicka tillbaka värden från metoden, detta säkerställer att de har korrekta värden när de kommer till användning i grossit.sendDelivery(), satt i flertal timmmar med detta problemet att variablerna var null när de kom till grossit.sendDelivery().
            validateInputs(out string ValidateSelectedProduct, out string ValidateName, out int ValidatePrice, out string ValidateAuthor, out string ValidateGenre, out string ValidateLanguage, out string ValidatePlatform, out string ValidatePlaytime, out string ValidateFormat, out int ValidateQuantity, out string ValidateType);
            grossit.sendDelivery(ValidateSelectedProduct, ValidateName, ValidatePrice, ValidateAuthor, ValidateGenre, ValidateLanguage, ValidatePlatform, ValidatePlaytime, ValidateFormat, ValidateQuantity, ValidateType); // Skickar in data till grossit för att lägga till i lagret

        }

        private void deletePanelOK_Click(object sender, EventArgs e)
        {
            grossit.removeItem(chooseToDelete, deleteThis); // Använder en metod i grossit för att ta bort produkter från lagret, den tar in två controllers som argument för att veta vilken produkt som ska tas bort
            Debug.WriteLine("Ta bort trycktes...");
        }

        private void cartItemsDisplay_CellClick(object sender, DataGridViewCellEventArgs e) //Hantering för att ta bort produkter från kundvagnen
        {
            Debug.WriteLine("cartItemDisplay_CellClick avlöstes..");
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && cartItemsDisplay.SelectedRows != null && cartItemsDisplay.SelectedRows.Count > 0) // Kontrollerar att det är en giltig cellklick (bollade med chatGPT om den här lösningen)
            {
                int rowIndex = cartItemsDisplay.SelectedRows[0].Index; // Hämtar index för den valda raden
                if (rowIndex < cart.cartList.Count) // Kontrollerar att indexet är inom gränserna för listan
                {
                    Product selectedProduct = cart.cartList[rowIndex]; // Hämtar produkten från listan

                    cart.cartList.RemoveAt(rowIndex); // Tar bort produkten från listan
                    cart.TotalPrice -= selectedProduct.Price ?? 0; // Minskar totalpriset med priset för produkten
                    cart.UpdateTotalPrice(); // Uppdaterar gränssnittet för kundvagnen

                    cartItemsDisplay.DataSource = null; // Sätter datasource till null för att rensa datagriden
                    cartItemsDisplay.DataSource = cart.cartList; // Sätter datasource till listan för att uppdatera datagriden

                    if (cart.cartList.Count == 0) // Kontrollerar om listan är tom
                    {
                        cartItemsDisplay.DataSource = null;
                    }
                }
            }
        }

        private void bookDataGrid_CellClick(object sender, DataGridViewCellEventArgs e) //Hantering för att lägga till produkter från böcker till kundvagnen
        {

            if (hasLoaded) // Kontrollerar om det är den första laddningen och avbryt om det är så, hade ett problem med att inte kunna klicka på cellerna för att lägga till produkter i kundvagnen, detta löste problemet
            {
                return;
            }

            try // Try-catch block för att hantera eventuella fel
            {
                // Kontrollera om det är en giltig cellklick
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {

                    // Hämta data från den klickade cellen
                    DataGridViewRow clickedRow = bookDataGrid.Rows[e.RowIndex];
                    var ProductPrice = clickedRow.Cells["ProductName"].Value;
                    var Price = clickedRow.Cells["Price"].Value;


                    int price = 0;


                    if (Price != null && int.TryParse(Price.ToString(), out int parsedPrice)) // Kontrollerar om priset är giltigt, konverterar det även till en int då det är en string vi trycker på i gridden
                    {
                        price = parsedPrice; // Sätter priset till det konverterade priset, parsedPrice blir som en temporär variabel som vi sedan sätter till price
                    }

                    // Kontrollera om productName är 0 eller tom
                    if (ProductPrice != null && price != 0) // Kontrollerar om produktnamnet och priset är giltiga
                    {
                        Book selectedProduct = new Book(); // Skapar en ny produkt
                        selectedProduct.ProductName = ProductPrice.ToString();
                        selectedProduct.Price = price; // Sätter priset till det konverterade priset, ?? 0 används för att sätta priset till 0 om det inte finns något pris, detta möjliggörs genom att priset är en nullable int


                        // Lägg till produkten i kundvagnen
                        cart.addToCart(selectedProduct);

                        // Uppdatera gränssnittet för kundvagnen
                        cart.UpdateTotalPrice();
                    }

                }
            }
            catch (Exception ex) // Fångar upp eventuella fel och skriver ut dem i debug
            {
                Debug.WriteLine("Ett fel uppstod: " + ex.Message);
            }

            finally
            {
                bookDataGrid.ClearSelection(); // Avmarkera alla rader i datagriden
                videogamesDataGrid.ClearSelection();
                moviesDataGrid.ClearSelection();
            }
        }



        private void videogamesDataGrid_CellClick(object sender, DataGridViewCellEventArgs e) //Hantering för att lägga till produkter från dataspel till kundvagnen
        {

            // Kontrollera om det är den första laddningen och avbryt om det är så
            if (hasLoaded)
            {
                return;
            }

            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {

                    // Hämta data från den klickade cellen
                    DataGridViewRow clickedRow = videogamesDataGrid.Rows[e.RowIndex];
                    var ProductPrice = clickedRow.Cells["gameName"].Value;
                    var Price = clickedRow.Cells["gamePrice"].Value;


                    int price = 0;


                    if (Price != null && int.TryParse(Price.ToString(), out int parsedPrice)) // Kontrollerar om priset är giltigt, konverterar det även till en int då det är en string vi trycker på i gridden
                    {
                        price = parsedPrice; // Sätter priset till det konverterade priset, parsedPrice blir som en temporär variabel som vi sedan sätter till price
                    }

                    // Kontrollera om productName är 0 eller tom
                    if (ProductPrice != null && price != 0) // Kontrollerar om produktnamnet och priset är giltiga
                    {
                        Videogame selectedProduct = new Videogame(); // Skapar en ny produkt
                        selectedProduct.ProductName = ProductPrice.ToString();
                        selectedProduct.Price = price; // Sätter priset till det konverterade priset, ?? 0 används för att sätta priset till 0 om det inte finns något pris, detta möjliggörs genom att priset är en nullable int


                        // Lägg till produkten i kundvagnen
                        cart.addToCart(selectedProduct);

                        // Uppdatera gränssnittet för kundvagnen
                        cart.UpdateTotalPrice();

                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Ett fel uppstod: " + ex.Message);
            }

            finally
            {
                bookDataGrid.ClearSelection();
                videogamesDataGrid.ClearSelection();
                moviesDataGrid.ClearSelection();
            }
        }

        private void moviesDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kontrollera om det är den första laddningen och avbryt om det är så
            if (hasLoaded)
            {
                return;
            }

            try
            {
                // Kontrollera om det är en giltig cellklick
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {

                    // Hämta data från den klickade cellen
                    DataGridViewRow clickedRow = moviesDataGrid.Rows[e.RowIndex];
                    var ProductPrice = clickedRow.Cells["movieName"].Value;
                    var Price = clickedRow.Cells["moviePrice"].Value;


                    int price = 0;


                    if (Price != null && int.TryParse(Price.ToString(), out int parsedPrice)) // Kontrollerar om priset är giltigt, konverterar det även till en int då det är en string vi trycker på i gridden
                    {
                        price = parsedPrice; // Sätter priset till det konverterade priset, parsedPrice blir som en temporär variabel som vi sedan sätter till price
                    }

                    // Kontrollera om productName är 0 eller tom
                    if (ProductPrice != null && price != 0) // Kontrollerar om produktnamnet och priset är giltiga
                    {
                        Movie selectedProduct = new Movie(); // Skapar en ny produkt
                        selectedProduct.ProductName = ProductPrice.ToString();
                        selectedProduct.Price = price; // Sätter priset till det konverterade priset, ?? 0 används för att sätta priset till 0 om det inte finns något pris, detta möjliggörs genom att priset är en nullable int


                        // Lägg till produkten i kundvagnen
                        cart.addToCart(selectedProduct);

                        // Uppdatera gränssnittet för kundvagnen
                        cart.UpdateTotalPrice();

                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Ett fel uppstod: " + ex.Message);
            }

            finally
            {
                bookDataGrid.ClearSelection();
                videogamesDataGrid.ClearSelection();
                moviesDataGrid.ClearSelection();
            }
        }
        private void chooseToDelete_SelectedIndexChanged(object sender, EventArgs e) //Hantering för att aktivera knappen för att ta bort produkter från lagret, man ska inte kunna mata in data om inte en produktkategori är vald
        {
            string choice = chooseToDelete.SelectedItem?.ToString();

            deleteThis.Enabled = false;

            if (choice == "Böcker" || choice == "Dataspel" || choice == "Filmer")
            {
                deleteThis.Enabled = true;
                Debug.WriteLine("Enable status ändrades på deleteThis rutan...");
            }
            else
            {
                deleteThis.Enabled = false;
            }

        }


        public void chooseProduct_SelectedIndexChanged(object sender, EventArgs e) //Hantering för att aktivera fälten för att mata in data beroende på vilken produktkategori som är vald
        {
            Debug.WriteLine("ValidateSelectedProduct ändrades med värdet: " + chooseProduct.SelectedItem); // Skriver ut i debug vilken produktkategori som är vald

            string ValidateSelectedProduct = chooseProduct.SelectedItem?.ToString();

            Debug.WriteLine("chooseProduct har nu värdet: " + chooseProduct.SelectedItem); // Skriver ut i debug vilken produktkategori som är vald efter att vi hämtar värdet från ComboBoxen

            // Om "Böcker" är vald
            if (ValidateSelectedProduct == "Böcker") // Kontrollerar vilken produktkategori som är vald och aktiverar fälten för att mata in data beroende på vilken produktkategori som är vald
            {
                // Aktivera de relevanta fälten för böcker och inaktivera resten
                nameBox.Enabled = true;
                priceBox.Enabled = true;
                authorBox.Enabled = true;
                genreBox.Enabled = true;
                formatBox.Enabled = true;
                languageBox.Enabled = true;
                quantityBox.Enabled = true;

                platformBox.Enabled = false; // Inaktiverar fält som inte är relevanta för böcker
                playtimeBox.Enabled = false;
            }
            // Om "Dataspel" är vald
            else if (ValidateSelectedProduct == "Dataspel")
            {
                // Aktivera de relevanta fälten för spel och inaktivera resten
                nameBox.Enabled = true;
                priceBox.Enabled = true;
                platformBox.Enabled = true;
                quantityBox.Enabled = true;

                authorBox.Enabled = false;
                genreBox.Enabled = false;
                formatBox.Enabled = false;
                languageBox.Enabled = false;
                playtimeBox.Enabled = false;

            }
            // Om "Filmer" är vald
            else if (ValidateSelectedProduct == "Filmer")
            {
                // Aktivera de relevanta fälten för filmer och inaktivera resten
                nameBox.Enabled = true;
                priceBox.Enabled = true;
                formatBox.Enabled = true;
                playtimeBox.Enabled = true;
                quantityBox.Enabled = true;

                authorBox.Enabled = false;
                genreBox.Enabled = false;
                languageBox.Enabled = false;
                platformBox.Enabled = false;


            }
        } // Metod för att validera inmatad data, returnerar en bool beroende på om valideringen lyckades eller inte, behöver egentligen inte returnera något då leveransen aldrig kan skickas om valideringen misslyckas eftersom den kallas efter.
        public bool validateInputs(out string ValidateSelectedProduct, out string ValidateName, out int ValidatePrice, out string ValidateAuthor, out string ValidateGenre, out string ValidateLanguage, out string ValidatePlatform, out string ValidatePlaytime, out string ValidateFormat, out int ValidateQuantity, out string ValidateType)
        {
            Debug.WriteLine("Validerar inmatning av data..."); // Säkerställer att funktionen körs

            ValidateSelectedProduct = ""; //Nollställ alla värden vid initisering detta för good practice att säkerställa att variablerna har ett definerat värde, också för att säkerställa att de inte har värden om de inte kommer igenom validering.
            ValidateName = "";
            ValidatePrice = 0;
            ValidateAuthor = "";
            ValidateGenre = "";
            ValidateLanguage = "";
            ValidatePlatform = "";
            ValidatePlaytime = "";
            ValidateFormat = "";
            ValidateQuantity = 0;
            ValidateType = "";

            try //Försök att köra kod med eventuella undantag kastrade vid fel
            {
                // Hämta värden från användargränssnittet och tilldela dem till våra variabler
                ValidateSelectedProduct = chooseProduct.SelectedItem?.ToString();
                ValidateName = nameBox.Text.ToString();
                ValidateAuthor = authorBox.Text.ToString();
                ValidateGenre = genreBox.Text.ToString();
                ValidateLanguage = languageBox.Text.ToString();
                ValidatePlatform = platformBox.Text.ToString();
                ValidatePlaytime = playtimeBox.Text.ToString();
                ValidateFormat = formatBox.Text.ToString();
                ValidateType = ValidateSelectedProduct;

                // Validera inmatade värden beroende på vald produkt, dessa är generella valideringar som gäller för alla produkter
                if (string.IsNullOrWhiteSpace(ValidateName)) //Funkar inte, fattar inte varför, redan suttit för länge med detta... Den kastar default Exception trots att den är tom
                    throw new Exception("Namn får inte vara tomt!");
           
                if (!int.TryParse(priceBox.Text, out ValidatePrice)) //Försöker konvertera datatypen till en int, om det inte är ett tal så får vi fel, vi använder oss av "!" för att få metoden att returnera true om det är en stäng som går att konvertera vilket inte ska gå i vårt fall, inverterad boolean.
                    throw new Exception("Pris är obligatoriskt och får enbart vara ett positivt heltal!");
                if (ValidatePrice <= 0)
                {
                    throw new Exception("Pris är obligatoriskt och får enbart vara ett positivt heltal!");
                }


                else if (ValidateSelectedProduct == "Böcker")
                {
                    if (string.IsNullOrWhiteSpace(ValidateAuthor))
                        throw new Exception("Författare får inte vara tomt!");
                    if (!ValidateAuthor.All(char.IsLetter))
                        throw new Exception("Författare får inte innehålla numeriska tecken!");

                    if (!ValidateGenre.All(char.IsLetter))
                        throw new Exception("Genre får inte innehålla numeriska tecken!");
                    if (string.IsNullOrWhiteSpace(ValidateGenre))
                        throw new Exception("Genre får inte vara tomt!");

                    if (!ValidateFormat.All(char.IsLetter))
                        throw new Exception("Format får inte innehålla numeriska tecken!");

                    if (!ValidateLanguage.All(char.IsLetter))
                        throw new Exception("Språk får inte innehålla numeriska tecken!");
                }
                if (ValidateSelectedProduct == "Dataspel")
                {
                    if (string.IsNullOrWhiteSpace(ValidatePlatform))
                        throw new Exception("Plattform får inte vara tomt!");
                    if (!ValidatePlatform.All(char.IsLetter))
                        throw new Exception("Författare får inte innehålla numeriska tecken!");


                }
                else if (ValidateSelectedProduct == "Filmer")
                {

                    if (!ValidateFormat.All(char.IsLetter))
                        throw new Exception("Format får inte innehålla numeriska tecken!");

                    if (string.IsNullOrWhiteSpace(ValidatePlaytime))
                        throw new Exception("Speltid får inte vara tomt!");

                    if (string.IsNullOrWhiteSpace(ValidatePlaytime))
                    {
                        throw new Exception("Speltid får inte vara tom!");
                    }

                    if (ValidatePlaytime.Length <= 0 || !char.IsDigit(ValidatePlaytime[0]) || ValidatePlaytime[0] == '0')
                    {
                        throw new Exception("Speltid måste vara ett positivt heltal!");                                 
                    }



                }
                if (!int.TryParse(quantityBox.Text, out ValidateQuantity))
                    throw new Exception("Antal är obligatoriskt och får enbart vara ett positivt heltal");
                if (ValidateQuantity <= 0 || ValidateQuantity > 100)
                {
                    throw new Exception("Antal är obligatoriskt och får enbart vara ett positivt heltal mellan 0-100!");
                }



                string localValidateName = ValidateName; // Skapar en lokal variabel för att använda i switch-satsen

                switch (ValidateSelectedProduct) // Kontrollerar vilken produktkategori som är vald och om produkten redan finns i lagret
                {
                    case "Böcker":
                        var existingBook = inventory.BookList.FirstOrDefault(book => book.ProductName == localValidateName); 
                        if (existingBook != null)
                        {
                            var result = MessageBox.Show($"Boken '{ValidateName}' finns redan i sortimentet. Vill du uppdatera antalet?", "Vill du uppdatera?", MessageBoxButtons.YesNoCancel); // Skapar en messagebox för att fråga om användaren vill uppdatera antalet av redan existerande bok, sedan hanterar vi valen.
                            if (result == DialogResult.Yes)
                            {
                                existingBook.Quantity = ValidateQuantity; // Uppdaterar antalet av boken
                                grossit.sendDelivery(ValidateSelectedProduct, localValidateName, ValidatePrice, ValidateAuthor, ValidateGenre, ValidateLanguage, ValidatePlatform, ValidatePlaytime, ValidateFormat, ValidateQuantity, ValidateType); // Skickar in data till grossit för att lägga till i lagret
                                return true; // Validering lyckades
                            }
                            else
                            {
                                return false; // Validering misslyckades eftersom användaren inte ville uppdatera antalet
                            }
                        }
                        break;

                    case "Dataspel":
                        var existingVideogame = inventory.VideogameList.FirstOrDefault(videogame => videogame.ProductName == localValidateName);
                        if (existingVideogame != null)
                        {
                            var result = MessageBox.Show($"Dataspel '{ValidateName}' finns redan i sortimentet. Vill du uppdatera antalet?", "Vill du uppdatera?", MessageBoxButtons.YesNoCancel);
                            if (result == DialogResult.Yes)
                            {
                                existingVideogame.Quantity = ValidateQuantity;
                                grossit.sendDelivery(ValidateSelectedProduct, localValidateName, ValidatePrice, ValidateAuthor, ValidateGenre, ValidateLanguage, ValidatePlatform, ValidatePlaytime, ValidateFormat, ValidateQuantity, ValidateType);
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                        break;

                    case "Filmer":
                        var existingMovie = inventory.MovieList.FirstOrDefault(movie => movie.ProductName == localValidateName);
                        if (existingMovie != null)
                        {
                            var result = MessageBox.Show($"Film '{ValidateName}' finns redan i sortimentet. Vill du uppdatera antalet?", "Vill du uppdatera?", MessageBoxButtons.YesNoCancel);
                            if (result == DialogResult.Yes)
                            {
                                existingMovie.Quantity = ValidateQuantity;
                                grossit.sendDelivery(ValidateSelectedProduct, localValidateName, ValidatePrice, ValidateAuthor, ValidateGenre, ValidateLanguage, ValidatePlatform, ValidatePlaytime, ValidateFormat, ValidateQuantity, ValidateType);
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                        break;

                    default:
                        return false;
                }

                return true;
            }

            catch (Exception m) // Fångar upp eventuella fel och skriver ut dem i en messagebox
            {
                // Visa felmeddelande
                MessageBox.Show("Fel inmatning: " + m.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Skapar en messagebox för att visa felmeddelandet

                // Återställ värdena för att undvika att felaktiga värden skickas vidare
                ValidateSelectedProduct = "";
                ValidateName = "";
                ValidatePrice = 0;
                ValidateAuthor = "";
                ValidateGenre = "";
                ValidateLanguage = "";
                ValidatePlatform = "";
                ValidatePlaytime = "";
                ValidateFormat = "";
                ValidateQuantity = 0;
                ValidateType = "";

                // Validering misslyckades
                return false;
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e) //Hantering för att betala
        {

            sales.checkOut();


        }

        private void bookDataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) //För att hantera att tomma celler är grå
        {

            if (e.Value == null || string.IsNullOrWhiteSpace(e.Value.ToString()))
            {
                e.CellStyle.BackColor = Color.Gray;
                Debug.WriteLine(e.Value);
            }

        }

        private void videogamesDataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == null || string.IsNullOrWhiteSpace(e.Value.ToString()))
            {
                e.CellStyle.BackColor = Color.Gray;
                Debug.WriteLine(e.Value);
            }

        }

        private void moviesDataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == null || string.IsNullOrWhiteSpace(e.Value.ToString()))
            {
                e.CellStyle.BackColor = Color.Gray;
                Debug.WriteLine(e.Value);
            }

        }

        private async void btnGetUpdate_Click(object sender, EventArgs e)
        {
            // Validate and convert user input
            if (!int.TryParse(inputID.Text, out int productID))
            {
                MessageBox.Show("Ange ett giltigt produkt-ID", "Inputfel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(inputQuantity.Text, out int newQuantity))
            {
                MessageBox.Show("Ange en giltig kvantitet", "Inputfel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(inputID.Text))
            {
                MessageBox.Show("ID får inte vara tomt", "Inputfel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(inputQuantity.Text))
            {
                MessageBox.Show("Antal får inte vara tomt", "Inputfel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Call the update method and handle the response
            string result = await grossit.UpdateProductStock(productID, newQuantity);
            MessageBox.Show(result);

            if (result == "Uppdatering lyckades!")
            {
                // Reflect this change in the local data for books, video games, and movies
                grossit.UpdateLocalProduct(inventory.BookList, productID, newQuantity);
                grossit.UpdateLocalProduct(inventory.VideogameList, productID, newQuantity);
                grossit.UpdateLocalProduct(inventory.MovieList, productID, newQuantity);

                // Refresh the DataGridViews to reflect the updated data
                grossit.UpdateLocalInventory();
            }
            else
            {
                MessageBox.Show("Misslyckades att uppdatera antal: " + result, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}








