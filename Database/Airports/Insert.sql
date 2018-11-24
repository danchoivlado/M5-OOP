INSERT INTO flights (departure_time,arrival_time,
	status,origin_airport_id,destination_airport_id,airline_id)
SELECT
("2017-06-19 14:00:00") AS departure_time ,
("2017-06-21 11:00:00") AS arrival_time ,
(
CASE
	WHEN (airline_id%4) = 0 THEN "Departing"
    WHEN (airline_id%4) = 1 THEN "Delayed"
    WHEN (airline_id%4) = 2 THEN "Arrived"
    ELSE "Canceled"
    END
    ) AS status,
CEIL(SQRT(LENGTH(a.airline_name))) AS origin_airport_id,
CEIL(SQRT(LENGTH(a.nationality))) AS destination_airport_id,
a.airline_id AS airline_id
FROM airlines AS a
WHERE a.airline_id BETWEEN 1 AND 10


