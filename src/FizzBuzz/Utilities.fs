module Utilities

open System.Runtime.CompilerServices

[<Extension>]
type IntExtensions =
    [<Extension>]
    static member inline DivisibleBy(num: int, div: int) = num % div = 0