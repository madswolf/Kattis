// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let n::m::k::xs = Console.ReadLine().Split([|' '|]) |> List.ofArray |> List.map int

    let func (line:string) : int64=
        let empty::name::count::ys = line.Split([|'"'|]) |> List.ofArray
        if name > "Jane Eyre" then 0L else (int64 count)

    let roundone = List.init n (fun _ -> func (Console.ReadLine())) |> List.sum

    let breakdown (line:string) =
        let time::name::count::ys = line.Split([|'"'|]) |> List.ofArray
        ((int64 time),name,(int64 count))

    let func item (currenttime:int64) : int64 = 
        let (time,name,count) = item
        if time <= currenttime
        then 
            if name > "Jane Eyre" then 0L else count
        else 0L

    let roundtwo = 
        (
            List.init m (fun _ -> Console.ReadLine()) |> 
            List.map breakdown |>
            List.sortBy (fun (x,_,_) -> x) |> 
            List.fold (fun acc item -> acc + (func item acc)) roundone
        ) + int64 k
    printfn "%i" roundtwo
    0 // return an integer exit code
