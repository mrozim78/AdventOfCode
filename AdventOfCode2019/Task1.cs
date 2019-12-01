using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2019
{
    // Task day 1
    // https://adventofcode.com/2019/day/1
    public class Task1
    {
        static void Main(string[] args)
        {
            #region Input data
            int[] input =
            {
                144968,
                146267,
                93774,
                66835,
                139920,
                65875,
                131321,
                108023,
                115369,
                94673,
                117989,
                127700,
                65335,
                81728,
                57601,
                140987,
                54606,
                91215,
                143883,
                131858,
                91864,
                149716,
                103598,
                118128,
                100712,
                108947,
                146637,
                80490,
                120895,
                52862,
                54410,
                99435,
                85306,
                58179,
                88679,
                71725,
                144885,
                145211,
                129650,
                146724,
                108649,
                95874,
                98155,
                118901,
                142581,
                133366,
                95823,
                87308,
                124940,
                145709,
                118384,
                85552,
                90275,
                136930,
                90085,
                50895,
                146422,
                125462,
                106267,
                131561,
                112356,
                101503,
                101531,
                84320,
                76950,
                51906,
                122922,
                136102,
                104329,
                63004,
                141827,
                134044,
                128319,
                95080,
                90765,
                87322,
                61905,
                65293,
                138240,
                74660,
                55963,
                83560,
                87871,
                106145,
                140945,
                114416,
                99056,
                53210,
                74577,
                120291,
                112627,
                102146,
                54700,
                112290,
                133848,
                113707,
                78735,
                54557,
                79540,
                143154
            };
            #endregion
            
            int[] requiredFuelArrayOne = input.Select(a => (int) (a / 3) - 2).ToArray();
            List<int> requiredFuelArray = new List<int>();
            
            foreach (int requiredFuel in requiredFuelArrayOne)
            {
                int actual = requiredFuel;
                while (actual > 0)
                {
                    requiredFuelArray.Add(actual);
                    actual = (actual / 3) - 2;
                }
            }
            
            Console.WriteLine($"Sum is {requiredFuelArrayOne.Sum()}");
            Console.WriteLine($"Sum all {requiredFuelArray.Sum()}");
        }
    }
}