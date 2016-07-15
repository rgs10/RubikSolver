namespace R1
open Cube

module Search = 
    let BasicTreeSearch scrambledState maxDepth (movesAllowed: CubeTransformation list) =

        let solutions = ref []

        let rec BasicTreeSearch_Internal cubeState d (movesSoFar : string list) =
            if cubeState = solvedCube then 
               solutions:= (movesSoFar |> String.concat " " ) :: !solutions 

            elif d > 0 then
                movesAllowed 
                |> List.iter
                    (fun move -> 
                        BasicTreeSearch_Internal (cubeState |> Execute move.Transformation) (d-1) (move.Label :: movesSoFar) 
                    ) 

        BasicTreeSearch_Internal scrambledState maxDepth []
        solutions.Value

