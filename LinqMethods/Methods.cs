using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqMethods
{
    class Methods
    {
        //Array
        public void Arrays1()
        {
            int[] numbers = { 1, 2, 3, 2, 4, 5, 6, 6, 7, 8, 9, 10 };
            
            //Query Syntax
            var even = (from i in numbers
                       where i % 2 == 0
                       orderby i descending
                       select i).Distinct();
            Console.WriteLine("Even numbers:");
            foreach ( var i in even )
            {
                Console.WriteLine( i + " " );
            }
            
            //Method syntax:
            var odd = numbers.Where(i => i % 2 != 0)
                             .OrderByDescending(i => i)
                             .Select(i => i)
                             .Distinct();
            Console.WriteLine("Odd numbers:");
            foreach (var i in odd)
            {
                Console.WriteLine(i + " ");
            }
        }
        public void Arrays()
        {
            int[] numbers = { 36, 71, 12, 15, 12, 29, 18, 27, 18,17, 9, 34 };
            int[] numbers1 = { 1, 2, 3, 2, 4, 5, 6, 6, 7, 8, 9, 10 };
            Console.Write("Array:");
            foreach ( var i in numbers )
            {
                Console.Write( i + " " );
            }
            //Select
            var square = numbers.Select(x => x * x);
            Console.Write("\nSelectS:");
            foreach (var i in square)
            {
                Console.Write(i + " ");
            }
            //Where
            var even = numbers.Where(x => x % 2 == 0);
            Console.Write("\nWhereE:");
            foreach (var i in even)
            {
                Console.Write(i + " ");
            }
            //Distinct
            var distinct = numbers.Distinct();
            Console.Write("\nDistinct:");
            foreach (var i in distinct)
            {
                Console.Write(i + " ");
            }
            //OrderBy
            var order = numbers.OrderBy(x => x);
            Console.Write("\nOrder:");
            foreach (var i in order)
            {
                Console.Write(i + " ");
            }
            //Reverse
            var rev = numbers.Reverse();
            Console.Write("\nReverse:");
            foreach (var i in rev)
            {
                Console.Write(i + " ");
            }
            //Concat(C-duplicate)
            var concat = numbers.Concat(numbers1);
            Console.Write("\nConcat:");
            foreach (var i in concat)
            {
                Console.Write(i + " ");
            }
            //Union(C-distinct)
            var union = numbers.Union(numbers1);
            Console.Write("\nUnion:");
            foreach (var i in union)
            {
                Console.Write(i + " ");
            }
            //Except(1-d)
            var except = numbers.Except(numbers1);
            Console.Write("\nExcept:");
            foreach (var i in except)
            {
                Console.Write(i + " ");
            }
            //Intersect
            var intersect = numbers.Intersect(numbers1);
            Console.Write("\nIntersect:");
            foreach (var i in intersect)
            {
                Console.Write(i + " ");
            }
            //Skip
            var skip = numbers.Skip(3);
            Console.Write("\nSkip:");
            foreach (var i in skip)
            {
                Console.Write(i + " ");
            }
            //Take
            var take = numbers.Take(3);
            Console.Write("\nTake:");
            foreach (var i in take)
            {
                Console.Write(i + " ");
            }
            //Average
            var avg = numbers.Average();
            Console.Write("\nAverage:" + avg);
            //Max
            var max = numbers.Max();
            Console.Write("\nMax:" + max);
            //Min
            var min = numbers.Min();
            Console.Write("\nMin:" + min);
            //Sum
            var sum = numbers.Sum();
            Console.Write("\nSum:" + sum);
            //Count
            var count = numbers.Count();
            Console.Write("\nCount:" + count);
            //Contains
            var contains = numbers.Contains(30);
            Console.Write("\nContains:"+contains);
            //First-Last
            var first = numbers.First();
            Console.Write("\nFirst:" + first);
            //Any
            var any = numbers.Any(x => x < 0);
            Console.Write("\nAny:" + any);
            //All
            var all = numbers.All(x => x > 0);
            Console.Write("\nAll:" + all);
            //Range
            var range = Enumerable.Range(1, 10)
                                  .Where(x=>x%2==0);
            Console.Write("\nRange:");
            foreach (var i in range)
            {
                Console.Write(i + " ");
            }
        }
    }
}
