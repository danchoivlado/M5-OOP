CREATE DATABASE airport_management_system;
USE airport_management_system;

CREATE TABLE towns(
	town_id INT ,
    town_name VARCHAR(30) NOT NULL,
    CONSTRAINT PRIMARY KEY(town_id)
);

CREATE TABLE airports(
	airport_id INT ,
    airport_name VARCHAR(50) NOT NULL,
    town_id INT ,
    CONSTRAINT PRIMARY KEY (airport_id),
    FOREIGN KEY (town_id) REFERENCES towns(town_id)
);

CREATE TABLE airlines(
	airline_id INT,
    airline_name VARCHAR(30) NOT NULL,
    nationality VARCHAR(30) NOT NULL,
    rating INT DEFAULT 0,
    CONSTRAINT PRIMARY KEY (airline_id)
);

CREATE TABLE customers(
	customer_id INT,
    first_name VARCHAR(20) NOT NULL,
    last_name VARCHAR(20)NOT NULL,
    date_of_birth DATE NOT NULL,
    gender VARCHAR(1),
    home_town_id INT,
    CONSTRAINT PRIMARY KEY (customer_id),
    FOREIGN KEY (home_town_id) REFERENCES towns(town_id)
);

CREATE TABLE flights(
	flight_id INT AUTO_INCREMENT,
    departure_time DATETIME NOT NULL,
    arrival_time DATETIME NOT NULL,
    `status` VARCHAR(9),
    origin_airport_id INT ,
    destination_airport_id INT,
    airline_id INT,
    CONSTRAINT PRIMARY KEY (flight_id),
    FOREIGN KEY (origin_airport_id)REFERENCES airports(airport_id),
    FOREIGN KEY (destination_airport_id)REFERENCES airports(airport_id),
    FOREIGN KEY (airline_id) REFERENCES airlines(airline_id)
);

CREATE TABLE tickets(
	ticket_id INT AUTO_INCREMENT,
    price DECIMAL(8,2) NOT NULL,
    class VARCHAR(6),
    seat VARCHAR(5) NOT NULL,
    customer_id INT ,
    flight_id INT,
    CONSTRAINT PRIMARY KEY (ticket_id),
    FOREIGN KEY (customer_id) REFERENCES customers(customer_id),
    FOREIGN KEY (flight_id) REFERENCES flights(flight_id)
);



















