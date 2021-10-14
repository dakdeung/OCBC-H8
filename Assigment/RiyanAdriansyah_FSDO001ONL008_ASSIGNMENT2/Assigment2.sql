CREATE DATABASE db_bank;

-------------------------------------------------------------
----------------------------NOTE-----------------------------

--karena ada foreign key jadi urutan pembuatan table dan insert data tidak berurut sesuai nomor soal
--Urutan : Productlines =>> Product =>> Offices =>> Employees =>> Customers =>> Payments =>> OrdersOrderdetails 

-------------------------------------------------------------
-------------------------------------------------------------

-------------------------------------------------------------
----------------------------Nomor 3--------------------------

CREATE TABLE productlines(
productLine int PRIMARY KEY IDENTITY(1,1),
textDescription VARCHAR(50),
htmlDescription VARCHAR(50),
image VARCHAR(50)
)

INSERT INTO productlines (textDescription, htmlDescription, image)
VALUES 
('Motor', '<p>this is motor.</p>','https://www.OCBCBANK.com/Motor'),
('Mobil', '<p>this is mobil.</p>','https://www.OCBCBANK.com/Mobil'),
('Handphone', '<p>this is handphone.</p>','https://www.OCBCBANK.com/Handphone'),
('Laptop', '<p>this is laptop.</p>','https://www.OCBCBANK.com/Laptop'),
('Komputer', '<p>this is komputer.</p>','https://www.OCBCBANK.com/Komputer')

SELECT * FROM productlines;

-------------------------------------------------------------
----------------------------Nomor 2--------------------------

CREATE TABLE products(
productCode INT PRIMARY KEY IDENTITY(1,1),
productName VARCHAR(50) NOT NULL,
productLine INT REFERENCES productlines(productline) NOT NULL,
productScale INT NOT NULL,
productVendor VARCHAR(50) NOT NULL,
productDescription VARCHAR(100) NOT NULL,
quantityInStock INT NOT NULL,
buyPrice DECIMAL(20,2) NOT NULL,
MSRP DECIMAL(20,2) NOT NULL
)

INSERT INTO products (productName, productLine, productScale ,productVendor, productDescription, quantityinStock, buyPrice, MSRP)
VALUES 
('X-Ride', 1, 1,'Yamaha', 'Sepeda motor Yamaha X-Ride', 10, 18000000, 17500000),
('Mio', 1, 1,'Yamaha', 'Sepeda motor Yamaha Mio', 30, 16000000, 15000000),
('Nmax', 1, 1,'Yamaha', 'Sepeda motor Yamaha Nmax', 15, 220000000, 215000000),
('Scoopy', 1, 1,'Honda', 'Sepeda motor Honda Mio', 25, 150000000, 140000000),
('KLX', 1, 1,'Kawasaki', 'Sepeda motor Kawasaki KLX', 8, 28000000, 27000000)

SELECT * FROM products;

-------------------------------------------------------------
----------------------------Nomor 8--------------------------

CREATE TABLE offices(
	officeCode INT PRIMARY KEY IDENTITY(1,1) ,
	city VARCHAR(20) NOT NULL,
	phone VARCHAR(20) NOT NULL,
	addressLine1 VARCHAR(50) NOT NULL,
	addressLine2 VARCHAR(50),
	state VARCHAR(20) NOT NULL,
	country VARCHAR(20) NOT NULL,
	postalCode VARCHAR(20) NOT NULL,
	teritory VARCHAR(20)
);

INSERT INTO offices (city, phone, addressLine1, addressLine2, state, country, postalCode, teritory)
VALUES 
('Bandung', '02287238', 'Jl Cihapit', NULL, 'Indonesia', 'Indonesia', '40121', 'Bandung'),
('Jakarta', '02287124', 'Jl Lebak Bulus', NULL, 'Indonesia', 'Indonesia', '40152', 'Jakarta'),
('Surabaya', '02287512', 'Jl Gatsu', NULL, 'Indonesia', 'Indonesia', '40235', 'Surabaya'),
('Semarang', '02287122', 'Jl Kosambi', NULL, 'Indonesia', 'Indonesia', '40235', 'Semarang'),
('Bekasi', '02287252', 'Jl Cicadas', NULL, 'Indonesia', 'Indonesia', '40235', 'Bekasi');

SELECT * FROM offices;

-------------------------------------------------------------
----------------------------Nomor 7--------------------------

CREATE TABLE employees(
	employeeNumber INT PRIMARY KEY IDENTITY(1,1) ,
	lastName VARCHAR(20),
	firstName VARCHAR(20) NOT NULL,
	extension VARCHAR(20),
	email VARCHAR(30) NOT NULL,
	officeCode INT REFERENCES offices(officeCode) NOT NULL,
	reportsTo VARCHAR(20) NOT NULL,
	jobTitle VARCHAR(20) NOT NULL
);


INSERT INTO employees (lastName, firstName, extension, email, officeCode, reportsTo, jobTitle)
VALUES 
('Permana', 'Angga', NULL, 'angga@ocbcbank.com', 1, 'Indra', 'Sales'),
('Devianti', 'Ayu', NULL, 'ayu@ocbcbank.com', 1, 'Indra', 'Accounting'),
(NULL, 'Herawati', NULL, 'herawati@ocbcbank.com', 1, 'Indra', 'IT'),
('Ratnasari', 'Desi', NULL, 'desi@ocbcbank.com', 1, 'Indra', 'Sales'),
( 'Simatupang', 'Derry', NULL, 'derry@ocbcbank.com', 1, 'Indra', 'Officer');

SELECT * FROM employees;


-------------------------------------------------------------
----------------------------Nomor 1--------------------------
CREATE TABLE customers(
	customerNumber INT PRIMARY KEY IDENTITY(1,1),
	customerName VARCHAR(50) NOT NULL,
	contactLastName VARCHAR(20),
	contactFirstName VARCHAR(20),
	addressLine1 VARCHAR(50) NOT NULL,
	addressLine2 VARCHAR(50),
	city VARCHAR(20) NOT NULL,
	state VARCHAR(20) NOT NULL,
	postalCode VARCHAR(8) NOT NULL,
	country VARCHAR(20) NOT NULL,
	salesRepEmployeeNumber INT REFERENCES employees(employeeNumber) NOT NULL,
	creditLimit DECIMAL(20,2)
);

INSERT INTO customers (customerName, contactLastName, contactFirstName, addressLine1, addressLine2, city, state, postalCode, country, salesRepEmployeeNumber, creditLimit)
VALUES 
	('Riyan', NULL, NULL, 'Jl. Sukarasa', NULL, 'Bandung', 'Indonesia', '40192', 'Indonesia', 5, NULL),
	('Felia', NULL, NULL, 'Jl. Sukapura', NULL, 'Bandung', 'Indonesia', '40261', 'Indonesia', 2, NULL),
	('Reva', NULL, NULL, 'Jl. Sukasenang', NULL, 'Cimahi', 'Indonesia', '40153', 'Indonesia', 3, NULL),
	('Didit', NULL, NULL, 'Jl. Sukarajin', NULL, 'Bogor', 'Indonesia', '40113', 'Indonesia', 1, NULL),
	('Ujang', NULL, NULL, 'Jl. Dago', NULL, 'Garut', 'Indonesia', '40151', 'Indonesia', 1, NULL);

SELECT * FROM customers;

-------------------------------------------------------------
----------------------------Nomor 6--------------------------

CREATE TABLE payments(
	customerNumber INT REFERENCES customers(customerNumber) NOT NULL,
	checkNumber INT PRIMARY KEY IDENTITY(1,1),
	paymentDate DATE NOT NULL,
	amount DECIMAL(20,2) NOT NULL
);

INSERT INTO payments (customerNumber, paymentDate, amount)
VALUES 
(1, '09-2-2021',18000000),
(2, '09-10-2021',18000000),
(3, '09-8-2021',12000000),
(4, '09-3-2021',28000000),
(5, '09-5-2021',10000000);

SELECT * FROM payments;

-------------------------------------------------------------
----------------------------Nomor 4--------------------------

CREATE TABLE orders(
orderNumber INT PRIMARY KEY IDENTITY(1,1) ,
orderDate DATE NOT NULL,
requiredDate DATE NOT NULL,
shippedDate DATE NOT NULL,
status VARCHAR(20),
comments VARCHAR(50),
customerNumber INT REFERENCES customers(customerNumber) NOT NULL
)

INSERT INTO orders (orderDate, requiredDate, shippedDate, status, comments, customerNumber)
VALUES 
('08-30-2021','09-1-2021', '09-1-2021', 'Proses', NULL, 2),
('09-2-2021','09-3-2021', '09-5-2021', 'Proses', NULL, 3),
('08-30-2021','09-1-2021', '09-2-2021', 'On Delivery', 'Barang Mudah Pecah', 1),
('08-1-2021','09-2-2021', '09-3-2021', 'Transit', NULL, 5),
('09-9-2021','09-12-2021', '09-12-2021', 'Proses', NULL, 4);

SELECT * FROM orders;

-------------------------------------------------------------
----------------------------Nomor 4--------------------------

CREATE TABLE orderdetails(
orderNumber INT REFERENCES orders(orderNumber) NOT NULL,
productCode INT REFERENCES products(productCode) NOT NULL,
quantityOrdered INT NOT NULL,
priceEach INT NOT NULL,
orderLineNumber INT NOT NULL
)

INSERT INTO orderdetails (orderNumber, productCode, quantityOrdered, priceEach, orderLineNumber)
VALUES 
(2, 1, 1, 18000000, 1),
(3, 1, 1, 18000000, 2),
(4, 3, 1, 22000000, 3),
(5, 5, 1, 28000000, 4),
(6, 1, 1, 18000000, 5);

SELECT * FROM orderdetails;

-------------------------------------------------------------
---------------------------Tambahan--------------------------

SELECT c.customerNumber, c.customerName, o.orderNumber, p.productName, p.buyPrice AS price ,od.quantityOrdered, py.amount 
AS pembayaran , py.paymentDate, o.status, (e.firstName +' '+ e.lastName) AS sales 
FROM customers c 
JOIN orders o ON c.customerNumber = o.customerNumber
JOIN orderdetails od ON o.orderNumber = od.orderNumber
JOIN products p ON od.productCode = p.productCode
JOIN payments py ON py.customerNumber = c.customerNumber
JOIN employees e ON c.salesRepEmployeeNumber = e.employeeNumber;