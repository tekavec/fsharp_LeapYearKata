namespace Tests

module YearShould =
    open NUnit.Framework
    open DateFunctions

    [<TestCase(1999, false)>]
    [<TestCase(2004, true)>]
    [<TestCase(2000, true)>]
    [<TestCase(1900, false)>]
    let be_a_leap_year_if_divisible_by_correct_number (year: int, expectedResult: bool) =
        Assert.AreEqual(isLeapYear(year), expectedResult)
