// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let lines = 
        Seq.initInfinite (fun _ -> Console.ReadLine().Split([|' '|]) |> Array.map int ) |>
        Seq.takeWhile ((<>) [|0;0|]) 
    let func (list:int []): string = 
        let x = list.[0]
        let y = list.[1]
        if x + y = 13 
        then "Never speak again." 
        else 
            if x < y 
            then "Left beehind." 
            else 
                if x > y 
                then "To the convention." 
                else "Undecided."
    Seq.iter (fun item -> printfn "%s" (func item) ) lines
    0 // return an integer exit code
