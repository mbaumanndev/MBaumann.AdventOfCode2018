open System.IO

[<EntryPoint>]
let main argv =
    File.ReadAllLines("input")
    |> Array.map(fun l -> int l)
    |> Array.sum
    |> printfn "%i"
    0
