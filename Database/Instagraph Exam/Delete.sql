DELETE users FROM users
LEFT JOIN users_followers AS uf ON users.id = uf.user_id
WHERE uf.user_id IS NULL 
