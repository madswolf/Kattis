// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let candlesFordays = fun x -> ((x * (x+1))/2 + x)
    let thing = Console.ReadLine()
    let x, y =
        (fun _ -> Console.ReadLine()) |>
        Seq.initInfinite |>
        Seq.takeWhile ((<>) null)|>
        Seq.map 
            (fun (s:string) ->
            let arr = s.Split([|' '|])
            let a = int arr.[0]
            let b = int arr.[1]
            let candles = candlesFordays b
            (a,candles)
        ) |>
        Seq.toList |>
        List.unzip

    for testnumber, result in Seq.zip x y do
        printfn "%i %i" testnumber result
    0 // return an integer exit code
