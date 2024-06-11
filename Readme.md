# Nizventory

🎓 **Semester Projects Showcase!** 🎓

Delighted to unveil my latest endeavor: an **Inventory Management System** integrating Visual and Database elements. Featuring robust cookie-based authentication and tailored setups for localhost, PHPMyAdmin, and SQL server. 🚀

## How to Run

- Run these Querries to Create tables in sql server or built in sql.
- 
  ```sql
    CREATE TABLE brands (
    bid INT IDENTITY(1,1) PRIMARY KEY,
    bname VARCHAR(20));

    CREATE TABLE categories (
    cid INT IDENTITY(1,1) PRIMARY KEY,
    category_name VARCHAR(20));

    CREATE TABLE stores (
    sid INT IDENTITY(1,1) PRIMARY KEY,
    sname VARCHAR(20),
    address VARCHAR(50),
    mobno VARCHAR(10))

    CREATE TABLE product (
    pid INT IDENTITY(1,1) PRIMARY KEY,
    cid INT,
    bid INT,
    sid INT,
    pname VARCHAR(20),
    p_stock INT,
    price DECIMAL(10, 2),
    added_date DATE,
    image VARCHAR(255),
    FOREIGN KEY (cid) REFERENCES categories(cid),
    FOREIGN KEY (bid) REFERENCES brands(bid),
    FOREIGN KEY (sid) REFERENCES stores(sid))
  ```
- Open `inventory_blazor\Server\appsettings.json`.
- Paste the Connection string in : `DefaultConnection:""`
- Run the project and you're good to go.
- For any queries, please feel free to contact me via the social media accounts provided below.

## Features

- Generation of cookies stored in local storage.
- No page redirection without authentication.
- Easy setup process.
- Image uploading functionality.

## Contributions

Feel free to fork this repository and contribute by adding the remaining pages for the tables. Your contributions will assist others who utilize this repository in the future.

Feel the code's pulse, delve deeper, and contribute your magic! 🛠️

## GitHub Repositories Blazor

- For C# Blazor Code, check out: [inventory_blazor](https://github.com/umairniaziofficial/inventory_blazor)

Join the journey! 🌟


## Author

🚀 **NizzyPedia - Umair Khan**

🌐 **Social Links**

- [![Instagram](https://img.shields.io/badge/Instagram-%40nizzypedia-red)](https://www.instagram.com/nizzypedia/)
- [![Linkedin](https://img.shields.io/badge/Linkedin-%40nizzypedia-blue)](https://www.linkedin.com/in/nizzypedia/)
