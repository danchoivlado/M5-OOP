-- Extract all travel cards 
SELECT card_number, job_during_journey FROM travel_cards
ORDER BY 1;
/*Extract from the database, all travel cards. Sort the results by card number ascending.*/

-- Extract all colonists 
SELECT id,CONCAT_ws(" ",first_name,last_name) AS full_name, ucn
FROM colonists
ORDER BY first_name,last_name,1;
/*Extract from the database, all colonists. Sort the results by first name, 
	them by last name, and finally by id in ascending order.*/
/*
	id	full_name	ucn
	35	Aigneis McConville	9225403496
	92	Althea Kelinge	9998159318
*/
--	Extract all military journeys 
SELECT id, journey_start, journey_end 
FROM journeys
WHERE purpose = "Military"
ORDER BY journey_start;
/*Extract from the database, all Military journeys. 		
	Sort the results ascending by journey start.*/
/*
		id	journey_start	journey_end
		7	2019-01-04 23:44:40	2049-12-09 04:00:54
		3	2019-02-21 22:06:34	2049-01-03 11:00:22

*/

--	07. Extract all pilots 	
SELECT c.id, CONCAT_ws(" ",c.first_name,c.last_name) AS full_name  
FROM colonists AS c
JOIN travel_cards AS tc ON c.id = tc.colonist_id
WHERE tc.job_during_journey = "Pilot"
ORDER BY id;
--Extract from the database all colonists, which have a pilot job. Sort the result by id, ascending.
/*
	id	full_name
	6	Clark Cowan
	18	Wald Bim
*/

-- 08.	Count all colonists that are on technical journey
SELECT COUNT(*) AS `count`
FROM colonists AS c
JOIN travel_cards AS tc ON c.id = tc.colonist_id
WHERE tc.job_during_journey = "Engineer";
--Count all colonists, that are on technical journey. 
/*
	count
	16
*/

-- 09.Extract the fastest spaceship 
SELECT s.name AS spaceship_name  , s2.name AS spaceport_name
FROM spaceships AS s
JOIN journeys AS j ON s.id = j.spaceship_id
JOIN spaceports AS s2 ON j.destination_spaceport_id = s2.id
ORDER BY light_speed_rate DESC LIMIT 1;
--Extract from the database the fastest spaceship and its destination spaceport name. 
--In other words, the ship with the highest light speed rate.
/*
	spaceship_name	spaceport_name
	SSE Priestess	Yggdrasil Station
*/

--10.Extract spaceships with pilots younger than 30 years
SELECT DISTINCT s.name AS `name`,  s.manufacturer AS manufacturer  
FROM colonists AS c
JOIN travel_cards AS tc ON c.id = tc.colonist_id
JOIN journeys AS j ON tc.journey_id = j.id
JOIN spaceships AS s ON  j.spaceship_id = s.id
WHERE tc.job_during_journey = "Pilot"
AND c.birth_date >= " 01.01.1989"
ORDER BY s.name;
--Extract from the database those spaceships, which have pilots, younger than 30 years old.
-- In other words, 30 years from 01/01/2019. Sort the results alphabetically by spaceship name.
/*
	name	manufacturer
	Anarchy	Fivebridge
*/

--11. Extract all educational mission planets and spaceports
SELECT p.name AS  planet_name, s.name AS  spaceport_name
FROM planets AS p 
JOIN spaceports AS s ON  p.id = s.planet_id
JOIN journeys AS j ON s.id = j.destination_spaceport_id
WHERE purpose = "Educational"
ORDER BY 2 DESC;
--Extract from the database names of all planets and their spaceports, which have educational missions.
-- Sort the results by spaceport name in descending order.
/*
	planet_name	spaceport_name
	Kascarth	Yggdrasil Station
	Lescore	Tartarus
*/

--Extract all planets and their journey count
SELECT p.name AS  planet_name,COUNT(p.name) AS `journeys_count `
FROM planets AS p
JOIN spaceports AS s ON p.id = s.planet_id
JOIN journeys AS j ON s.id = j.destination_spaceport_id
GROUP BY p.name 
ORDER BY 2 DESC ,1;	
--Extract from the database all planets’ names and their journeys count. 
--Order the results by journeys count, descending and by planet name ascending.
/*
planet_name	journeys_count
Otroyphus	4
Eipra	2
*/



--13.Extract the shortest journey
SELECT j.id AS id, p.name AS  planet_name,s.name AS spaceport_name,
	j.purpose AS journey_purpose 
FROM journeys j
JOIN spaceports s on j.destination_spaceport_id = s.id
JOIN planets p on s.planet_id = p.id
WHERE DATE(j.journey_end) - DATE(j.journey_start) = (
	SELECT   DATE(journey_end) - DATE(journey_start)  AS d
	FROM journeys
	ORDER BY 1 ASC
	LIMIT 1
);
--Extract from the database the shortest journey, its destination spaceport name, planet name and purpose.
/*
	id	planet_name	spaceport_name	journey_purpose
	3	Casmadus	Minerva Station	Military

*/

--14.Extract the less popular job
SELECT tc.job_during_journey AS job_name   
FROM colonists AS c
JOIN travel_cards AS tc ON c.id = tc.colonist_id
JOIN journeys AS j ON tc.journey_id = j.id
WHERE j.id  = (
	SELECT id  FROM journeys
    ORDER BY DATEDIFF(journey_end,journey_start) DESC
    LIMIT 1
)
GROUP BY tc.job_during_journey
ORDER BY  COUNT(tc.job_during_journey)
LIMIT 1;
--Extract from the database the less popular job in the longest journey.
-- In other words, the job with less assign colonists.
/*
	job_name
	Engineer

*/


--Get colonists count
DELIMITER $$
CREATE FUNCTION udf_count_colonists_by_destination_planet(planet_name VARCHAR(30))
RETURNS INT 

BEGIN
	 DECLARE result INT;
   SET result := (
	SELECT  COUNT(p.id)
	FROM planets AS p
	JOIN spaceports AS s ON p.id = s.planet_id
	JOIN journeys AS j ON s.id = j.destination_spaceport_id
	JOIN travel_cards AS tc ON j.id = tc.journey_id
	WHERE p.name = planet_name
	GROUP BY p.id
   );
    RETURN result;
    
END
$$

SELECT p.name, udf_count_colonists_by_destination_planet("Otroyphus") AS count
FROM planets AS p
WHERE p.name = "Otroyphus";
--Create a user defined function with the name udf_count_colonists_by_destination_planet (planet_name VARCHAR (30))
-- that receives planet name and returns the count of all colonists sent to that planet.
/*
Query
SELECT p.name, udf_count_colonists_by_destination_planet(‘Otroyphus’) AS count
FROM planets AS p
WHERE p.name = ‘Otroyphus’;
name	count
Otroyphus	35

*/


