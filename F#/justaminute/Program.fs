// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let n = Console.ReadLine() |> int
    let func (x:int list) (y:int*int) : int*int=
        ((x.[0] + fst y),(x.[1] + snd y)) 
    let sum = 
        List.init n (fun _ -> Console.ReadLine().Split([|' '|]) |> Array.map int |> List.ofArray) |>
        List.fold (fun acc item-> func item acc) (0,0)
    let average = double (snd sum) / double (fst sum * 60)
    if (average > 1.0) then printfn "%.20f" average else printfn "%s" "measurement error"
    0 // return an integer exit code
