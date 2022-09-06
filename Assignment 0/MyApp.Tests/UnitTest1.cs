using System;
using Xunit;
using System.IO;

namespace MyApp.Tests;

public class UnitTest1{
    

    [Fact]
    public void Test1(){
        var actual = "Jonas";
        var expected = Program.printName("Jonas");

        Assert.Equal(actual, expected);
    }

    [Fact]
    public void ISLEAPYEAR_GIVEN_2002_FALSE()
    {
        Assert.False(Program.isLeapYear(2002));
    }

    [Fact]
    public void ISLEAPYEAR_GIVEN_1600_TRUE()
    {
        Assert.True(Program.isLeapYear(1600));
    }

    [Fact]
    public void ISLEAPYEAR_GIVEN_1700_FALSE()
    {
        Assert.False(Program.isLeapYear(1700));
    }
    [Fact]
    public void ISLEAPYEAR_GIVEN_2004_TRUE()
    {
        Assert.True(Program.isLeapYear(2004));
    }
}