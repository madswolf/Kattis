// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let alphabet = ['a'..'z']
    let x = Console.ReadLine().Split([|' '|]) |> Array.map int
    let keyLength = x.[0]
    let ciphertextLength = x.[1]
    let last = Console.ReadLine()
    let ciphertext = Console.ReadLine()
    let lastOfPlaintext = ciphertext.[ciphertext.Length-(keyLength)..]
    printfn "%s" lastOfPlaintext
    let func = fun acc item -> acc + (string (alphabet.[( int lastOfPlaintext.[item] - int last.[item])%26]))
    let bong =List.fold (func) "" [0..keyLength-1]

    
    printfn"%s" bong
    0 // return an integer exit code
