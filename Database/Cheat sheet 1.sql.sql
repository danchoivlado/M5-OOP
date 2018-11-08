добавяне на референция(
ALTER TABLE `products`
ADD CONSTRAINT fk_town_id FOREIGN KEY(town_id)
REFERENCES town(id);
FOREIGN KEY (director_id) REFERENCES directors(id)
created TIMESTAMP DEFAULT CURRENT_TIMESTAMP
)

добавяне на колона(
ALTER TABLE `products` 
ADD COLUMN town_id INT NOT NULL ;
SELECT * FROM  products;
)

създавяне на таблица(
CREATE TABLE Products(
	id int not null AUTO_INCREMENT,
    `name` varchar(50) not null ,
    age int not null ,
    constraint pk_market_id primary key(id) 
);
)

изтриване на записи от дани в таблицата(
TRUNCATE TABLE products;
)

прави колоната уникална(
ALTER TABLE users ADD UNIQUE(username);
)

записи на базата (
INSERT INTO user(name)
VALUES * FROM user;
)

опресняване на запис от таблица(
UPDATE person SET name='Gosho' WHERE id = 1;

ALTER TABLE departments
	MODIFY COLUMN manager_id INT(11) NULL;
	
)

ИЗТРИВАНЕ НА ЕДИН ЗАПИС ОТ ТАБЛИЦАТА(
DELETE FROM  person WHERE name= 'Gosho';
)

ПЕЧАТАНЕ НА ТАБЛИЦАТА(
	SELECT * FROM addresses WHERE town_id =2;
	SELECT address_text FROM addresses;
)
	
ПРЕИМЕНУВАНЕ НА ТАБЛИЦАТА(
RENAME TABLE 
	addresses1 TO addresses;
)
IF STATEMENT (
SELECT country_name,country_code,
	IF(continent_code="EU","EUR","NOT EUR") AS currency
	FROM countries
	ORDER BY country_name ASC;

)

CASE(
SELECT e.employee_id,e.first_name,
CASE 
	WHEN p.start_date >= '2005-01-01' THEN NULL
    ELSE p.name
    END AS `project_name`
FROM employees AS e
INNER JOIN employees_projects AS ep
ON e.employee_id = ep.employee_id
INNER JOIN projects AS p
ON ep.project_id = p.project_id
WHERE e.employee_id = 24
ORDER BY project_name ;
)
