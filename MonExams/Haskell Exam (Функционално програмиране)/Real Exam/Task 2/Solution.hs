main = do
    x <- getLine
    y <- getLine
    let num = read y :: Int
    let lis = read x :: Int
    putStrLn(show(doRotations num (createLis lis []) 0))

doRotations numRotations inputlis  counter =
    if numRotations == counter
        then inputlis
    else doRotations numRotations (innverse inputlis)  (counter + 1)

innverse inputLis =  
    ((tail inputLis) ++ [(head inputLis)])

createLis newNum endLis =
    if newNum < 1
        then endLis
    else createLis (div newNum 10) ( (mod newNum 10) : endLis)
    