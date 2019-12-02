using System;
using System.Data;

namespace AdventOfCode2019
{
    // Task day 1
    // https://adventofcode.com/2019/day/2
    public class Task2
    {
        public void Run()
        {
            #region Program
            int[] program =
            {
                1, 0, 0, 3, 1, 1, 2, 3, 1, 3, 4, 3, 1, 5, 0, 3, 2, 13, 1, 19, 1, 19, 9, 23, 1, 5, 23, 27, 1, 27, 9, 31,
                1, 6, 31, 35, 2, 35, 9, 39, 1, 39, 6, 43, 2, 9, 43, 47, 1, 47, 6, 51, 2, 51, 9, 55, 1, 5, 55, 59, 2, 59,
                6, 63, 1, 9, 63, 67, 1, 67, 10, 71, 1, 71, 13, 75, 2, 13, 75, 79, 1, 6, 79, 83, 2, 9, 83, 87, 1, 87, 6,
                91, 2, 10, 91, 95, 2, 13, 95, 99, 1, 9, 99, 103, 1, 5, 103, 107, 2, 9, 107, 111, 1, 111, 5, 115, 1, 115,
                5, 119, 1, 10, 119, 123, 1, 13, 123, 127, 1, 2, 127, 131, 1, 131, 13, 0, 99, 2, 14, 0, 0
            };
            #endregion

            int counter = -1;
            bool endProgram = false;
            
            //before running the program, replace position 1 with the value 12 and replace position 2 with the value 2. What value is left at position 0 after the program halts?


            int value = RunProgram(program, 12, 2);

            Console.WriteLine($"First part - End with {value}");
           
           // With terminology out of the way, we're ready to proceed. To complete the gravity assist, you need to determine what pair of inputs produces the output 19690720
           int findValue = 19690720;

           
           int resultNoun = -1;
           int resultVerb = -1;
           
           for (int i = 0;i < 99; i++)
           {
               for (int j = 0; j < 99; j++)
               {
                   int result = RunProgram(program, i, j);
                   
                   if (result == findValue)
                   {
                       resultNoun = i;
                       resultVerb = j;
                       break;
                   }
               }
           }

           Console.WriteLine($"Second part  - find pair is {resultNoun}x100+{resultVerb} =  {resultNoun*100+resultVerb}");

        }

        public int RunProgram(int[] startProgram, int noun, int verb)
        {
            int counter = -1;
            bool endProgram = false;
            
            int[] program= InitializeProgram(startProgram, noun, verb);
            while (!endProgram)
            {
                counter++;

                int value = program[counter];
                switch (value)
                {
                    case 1:
                    {
                        program = Add(counter, program);
                        counter = counter + 3;
                        break;
                    }
                    case 2:
                    {
                        program = Multiply(counter, program);
                        counter = counter + 3;
                        break;
                    }
                    case 99:
                    {
                        endProgram = true;
                        break;
                    }
                }
            }

            return program[0];

        }


        public int[] InitializeProgram(int[] program, int noun, int verb)
        {
            int[] programClone = (int[]) program.Clone();
            programClone[1] = noun;
            programClone[2] = verb;
            return programClone;
        }

        public int[] Add(int counter, int[] program)
        {
            int x = program[program[counter + 1]];
            int y = program[program[counter + 2]];
            program[program[counter + 3]] = x + y;
            return program;
        }
        
        public int[] Multiply(int counter, int[] program)
        {
            int x = program[program[counter + 1]];
            int y = program[program[counter + 2]];
            program[program[counter + 3]] = x * y;
            return program;
        }

     



    }
}