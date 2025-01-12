# CRUD Operation with Entity Framework Code-First Approach

This project demonstrates the implementation of CRUD (Create, Read, Update, Delete) operations using the Entity Framework Code-First approach in an ASP.NET MVC application. The application manages products and their associated categories.

## Features
- Create, Read, Update, and Delete operations for `Product` and `Category` entities.
- Pagination for better user experience when browsing large datasets.
- Integration with Entity Framework using the Code-First approach.

---

## Prerequisites
- **Visual Studio**: Any recent version supporting ASP.NET MVC.
- **SQL Server**: A database server for storing application data.
- **Entity Framework**: NuGet package for EF installed.
- **Bootstrap** (optional): For UI styling.

---

## Installation
1. **Clone the Repository**:
   ```bash
   git clone https://github.com/jamdademayuri/DotnetCodeSamples.git
   ```
2. **Open the Project**:
   Open the `.sln` file in Visual Studio.
3. **Restore NuGet Packages**:
   Use the NuGet Package Manager to restore the required dependencies.
   ```bash
   Update-Package -reinstall
   ```
4. **Configure the Database Connection**:
   Update the `connectionString` in `Web.config`:
   ```xml
   <connectionStrings>
       <add name="DefaultConnection" connectionString="Server=<your-server>;Database=YourDatabaseName;Trusted_Connection=True;" providerName="System.Data.SqlClient" />
   </connectionStrings>
   ```
5. **Apply Migrations**:
   Enable and apply migrations to generate the database schema:
   ```bash
   Enable-Migrations
   Add-Migration InitialCreate
   Update-Database
   ```
6. **Run the Application**:
   Press `F5` or run the application to start the development server.

---

## Project Structure
### Models
- `Product`: Represents a product entity with properties such as `ProductId`, `ProductName`, and `CategoryId`.
- `Category`: Represents a category entity with properties such as `CategoryId` and `CategoryName`.

### Controllers
- `ProductController`: Handles CRUD operations for products.
- `CategoryController`: Handles CRUD operations for categories.

### Views
- **Index**: Displays a paginated list of products or categories.
- **Create**: Provides a form to add a new product or category.
- **Edit**: Provides a form to update an existing product or category.
- **Delete**: Confirms the deletion of a product or category.
- **Details**: Displays detailed information about a product or category.

### Pagination
Pagination is implemented in the `ProductController` to limit the number of displayed records per page. Users can navigate through pages using links in the view.

---

## How to Use
1. **Home Page**:
   Navigate to the home page to view a list of products.
2. **Add a Product**:
   - Click on "Create New".
   - Fill in the product details and save.
3. **Edit a Product**:
   - Click on "Edit" for a specific product.
   - Update the details and save.
4. **Delete a Product**:
   - Click on "Delete" for a specific product.
   - Confirm deletion.
5. **View Product Details**:
   - Click on "Details" to view product information.
6. **Pagination**:
   - Navigate between pages using the pagination links at the bottom of the list.

---

## Technologies Used
- **ASP.NET MVC**: Framework for building web applications.
- **Entity Framework**: ORM tool for data access.
- **SQL Server**: Database for storing application data.
- **Bootstrap** (optional): For UI styling.

---



