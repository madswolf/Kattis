// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let radius = Console.ReadLine() |> int
    //found an explianation of taxicab geometry 
    //https://www.quora.com/How-do-I-calculate-the-area-of-a-circle-using-Taxicab-Geometry
    printfn "%.6f" (Math.PI * float radius * float radius)
    printfn "%.6f" (2.0 * float radius * float radius)
    0 // return an integer exit code
