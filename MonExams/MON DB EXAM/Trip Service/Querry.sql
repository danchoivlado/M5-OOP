-- 01 Български градове
SELECT id AS Id,name AS Name
FROM cities AS c 
WHERE c.country_code ="BG"
ORDER BY c.name ASC;

-- 02 Хора родени след 1991
SELECT CONCAT_WS(" ",first_name,middle_name,last_name) 
	AS `Full Name` ,YEAR(birth_date) AS BirthYear
FROM accounts AS c
WHERE YEAR(c.birth_date)>1991
ORDER BY 2 DESC,c.first_name ASC;

-- 03 Градска статистика
SELECT c.name AS City,COUNT(h.city_id) AS Hotels
FROM cities AS c
LEFT JOIN hotels AS h ON h.city_id = c.id
GROUP BY c.id
ORDER BY Hotels DESC,1 ASC;

-- 04 Стаи от първа класа
SELECT r.id AS Id,r.price AS Price,h.name AS Hotel,c.name AS City
FROM rooms AS r
JOIN hotels AS h ON r.hotel_id=h.id
JOIN cities AS c ON h.city_id=c.id
WHERE r.type= "First Class"
ORDER BY 2 DESC,1 ASC;

-- 05 Най-дълги и най-кратки пътувания 
SELECT a.Id   AS AccountId,-- NE BACHKA
  concat(a.FirstName, ' ', a.LastName)  AS FullName,-- NE BACHKA
  MAX(datediff(DAY, ArrivalDate, ReturnDate)) AS LongestTrip,-- NE BACHKA
  MIN(datediff(DAY, ArrivalDate, ReturnDate)) AS ShortestTrip-- NE BACHKA
FROM Accounts a-- NE BACHKA
  JOIN AccountsTrips at2-- NE BACHKA
    ON a.Id = at2.AccountId-- NE BACHKA
  JOIN Trips t-- NE BACHKA
    ON at2.TripId = t.Id-- NE BACHKA
WHERE a.MiddleName IS NULL AND t.CancelDate IS NULL-- NE BACHKA
GROUP BY a.Id, a.FirstName, a.LastName-- NE BACHKA
ORDER BY LongestTrip DESC, a.Id;-- NE BACHKA

-- 06 Метрополис
SELECT c.id AS Id, c.name AS City,c.country_code AS Country,
	COUNT(a.id) AS Accounts
FROM cities AS c
JOIN accounts AS a ON c.id = a.city_id
GROUP BY c.id
ORDER BY Accounts DESC ,c.id ASC 
LIMIT 5;

-- 07 Романтични обиколки
SELECT a.id AS Id,a.email AS  Email,
	c.name City,COUNT(ac.trip_id) AS Trips
FROM accounts AS a 
JOIN accounts_trips AS ac ON a.id = ac.account_id
JOIN trips AS t ON ac.trip_id=t.id
JOIN rooms AS r ON t.room_id = r.id
JOIN hotels AS h ON r.hotel_id = h.id
JOIN cities AS c ON h.city_id = c.id
WHERE h.city_id = a.city_id
GROUP BY a.id
ORDER BY Trips DESC ,c.id ASC;








