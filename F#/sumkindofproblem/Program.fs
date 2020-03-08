// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let cases = Console.ReadLine() |> int64
    let even (n:int64) = 
        let rec evenA (acc:int64) (innerN:int64) :int64 = 
            match innerN with
            |n when n = 0L -> acc
            |n -> evenA (acc + 2L) (n-1L)
        evenA 0L n
    
    let odd (n:int64) = 
        let rec oddA (acc:int64) (innerN:int64) :int64 = 
            match innerN with
            |n when n = 0L -> acc
            |n -> oddA (acc + 2L) (n-1L)
        oddA 1L n
 
    let getN (func: int64 -> int64) (n:int64)=
        List.fold (fun acc item -> (func item) + acc) 0L [0L..n-1L]

    let func (string:string) = 
        let casenumber::n::xs = string.Split ' ' |> Array.map int64 |> List.ofArray
        printfn "%A %A %A %A" casenumber (getN id n) (getN odd n) (getN even n)
    List.iter (fun _ -> Console.ReadLine() |>  func ) [1..int cases]
    
    0 // return an integer exit code
