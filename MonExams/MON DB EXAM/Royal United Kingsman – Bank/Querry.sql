-- 05.     Клиенти
SELECT id,full_name
FROM clients
ORDER BY 1;

-- 06.     Начинаещи
SELECT id,CONCAT(e.first_name," ",e.last_name) 
	AS full_name, CONCAT("$",e.salary) AS salary,started_on
FROM employees AS e
WHERE e.salary>= 100000 AND e.started_on >= "2018-01-01"
ORDER BY 3 DESC;

-- 07.     Карти срещу човечеството
SELECT c.id,CONCAT(c.card_number," : ",cl.full_name) 
	AS card_token
FROM cards AS c
JOIN bank_accounts AS bc ON c.bank_account_id=bc.id
JOIN clients AS cl  ON cl.id = bc.client_id
ORDER BY 1 DESC;

-- 08.     Забранени профили -- NE BACHKA
SELECT ba.account_number,CONCAT("$",ba.balance) AS name,-- NE BACHKA
	cl.full_name-- NE BACHKA
FROM clients AS cl-- NE BACHKA
JOIN bank_accounts AS ba ON ba.client_id=cl.id-- NE BACHKA
JOIN cards AS c ON ba.id = c.bank_account_id-- NE BACHKA
WHERE c.card_status = "Frozen" OR  "Deleted"-- NE BACHKA
ORDER BY ba.id DESC;-- NE BACHKA

-- 09.     Топ 5 Служители
SELECT CONCAT(e.first_name," ",e.last_name) AS name,
	 e.started_on,COUNT(ec.client_id) AS count_of_clients
FROM employees AS e
JOIN employees_clients AS ec ON e.id = ec.employee_id
GROUP BY e.id 
ORDER BY count_of_clients DESC,e.id LIMIT 5;

-- 10.     Семеен човек
SELECT cl.id,cl.full_name,COUNT(c.bank_account_id) AS cards
FROM clients AS cl
JOIN bank_accounts AS ba ON cl.id =ba.client_id
JOIN cards AS c ON ba.id = c.bank_account_id
GROUP BY ba.id
ORDER BY cards DESC ,1 ASC LIMIT 1;

-- 11.     Отдели на клиенти
SELECT b.name AS id,COUNT(ec.client_id) AS clients
FROM branches AS b 
JOIN employees AS e ON b.id = e.branch_id
JOIN employees_clients AS ec ON e.id =ec.employee_id
GROUP BY b.id
ORDER BY clients DESC ,b.id














