let mutable x = 10
let mutable y = 20

let add x y = x + y

let z = add x y
printf "%d\n" z

x <- 100
y <- 200

printf "%d\n" (add x y)