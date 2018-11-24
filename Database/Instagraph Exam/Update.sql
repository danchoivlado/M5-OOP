UPDATE users 
JOIN users_followers AS uf ON users.id=user_id
SET profile_picture_id =(
	CASE 
		WHEN (SELECT COUNT(uf.follower_id)
            GROUP BY follower_id) = 0 THEN users.id
        ELSE (SELECT COUNT(uf.follower_id)
            GROUP BY follower_id)  
        END
)
WHERE users.profile_picture_id IS NULL;


            
            
            
            
            
            
            
            