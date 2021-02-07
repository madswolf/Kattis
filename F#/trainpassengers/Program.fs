// Learn more about F# at http://fsharp.org

open System

type multimap<'a,'b when 'a: comparison> =MMap of Map<'a,list<'b>>

let canonical (m : multimap<'a,'b>) : multimap<'a,'b> when 'a: comparison and 'b: comparison = 
  let getValueMmap (MMap m) = m
  let map = getValueMmap m
  Map.map(fun key value -> List.sort value) map |>
  MMap


[<EntryPoint>]
let main argv =
    let limit::stops::xs = Console.ReadLine().Split ' ' |> Array.map int64 |> List.ofArray 

    let func (string:string) acc stop =
        let (currentPassengerCount, status) = acc
        if status 
        then
            let off::on::left::xs = string.Split ' ' |> Array.map int64 |> List.ofArray
            let supposedPassengercount = currentPassengerCount + on - off
            if(
                currentPassengerCount < off 
                || supposedPassengercount < 0L 
                || supposedPassengercount > limit 
                || (supposedPassengercount < limit && left > 0L) 
                || (stop = stops && (left <> 0L || supposedPassengercount <> 0L))
            )
            then (supposedPassengercount,false)
            else (supposedPassengercount,status)
        else acc

    let result = List.fold (fun acc item -> func (Console.ReadLine()) acc item) (0L,true) [1L..stops] |> snd
    printfn "%s" (if result then "possible" else "impossible")
    0 // return an integer exit code
