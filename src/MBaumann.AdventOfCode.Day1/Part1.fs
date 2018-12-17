namespace MBaumann.AdventOfCode.Day1

module Part1 =
    let Compute (input: string[]) =
        (Array.sumBy (int) (input))
