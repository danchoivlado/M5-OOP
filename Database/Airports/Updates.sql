-- 03.	Update Arrived Flights
UPDATE flights AS f
SET f.airline_id =1
WHERE f.status= "Arrived";
-- 04.	Update Tickets
UPDATE tickets AS t
JOIN flights AS f ON t.ticket_id =f.flight_id
SET t.price=(t.price* 0.5) + t.price
WHERE f.flight_id =(SELECT a.airline_id FROM airlines AS a
				ORDER BY a.rating  DESC LIMIT 1)









