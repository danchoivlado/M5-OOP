-- 05.	Users
SELECT id,username
FROM users
ORDER BY 1 ASC;

-- 06.	Cheaters
SELECT id,username
FROM users
JOIN users_followers AS uf ON users.id = uf.user_id
WHERE uf.user_id=uf.follower_id
ORDER BY 1 ASC;

-- 07.	High Quality Pictures

SELECT p.id,p.path,p.size
FROM pictures AS p
WHERE p.size > 50000 AND(
SUBSTRING(p.path,-4,4) = "jpeg" OR
SUBSTRING(p.path,-3,3) = "png")
ORDER BY p.size DESC;

-- 08.	Comments and Users
SELECT c.id AS id, 	CONCAT(u.username," : ",c.content) AS full_comment
FROM users AS u
JOIN comments AS c ON c.user_id = u.id
ORDER BY 1 DESC;

-- 09.	Profile Pictures
SELECT u.id,u.username,CONCAT(p.size,"KB") AS size
FROM users AS u 
JOIN pictures AS p ON p.id=u.profile_picture_id
WHERE u.profile_picture_id IN 
	(SELECT profile_picture_id FROM users WHERE u.id !=  id)
ORDER BY 1;

-- 10.	Spam Posts
SELECT p.id, p.caption,COUNT(c.post_id) AS comments
FROM posts AS p
JOIN comments AS c ON c.post_id=p.id
GROUP BY p.id
ORDER BY comments DESC,1 ASC
LIMIT 5;

SELECT u.id,u.username,
(SELECT COUNT(user_id) FROM posts
WHERE p.id = u.id
GROUP BY user_id
)
AS posts

,COUNT(uf.follower_id) AS followers
FROM users AS u
JOIN posts AS p ON p.user_id = u.id
JOIN users_followers AS uf ON u.id = uf.follower_id
ORDER BY followers
LIMIT 1;













