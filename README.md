# ERP System  

## Overview

This project is a desktop-based **Enterprise Resource Planning (ERP)** system developed in **C# and .NET (Windows Forms)** as part of a university coursework assignment. The system demonstrates core ERP functionality such as inventory management, sales processing, persistent storage, and integration with an external API.

The application is designed to manage multiple product categories and provides a graphical user interface for interacting with inventory and sales workflows.

---

## Features

- Product inventory management
  - Books
  - Videogames
  - Movies
- Shopping cart and checkout functionality
- Stock validation during sales
- Persistent storage using CSV files
- Synchronization with an external inventory API
- XML parsing for API responses
- Windows Forms–based graphical user interface

---

## Architecture

The system follows a simple object-oriented design with clear responsibility separation:

- **Product**
  - Base class for all products
  - Specialized types: `Book`, `Videogame`, `Movie`
- **Inventory**
  - Maintains product lists
  - Handles initial data population and ID generation
- **Grossit**
  - Manages stock updates, persistence, and API communication
- **ShoppingCart**
  - Handles cart operations and total price calculation
- **Sales**
  - Validates stock and processes checkout logic

The application prioritizes clarity and learning outcomes over enterprise-scale complexity.

---

## Persistence

Product data is stored locally in a **CSV file**:

- Automatically created on first run
- Updated after inventory changes and completed sales
- Loaded at application startup to restore previous state

---

## External API Integration

The system integrates with an external REST API that:

- Provides centralized product stock data
- Accepts stock updates via HTTP GET requests
- Returns responses in XML format

API data is parsed and merged with local inventory data.

---

## Technologies Used

- C# (.NET)
- Windows Forms
- LINQ
- HttpClient
- XML parsing
- CSV file handling

---

## Academic Context

This project was developed as part of a **university course assignment** and is intended for educational purposes. Design decisions reflect the scope and constraints of the course.

---

## Possible Improvements

- Replace CSV storage with a database
- Introduce layered architecture (UI / Business / Data)
- Improve error handling and validation
- Add unit testing
- Improve separation between UI and domain logic

---

## License

This project is provided for educational use only.

