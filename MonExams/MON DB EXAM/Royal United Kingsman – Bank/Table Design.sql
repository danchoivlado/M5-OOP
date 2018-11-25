CREATE DATABASE ruk_database;
USE ruk_database;

CREATE TABLE branches(
	id INT AUTO_INCREMENT,
    name VARCHAR(30) NOT NULL UNIQUE,
    CONSTRAINT PRIMARY KEY (id)	
);

CREATE TABLE employees(
	id INT AUTO_INCREMENT,
    first_name VARCHAR(20) NOT NULL,
    last_name VARCHAR(20) NOT NULL,
    salary DECIMAL(10,2) NOT NULL ,-- PROBVAI DECIMAL
    started_on DATE NOT NULL,
    branch_id INT NOT NULL,
    CONSTRAINT PRIMARY KEY (id),
    FOREIGN KEY (branch_id) REFERENCES branches(id)
);

CREATE TABLE clients(
	id INT AUTO_INCREMENT,
    full_name VARCHAR(50) NOT NULL,
    age INT NOT NULL,
    CONSTRAINT PRIMARY KEY (id)
);

CREATE TABLE employees_clients(
	employee_id INT ,
    client_id INT ,
    FOREIGN KEY (employee_id) REFERENCES employees(id),
    FOREIGN KEY (client_id) REFERENCES clients(id)
);

CREATE TABLE bank_accounts(
	id INT AUTO_INCREMENT,
    account_number VARCHAR(10) NOT NULL,
    balance DECIMAL(10,2) NOT NULL,
    client_id INT NOT NULL UNIQUE,
    CONSTRAINT PRIMARY KEY (id),
    FOREIGN KEY (client_id) REFERENCES clients(id)
);

CREATE TABLE cards(
	id INT AUTO_INCREMENT,
    card_number VARCHAR(19)	NOT NULL,
    card_status VARCHAR(7) NOT NULL,
    bank_account_id INT NOT NULL,
    CONSTRAINT PRIMARY KEY (id),
    FOREIGN KEY (bank_account_id) REFERENCES bank_accounts(id)
);







