UPDATE clients AS c
SET c.age= c.age+5
WHERE c.id  %2 =0;
