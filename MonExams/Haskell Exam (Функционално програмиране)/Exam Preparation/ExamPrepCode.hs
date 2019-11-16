import System.Exit (exitSuccess)

main = do
    doWork

doWork = do
    x <- getLine 
    
    if (length x) > 1
        then chekIfEnd x
    else do let nuim = read x :: Integer
            putStrLn(printNum nuim)
            doWork         

chekIfEnd input = 
    if input == "End"          
        then exitSuccess
    else do putStrLn("Please only enter single digit positive numbers")
            doWork

printNum num = 
    case num of 
        0 ->  "Zero"
        1 ->  "One"
        2 ->  "Two"
        3 ->  "Three"
        4 ->  "Four"
        5 ->  "Five"
        6 ->  "Six"
        7 ->  "Seven"
        8 ->  "Eight"
        9 ->  "Nine"
    
