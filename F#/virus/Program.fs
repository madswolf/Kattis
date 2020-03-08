// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    
    let original = Console.ReadLine().ToCharArray()  |> List.ofArray
    let replication = Console.ReadLine().ToCharArray() |> List.ofArray
    
    let rec removeCommonality c = 
        let original, replication = c
        if List.isEmpty original || List.isEmpty replication
        then (original,replication)
        else 
            if List.head original = List.head replication
            then removeCommonality ((List.tail original), (List.tail replication))
            else (original,replication)

    let removedCommonalityFront = removeCommonality (original, replication)
    
    let removedCommonalityFrontAndBack = removeCommonality ((fst removedCommonalityFront |> List.rev), (snd removedCommonalityFront |> List.rev)) 

    printfn "%A" (snd removedCommonalityFrontAndBack).Length
    0 // return an integer exit code