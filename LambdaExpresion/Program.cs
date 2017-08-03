using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpresion
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>()
            {
                1,2,3,4,5,6,7,8,9
            };

            //Expresion
            numbers.Where(n => n > 1).ToList();
        }
    }
}
