﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overridemethos
{
    class Program
    {
        int Power(int input)
        {
            return input * input;
        }

        int Power(int input, int count)
        {
            for (int i = 0; i < count; i++)
            {
                input *= input;
            }
            return input;
        }

        int SumAll(int end)
        {
            int sum = 0;
            for (int i = 0; i < end; i++)
            {
                sum += i;
            }
            return end;
        }

        int SumAll(int start, int end)
        {
            int sum = 0;
            for (int i = start; i < end; i++)
            {
                sum += start;
            }
            return sum;
        }
        static void Main(string[] args)
        {
        }
    }
}
