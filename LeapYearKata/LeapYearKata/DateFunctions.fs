module DateFunctions

    let isLeapYear value =
        (value % 4 = 0 && value % 100 <> 0) || (value % 400 = 0)
