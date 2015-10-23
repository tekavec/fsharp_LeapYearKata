module LeapYearTests

open NUnit.Framework
open LeapYear 

[<TestCase(1997, false)>]
[<TestCase(1996, true)>]
[<TestCase(1600 , true)>]
[<TestCase(1800 , false)>]
let TestLeapYear caseValue expIsLeapYear = 
    let year = new Year(caseValue)
    let isLeapYear = year.IsLeapYear()
    Assert.AreEqual(expIsLeapYear, isLeapYear)