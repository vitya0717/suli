DROP DATABASE IF EXISTS shop;
CREATE DATABASE shop;
USE shop;
CREATE TABLE customers(
	customer_id INT,
	name VARCHAR(64), 
	PRIMARY KEY(customer_id)
);
CREATE TABLE orders(
	order_id INT,
	date DATE,
	customer_id INT,
	PRIMARY KEY(order_id),
	FOREIGN KEY (customer_id) REFERENCES customers (customer_id);
);
INSERT INTO customers (customer_id, name) VALUES 
	(1,"Nagy Gergo"),
	(2, "Gipsz Jakab"),
	(77, "Cement Janos");
	
INSERT INTO orders(order_id, date, customer_id) VALUES 
	(1000, '2023-01-11', 1), 
	(1001, '2023-01-19', 2),
	(1002, '2023-04-19', 77);


DELETE FROM customers WHERE customer_id = 2;
DELETE FROM orders WHERE customer_id = 2;