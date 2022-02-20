using System;
using System.Collections.Generic;
using Xunit;

namespace Suicid_Xarakiri
{
    public class Test
    {
        [Theory]


        [InlineData(3, 1, 2, 3)]
        [InlineData(3, 6, 1, 5)]
        [InlineData(6, 2, 4, 6)]
        [InlineData(15, 5, 2, 11)]
        [InlineData(100, 50, 150, 150)]
        [InlineData(7, 13, 10, 15)]
        [InlineData(8, 12, 20, 20)]
        [InlineData(9, 5, 16, 15)]
        [InlineData(44, 6, 74, 62)]
        [InlineData(14, 15, 1, 15)]
        [InlineData(45, 55, 100, 100)]
        [InlineData(40, 50, 70, 80)]
        [InlineData(9, 2, 17, 14)]
        [InlineData(12, 8, 60, 40)]
        [InlineData(47, 95, 40, 91)]
        [InlineData(3, 6, 3, 6)]
        [InlineData(2, 9, 1, 6)]
        [InlineData(2, 5, 9, 8)]
        [InlineData(6, 2, 6, 7)]
        [InlineData(100, 100, 100, 150)]

    
        public void Test1(int a, int b, int c, int expected)
        {
            Console.WriteLine("2");
            int actual = EmptyClass.Testing(a, b, c);
            Assert.Equal(expected, actual);
        }
    }
    

}
