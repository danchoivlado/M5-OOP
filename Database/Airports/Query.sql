-- 05.	Tickets
SELECT ticket_id,price, class, seat
FROM tickets
ORDER BY 1;

-- 06.	Customers
SELECT customer_id, CONCAT(first_name," ",last_name) AS full_name, gender
FROM customers AS c
ORDER BY 2,1;

-- 07.	Flights
SELECT  flight_id,departure_time,arrival_time
FROM flights 
WHERE `status` = "Delayed"
ORDER BY 1;

-- 08.	Top 5 Airlines
SELECT airline_id, airline_name, nationality, rating
FROM airlines AS a
ORDER BY rating DESC,airline_id ASC LIMIT 5;

-- 09.	‘First Class’ Tickets
SELECT ticket_id,a.airport_name destination,CONCAT(c.first_name," ",c.last_name) AS customer_name
FROM tickets AS t
JOIN customers AS c ON t.customer_id=c.customer_id
JOIN flights AS f ON t.flight_id=f.flight_id
JOIN airports AS a ON f.destination_airport_id=a.airport_id
WHERE t.price<5000 AND t.class="First"
ORDER BY 1;

-- 10.	Home Town Customers
SELECT DISTINCT c.customer_id, CONCAT(c.first_name," ",c.last_name) AS full_name,towns.town_name AS home_town
FROM  customers AS c
JOIN tickets AS t ON t.customer_id=c.customer_id
JOIN flights AS f ON t.flight_id=f.flight_id
JOIN airports AS a ON a.airport_id=f.origin_airport_id
JOIN towns  ON towns.town_id=c.home_town_id
WHERE a.airport_name LIKE CONCAT(towns.town_name,"%")
ORDER BY 1;

-- 11.	Flying Customers
SELECT DISTINCT c.customer_id, CONCAT(c.first_name," ",c.last_name) AS full_name,
	("2016" - YEAR(c.date_of_birth)) AS age
FROM  customers AS c
JOIN tickets AS t ON t.customer_id=c.customer_id
JOIN flights AS f ON t.flight_id=f.flight_id
WHERE f.status = "Departing" 
ORDER BY age ,1;

-- 12.	Delayed Customers
SELECT c.customer_id,CONCAT(c.first_name," ",c.last_name)AS full_name,
	t.price AS ticket_price, a.airport_name AS destination
FROM customers AS c
JOIN tickets AS t ON t.customer_id=c.customer_id
JOIN flights AS f ON t.flight_id=f.flight_id
JOIN airports AS a ON a.airport_id=f.destination_airport_id
WHERE f.status ="Delayed"
ORDER BY ticket_price DESC ,1 LIMIT 3;


SELECT f.flight_id, f.departure_time, f.arrival_time,a1.airport_name AS origin,
	a2.airport_name AS destination
FROM flights AS f
JOIN airports AS a1 ON a1.airport_id=f.origin_airport_id
JOIN airports AS a2 ON a2.airport_id=f.destination_airport_id
ORDER BY f.departure_time DESC, 2,1 LIMIT 5;

-- 14.	Flying Children
SELECT DISTINCT c.customer_id, CONCAT(c.first_name," ",c.last_name) AS full_name,
("2016" - YEAR(c.date_of_birth)) AS age	
FROM customers AS c
JOIN tickets AS t ON t.customer_id=c.customer_id
JOIN flights AS f ON t.flight_id=f.flight_id
WHERE f.status = "Arrived" AND ("2016" - YEAR(c.date_of_birth))<21
ORDER BY age DESC,1;
 -- 15
SELECT   airport_id, airport_name,
	COUNT(f.origin_airport_id) AS passengers
FROM airports AS a
JOIN towns AS t ON a.town_id= t.town_id
JOIN customers AS c ON c.home_town_id = t.town_id
JOIN tickets AS t1 ON t1.customer_id=c.customer_id
JOIN flights AS f ON t1.flight_id=f.flight_id
WHERE f.status = "Departing"
GROUP BY a.airport_id
ORDER BY 1;


SELECT   *
FROM airports AS a






