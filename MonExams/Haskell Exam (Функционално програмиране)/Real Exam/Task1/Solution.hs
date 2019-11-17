main = do
  x <- getLine
  let num = read x :: Int
  putStrLn(show(doWord num 0))

doWord newNum endSum =
  if newNum < 1
    then endSum
  else doWord (div newNum 10) (endSum + (mod newNum 10))