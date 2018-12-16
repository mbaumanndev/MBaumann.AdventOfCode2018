open System.IO

[<EntryPoint>]
let main argv =
    (Array.sumBy (int) (File.ReadAllLines("input")))
    |> printfn "%i"
    0
