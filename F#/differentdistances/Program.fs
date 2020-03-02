// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let func (list:double list) =
        match list with
        |x1::y1::x2::y2::p::xs -> (((abs(x1 - x2)) ** p) + ((abs(y1 - y2)) ** p)) ** (1.0/p)
        |_ -> 0.0
    let cases = 
        Seq.initInfinite (
            fun _ -> 
                Console.ReadLine().Split([|' '|]) |> 
                Array.map double |> 
                List.ofArray
        ) |>
        Seq.takeWhile((<>) [0.0])|>
        Seq.map func
    Seq.iter (fun x -> printfn "%.10f" x) cases
    0 // return an integer exit code
