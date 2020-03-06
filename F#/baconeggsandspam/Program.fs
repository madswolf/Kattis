
open System

[<EntryPoint>]
let main argv =
    let funny x = 
        let n = Console.ReadLine() |> int
        if n = 0 then Map.add "" [""] Map.empty
        else
            let cases = List.init n (fun _ -> Console.ReadLine().Split([|' '|]) |> List.ofArray)
            let func (list:string list) (map:Map<string,string list>) =
                let person::orders =  list
                List.fold (
                    fun (acc:Map<string,string list>) order ->
                        let listOfPeopleWithOrder = if(acc.ContainsKey order) then person::acc.[order] else [person]
                        Map.add order listOfPeopleWithOrder acc
                ) map orders
            List.fold (fun acc item -> func item acc) Map.empty cases
    let allcases = 
        Seq.initInfinite (fun x -> funny x)|>
        Seq.takeWhile((<>) (Map.add "" [""] Map.empty))
    Seq.iter ( fun map -> Map.iter (fun key value -> printfn "%s %s" key (value |> List.sort|> String.concat " ")) map) allcases
    0 // return an integer exit code