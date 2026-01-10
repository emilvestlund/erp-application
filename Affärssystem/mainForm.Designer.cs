namespace Affärssystem
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip = new MenuStrip();
            lagerToolStripMenuItem = new ToolStripMenuItem();
            kassaToolStripMenuItem = new ToolStripMenuItem();
            btnDelivery = new Button();
            btnDelete = new Button();
            Inventory = new Panel();
            videogamesDataGrid = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            gameName = new DataGridViewTextBoxColumn();
            gamePrice = new DataGridViewTextBoxColumn();
            platformDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            inventoryBindingSource1 = new BindingSource(components);
            bookDataGrid = new DataGridView();
            ProductID = new DataGridViewTextBoxColumn();
            productName = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            author = new DataGridViewTextBoxColumn();
            genre = new DataGridViewTextBoxColumn();
            format = new DataGridViewTextBoxColumn();
            language = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            inventoryBindingSource = new BindingSource(components);
            moviesDataGrid = new DataGridView();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            movieName = new DataGridViewTextBoxColumn();
            moviePrice = new DataGridViewTextBoxColumn();
            movieFormat = new DataGridViewTextBoxColumn();
            moviePlaytime = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            inventoryBindingSource2 = new BindingSource(components);
            TitleMovies = new TextBox();
            TitleVideogames = new TextBox();
            TitleBooks = new TextBox();
            panelUpdateItem = new Panel();
            btnGetUpdate = new Button();
            label13 = new Label();
            inputQuantity = new TextBox();
            label12 = new Label();
            inputID = new TextBox();
            label11 = new Label();
            deliveryPanel = new Panel();
            label10 = new Label();
            quantityBox = new TextBox();
            label9 = new Label();
            playtimeBox = new TextBox();
            label8 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            platformBox = new TextBox();
            languageBox = new TextBox();
            formatBox = new TextBox();
            genreBox = new TextBox();
            authorBox = new TextBox();
            priceBox = new TextBox();
            nameBox = new TextBox();
            chooseProduct = new ComboBox();
            btnEscape = new Button();
            btnConfirm = new Button();
            comboLabel = new Label();
            inventoryPanel = new Panel();
            btnUpdateStock = new Button();
            cashierPanel = new Panel();
            cartItemsDisplay = new DataGridView();
            productNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            shoppingCartBindingSource2 = new BindingSource(components);
            btnClear = new Button();
            btnCheckout = new Button();
            TotalDisplay = new TextBox();
            cartLabel = new Label();
            label1 = new Label();
            shoppingCartBindingSource1 = new BindingSource(components);
            shoppingCartBindingSource = new BindingSource(components);
            deletePanel = new Panel();
            deletePanelOK = new Button();
            deleteThis = new TextBox();
            chooseToDelete = new ComboBox();
            menuStrip.SuspendLayout();
            Inventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)videogamesDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inventoryBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inventoryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)moviesDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inventoryBindingSource2).BeginInit();
            panelUpdateItem.SuspendLayout();
            deliveryPanel.SuspendLayout();
            inventoryPanel.SuspendLayout();
            cashierPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cartItemsDisplay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)shoppingCartBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)shoppingCartBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)shoppingCartBindingSource).BeginInit();
            deletePanel.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { lagerToolStripMenuItem, kassaToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(1040, 24);
            menuStrip.TabIndex = 11;
            menuStrip.Text = "menu";
            // 
            // lagerToolStripMenuItem
            // 
            lagerToolStripMenuItem.Name = "lagerToolStripMenuItem";
            lagerToolStripMenuItem.Size = new Size(48, 20);
            lagerToolStripMenuItem.Text = "Lager";
            lagerToolStripMenuItem.Click += lagerToolStripMenuItem_Click;
            // 
            // kassaToolStripMenuItem
            // 
            kassaToolStripMenuItem.Name = "kassaToolStripMenuItem";
            kassaToolStripMenuItem.Size = new Size(48, 20);
            kassaToolStripMenuItem.Text = "Kassa";
            kassaToolStripMenuItem.Click += kassaToolStripMenuItem_Click;
            // 
            // btnDelivery
            // 
            btnDelivery.Location = new Point(30, 14);
            btnDelivery.Name = "btnDelivery";
            btnDelivery.Size = new Size(66, 53);
            btnDelivery.TabIndex = 40;
            btnDelivery.Text = "Lägg till leverans";
            btnDelivery.UseVisualStyleBackColor = true;
            btnDelivery.Click += btnDelivery_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(106, 14);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(66, 53);
            btnDelete.TabIndex = 39;
            btnDelete.Text = "Ta bort varor";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Inventory
            // 
            Inventory.BorderStyle = BorderStyle.FixedSingle;
            Inventory.Controls.Add(videogamesDataGrid);
            Inventory.Controls.Add(bookDataGrid);
            Inventory.Controls.Add(moviesDataGrid);
            Inventory.Controls.Add(TitleMovies);
            Inventory.Controls.Add(TitleVideogames);
            Inventory.Controls.Add(TitleBooks);
            Inventory.Location = new Point(3, 28);
            Inventory.Name = "Inventory";
            Inventory.Size = new Size(836, 726);
            Inventory.TabIndex = 41;
            // 
            // videogamesDataGrid
            // 
            videogamesDataGrid.AccessibleName = "videogamesDataGrid";
            videogamesDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            videogamesDataGrid.AutoGenerateColumns = false;
            videogamesDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            videogamesDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            videogamesDataGrid.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, gameName, gamePrice, platformDataGridViewTextBoxColumn, dataGridViewTextBoxColumn3 });
            videogamesDataGrid.DataMember = "VideogameList";
            videogamesDataGrid.DataSource = inventoryBindingSource1;
            videogamesDataGrid.Location = new Point(0, 272);
            videogamesDataGrid.Name = "videogamesDataGrid";
            videogamesDataGrid.ReadOnly = true;
            videogamesDataGrid.Size = new Size(2699, 212);
            videogamesDataGrid.TabIndex = 18;
            videogamesDataGrid.VirtualMode = true;
            videogamesDataGrid.CellClick += videogamesDataGrid_CellClick;
            videogamesDataGrid.CellFormatting += videogamesDataGrid_CellFormatting;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "ProductID";
            dataGridViewTextBoxColumn1.HeaderText = "ProductID";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 85;
            // 
            // gameName
            // 
            gameName.DataPropertyName = "ProductName";
            gameName.HeaderText = "Namn*";
            gameName.Name = "gameName";
            gameName.ReadOnly = true;
            gameName.Width = 70;
            // 
            // gamePrice
            // 
            gamePrice.DataPropertyName = "Price";
            gamePrice.HeaderText = "Pris*";
            gamePrice.Name = "gamePrice";
            gamePrice.ReadOnly = true;
            gamePrice.Width = 56;
            // 
            // platformDataGridViewTextBoxColumn
            // 
            platformDataGridViewTextBoxColumn.DataPropertyName = "Platform";
            platformDataGridViewTextBoxColumn.HeaderText = "Plattform";
            platformDataGridViewTextBoxColumn.Name = "platformDataGridViewTextBoxColumn";
            platformDataGridViewTextBoxColumn.ReadOnly = true;
            platformDataGridViewTextBoxColumn.Width = 82;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Quantity";
            dataGridViewTextBoxColumn3.HeaderText = "Antal";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 60;
            // 
            // inventoryBindingSource1
            // 
            inventoryBindingSource1.DataSource = typeof(Inventory);
            // 
            // bookDataGrid
            // 
            bookDataGrid.AccessibleName = "bookDataGrid";
            bookDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            bookDataGrid.AutoGenerateColumns = false;
            bookDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            bookDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bookDataGrid.Columns.AddRange(new DataGridViewColumn[] { ProductID, productName, price, author, genre, format, language, Quantity });
            bookDataGrid.DataMember = "BookList";
            bookDataGrid.DataSource = inventoryBindingSource;
            bookDataGrid.ImeMode = ImeMode.NoControl;
            bookDataGrid.Location = new Point(0, 30);
            bookDataGrid.Name = "bookDataGrid";
            bookDataGrid.ReadOnly = true;
            bookDataGrid.Size = new Size(2699, 212);
            bookDataGrid.TabIndex = 17;
            bookDataGrid.VirtualMode = true;
            bookDataGrid.CellClick += bookDataGrid_CellClick;
            bookDataGrid.CellFormatting += bookDataGrid_CellFormatting;
            // 
            // ProductID
            // 
            ProductID.DataPropertyName = "ProductID";
            ProductID.HeaderText = "ProductID";
            ProductID.Name = "ProductID";
            ProductID.ReadOnly = true;
            ProductID.Width = 85;
            // 
            // productName
            // 
            productName.DataPropertyName = "ProductName";
            productName.HeaderText = "Namn*";
            productName.Name = "productName";
            productName.ReadOnly = true;
            productName.Width = 70;
            // 
            // price
            // 
            price.DataPropertyName = "Price";
            price.HeaderText = "Pris*";
            price.Name = "price";
            price.ReadOnly = true;
            price.Width = 56;
            // 
            // author
            // 
            author.DataPropertyName = "Author";
            author.HeaderText = "Författare";
            author.Name = "author";
            author.ReadOnly = true;
            author.Width = 83;
            // 
            // genre
            // 
            genre.DataPropertyName = "Genre";
            genre.HeaderText = "Genre";
            genre.Name = "genre";
            genre.ReadOnly = true;
            genre.Width = 63;
            // 
            // format
            // 
            format.DataPropertyName = "Format";
            format.HeaderText = "Format";
            format.Name = "format";
            format.ReadOnly = true;
            format.Width = 70;
            // 
            // language
            // 
            language.DataPropertyName = "Language";
            language.HeaderText = "Språk";
            language.Name = "language";
            language.ReadOnly = true;
            language.Width = 61;
            // 
            // Quantity
            // 
            Quantity.DataPropertyName = "Quantity";
            Quantity.HeaderText = "Antal";
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            Quantity.Width = 60;
            // 
            // inventoryBindingSource
            // 
            inventoryBindingSource.DataSource = typeof(Inventory);
            // 
            // moviesDataGrid
            // 
            moviesDataGrid.AccessibleName = "moviesDataGrid";
            moviesDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            moviesDataGrid.AutoGenerateColumns = false;
            moviesDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            moviesDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            moviesDataGrid.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, movieName, moviePrice, movieFormat, moviePlaytime, dataGridViewTextBoxColumn4 });
            moviesDataGrid.DataMember = "MovieList";
            moviesDataGrid.DataSource = inventoryBindingSource2;
            moviesDataGrid.Location = new Point(0, 518);
            moviesDataGrid.Name = "moviesDataGrid";
            moviesDataGrid.ReadOnly = true;
            moviesDataGrid.Size = new Size(2699, 212);
            moviesDataGrid.TabIndex = 16;
            moviesDataGrid.VirtualMode = true;
            moviesDataGrid.CellClick += moviesDataGrid_CellClick;
            moviesDataGrid.CellFormatting += moviesDataGrid_CellFormatting;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "ProductID";
            dataGridViewTextBoxColumn2.HeaderText = "ProductID";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 85;
            // 
            // movieName
            // 
            movieName.DataPropertyName = "ProductName";
            movieName.HeaderText = "Namn*";
            movieName.Name = "movieName";
            movieName.ReadOnly = true;
            movieName.Width = 70;
            // 
            // moviePrice
            // 
            moviePrice.DataPropertyName = "Price";
            moviePrice.HeaderText = "Pris*";
            moviePrice.Name = "moviePrice";
            moviePrice.ReadOnly = true;
            moviePrice.Width = 56;
            // 
            // movieFormat
            // 
            movieFormat.DataPropertyName = "Format";
            movieFormat.HeaderText = "Format";
            movieFormat.Name = "movieFormat";
            movieFormat.ReadOnly = true;
            movieFormat.Width = 70;
            // 
            // moviePlaytime
            // 
            moviePlaytime.DataPropertyName = "Playtime";
            moviePlaytime.HeaderText = "Speltid";
            moviePlaytime.Name = "moviePlaytime";
            moviePlaytime.ReadOnly = true;
            moviePlaytime.Width = 68;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "Quantity";
            dataGridViewTextBoxColumn4.HeaderText = "Antal";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 60;
            // 
            // inventoryBindingSource2
            // 
            inventoryBindingSource2.DataSource = typeof(Inventory);
            // 
            // TitleMovies
            // 
            TitleMovies.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleMovies.Location = new Point(0, 484);
            TitleMovies.Name = "TitleMovies";
            TitleMovies.Size = new Size(835, 33);
            TitleMovies.TabIndex = 13;
            TitleMovies.Text = "Filmer";
            TitleMovies.TextAlign = HorizontalAlignment.Center;
            // 
            // TitleVideogames
            // 
            TitleVideogames.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleVideogames.Location = new Point(0, 242);
            TitleVideogames.Name = "TitleVideogames";
            TitleVideogames.Size = new Size(835, 33);
            TitleVideogames.TabIndex = 14;
            TitleVideogames.Text = "Dataspel";
            TitleVideogames.TextAlign = HorizontalAlignment.Center;
            // 
            // TitleBooks
            // 
            TitleBooks.Dock = DockStyle.Top;
            TitleBooks.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleBooks.Location = new Point(0, 0);
            TitleBooks.Name = "TitleBooks";
            TitleBooks.ReadOnly = true;
            TitleBooks.Size = new Size(834, 33);
            TitleBooks.TabIndex = 12;
            TitleBooks.Text = "Böcker";
            TitleBooks.TextAlign = HorizontalAlignment.Center;
            // 
            // panelUpdateItem
            // 
            panelUpdateItem.Controls.Add(btnGetUpdate);
            panelUpdateItem.Controls.Add(label13);
            panelUpdateItem.Controls.Add(inputQuantity);
            panelUpdateItem.Controls.Add(label12);
            panelUpdateItem.Controls.Add(inputID);
            panelUpdateItem.Controls.Add(label11);
            panelUpdateItem.Location = new Point(845, 28);
            panelUpdateItem.Name = "panelUpdateItem";
            panelUpdateItem.Size = new Size(193, 725);
            panelUpdateItem.TabIndex = 67;
            // 
            // btnGetUpdate
            // 
            btnGetUpdate.Location = new Point(51, 129);
            btnGetUpdate.Name = "btnGetUpdate";
            btnGetUpdate.Size = new Size(100, 35);
            btnGetUpdate.TabIndex = 42;
            btnGetUpdate.Text = "Uppdatera vara";
            btnGetUpdate.UseVisualStyleBackColor = true;
            btnGetUpdate.Click += btnGetUpdate_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(10, 94);
            label13.Name = "label13";
            label13.Size = new Size(35, 15);
            label13.TabIndex = 4;
            label13.Text = "Antal";
            // 
            // inputQuantity
            // 
            inputQuantity.Location = new Point(51, 91);
            inputQuantity.Name = "inputQuantity";
            inputQuantity.Size = new Size(100, 23);
            inputQuantity.TabIndex = 3;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(27, 57);
            label12.Name = "label12";
            label12.Size = new Size(18, 15);
            label12.TabIndex = 2;
            label12.Text = "ID";
            // 
            // inputID
            // 
            inputID.Location = new Point(51, 53);
            inputID.Name = "inputID";
            inputID.Size = new Size(100, 23);
            inputID.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(42, 10);
            label11.Name = "label11";
            label11.Size = new Size(121, 15);
            label11.TabIndex = 0;
            label11.Text = "Väl vara att uppdatera";
            // 
            // deliveryPanel
            // 
            deliveryPanel.Controls.Add(label10);
            deliveryPanel.Controls.Add(quantityBox);
            deliveryPanel.Controls.Add(label9);
            deliveryPanel.Controls.Add(playtimeBox);
            deliveryPanel.Controls.Add(label8);
            deliveryPanel.Controls.Add(label5);
            deliveryPanel.Controls.Add(label6);
            deliveryPanel.Controls.Add(label7);
            deliveryPanel.Controls.Add(label4);
            deliveryPanel.Controls.Add(label3);
            deliveryPanel.Controls.Add(label2);
            deliveryPanel.Controls.Add(platformBox);
            deliveryPanel.Controls.Add(languageBox);
            deliveryPanel.Controls.Add(formatBox);
            deliveryPanel.Controls.Add(genreBox);
            deliveryPanel.Controls.Add(authorBox);
            deliveryPanel.Controls.Add(priceBox);
            deliveryPanel.Controls.Add(nameBox);
            deliveryPanel.Controls.Add(chooseProduct);
            deliveryPanel.Controls.Add(btnEscape);
            deliveryPanel.Controls.Add(btnConfirm);
            deliveryPanel.Controls.Add(comboLabel);
            deliveryPanel.Location = new Point(844, 28);
            deliveryPanel.Name = "deliveryPanel";
            deliveryPanel.Size = new Size(196, 725);
            deliveryPanel.TabIndex = 42;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(60, 497);
            label10.Name = "label10";
            label10.Size = new Size(67, 15);
            label10.TabIndex = 66;
            label10.Text = "Ange antal:";
            // 
            // quantityBox
            // 
            quantityBox.Enabled = false;
            quantityBox.Location = new Point(51, 515);
            quantityBox.Multiline = true;
            quantityBox.Name = "quantityBox";
            quantityBox.PlaceholderText = "1-100";
            quantityBox.Size = new Size(100, 32);
            quantityBox.TabIndex = 65;
            quantityBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(60, 443);
            label9.Name = "label9";
            label9.Size = new Size(76, 15);
            label9.TabIndex = 63;
            label9.Text = "Ange speltid:";
            // 
            // playtimeBox
            // 
            playtimeBox.Enabled = false;
            playtimeBox.Location = new Point(51, 461);
            playtimeBox.Multiline = true;
            playtimeBox.Name = "playtimeBox";
            playtimeBox.PlaceholderText = "152 min";
            playtimeBox.Size = new Size(100, 32);
            playtimeBox.TabIndex = 62;
            playtimeBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(60, 389);
            label8.Name = "label8";
            label8.Size = new Size(87, 15);
            label8.TabIndex = 61;
            label8.Text = "Ange platform:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(66, 336);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 60;
            label5.Text = "Ange språk:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(66, 283);
            label6.Name = "label6";
            label6.Size = new Size(77, 15);
            label6.TabIndex = 59;
            label6.Text = "Ange format:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(66, 227);
            label7.Name = "label7";
            label7.Size = new Size(71, 15);
            label7.TabIndex = 58;
            label7.Text = "Ange genre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 171);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 57;
            label4.Text = "Ange författare:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 118);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 56;
            label3.Text = "Ange pris:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 65);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 55;
            label2.Text = "Ange namn:";
            // 
            // platformBox
            // 
            platformBox.Enabled = false;
            platformBox.Location = new Point(51, 407);
            platformBox.Multiline = true;
            platformBox.Name = "platformBox";
            platformBox.PlaceholderText = "PC";
            platformBox.Size = new Size(100, 32);
            platformBox.TabIndex = 53;
            platformBox.TextAlign = HorizontalAlignment.Center;
            // 
            // languageBox
            // 
            languageBox.Enabled = false;
            languageBox.Location = new Point(51, 353);
            languageBox.Multiline = true;
            languageBox.Name = "languageBox";
            languageBox.PlaceholderText = "Svenska";
            languageBox.Size = new Size(100, 32);
            languageBox.TabIndex = 52;
            languageBox.TextAlign = HorizontalAlignment.Center;
            // 
            // formatBox
            // 
            formatBox.Enabled = false;
            formatBox.Location = new Point(51, 301);
            formatBox.Multiline = true;
            formatBox.Name = "formatBox";
            formatBox.PlaceholderText = "Pocket, DVD";
            formatBox.Size = new Size(100, 32);
            formatBox.TabIndex = 51;
            formatBox.TextAlign = HorizontalAlignment.Center;
            // 
            // genreBox
            // 
            genreBox.Enabled = false;
            genreBox.Location = new Point(51, 247);
            genreBox.Multiline = true;
            genreBox.Name = "genreBox";
            genreBox.Size = new Size(100, 32);
            genreBox.TabIndex = 50;
            genreBox.TextAlign = HorizontalAlignment.Center;
            // 
            // authorBox
            // 
            authorBox.Enabled = false;
            authorBox.Location = new Point(51, 189);
            authorBox.Multiline = true;
            authorBox.Name = "authorBox";
            authorBox.Size = new Size(100, 32);
            authorBox.TabIndex = 49;
            authorBox.TextAlign = HorizontalAlignment.Center;
            // 
            // priceBox
            // 
            priceBox.Enabled = false;
            priceBox.Location = new Point(51, 137);
            priceBox.Multiline = true;
            priceBox.Name = "priceBox";
            priceBox.Size = new Size(100, 32);
            priceBox.TabIndex = 48;
            priceBox.TextAlign = HorizontalAlignment.Center;
            // 
            // nameBox
            // 
            nameBox.Enabled = false;
            nameBox.Location = new Point(51, 83);
            nameBox.Multiline = true;
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(100, 32);
            nameBox.TabIndex = 47;
            nameBox.TextAlign = HorizontalAlignment.Center;
            // 
            // chooseProduct
            // 
            chooseProduct.FormattingEnabled = true;
            chooseProduct.Items.AddRange(new object[] { "Böcker", "Dataspel", "Filmer" });
            chooseProduct.Location = new Point(42, 32);
            chooseProduct.Name = "chooseProduct";
            chooseProduct.Size = new Size(121, 23);
            chooseProduct.TabIndex = 0;
            chooseProduct.Text = "Välj produkt";
            chooseProduct.SelectedIndexChanged += chooseProduct_SelectedIndexChanged;
            // 
            // btnEscape
            // 
            btnEscape.Location = new Point(101, 561);
            btnEscape.Name = "btnEscape";
            btnEscape.Size = new Size(46, 23);
            btnEscape.TabIndex = 64;
            btnEscape.Text = "OK";
            btnEscape.UseVisualStyleBackColor = true;
            btnEscape.Click += btnEscape_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(51, 561);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(48, 23);
            btnConfirm.TabIndex = 43;
            btnConfirm.Text = "Skicka";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += confirmButton_Click;
            // 
            // comboLabel
            // 
            comboLabel.AutoSize = true;
            comboLabel.Location = new Point(66, 11);
            comboLabel.Name = "comboLabel";
            comboLabel.Size = new Size(73, 15);
            comboLabel.TabIndex = 1;
            comboLabel.Text = "Välj produkt:";
            // 
            // inventoryPanel
            // 
            inventoryPanel.Controls.Add(btnUpdateStock);
            inventoryPanel.Controls.Add(btnDelivery);
            inventoryPanel.Controls.Add(btnDelete);
            inventoryPanel.Location = new Point(844, 28);
            inventoryPanel.Name = "inventoryPanel";
            inventoryPanel.Size = new Size(196, 726);
            inventoryPanel.TabIndex = 51;
            // 
            // btnUpdateStock
            // 
            btnUpdateStock.Location = new Point(30, 76);
            btnUpdateStock.Name = "btnUpdateStock";
            btnUpdateStock.Size = new Size(142, 35);
            btnUpdateStock.TabIndex = 41;
            btnUpdateStock.Text = "Hämta lager";
            btnUpdateStock.UseVisualStyleBackColor = true;
            btnUpdateStock.Click += btnUpdateStock_Click;
            // 
            // cashierPanel
            // 
            cashierPanel.Controls.Add(cartItemsDisplay);
            cashierPanel.Controls.Add(btnClear);
            cashierPanel.Controls.Add(btnCheckout);
            cashierPanel.Controls.Add(TotalDisplay);
            cashierPanel.Controls.Add(cartLabel);
            cashierPanel.Controls.Add(label1);
            cashierPanel.Location = new Point(841, 28);
            cashierPanel.Name = "cashierPanel";
            cashierPanel.Size = new Size(196, 725);
            cashierPanel.TabIndex = 42;
            // 
            // cartItemsDisplay
            // 
            cartItemsDisplay.AutoGenerateColumns = false;
            cartItemsDisplay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cartItemsDisplay.Columns.AddRange(new DataGridViewColumn[] { productNameDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn });
            cartItemsDisplay.DataMember = "cartList";
            cartItemsDisplay.DataSource = shoppingCartBindingSource2;
            cartItemsDisplay.Location = new Point(3, 99);
            cartItemsDisplay.Name = "cartItemsDisplay";
            cartItemsDisplay.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            cartItemsDisplay.Size = new Size(198, 292);
            cartItemsDisplay.TabIndex = 200;
            cartItemsDisplay.VirtualMode = true;
            cartItemsDisplay.CellClick += cartItemsDisplay_CellClick;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            productNameDataGridViewTextBoxColumn.HeaderText = "Namn*";
            productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            productNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Pris*";
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shoppingCartBindingSource2
            // 
            shoppingCartBindingSource2.DataSource = typeof(ShoppingCart);
            // 
            // btnClear
            // 
            btnClear.Location = new Point(12, 426);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 49;
            btnClear.Text = "Rensa";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnCheckout
            // 
            btnCheckout.Location = new Point(93, 426);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(66, 23);
            btnCheckout.TabIndex = 43;
            btnCheckout.Text = "Betala";
            btnCheckout.UseVisualStyleBackColor = true;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // TotalDisplay
            // 
            TotalDisplay.Location = new Point(12, 397);
            TotalDisplay.Name = "TotalDisplay";
            TotalDisplay.ReadOnly = true;
            TotalDisplay.Size = new Size(100, 23);
            TotalDisplay.TabIndex = 48;
            // 
            // cartLabel
            // 
            cartLabel.AutoSize = true;
            cartLabel.Location = new Point(68, 81);
            cartLabel.Name = "cartLabel";
            cartLabel.Size = new Size(61, 15);
            cartLabel.TabIndex = 47;
            cartLabel.Text = "Kundvagn";
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            // 
            // shoppingCartBindingSource1
            // 
            shoppingCartBindingSource1.DataSource = typeof(ShoppingCart);
            // 
            // shoppingCartBindingSource
            // 
            shoppingCartBindingSource.DataSource = typeof(ShoppingCart);
            // 
            // deletePanel
            // 
            deletePanel.Controls.Add(deletePanelOK);
            deletePanel.Controls.Add(deleteThis);
            deletePanel.Controls.Add(chooseToDelete);
            deletePanel.Location = new Point(844, 29);
            deletePanel.Name = "deletePanel";
            deletePanel.Size = new Size(196, 725);
            deletePanel.TabIndex = 50;
            // 
            // deletePanelOK
            // 
            deletePanelOK.Location = new Point(42, 69);
            deletePanelOK.Name = "deletePanelOK";
            deletePanelOK.Size = new Size(75, 23);
            deletePanelOK.TabIndex = 2;
            deletePanelOK.Text = "Ta bort";
            deletePanelOK.UseVisualStyleBackColor = true;
            deletePanelOK.Click += deletePanelOK_Click;
            // 
            // deleteThis
            // 
            deleteThis.Enabled = false;
            deleteThis.Location = new Point(42, 40);
            deleteThis.Name = "deleteThis";
            deleteThis.PlaceholderText = "Namn";
            deleteThis.Size = new Size(100, 23);
            deleteThis.TabIndex = 1;
            // 
            // chooseToDelete
            // 
            chooseToDelete.FormattingEnabled = true;
            chooseToDelete.Items.AddRange(new object[] { "Böcker", "Dataspel", "Filmer" });
            chooseToDelete.Location = new Point(42, 11);
            chooseToDelete.Name = "chooseToDelete";
            chooseToDelete.Size = new Size(121, 23);
            chooseToDelete.TabIndex = 0;
            chooseToDelete.Text = "Välj vara";
            chooseToDelete.SelectedIndexChanged += chooseToDelete_SelectedIndexChanged;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1040, 757);
            Controls.Add(cashierPanel);
            Controls.Add(inventoryPanel);
            Controls.Add(deliveryPanel);
            Controls.Add(panelUpdateItem);
            Controls.Add(Inventory);
            Controls.Add(menuStrip);
            Controls.Add(deletePanel);
            MainMenuStrip = menuStrip;
            Name = "mainForm";
            Text = "Affär";
            Load += mainForm_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            Inventory.ResumeLayout(false);
            Inventory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)videogamesDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)inventoryBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)inventoryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)moviesDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)inventoryBindingSource2).EndInit();
            panelUpdateItem.ResumeLayout(false);
            panelUpdateItem.PerformLayout();
            deliveryPanel.ResumeLayout(false);
            deliveryPanel.PerformLayout();
            inventoryPanel.ResumeLayout(false);
            cashierPanel.ResumeLayout(false);
            cashierPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cartItemsDisplay).EndInit();
            ((System.ComponentModel.ISupportInitialize)shoppingCartBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)shoppingCartBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)shoppingCartBindingSource).EndInit();
            deletePanel.ResumeLayout(false);
            deletePanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem lagerToolStripMenuItem;
        private ToolStripMenuItem kassaToolStripMenuItem;
        private Button btnDelivery;
        private Button btnDelete;
        private Panel Inventory;
        private DataGridView videogamesDataGrid;
        private DataGridView moviesDataGrid;
        private TextBox TitleMovies;
        private TextBox TitleVideogames;
        private TextBox TitleBooks;
        private DataGridView bookDataGrid;
        private BindingSource inventoryBindingSource;
        private BindingSource inventoryBindingSource1;
        private BindingSource inventoryBindingSource2;
        private Panel cashierPanel;
        private Button btnCheckout;
        private Label label1;
        private Label cartLabel;
        private TextBox TotalDisplay;
        private Button btnClear;
        private Panel deliveryPanel;
        private ComboBox chooseProduct;
        private Label comboLabel;
        private TextBox nameBox;
        private TextBox platformBox;
        private TextBox languageBox;
        private TextBox formatBox;
        private TextBox genreBox;
        private TextBox authorBox;
        private TextBox priceBox;
        private Label label3;
        private Label label2;
        private Label label8;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label4;
        private Label label9;
        private TextBox playtimeBox;
        private Button btnConfirm;
        private Panel inventoryPanel;
        private Button btnEscape;
        private Panel deletePanel;
        private Button deletePanelOK;
        private TextBox deleteThis;
        private ComboBox chooseToDelete;
        private BindingSource shoppingCartBindingSource;
        private BindingSource shoppingCartBindingSource1;
        private DataGridView cartItemsDisplay;
        private BindingSource shoppingCartBindingSource2;
        private Label label10;
        private TextBox quantityBox;
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn gameName;
        private DataGridViewTextBoxColumn gamePrice;
        private DataGridViewTextBoxColumn platformDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn ProductID;
        private DataGridViewTextBoxColumn productName;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn author;
        private DataGridViewTextBoxColumn genre;
        private DataGridViewTextBoxColumn format;
        private DataGridViewTextBoxColumn language;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn movieName;
        private DataGridViewTextBoxColumn moviePrice;
        private DataGridViewTextBoxColumn movieFormat;
        private DataGridViewTextBoxColumn moviePlaytime;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Button btnUpdateStock;
        private Panel panelUpdateItem;
        private Label label12;
        private TextBox inputID;
        private Label label11;
        private Label label13;
        private TextBox inputQuantity;
        private Button btnGetUpdate;
    }
}
