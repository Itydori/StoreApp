# Product Management System

## Overview

The **Product Management System** is a web application designed to efficiently manage product-related operations such as creating, updating, and categorizing products. This system is built using ASP.NET Core MVC, providing a structured and scalable solution for e-commerce platforms, inventory management, or any business that requires organized product handling.

## Features

- **Product Creation**: Add new products with details such as name, category, summary, price, and image.
- **Category Management**: Select categories dynamically from the database.
- **File Upload**: Allows users to upload images for products.
- **Validation & Error Handling**: Ensures that product data is correctly entered before submission.
- **Responsive UI**: Built with Bootstrap for a clean and accessible user interface.

## Technologies Used

- ASP.NET Core MVC
- Entity Framework Core (EF Core)
- SQL Server
- Bootstrap
- JavaScript / jQuery

## Installation

### Prerequisites

Ensure you have the following installed on your machine:

- [.NET SDK](https://dotnet.microsoft.com/en-us/download/dotnet)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [Visual Studio](https://visualstudio.microsoft.com/) (or VS Code with C# extensions)

### Setup Steps

1. Clone the repository:
   ```sh
   git clone https://github.com/your-repository/product-management-system.git
   cd product-management-system
   ```
2. Install dependencies:
   ```sh
   dotnet restore
   ```
3. Set up the database:
   - Update `appsettings.json` with your SQL Server connection string.
   - Apply migrations:
     ```sh
     dotnet ef database update
     ```
4. Run the application:
   ```sh
   dotnet run
   ```

## Usage

### Adding a Product

1. Navigate to `/Product/Create`
2. Fill in the product details (Name, Summary, Price, etc.)
3. Select a category from the dropdown menu
4. Upload an image (optional)
5. Click **Save** to add the product

### Viewing Products

- Navigate to `/Product/Index` to see the list of all added products.

### Editing & Deleting Products

- Click on **Edit** to update a product's details.
- Click on **Delete** to remove a product from the system.

## Troubleshooting

### "The value '' is invalid" Error

If you encounter this error while submitting the form, ensure that:

- A category is selected before submission.
- Required fields are not left empty.
- The `CategoryId` field in the model is properly configured with a `[Required]` attribute.

## Contributing

Feel free to contribute by submitting pull requests. Ensure to follow the coding guidelines and document your changes properly.

## License

This project is licensed under the [MIT License](LICENSE).

---

For further inquiries, contact [your-email@example.com](mailto\:itydori@gmail.com).

