module LeapYear

type Year(year) = 
    member x.Value = year
    member x.IsLeapYear () = 
        (x.Value % 4 = 0) && (x.Value % 100 <> 0 || x.Value % 400 = 0) 