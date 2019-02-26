namespace Tests

open NUnit.Framework

module YearShould =

    [<TestCase(1999, false)>]
    [<TestCase(2004, true)>]
    let not_be_a_leap_year_if_not_divisible_by_4 (year: int, expectedResult: bool) =
        Assert.AreEqual(DateFunctions.isLeapYear(year), expectedResult)
