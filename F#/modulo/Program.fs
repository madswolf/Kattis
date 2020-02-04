// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let readNlines n = List.init n ( fun _ -> (Console.ReadLine() |> int)%42)
    let arr = readNlines 10


    let x = (arr |> Seq.distinct |> List.ofSeq).Length
    printfn "%i" x
    0 // return an integer exit code
