module DateFunctions
    let private (%%) a b = a % b = 0
    let isLeapYear value = value %% 4 && not(value %% 100) || value %% 400