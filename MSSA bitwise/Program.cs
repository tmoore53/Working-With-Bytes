using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSSA_bitwise
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 7;
            Console.WriteLine(x << 1);
            Console.WriteLine(x << 3);

            int y = 7;
            Console.WriteLine(y >> 1);
            Console.WriteLine(y >> 3);

            Console.WriteLine(int.MaxValue);
            int yyy = 2147483647;
            Console.WriteLine(yyy+2);

            int num = 0x73FA;
            Console.WriteLine(num);

            int num2 = 2020;
            Console.WriteLine(Convert.ToString(num2, 2));

            int num3 = num2*2;
            Console.WriteLine(Convert.ToString(num3, 2));



            //////////////////////////////
            int n1 = 0b00000000_00000000_00100000_11001011;
            int n2 = 0b00000000_10010010_00100100_10001001;
            Console.WriteLine();
            Console.WriteLine("bitwise AND");
            Console.WriteLine(Convert.ToString(n1 , 2).PadLeft(32, '0'));
            Console.WriteLine(Convert.ToString(n2, 2).PadLeft(32, '0'));
            Console.WriteLine(Convert.ToString(n1 & n2, 2).PadLeft(32, '0'));

            Console.WriteLine();
            Console.WriteLine("bitwise OR");
            Console.WriteLine(Convert.ToString(n1, 2).PadLeft(32, '0'));
            Console.WriteLine(Convert.ToString(n2, 2).PadLeft(32, '0'));
            Console.WriteLine(Convert.ToString(n1 | n2, 2).PadLeft(32, '0'));

            Console.WriteLine(  );
            Console.WriteLine("bitwise XOR - exclusive or");
            Console.WriteLine(Convert.ToString(n1, 2).PadLeft(32, '0'));
            Console.WriteLine(Convert.ToString(n2, 2).PadLeft(32, '0'));
            Console.WriteLine(Convert.ToString(n1 ^ n2, 2).PadLeft(32, '0'));




            Console.WriteLine();
            int m1 = 5;
            int m2 = 809820;
            Console.WriteLine("bitwise XOR - exclusive or");
            //Console.WriteLine(m1^m2);
            Console.WriteLine( (m1 ^ m2)^m2 );

            //////////////////////////////
            ///
            int[] arr = { 6, 6, 3, 2, 1, 3, 10, 2, 1};
            //find the unique value
            //   -  (check each value if it has a duplicate) - O(n^2)
            //   -  sort (O(nlog n) - mergesort)             - O(nlogn)
            //   -  solve this in O(n) using XOR
            int uniq = 0;
            foreach (int value in arr)
                uniq = uniq ^ value;
            Console.WriteLine(uniq);
        }
    }
}
