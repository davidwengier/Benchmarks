﻿using System;
using BenchmarkDotNet.Running;
using Tests;

namespace Benchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<Collections>();
        }
    }
}