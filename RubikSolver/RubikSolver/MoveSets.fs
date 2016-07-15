namespace R1
    module MoveSets =
        open Cube
    
        type MoveSets =
            static member All = 
                [ { Label  = "F";  Transformation = F }; 
                  { Label  = "F'"; Transformation = F' }; 
                  { Label  = "F2"; Transformation = F2 }; 
                  { Label  = "U";  Transformation = U }; 
                  { Label  = "U'"; Transformation = U' }; 
                  { Label  = "U2"; Transformation = U2 }; 
                  { Label  = "R";  Transformation = R }; 
                  { Label  = "R'"; Transformation = R' }; 
                  { Label  = "R2"; Transformation = R2 }; 
                  { Label  = "L";  Transformation = L }; 
                  { Label  = "L'"; Transformation = L' }; 
                  { Label  = "L2"; Transformation = L2 }; 
                  { Label  = "D";  Transformation = D }; 
                  { Label  = "D'"; Transformation = D' }; 
                  { Label  = "D2"; Transformation = D2 }; 
                  { Label  = "B";  Transformation = B }; 
                  { Label  = "B'"; Transformation = B' }; 
                  { Label  = "B2"; Transformation = B2 }; ]