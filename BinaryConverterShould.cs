using System;
using System.Collections.Generic;
using Xunit;
using static BinaryConverter_Kata.BinaryConverter;

namespace BinaryConverter_Kata
{
    public class BinaryConverterShould
    {
        [Theory]
        [InlineData("0", 0)]
        [InlineData("1", 1)]
        [InlineData("10", 2)]
        [InlineData("100", 4)]
        [InlineData("1011101011100", 5980)]
        public void Convert_Binary_For_Given_Decimal(string binary, int number)
        {
            Assert.Equal(binary, BinaryFor(number));
        }

        [Theory]
        [InlineData(0, "0")]
        [InlineData(1, "1")]
        [InlineData(2, "10")]
        [InlineData(4, "100")]
        [InlineData(5980, "1011101011100")]
        public void Convert_Decimal_For_Given_Binary(int number, string binary)
        {
            Assert.Equal(number, DecimalFor(binary));
        }
    }
}