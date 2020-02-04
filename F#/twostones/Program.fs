// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let x = Console.ReadLine() |> int
    if x%2 = 1 then printf "Alice"
    else printf "Bob"
    0 // return an integer exit code


