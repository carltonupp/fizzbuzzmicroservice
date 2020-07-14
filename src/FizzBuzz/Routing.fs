module Routing

open Saturn
open Giraffe

open Utilities

let fizzBuzz (number: int) =
    match number with
    | n when n.DivisibleBy 3 && n.DivisibleBy(5) -> "FizzBuzz"
    | n when n.DivisibleBy 3 -> "Fizz"
    | n when n.DivisibleBy 5 -> "Buzz"
    | _ -> number |> string

let index =
    seq { for i in 1 .. 100 do fizzBuzz i }
    |> fun x -> (json {| Results = x|})

let appRouter = router {
    get "/" index
    getf "/%i" (fun n -> (json {|Result = (fizzBuzz n) |}))
}